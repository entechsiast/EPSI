#pragma once
#include<string>
#include "Vehicule.h"
class Personne
{
public:
	Personne();
	~Personne();
	Personne(std::string nom, std::string prenom, int age, int taille, std::string marque)
	{
		p_nom = nom;
		p_prenom = prenom;
		p_age = age;
		p_taille = taille;
		p_vehicule = Vehicule(marque);
	}

	void setNom(std::string leNom)
	{
		p_nom = leNom;
	}

	std::string getNom()
	{
		return p_nom;
	}

	Vehicule getVehicule()
	{
		return p_vehicule;
	}

	std::string ToString()
	{
		return p_nom +" "+ p_prenom + " " + p_vehicule.getMarque();
	}

private:
	int p_age;
	int p_taille; // en cm
	std::string p_nom;
	std::string p_prenom;
	Vehicule p_vehicule;
};

