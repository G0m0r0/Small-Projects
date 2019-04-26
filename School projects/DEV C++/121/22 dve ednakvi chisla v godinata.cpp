#include <iostream>
using namespace std;
int main ()
{
	int a,b,c,d,br,n;
	do{ 
		cout<<"vavedi cetiricifreno chislo "; cin>>n;
	//	if((n>1000)or(n<1000)) cout<<"vavedena e godina predi 1 000 i nad 10 000"<<endl;
	}while ((n<1000)or(n>10000));
	a=n%10;
	b=(n/10)%10;
	c=(n/100)%10;
	d=n/1000;
	if ((a==b)or(a==c)or(a==d)) cout<<"YES godinata e shtasliva"<<endl; 
    else if ((b==c)or(b==d)) cout<<"YES godinata e shtasliva"<<endl; 
    else if ((c==d)) cout<<"YES godinata e shtasliva"<<endl; 
    else cout<<"NO godinata ne e shtasliva"<<endl;
	return 0;
}
