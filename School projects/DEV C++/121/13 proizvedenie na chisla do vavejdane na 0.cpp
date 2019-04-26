#include <iostream>
using namespace std;
int main ()
{
	int a;
	long A=1;
	cout<<"vavejdaneto spira pri vavejdane na 1 !"<<endl;
	cout<<"vavedi chislo "; 
	do{
		cin>>a;
		A*=a;
	}while (a!=1);
	cout<<"proizvedenieto na chislata e "<<A<<endl;
	return 0;
}
