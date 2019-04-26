#include<iostream>
using namespace std;
int main()
{
	int n,max;
	int a[n];
	cout<<"enter n= ";
	cin>>n;
	cout<<"full the mas with "<<n<<" elements\n";
	for(int i=0;i<n;i++)
	cin>>a[i];
	max=a[0];
	for(int i=1;i<n;i++)
	if((a[i]%2!=0)and(max<a[i])) max=a[i];
	cout<<"max= "<<max;
	return 0;
}
