// ConsoleApplication1.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#define n 2
#define N 5
#define INF   0x7fffffff

int d[N][N] = { {INF, 2*n, 21+n, INF, n  },
				{n  , INF, 15+n,68-n,84-n},
				{2+n, 3*n, INF ,86 , 49+n},
				{17+n,58-n,4*n ,INF, 3*n },
				{93-n, 66+n, 52, 13+n, INF}
};

int main()
{
    return 0;
}

