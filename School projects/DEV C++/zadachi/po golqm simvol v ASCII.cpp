#include <iostream>
#include <locale>
using namespace std;
int main ()
{
	setlocale (LC_ALL,"BULGARIAN");
    char a,b;
	cout<<"въведи символ 1= ";
    cin>>a;
	cout<<"въведи симбол 2= ";
	cin>>b;
	//символите са от таблицата ASCII
	if(a>b){
		        cout<<"Символ "<<a<<" е по голям"<<endl; 
	        }
	if(b>a){
		        cout<<"Символ "<<b<<" е по голям"<<endl;
	        }      
	system ("PAUSE");
	return 0;        
	}
