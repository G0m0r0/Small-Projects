#include <iostream>
using namespace std;
int main ()
{
	int a,b,c,s,k;
	do{
		cout<<"vavedi tricifreno chislo ";
		cin>>k;
		if((k<100)or(k>999)) cout<<"vavedena e nekorektna stoinost !!!"<<endl;
	} while ((k<100)or(k>1000));
	a=k%10;
	b=(k/10)%10;
	c=k/100;
    if ((a==0)and(b==0))  cout<<"obarnatoto chislo na "<<k<<" e 00"<<c;
	else if ((a!=0)and(b!=0)) cout<<"obarnatoto chislo na "<<k<<" e "<<100*a+10*b+c;
	else if (a==0) cout<<"obarnatoto chislo na "<<k<<" e 0"<<10*b+c<<endl;
	else if (b==0)  cout<<"obarnatoto chislo na "<<k<<" e "<<100*a+c;
	return 0;
}
