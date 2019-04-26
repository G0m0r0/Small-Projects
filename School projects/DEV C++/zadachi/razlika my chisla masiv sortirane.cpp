#include<iostream>
using namespace std;
void input(int a[],int n)
{
	cout<<"avedi elementi na masiva\n";
	for(int i=0;i<n;i++)
	{
		cout<<"["<<i+1<<"]= ";
		cin>>a[i];
	}
}
void output(int a[], int n)
{
	for(int i=0;i<n;i++)
    cout<<a[i]<<" ";
}
void action(int a[], int n)
{   int s;
       for(int i=0;i<n-1;i++)
	      for(int j=0;j<n;j++)
	         if((a[i]-a[i+1])<a[j+1]-a[j+2])
	           {
	           	    s=a[i];
	           	    a[i]=a[i+1];
	           	    a[i+1]=s;
	   	            s=a[i+1];
	   	            a[i+1]=a[j+2];
	   	            a[j+2]=s;
	           }
}
int main()
{
	int n;
	cout<<"vavedi broi elementi na masiva";
	cin>>n;
	int a[n];
	input(a,n);
	action(a,n);
	output(a,n);
	return 0;
}

