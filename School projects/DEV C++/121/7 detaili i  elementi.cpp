#include <iostream>
using namespace std;
int main ()
{
	int I1,I2,I3,D1,D2,a,b,c,d,Br1;
	cout<<"vavedi nalichno kolichestvo D1= "; cin>>D1;
	cout<<"vavedi nalichno kolichestvo D2= "; cin>>D2;
	Br1=D1/2; if(Br1>0) cout<<"I1= "<<Br1<<endl;
	else cout<<"nqma dostatachno elementi ot T3"<<endl;
	a=D1/4;
	b=D2/2; if ((a>0)and(b>0)) cout<<"T2= "<<a<<endl;
	else cout<<"nqma dostatachno elementi ot T2"<<endl;
	c=D1/5;
	d=D2/4; if ((c>0)and(d>0)) cout<<"T3= "<<c<<endl;
	else cout<<"nqma dostatachno elementi ot T3"<<endl;
	return 0;
}
