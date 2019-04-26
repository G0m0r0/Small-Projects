#include <iostream>
using namespace std;
int main ()
{
	int N,a,Br;
	cout<<"za da spresh vavejdane na chisla natisni 0 "<<endl;
	cout<<"vavedi chislo ";
	cin>>N;
	Br=0;
	while (N!=0)
	{
		if(N<0) 
		Br=Br+1;
		cin>>N;
	}
	cout<<"broq na otricatelnite chisla e "<<Br;
}

