#include <iostream>
#include <cmath>
using namespace std;
int main ()
{
 double a,b,c;
 do{
 cout<<"a="; cin>>a;
 cout<<"b="; cin>>b;
 c=a*b;
 if((a<0)or(b<0)) cout<<"ne sashtestvyva koren na otricatelno chislo ! "<<endl;
}while((a<0)or(b<0));
 if ((a==0)&&(b==0)) cout<<"vsqko c e reshenie "<<sqrt(c);
 cout<<"korena na uravnenieto e "<<sqrt(c);
 return 0;
}
