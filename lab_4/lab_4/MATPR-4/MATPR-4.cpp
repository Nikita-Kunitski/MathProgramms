#include "stdafx.h"
#include <iostream>
#include <string>
#include <ctime>
#include <locale>
#include "Levenshtein.h"
#include "LCS.h"
using namespace std;
char* generate(int size) // ���������� ������ ������� ��������� ����
{
	
	char* str = (char*)malloc(sizeof(char)*size);
	for (int i(0); i < size; i++)
	{
		str[i] = 65 + rand() % (91 - 65);
	}
	return str;
}

int _tmain(int argc, _TCHAR* argv[])
{
	clock_t t1 = 0, t2 = 0;
	setlocale(LC_ALL, "RUS");
	cout << " ----- ��������� �����! ----- " << endl << endl;

	
	const char* A = generate(300); const char* B = generate(250); 
	cout << "������ A:" << endl; for (int i = 0; i < 300; i++) cout << A[i] << " ";
	cout << endl << endl << "������ B:" << endl; for (int i = 0; i < 250; i++) cout << B[i] << " ";
	cout << endl << endl;
	system("pause");
	
	
	double kmas[] = { 0.04, 0.05, 0.625, 0.1, 0.2, 0.5, 1 };
	cout << " ----- ��������� �����������! ----- " << endl << endl;
	for (int j = 0; j < 3; j++)
	{
		int res = 0; clock_t t1 = 0, t2 = 0;
		for (int i = 0; i < 300 * kmas[j]; i++)
			cout << A[i] << " "; cout << endl;
		for (int i = 0; i < 250 * kmas[j]; i++)
			cout << B[i] << " "; cout << endl;
		t1 = clock(); 
		res = levenshtein(300 * kmas[j], A, 250 * kmas[j], B); t2 = clock();
		cout << "������������ ����������������" << endl << "��������� �����������: " << res << endl;
		cout << "�����: " << t2 - t1 << endl;
		t1 = clock(); res = levenshtein_r(300 * kmas[j], A, 250 * kmas[j], B); t2 = clock(); 
		cout << "��������" << endl << "��������� �����������: " << res << endl;
		cout << "�����: " << t2 - t1 << endl << endl;
	}
	
	
	/*cout << endl << endl << " ----- ���������� ����� ��������������������� (LCS)! ----- " << endl;
	int s = 0; 
	cout << endl << endl << "����������� ����� LCS: " << endl;
	for (int k = 2; k < 5; k++)
	{
		cout << endl;
		for (int i = 0; i < k; i++) cout << A[i] << " "; cout << endl;
		for (int i = 0; i < k; i++) cout << B[i] << " "; cout << endl;
		t1 = clock(); s = lcs(k, A, k, B); t2 = clock();
		cout << "����� �����: " << k << endl << "����� LCS: " << s << endl << "�����: " << t2 - t1 << endl << endl;
	}
	cout << endl << endl << "������������ ����������������:" << endl;
	char z[100] = ""; t1 = clock(); int l = lcsd(A, B, z); t2 = clock();
	cout << "LCS: " << z << endl << "����� LCS: " << l << endl << "�����: " << t2 - t1 << endl << endl;*/
	
	/*
	cout << endl << endl << " ----- ��������� ����������� ----- " << endl << endl;
	const char H1[] = {'�', '�', '�'};
	const char H2[] = { '�', '�' ,'�', '�', '�'};
	for (int i = 0; i < 3; i++) cout << H1[i] << " "; cout << endl;
	for (int i = 0; i < 5; i++) cout << H2[i] << " "; cout << endl;
	int s = levenshtein_r(3,H1,5,H2);
	cout << "��������� ����������� ��� ��� � �����: " << s << endl << endl;
	system("pause");
	*/
	/*
	cout << endl << endl << " ----- ���������� ����� ��������������������� ----- " << endl;
	char X[] = "QVTWNHO", Y[] = "RQTWYK";
	cout << endl << "������������������ X: " << X;
	cout << endl << "������������������ Y: " << Y;
	cout << endl << endl << "����������� �����: ";
	t1 = clock(); int s = lcs(sizeof(X)-1, X, sizeof(Y)-1, Y); t2 = clock();
	cout << endl << "����� LCS: " << s << endl << "�����: " << t2 - t1 << endl << endl;
	cout << "������������ ����������������:" << endl;
	char zz[100] = ""; t1 = clock(); int l = lcsd(X, Y, zz); t2 = clock();
	cout << "LCS: " << zz << endl << "����� LCS: " << l << endl << "�����: " << t2 - t1 << endl << endl;
	*/
	return 0;
}