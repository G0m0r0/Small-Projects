#include<iostream>
using namespace std;
int main()
{
	int n,s;
	int a[n];
	cout<<"enter n= ";
	cin>>n;
	cout<<"full mas with "<<n<<" numbers\n";
	for(int i=0;i<n;i++)
	{
		cin>>a[i];
		s+=a[i];
	}
	cout<<"numbers that are bigger than avr of mass are:\n";
	for(int i=0;i<n;i++)
	if(s/n<a[i]) cout<<a[i]<<" ";
	return 0;
}
