#include <iostream>
using namespace std;
int main(void){
int a;
int b;
int c = 0;
while(true)
{
system("CLS");
cin.clear();
c = 0;
srand(static_cast<unsigned int>(time (0)));
a = rand()%1000+1;
cout<<"Koe mi e lubimoto chislo !?"<<endl;
do
{
cout<<"Dai svoeto predlojenie:";
cin >> b;
if(b > a)
 {
cout<<"Tvarde Golqmo Chislo!"<< endl <<endl;
}
if(b < a)
{
cout<<"Tvarde Malko Chislo!"<< endl <<endl;
 }
c ++;
}while(b > a || b < a);
cout << "Bravoi ti pozna lubimoto mi chislo!!!"<<endl<<endl;
cout << "Ti napravi" <<" "<<c<<" "<< "predlojeniq" <<endl<<endl;
system("PAUSE");
 }
return 0;}
