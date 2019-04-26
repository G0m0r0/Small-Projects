#include <iostream>
using namespace std;
int main ()
{
	int i=1,n,s=0;
	cout<<"vavedi kolko trohi ima "; cin>>n;
	while (i<=n)
	{
		s+=i;
		i++;
	}
	cout<<"mravkata e izminala "<<s*2<<endl;
	return 0;
}
