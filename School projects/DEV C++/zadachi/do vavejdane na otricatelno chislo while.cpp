#include <iostream>
using namespace std;
int main ()
{
	double a,b,S,I;
	cout<<"vavedi chislo ";
	cin>>a;
	I=0; S=0;
	while (a>0)
	{
		I=I+1;
		S=S+a; 
		cout<<"vavedi chislo ";
		cin>>a;
	}
	cout<<"srdnoto aretmetichno e "<<S/I<<endl;
	return 0;
}
