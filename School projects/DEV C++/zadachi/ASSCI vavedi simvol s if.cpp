#include <iostream>
#include <locale>
using namespace std;
int main ()
{
	setlocale (LC_ALL,"BULGARIAN");
	char a;
	cout<<"vavedi simvol ";
	cin>>a;
	if((a>47)&(a<58)) cout<<"vavedeno e chislo "<<char(a)<<"   "<<"ASCII "<<int(a);
	else cout<<"vavedena e bykva "<<char(a)<<"   "<<"ASCII "<<int(a);
	return 0;
	}
