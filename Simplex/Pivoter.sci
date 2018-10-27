function [CoefficientsDesContraintes,ValeursDesContraintesDeLequation]=Pivoter(CoefficientsDesContraintes,ValeursDesContraintesDeLequation,N,e,s)
    m=length(ValeursDesContraintesDeLequation); //m prend le nombre de lignes de ValeursDesContraintesDeLequation
    for i=1:m
        if(CoefficientsDesContraintes(s,N(e))<>0)
            if(i<>s) //si i different de l'indice de la variable sortante on ne touche pas la ligne qui contient la variable sortante
                ValeursDesContraintesDeLequation(i)=ValeursDesContraintesDeLequation(i)-ValeursDesContraintesDeLequation(s)*CoefficientsDesContraintes(i,N(e))/CoefficientsDesContraintes(s,N(e));
                CoefficientsDesContraintes(i,:) = CoefficientsDesContraintes(i,:)-CoefficientsDesContraintes(s,:)*CoefficientsDesContraintes(i,N(e))/CoefficientsDesContraintes(s,N(e));
            else
                //si i=s
                ValeursDesContraintesDeLequation(i)=ValeursDesContraintesDeLequation(i)/CoefficientsDesContraintes(s,N(e));
                CoefficientsDesContraintes(i,:)=CoefficientsDesContraintes(i,:)/CoefficientsDesContraintes(s,N(e));
            end
        end
    end
endfunction