#include <iostream>
using namespace std;
int main ()
{
	int m,h,a,ml;
	do{
	cout<<"vavedi chas na izlitane ";
	cin>>h; cin>>m;
	cout<<"vavedi vremetraene na poleta ";
	cin>>ml;
	if(h>24) cout<<"nqma takav chas ";
}while (h>24);
	a=(h*60)+(m+ml);
	h=a/60;
	m=a%60;
	if(h>24) {
	h=h%24;
	}
	if ((h<10)and(m<10)) cout<<"chas na kacane 0"<<h<<":0"<<m;
	else cout<<"chas na kacane "<<h<<":"<<m;
	return 0;
}
