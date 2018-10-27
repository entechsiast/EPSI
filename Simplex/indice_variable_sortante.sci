function i=indice_variable_sortante(CoefficientsDesContraintes,ValeursDesContraintesDeLequation,N,e)
    m=length(ValeursDesContraintesDeLequation);//m= taille de vecteur ValeursDesContraintesDeLequation
    for k=1:m
        if(CoefficientsDesContraintes(k,N(e))>0)
            Y(k)=ValeursDesContraintesDeLequation(k)/CoefficientsDesContraintes(k,N(e));
        else
            Y(k)=%inf;
        end
    end

    [x,i]=min(Y);
endfunction