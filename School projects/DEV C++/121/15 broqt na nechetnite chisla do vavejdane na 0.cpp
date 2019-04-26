#include <iostream>
using namespace std;
int main ()
{
	int a,br=0;
	cout<<"pprogramata spira pri vavejdane na 0"<<endl;
	cout<<"vavedi chisla "<<endl;
	do{
		cin>>a;
		if (a<0) br++;
	} while (a!=0);
	cout<<"broqt na otricatelnite chisla e "<<br<<endl;
	return 0;
}
