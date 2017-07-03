// ConsoleApplication1.cpp: ���������� ����� ����� ��� ����������� ����������.
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
	auxil::start();                          // ����� ��������� 
	t1 = clock();                            // �������� ������� 
	for (int i = 0; i < CYCLE; i++)
	{
		av1 += (double)auxil::iget(-100, 100); // ����� ��������� ����� 
		av2 += auxil::dget(-100, 100);         // ����� ��������� ����� 
	}
	t2 = clock();                            // �������� ������� 


	cout << endl << "���������� ������:         " << CYCLE;
	cout << endl << "������� �������� (int):    " << av1 / CYCLE;
	cout << endl << "������� �������� (double): " << av2 / CYCLE;
	cout << endl << "����������������� (�.�):   " << (t2 - t1);
	cout << endl << "                  (���):   "
		<< ((double)(t2 - t1)) / ((double)CLOCKS_PER_SEC);
	cout << endl;
	return 0;
}

