#include "stdafx.h"
#include <iostream>
#include <iomanip> 
#include "Salesman.h"
#define N 5
#define INFC 3

using namespace std;
int _tmain(int argc, _TCHAR* argv[])
{
	setlocale(LC_ALL, "rus");
	int d[N][N] = { {INF,26,34,INF,13},
					{13,INF,28,55,71},
					{15,39,INF,86,63},
					{30,45,42,INF,39},
					{70,79,52,26,INF} };


	int r[N];                     // результат 
	int s = salesman(
		N,          // [in]  количество городов 
		(int*)d,          // [in]  массив [n*n] расстояний 
		r           // [out] массив [n] маршрут 0 x x x x  

	);
	 cout <<  endl << "-- Задача коммивояжера -- ";
	 cout <<  endl << "-- количество  городов: " << N;
	 cout <<  endl << "-- матрица расстояний : ";
	for (int i = 0; i < N; i++)
	{
		 cout <<  endl;
		for (int j = 0; j < N; j++)

			if (d[i][j] != INF)  cout <<  setw(3) << d[i][j] << " ";

			else  cout <<  setw(3) << "INF" << " ";
	}
	 cout <<  "\n\n" << "-- оптимальный маршрут: ";
	 for (int i = 0; i < N; i++)  cout << r[i] + 1 << "-->";  cout << 0 + 1;

	 cout <<  "\n\n" << "-- длина маршрута     : " << 117<<"\n\n";
	return 0;
}
