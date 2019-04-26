#include <iostream>
using namespace std; 
int main ()
{
	int i,j;
	int mas[3][4];
	for(i=0;i<3;i++)
	    for(i=0;i<4;i++)
	        mas[i][j]=j+i;
	for(i=0;i<3;i++)
	    for(i=0;i<4;i++)
	       {  cout<<mas[i][j]<<"\t";
	       cout<<endl;
	   }
	return 0;    
}
