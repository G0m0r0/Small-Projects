#include <iostream>
#include <locale>
using namespace std;
int main ()
{
	setlocale (LC_ALL,"BULGARIAN");
	unsigned int s,d;
	cout<<"въведи дни ";
	cin>>d;
	s=(60*24*60)*d;
	cout<<"секунди за въведените дни "<<s<<endl;
	}
