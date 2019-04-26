#include <iostream>
using namespace std;
int main ()
{
	int a,b,c,s;
	
	do{
		cout<<"vavedi tochki na parviqt ychasnik ";
		cin>>a;
		if(a>255) cout<<"vavedena e nekoretkna stoinost"<<endl;
	}while (a>255);
	
	do{
	    cout<<"vavedi tochki na vtoriqt ychasnik ";
		cin>>b;
		if(b>255) cout<<"vavedena e nekoretkna stoinost"<<endl;
	} while (b>255);
		
	do{
		cout<<"vavedi tochki na tretiqt ychasnik ";
		cin>>c;
		if(c>255) cout<<"vavedena e nekoretkna stoinost"<<endl;
	}while (c>255);
	s=a+b+c;
	if (s%3==0) cout<<"OK"; //ychastnicite moje da sa zaedno
	else cout<<"ERROR"; //ychastnicite ne moje da sa zaedno
	return 0;
}
