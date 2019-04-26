#include<iostream>
using namespace std;
int main()
{   int candy;
	cout<<"enter the price for 1kg candy = ";
	cin>>candy;
	for(double i=0.1;i<=1;i+=0.1)
	cout<<i<<" kg candy= "<<candy*i<<endl;
	return 0;
}
