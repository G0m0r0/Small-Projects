#include <iostream>
#include <locale>
using namespace std;
int main ()
{
	setlocale (LC_ALL,"BULGARIAN");
	int n,m,k,a,b,c,A,B,C,K1,K2,K3,p1,p2,c1,c2,v1,v2;
	cout<<"vavedi tricifreno chislo ";
	cin>>m;
	cout<<"vavedi drygo tricifreno chislo ";
	cin>>n;
	a=n%10; b=(n/10)%10; c=n/100;
	A=m%10; B=(m/10)%10; C=m/100;
	K1=c+A; K2=b+B; K3=a+C;
	if (K1>9){
		p1=K1%10;
		p2=K1/10;
		K1=p1+p2;
	}
	else if (K2>9){
		c1=K2%10;
		c2=K2/10;
		K2=c1+c2;
	}
	else if (K3>9){
		v1=K3%10;
		v2=K3/10;
		K3=v1+v2;
	}
	cout<<"chisloto K="<<K3<<K2<<K1<<endl;
	return 0;
}
