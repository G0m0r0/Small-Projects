#include<iostream>
using namespace std;
int main()
{
	int n,m,a[n],i;
	cout<<"enter n= ";
	cin>>n;
	cout<<"full mass\n";
	int br;
	for(i=0;i<n;i++)
    cin>>a[i]; if(a[i]%2==0) br++;
	int b[br];
	for(i=0,br=0;i<n;i++)
	if(a[i]%2==0) { 
	            b[br]=a[i]; 
	            br++;
	       }
	for(i=0;i<br;i++)
	cout<<"B["<<i+1<<"]= "<<b[i]<<endl;
	cout<<"all elements of mass b are: "<<br;
	return 0;
}

