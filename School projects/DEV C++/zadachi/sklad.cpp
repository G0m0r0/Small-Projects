#include <iostream>
#include <locale>
using namespace std;
int main ()
{
	setlocale (LC_ALL,"BULGARIAN");
	long int nk,ng,pk,pg,ok,og,a;
	cout<<"налично количество кг ";
	cin>>nk;
	cout<<"налично количество гр ";
	cin>>ng;
	cout<<"продадено количество кг ";
	cin>>pk;
	cout<<"продадено количество гр ";
	cin>>pg;
	a=(ng-pg)/1000;
    ok=(nk-pk)+a;
    if (pg>ng){
    	         og=(pg-ng)%1000;
    	         cout<<"оставащи кг "<<ok<<endl<<"оставащи гр "<<og<<endl;  
	          }
	og=(ng-pg)%1000;         
	cout<<"оставащи кг "<<ok<<endl<<"оставащи гр "<<og<<endl;
	system ("PAUSE");
	return 0;
}
