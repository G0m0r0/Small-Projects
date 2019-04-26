#include <iostream>
using namespace std;
int main ()
{
	int a,b,c,s;
	s=100;
	while (s<1000){
		a=s%10;
		b=(s/10)%10;
		c=s/100;
		if((a*b*c!=0)&&(s%a==0)&&(s%b==0)&&(s%c==0)) cout<<s<<" ";
		s++;
	}
	return 0;
}
