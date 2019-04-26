#include <iostream>
using namespace std;
int main ()
{
	int i,s=0,p;
    int a[4];
    cout<<"vavedi broi bonboni za vsqka kypicka "<<endl;
	for(i=0;i<4;i++)
    {cout<<"kypichka "<<i+1<<"="; 
	cin>>a[i];
	s=s+a[i]; 
	}
	if (s%4!=0) s=s+1;
	s=s/4;
	for(i=0;i<4;i++)
	{
	cout<<"v kypichka "<<i+1<<" trqbva da se dobavqt "<<s-a[i]<<" bonboni"<<endl;
    }
	system("PAUSE");
	return 0;
}



