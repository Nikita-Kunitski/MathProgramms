#include "stdafx.h"
#include <iostream>
#include "Combi.h"

using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	setlocale(LC_ALL, "rus");
	char  AA[][2] = { "A", "B", "C", "D" };
	cout << "Размер множества: " << sizeof(AA)<<endl;
	cout << " - Генератор множества всех подмножеств -"<< endl;
	cout  << "Исходное множество: " << endl;
	cout << "{ ";	

		for (int i = 0; i < sizeof(AA) / 2; i++)
			cout << AA[i] << ((i< sizeof(AA) / 2 - 1) ? ", " : " ");
	cout << "}";
	cout <<  endl << "Генерация всех подмножеств  ";
	combi::subset s1(sizeof(AA) / 2);         // создание генератора   
	int  n = s1.getfirst();                // первое (пустое) подмножество    
	while (n >= 0)                          // пока есть подмножества 
	{
		 cout <<  endl << "{ ";
		for (int i = 0; i < n; i++)
			 cout << AA[s1.ntx(i)] << ((i< n - 1) ? ", " : " ");
		 cout << "}";
		n = s1.getnext();                   // cледующее подмножество 
	};
	cout <<  endl << "всего: " << s1.count() <<  endl;
	return 0;
}
