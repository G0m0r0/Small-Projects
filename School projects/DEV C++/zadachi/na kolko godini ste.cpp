#include <iostream>
#include <locale>
using namespace std;
int main ()
{
	int a,b,c;
	setlocale(LC_ALL,"BULGARIAN");
	cout<<"година на раждане ";
	cin>>a;
	cout<<"коя година сме ";
	cin>>b;
	c=b-a;
	cout<<"вашата възраст е "<<c<<endl;
	system ("PAUSE");
	return 0;
}
