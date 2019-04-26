#include <iostream>
using namespace std;
int main ()
{
	int a,b,c,k;
	do{
	cout<<"vavedi tricifreno chislo "; cin>>k;
	if((k<100)or(k>999)) cout<<"vavedeno e nekorektna stoinost";
}while ((k<99)or(k>1000));
a=k%10;
b=k/10%10;
c=k/100;
cout<<"sbora na chislata e "<<(100*a+10*b+c)+k<<endl;
return 0;
}
