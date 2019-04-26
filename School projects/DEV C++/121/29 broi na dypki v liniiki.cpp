#include <iostream>
using namespace std;
int main ()
{
	int l,n,m,j,br=0,i;
	do{
    cout<<"vavedi daljina do 501sm na 1 i 2 linika "; 
	cin>>l;
}while ((l<0)or(l>501));
    do{
    	cout<<"vavedi do 5 mm prez kolko sa dypkite na 1=";
    	cin>>m;
	}while ((m<0)or(m>5));
	do{
    	cout<<"vavedi do 5 prez kolko sa dypkite na 2=";
    	cin>>n;
	}while ((n<0)or(n>5));
	
	for (i=m;i<=l;i+=m)	{
	for(j=n;j<=l;j+=n)
		if (i==j) br++; 
	}
	cout<<"broqt na obshite dypki e "<<br+2<<endl;
	system ("PAUSE");
	return 0;
}
