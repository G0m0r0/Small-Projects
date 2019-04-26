#include <iostream>
using namespace std;
int main ()
{
	int L,a,La;
	cout<<"vavedi tri chifreno chislo=";
	cin>>L;
	a=(L/100)%10;
    L=(L%100);
	cout<<"tri chifreno chislo="<<L<<a<<endl;
	//izkarva tretata cifra otpred 123=231
	system ("PAUSE");
	return 0;
	}
