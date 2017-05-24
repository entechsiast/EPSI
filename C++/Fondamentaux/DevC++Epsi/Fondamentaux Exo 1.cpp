// DevC++ Epsi : Defines the entry point for the console application.


#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	//initialisation des variables

	int total{ 0 };
	int* tab = new int[5]{ 11,22,33,44 };

	//on double la valeur de l'index 0, pour le fun

	*tab = 22;

	//boucle pour additionner les valeurs entre elles
	for (int i = 0; i < sizeof(tab); i++)
	{
		total += *(tab + i);
	}

	//libérationn de l'espace mémoire
	delete[] tab;


	//affichage du total
	cout << "total = " << total << "\n"; // le total est 121
	return 0;
}

