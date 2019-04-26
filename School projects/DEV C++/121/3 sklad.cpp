#include <iostream>
using namespace std;
int main ()
{
    int ngr,pkg,pgr,nkg,a;
	do{
	cout<<"nalichna stoka v kilogrami  "; cin>>nkg; 
	cout<<"nalichni stoka v gramove  "; cin>>ngr; 
	cout<<"vavedi prodadeno kolichestvo kilogrami  "; cin>>pkg;
	cout<<"vavedi prodadeno kolichestvo gramove   "; cin>>pgr;
  if (ngr>1000) nkg=nkg+(ngr/1000);
  else if (nkg>10000) cout<<"sklada ne moje da sadarja nad 10 000 kg";
}while (nkg>10000);
if(ngr>1000) ngr=ngr%1000;
else if (pgr>ngr) ngr=pgr-ngr;
else ngr=ngr-pgr;
nkg=nkg-pkg;
if (ngr>0) nkg=nkg-1;
cout<<"nalichni kilogrami "<<nkg<<"kg"<<endl;
cout<<"nalichni gramove "<<ngr<<"gr"<<endl;
return 0;
}
