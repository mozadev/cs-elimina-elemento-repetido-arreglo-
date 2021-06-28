
#include<iostream>
#include<stdlib.h>
#include<conio.h>
#include <iomanip>
using namespace std;

int len;
void ingresadatos(int* n, float* vecNumeros)
{
	for (int i = 0; i < *n; i++)
	{
		cout << "ingresa peso " << i + 1 << ":";
		cin >> vecNumeros[i];
	}


}

void salidadatos(int* n, float* vecNumeros)
{
	for (int i = 0; i < *n; i++)
	{
		cout << vecNumeros[i] << " ";

	}
	cout << "tamaño del arreglo: " << *n << endl;;

}

void eliminaElementoRepetido(int* n, float* vecNumeros)
{
	 len=*n;

	for (int i = 0; i < len - 1; i++)
		for (int j = i + 1; j < len; j++) {
			///Si encontramos un duplicado
			if (vecNumeros[i] == vecNumeros[j]) {

				///Lo vamos intercambiando hasta que quede al final
				for (int k = j;k < len - 1;k++)
					swap(vecNumeros[k], vecNumeros[k + 1]);

				///Disminuimos la longitud en 1, lo que significa
				///que se elimina un elemento

				len--;

				///Disminuimos a j para que se quede en el mismo
				///lugar (vease que el elemento que estaba en esa
				///posicion fue eliminado, si no disminuimos j en 1
				///nos saltamos un valor por analizar).
				j--;
			}
		}
	
}

void mostrar(float *vecNumeros) {

	for (int i = 0;i < len;i++)
		cout << vecNumeros[i] << " \n"[i == len - 1];
	cout << "tamaño del arreglo: " << len << endl;
}


int main()
{
	int n;
	cout << "ingrese la cantidad de numeros" << endl;
	cin >> n;

	float* vectorNumeros;
	vectorNumeros = new float[n];
	ingresadatos(&n, vectorNumeros);
	salidadatos(&n, vectorNumeros);
	eliminaElementoRepetido(&n, vectorNumeros);
	mostrar(vectorNumeros);
	delete vectorNumeros;
	_getch();

}


