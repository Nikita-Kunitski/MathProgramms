#include "stdafx.h"
#include <iostream>
#include <iomanip> 
#include "Combi.h"

using namespace std;
#define N (sizeof(AA)/2)
#define M 3


int _tmain(int argc, _TCHAR* argv[])
{
	setlocale(LC_ALL, "rus");
	char  AA[][2] = { "A", "B", "C", "D" };
	 cout <<  endl << " --- ��������� ���������� ---";
	 cout <<  endl << "�������� ���������: ";
	 cout << "{ ";
	for (int i = 0; i < N; i++)

		 cout << AA[i] << ((i< N - 1) ? ", " : " ");
	 cout << "}";
	 cout <<  endl << "��������� ����������  ��  " << N << " �� " << M;
	combi::accomodation s(N, M);
	int  n = s.getfirst();
	while (n >= 0)
	{

		 cout <<  endl <<  setw(2) << s.na << ": { ";

		for (int i = 0; i < 3; i++)

			 cout << AA[s.ntx(i)] << ((i< n - 1) ? ", " : " ");

		 cout << "}";

		n = s.getnext();
	};
	 cout <<  endl << "�����: " << s.count() <<  endl;
	
	return 0;
}
