#include <iostream>
using namespace std;
int main ()
{
     int min,max,*p,i,n;
     cout<<"enter the number of array elements= ";
     cin>>n;
     int a[n];
     p=a; min=a[0]; max=a[0];
     for(i=0;i<n;i++,p++)
         {
             cin>>*p;           
             if(min>*p) min=*p; cout<<".";
             if(max<*p) max=*p; cout<<"!";
		 }
		 cout<<"max="<<max<<endl;
		 cout<<"min="<<min<<endl;
     cout<<"max-min= "<<max-min<<endl;
     return 0;
}         
           
