#include <iostream>
using namespace std;
int main ()
{
	int A,b,c,d,e,total;
	cout<<"A=";
	cin>>A;
	b=(A/10)%10;
	c=(A/100)%10;
	d=(A/1000)%10;
	e=(A/10000)%10;
	total=b+c+d+e;
	cout<<total<<total<<ednl;
	system("PAUSE");
	return 0;
}
