#include <iostream>
using namespace std;
int main ()
{
	int m,n;
    do{
	cout<<"m<n"<<endl;
	cout<<"vavedi m=";
	cin>>m;
	cout<<"vavedi n=";
	cin>>n;
    }
	while (m>n);
	while (m<=n)
	{
		if(m%5==0) cout<<" chisloto se deli "<<m<<endl;
		m++;
	}
	return 0;
}
