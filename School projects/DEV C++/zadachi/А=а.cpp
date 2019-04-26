#include <iostream>
#include <locale>
using namespace std;
int main ()
{
	setlocale (LC_ALL,"BULGARIAN");
	char ch,a;
    cout<<"въведи голяма буква ";
	cin>>ch;
	a=ch+32;
	cout<<char(a)<<endl;
	system ("PAUSE");
	return 0;
	}
