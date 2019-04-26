#include <iostream>
using namespace std;
int main ()
{
	int g,m,d;
	cout<<"godina- "; cin>>g;
	cout<<"mesec- "; cin>>m;
	cout<<"den- "; cin>>d;
	switch (m)
	{
		case 1:
	    case 3:
	    case 5:
	    case 7:
	    case 8:
	    case 10: if (d==31) cout<<"YES 1:"<<m+1<<":"<<g;
	    else cout<<"Yes"<<d+1<<":"<<m<<":"<<g; break;
	    case 4:
	    case 6:
	    case 9:
	    case 11: if (d==30) cout<<"YES 1:"<<m+1<<":"<<g;
	    else cout<<"YES"<<d+1<<":"<<m<<":"<<g; break;
	    case 2: if (d==28) cout<<"YES 1:3:"<<g;
		else if(d==27) cout<<"YES 1:3:"<<g;
		else if (d<27) cout<<"YES "<<d+1<<":"<<m<<":"<<g; break;
		case 12: if (d==31) cout<<"YES 1:1:"<<g+1; break;
		deafult: cout<<"NO nqma takava data "; break;
	}
	return 0;
}

