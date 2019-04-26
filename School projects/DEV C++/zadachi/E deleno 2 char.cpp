#include <iostream>
#include <locale>
#include <cmath>
using namespace std;
int main ()
{
	setlocale (LC_ALL,"BULGARIAN");
	char ch='G',a;
    a=ch/2;
    floor (a);
    cout<<char(a)<<endl;
	system ("PAUSE");
	return 0;
	}
