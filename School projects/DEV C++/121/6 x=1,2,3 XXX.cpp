#include <iostream>
#include <locale>
#include <cmath>
using namespace std;
int main ()
{
	int x,P1;
	double a,P,S,S1;
    P1=3.14;
	setlocale(LC_ALL,"Bulgarian");
cout<<"х=1 извежда периметъра на равностранен триъгълник със страна a"<<endl;
	cout<<"х=2 лицето на квадрат със страна a"<<endl;
	cout<<"х=3 лицето на кръг с радиус a"<<endl;
	cout<<"въведи Х= "; cin>>x;
	if ((x<0)or(x>3)) cout<<"въведени са некоректни стойности въведете отношо избора си"<<endl;
   	cout<<"въведи страната а= "; cin>>a; 
     switch(x){
     	case 1: P=a*3; cout<<"периметара на триагълника е "<<P; break;
     	case 2: S=a*a;  cout<<"лицето на квадрата е "<<S; break;
     	case 3: S1=P1*pow(a,2); cout<<"лицето на крага е "<<S1; break;
	 }
	
	        return 0;
	        
}
