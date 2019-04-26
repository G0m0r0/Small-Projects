#include <iostream>
using namespace std;
int main ()
{
	int a,br=0;
	cout<<"programata spira pri vavejdane na otricatelno chislo "<<endl;
	cout<<"vavedi chislo "<<endl;
	do{
		cin>>a;
		if((a>0)&&(a%2==0)) br++;
	} while (a>0);
	cout<<"broqt na chetnite chisla e "<<br<<endl;
	return 0;
}
