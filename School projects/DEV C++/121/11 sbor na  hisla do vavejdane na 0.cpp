#include <iostream>
using namespace std;
int main ()
{
	int a,br,s,b;
	cout<<"programata spira pri vavejdane na 0"<<endl;
	cout<<"vavedi chislo"; 
	br=0; 
	do {
		cin>>a; 
		br=br+a;
	}while (a!=0);
	cout<<"sbora na chislata e "<<br;
	return 0;
}
