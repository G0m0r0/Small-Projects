#include <iostream>
#include <cmath>
using namespace std;
int main ()
{
	double l,h,m,S;
	cout<<"vavedi visochina "; cin>>h;
	cout<<"vavedi daljina "; cin>>l;
	cout<<"vavedi kolko kv.metra pokriva 1 kytiq boq "; cin>>m;
	S=h*l;
	S=S/m;
	cout<<"nyjnite kytii sa "<<	ceil(S);
	return 0;
}
