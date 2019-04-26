#include<iostream>
using namespace std;
int main()
{
	int i,n,a[n],m,b[m],v,c[v];
	cout<<"enter n= ";
	cin>>n;
	cout<<"full mass A:\n";
	for(i=0;i<n;i++)
	{
	cin>>a[i];
	if(a[i]>=0) m++;
	else v++;
    }
    for(i=0,m=0;i<n;i++)
    if(a[i]>=0) {
	               b[m]=a[i];
	               m++;
                }
    cout<<"elements of mas B:\n";
    for(i=0;i<m;i++)
    cout<<"B["<<i+1<<"]= "<<b[i]<<endl;
    cout<<"all elements of mass B= "<<m<<endl<<endl;
    for(i=0,v=0;i<n;i++)
    if(a[i]<0) {
	                c[v]=a[i];
	                v++;
	            }
    cout<<"elements of mas C:\n";
    for(i=0;i<v;i++)
    cout<<"C["<<i+1<<"]= "<<c[i]<<endl;
    cout<<"all elements of mass C= "<<v<<endl;
    return 0;
}
