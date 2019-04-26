#include <iostream>
#include <locale>
using namespace std;
int main ()
{
	setlocale (LC_ALL,"BULGARIAN");
	double a,b,c;
	cout<<"vavedi strani na triagalnik"<<endl;
	cout<<"a="; cin>>a;
	cout<<"b="; cin>>b;
	cout<<"c="; cin>>c;
	if (b+c<a) cout<<"ne sashtestvyva takav triagalnik ";
	else if (a+c<b) cout<<"ne sashtestvyva takav triagalnik ";
	else if (b+a<c) cout<<"ne sashtestvyva takav triagalnik ";
	else cout<<"liceto na trigalnika e S="<<(a*b)/2;
	return 0;
	}
