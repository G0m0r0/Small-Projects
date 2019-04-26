#include <iostream>
using namespace std;
int main ()
{
	//9/97
	int a,k,s;
	cout<<"vavedi k=";
	cin>>k;
	s=100;
	while (s<1000)
	{
	   if (s==k) 
	   {
	   	s++;
	   	cout<<s;
	   }	
	}
	return 0;
}
