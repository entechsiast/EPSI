// Fondamentaux Exo 2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cstdlib>

using namespace std; // namespace à inclure pour utiliser cou, cin , etc...


int main()
{

	int note;
	int nombreDeNotesASaisir = 0;
	int totalDesNotes = 0;// initialisation à 0 obligatoire sinon pas d'instanciation de tableau , unisgned = pas de nombres négatifs

   //demande à l'utilisateur le nombre de notes à saisir
	cout << "Entrez le nombre de notes à saisir" << "\n";
	cin >> nombreDeNotesASaisir;
	while (cin.fail() || nombreDeNotesASaisir < 0 || nombreDeNotesASaisir == 0)
	{
		if (cin.fail()) {
			cout << "Erreur, resaisissez le nombre" << '\n';
			cin.clear();
			cin.ignore(256, '\n');
			cin >> nombreDeNotesASaisir;
		}

		if (nombreDeNotesASaisir == 0 || nombreDeNotesASaisir < 0) {
			cout << "le nombre ne peut pas être nul ou négatif" << '\n';
			cin >> nombreDeNotesASaisir;
		}
	}


	//Gère les débordements de capacité mémoire

	int* tableauDeNotes = new int[nombreDeNotesASaisir] {}; //instanciation du tableau de notes

	// demande à l'utilisateur de saisir les notes (valeur entre 0 et 20)
	cout << "Saisissez les notes que vous souhaitez entrer dans le tableau" << "\n";

	for (int i = 0; i < nombreDeNotesASaisir; i++)
	{
		cin >> note;

		while (cin.fail() || note < 0 || note > 20)
		{
			if (cin.fail()) {
				cout << "Erreur, vous ne pouvez entrer autre chose qu'un nombre" << '\n';
				cin.clear();
				cin.ignore(256, '\n');
				cin >> note;
			}

			if (note < 0) {
				cout << "les valeurs négative ne sont pas permises" << '\n';
				cin >> note;
			}


			else if (note > 20)
			{
				cout << "une note ne peut pas être supérieure à 20" << '\n';
				cin >> note;
			}
		}
		tableauDeNotes[i] = note;

	}

	//affiche toutes les notes saisies dans le tableau
	for (int i = 0; i < nombreDeNotesASaisir; i++)
	{
		cout << "vous avez saisi la note " << tableauDeNotes[i] << "\n";
	}

	//calcule la totale des notes

	for (int i = 0; i < nombreDeNotesASaisir; ++i)
	{
		totalDesNotes += tableauDeNotes[i];
	}

	cout << "le total des notes est de : " << totalDesNotes << "\n";

	//Affiche la moyenne de toutes les notes

	int moyenne = totalDesNotes / nombreDeNotesASaisir;
	cout << "la moyenne des notes est de : " << moyenne << '\n';

	delete[] tableauDeNotes; // ferme le pointeur


	return 0;
}

