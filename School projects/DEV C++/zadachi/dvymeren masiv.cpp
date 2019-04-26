#include <iostream>
using namespace std;
int main ()
{
	int i,j;
	int mas[10][10];
	for(i=0;i<10;i++)
	    for(j=0;j<10;j++)
	        mas[i][j]=i+j;
	for(i=0;i<10;i++)
	   {
	        for(j=0;j<10;j++)
	        cout<<mas[i][j]<<"\t";
	        cout<<endl;
	   }
return 0;
}
