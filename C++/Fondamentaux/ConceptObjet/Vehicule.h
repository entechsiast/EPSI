#pragma once
#include<string>
class Vehicule
{
public:
	Vehicule();
	~Vehicule();
	Vehicule(std::string marque)
	{
		v_marque = marque;
	}

	void setMarque(std::string laMarque)
	{
		v_marque = laMarque;
	}

	std::string getMarque()
	{
		return v_marque;
	}
private:
	std::string v_marque;
};

