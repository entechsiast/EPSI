function [xsol,z]=SimplexAlgebre(CoefficientsDesContraintes,ValeursDesContraintesDeLequation,coefficientDesVariablesDeBase)

    
//methode du simplex algébrique (maximisation de l'optimum)

//m= nombre de variables de base et n= nombre de colonnes(contraintes)
[m,n]=size(CoefficientsDesContraintes);

//on définit la forme standard de l'équation
formeStandard = [CoefficientsDesContraintes,eye(m,m)]; 

//[n+1:n+m]; tableaux qui se redimensionnent automatiquement en fonction du nombre variables et de contraintes

//les indices des variables de base
B = [n+1:n+m];
//N est un tableau des indices des variables hors base
N = [1:n];
//on attribut une valeur par défaut à Z solution optimale
    z=0;
//Numero de l'iteration
    l=0;
    while(1)
        l=l+1;
        disp('Iteration n°'+string(l)+': ');
        disp(B,"    les indices des variables de base: ");
        disp(N,"    les indices des variables hors base: ");

//détermination de la solution de base

        //définition de la forme d'une solution de base
        xbase=SolutionDeBase(formeStandard,ValeursDesContraintesDeLequation,B);
        if(min(xbase)<0) //cherche le coeff le plus petit pour équation d'échange
            disp(" solution de base non realisable ");
            break;
        end
        disp(xbase,"    la solution de base: ");
        if(max(coefficientDesVariablesDeBase)<=0)
            disp("    les couts sont négatifs, on arrete ");
            break;
        else
            [maxcount,e]=max(coefficientDesVariablesDeBase);//e est le coeff de la variable entrante

            disp('    coefficient de la variable entrante '+string(N(e)));
        end
            //la fonction indice_variable_sortante permet de retourner le coefficient de la varaiable sortante

            s=indice_variable_sortante(formeStandard,ValeursDesContraintesDeLequation,N,e); //s est l'indice de la variable de base sortante

        disp('    coefficient de la variable sortante est '+string(B(s)));
        //la fonction Pivoter permet de retourner la nouvelle formeStandard et ValeursDesContraintesDeLequation après le changement de base

        [formeStandard,ValeursDesContraintesDeLequation]=Pivoter(formeStandard,ValeursDesContraintesDeLequation,N,e,s);

        disp("    transfert des variables de base et hors bases :");
        //on affiche la nouvelleforme standard après échange des variables
        disp(formeStandard,"    coefficients De L equation  = ",ValeursDesContraintesDeLequation,"    contraintes De L equation = ");
        z=z+ValeursDesContraintesDeLequation(s)*coefficientDesVariablesDeBase(e) //calcul de l'optimum

        for j=1:n
            if(j<>N(e))
                tab(j)=formeStandard(s,N(j))*coefficientDesVariablesDeBase(e); // on remplace formeStandarde de la variable entrante par sa combinaison dans Z
            else
                tab(j)=formeStandard(s,B(s))*coefficientDesVariablesDeBase(e); // on remplace formeStandarde de la variable entrante par sa combinaison dans Z
            end
        end
        tab=-tab;
        for j =1:n
            if(j<>e)
                coefficientDesVariablesDeBase(j)=coefficientDesVariablesDeBase(j)+tab(j);//calcul du cout
            else
                coefficientDesVariablesDeBase(j)=tab(j); //calcul du cout
            end
        end
        tmp = B(s); //l'échange entre la variable de base et la variable hors base
        B(s) = N(e);
        N(e) = tmp;
    end

    //La solution canonique du Problème Linéraire
    x=[zeros(n,l),xbase]; //x est un tableau intermédiaire pour trier la solution
    t=[N,B];
    for k=1:n+m
        xsol(k) = x(t(k));
    end
endfunction
