#include <iostream>
using namespace std;
int main ()
{
   int a,b,c,L;
   cout<<"vavedi tricifreno chislo ";
   cin>>L;
   c=L%10;
   b=(L/10)%10;
   a=(L/100)%10;
   cout<<"tricifreno="<<c<<b<<a<<endl;
   system ("PAUSE");
   return 0;
}
//incomplete
