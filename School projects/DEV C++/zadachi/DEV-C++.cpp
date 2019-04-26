#include <iostream>
#include <locale>
using namespace std;
int main ()
{
	setlocale (LC_ALL,"BULGARIAN");
	char a,b,c,d,e,f,g;
	a=68;
	b=101;
	c=118;
	d=45;
	e=67;
	f=43;
	g=43;
	cout<<char(a)<<char(b)<<char(c)<<char(d)<<char(e)<<char(f)<<char(g)<<endl;
    system ("PAUSE");
    return 0;
	}
