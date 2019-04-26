#include <iostream>
using namespace std;
int main ()
{

	double x,y;
	cout<<"vavedi x=";
	cin>>x;
	cout<<"vavedi y=";
	cin>>y;
	if ((x<0)&&(x>y)) cout<<"X e po golqmo ot Y";             
    else if ((x<0)&&(y>x)) cout<<"Y e po golqmo ot X";
    else cout<<"vavedena e polojitelna stoinost ";
 	return 0;
}
