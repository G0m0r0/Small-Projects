#include <iostream>
using namespace std;
int main ()
{
	int Br4,BrN,a;
	cout<<"vavedi chisla "<<endl;
	cin>>a;
	Br4=0; BrN=0;
	while (a!=0)
	{
		if(a%2==0)
		Br4=Br4+1;
		else if (a%2!=0)
		BrN=BrN+1;
		cin>>a;
	}
	cout<<"broq na chetnite e "<<Br4<<endl;
	cout<<"broq na nechetnite e "<<BrN<<endl;
	return 0;
}
