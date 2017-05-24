// ConceptObjet.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Vehicule.h"
#include "Personne.h"
#include<iostream> // permet d'utiliser les commandes console i.e ( cin, cout ...)

using namespace std; // permet d'utiliser les commandes console i.e ( cin, cout ...)

int main()
{
	//variables
	int age, taille;
	string prenom, nom, marque;

	//creation de la personne
	cout << "entrez le nom de la personne \n" << endl;
	cin >> nom;
	cout << "entrez le prenom de la personne \n" << endl;
	cin >> prenom;
	cout << "entrez l'age de la personne \n" << endl;
	cin >> age;
	cout << "entrez la taille (en cm) de la personne \n" << endl;
	cin >> taille;
	cout << "entrez la marque de la voiture de la personne \n" << endl;
	cin >> marque;

	//affiche les informations de la personne
	Personne laNouvellePersonne = Personne(nom,prenom,age,taille,marque);

	cout << laNouvellePersonne.ToString() << endl;

	//cout << laNouvellePersonne.getNom() << endl;
	//cout << laNouvellePersonne.getVehicule().getMarque() << endl;

    return 0;
}

