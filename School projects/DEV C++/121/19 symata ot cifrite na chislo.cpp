#include <iostream>
using namespace std;
int main ()
{
	int a,b,c,k;
	do{
	cout<<"vavedi tricifreno chislo "; 
	cin>>k;
	if((k>=1000)or(k<100)) cout<<"vavedena e nekorekna stoinost !!! "<<endl;
}while ((k>=1000)or(k<100));
a=k%10;
b=(k/10)%10;
c=k/100;
cout<<"symata ot cifrite na k e "<<a+b+c;
return 0;
}
