#include <iostream>
using namespace std;
int main ()
{
	double a,b,P;
    do{
		cout<<"vavedi daljina  "; cin>>a;
		if (a<0) cout<<"vavedena e otricatelna stoinost !"<<endl;
  }while (a<0);
    do{
		cout<<"vavedi shirina  "; cin>>b;
			if (b<0) cout<<"vavedena e otricatelna stoinost !"<<endl;
      }while (b<0);
	P=2*(a+b);
	cout<<"perimetara na pravoagalnika e "<<P;
	return 0;
}
