// ConsoleApplication1.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include "Auxil.h"
#include <iostream>
#include <ctime>

#define CYCLE 1000000

using namespace std;
//Variant 13
int _tmain(int argc, _TCHAR* argv[])
{
	double av1 = 0, av2 = 2;
	clock_t t1 = 0, t2 = 0;
	setlocale(LC_ALL, "rus");
	auxil::start();                          // старт генерации 
	t1 = clock();                            // фиксация времени 
	for (int i = 0; i < CYCLE; i++)
	{
		av1 += (double)auxil::iget(-100, 100); // сумма случайных чисел 
		av2 += auxil::dget(-100, 100);         // сумма случайных чисел 
	}
	t2 = clock();                            // фиксация времени 


	cout << endl << "количество циклов:         " << CYCLE;
	cout << endl << "среднее значение (int):    " << av1 / CYCLE;
	cout << endl << "среднее значение (double): " << av2 / CYCLE;
	cout << endl << "продолжительность (у.е):   " << (t2 - t1);
	cout << endl << "                  (сек):   "
		<< ((double)(t2 - t1)) / ((double)CLOCKS_PER_SEC);
	cout << endl;
	return 0;
}

