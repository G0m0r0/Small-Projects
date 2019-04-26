#include <iostream>
#include <locale>
#include <cmath>
using namespace std;
int main ()
{
	setlocale (LC_ALL,"BULGARIAN");
	double a,b,m,S,mb;
	cout<<"страна на нивата ";
	cin>>a;
	cout<<"друга страна на нивата ";
	cin>>b;
	cout<<"пакетчета кв метри ";
	cin>>m;
	S=a*b;
	mb=S/m;
	//ceil (mb);
	cout<<"нужни пакечета "<<ceil(mb)<<endl;
	system ("PAUSE");
	return 0;
	}
