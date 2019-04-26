#include <iostream>
using namespace std;
int main ()
{
	int cl1,cl2,cl1min,cl2min,H,H1,Cl,B;
	cout<<"vavedi nachalen chas- "; cin>>cl1; 
	cout<<"i minyti- "; cin>>cl1min;
	cout<<"vavedi kraen chas- "; cin>> cl2; 
    cout<<"i minyti- "; cin>>cl2min;
	H=(cl1*60)+cl1min;
    H1=(cl2*60)+cl2min;
   if (H>=H1) H1=H1+1440;
   B=H1-H;
   cout<<"vremetraene"<<B/60<<":"<<B%60 <<endl;
   return 0;

}
	

