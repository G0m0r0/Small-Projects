#include<iostream>
using namespace std;
int main()
{
	int n,p=1;
	cout<<"enter n= ";
	cin>>n;
    while(p<n)
    {
    	p*=3;
	}
	if(p==n) cout<<"true";
	else cout<<"false";
	return 0;
}
