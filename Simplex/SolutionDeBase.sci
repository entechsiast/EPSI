function [Xbase]=SolutionDeBase(CoefficientsDesContraintes,ValeursDesContraintesDeLequation,B)
    [m,n] = size(CoefficientsDesContraintes); //m= nombre de variables de base et n= nombre de colonnes(contraintes)
    for i=1:m
        Xbase(i)=ValeursDesContraintesDeLequation(i)/CoefficientsDesContraintes(i,B(i));
    end
endfunction