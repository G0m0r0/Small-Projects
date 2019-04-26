#include <iostream>
using namespace std;
int main()
{
int x,den,mes,god,visok;
cin>>den>>mes>>god;
x=god%100;
x=x+x/4;
x=x+den;
if(((god%4==0)&&(god%100!=0))||(god%400==0))
visok=-1;
else visok=0;
switch(mes)
{
case 1:x=x+1+visok;break;
case 2:x=x+4+visok;break;
case 3:case 11:x=x+4;break;
case 5:x=x+2;break;
case 6:x=x+5;break;
case 8:x=x+3;break;
case 9:x=x+6;break;
case 10:x=x+1;break;
}
if(god<1900) x=x+2;
else if(god<200) x=x+6;
else x=x+5;
switch(x%7)
{
case 1:cout<<"Ponedelnik"; break;
case 2:cout<<"Vtornik"; break;
case 3:cout<<"Sriada"; break;;
case 4:cout<<"Chetvurtuk"; break;
case 5:cout<<"Petuk"; break;
case 6:cout<<"Subota"; break;
case 0:cout<<"Nedelia"; break;
}
 

return 0;
}

