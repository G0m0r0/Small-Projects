#include <iostream>
using namespace std;
int main ()
{
	int a,i,s=0;
	cout<<"vavedi chislo "; cin>>a;
	for(i=2;i<=a/2;i++)
	{
		if(a%i==0) s+=i;
	}
	cout<<"sbora na deltelite na tova chislo e "<<s<<endl;
	system ("PAUSE");
	return 0;
}
