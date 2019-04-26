#include<iostream>
using namespace std;
int main()
{
	int n;
	double s=0;
	cout<<"enter integer= ";
	cin>>n;
	for(double i=1;i<=n;i++)
	s+=1/i; 
	cout<<"S= "<<s<<endl;
	return 0;
}
