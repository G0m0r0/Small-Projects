#include <iostream>
using namespace std;
int main ()
{
	int a,b,c,d,s;
	cout<<"edno chislo e lynno ako sbora n hilqdnite i edinicite e ravno ot sbora na symata na deseticite i stoticite"<<endl;
	do{
	cout<<"vavedi chetiricifreno chislo  "; cin>>s;
}while ((a<999)and(a>10000)); 
a=s%10;
b=(s/10)%10;
c=(s/100)%10;
d=s/1000;
if(a+d==b+c) cout<<"chisloto e lynno";
else cout<<"chisloto ne e lynno";
return 0;
}
