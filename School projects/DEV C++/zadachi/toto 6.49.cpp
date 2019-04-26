#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;
int main ()
{
	int a,b,c,d,e,f,br=0,i,x;
	srand ((time)(NULL));
	cout<<"vavedi 6 chisla"<<endl; 
	cin>>a; cin>>b; cin>>c; cin>>d; cin>>e; cin>>f;
	for(i=1;i<=6;i++)
	{
		 x=rand ()%(49)+1;
		if(x==a) cout<<"pozna"; 
		 if(x==b) cout<<"pozna"; 
		 if(x==c) cout<<"pozna"; 
		 if(x==d) cout<<"pozna"; 
		 if(x==e) cout<<"pozna"; 
		 if(x==f) cout<<"pozna"; 
		 cout<<x<<" ";

	}
	cout<<endl;
	system ("PAUSE");
	return 0;
}

