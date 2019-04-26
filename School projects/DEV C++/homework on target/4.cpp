#include<iostream>
using namespace std;
int main()
{
	int a,b;
	do{
	cout<<"enter A= "; 
	cin>>a;
	cout<<"enter B= "; 
	cin>>b;
    }while(a>b);
    for(int i=a;i<b;i++)
    {
    cout<<endl;
    for(int j=0;j<i;j++)
    cout<<i;
    }
    return 0;
}
    
