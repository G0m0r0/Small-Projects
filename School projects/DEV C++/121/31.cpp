#include <iostream>
using namespace std;
int main ()
{
	int s;
	bool n=true;
	do
	{
	cout<<"enter the sum of money you have ";
	cin>>s;
    }while(s<0);
	if(s%5==0) cout<<s/5<<".5"<<endl;
	if(s%2==0) cout<<s/2<<".2"<<endl;
    if((s%5!=0)and(s>5))
    {
	if((s%5)%2==0) cout<<s/5<<".5"<<"+"<<(s%5)/2<<".2"<<endl;
    }
    return 0;
}
