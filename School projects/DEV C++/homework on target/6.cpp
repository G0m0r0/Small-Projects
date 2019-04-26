#include<iostream>
using namespace std;
int main()
{
	int v=100,p; //lv
	do{
	cout<<"enter p max to 25% = ";
	cin>>p;
    }while((p<0)or(p>25));
    int k=0,s=0;
    while(v<1100)
    {
          v+=(v*p)/100;
          k++;
	}
	cout<<"months= "<<k<<endl;
	cout<<"S= "<<v<<endl;
}
