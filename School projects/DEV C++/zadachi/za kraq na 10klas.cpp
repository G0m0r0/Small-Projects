#include<iostream>
#include<cstring>
#include<fstream>
#include<fcntl.h>
#include<string>
using namespace std;
int br1=0;
struct danni
{
	string ime;
	char egn[11];
	string adres;
	string otdel;
	string dlajnost;
	string obrazovanie;
	int trydovST;
	double zaplata;
}u;
void create ()
{
	ofstream f;
	f.open("slujitel.dat",ios::out);
	if(!f)
	{
	   cout<<"error\n";
	   system("pause");
	   return;
	}
	int n=-1;
	while(n!=0)
	{
		cout<<"ime "; getline(cin,u.ime); cin.ignore(1024,'\n');
		cout<<"egn "; cin>>u.egn;
		cout<<"adres "; getline(cin,u.adres); cin.ignore(1024,'\n');
		cout<<"otdel "; getline(cin,u.otdel); 
		cout<<"dlajnost "; getline(cin,u.dlajnost);
		cout<<"obrazovanie "; getline(cin,u.obrazovanie);
		cout<<"trydov staj "; int trydovST; cin.ignore(1024,'\n');
		cout<<"zaplata "; cin>>u.zaplata;
		br1++;
		f.write((const char*)&u,sizeof(struct danni));
		cout<<"nov zapis: 1-da,0-ne\n";
		cin>>n;
	}
	f.close();
}
void append ()
{
	ofstream f;
	f.open("slujitel.dat",ios::app);
	if(!f)
	{
	   cout<<"error\n";
	   system("pause");
	   return;
	}
	int n=-1;
	while(n!=0)
	{ 
	    cin.ignore(1024,'\n');
		cout<<"ime "; getline(cin,u.ime); cin.ignore(1024,'\n');
		cout<<"egn "; cin>>u.egn;
		cout<<"adres "; getline(cin,u.adres); cin.ignore(1024,'\n');
		cout<<"otdel "; getline(cin,u.otdel); 
		cout<<"dlajnost "; getline(cin,u.dlajnost);
		cout<<"obrazovanie "; getline(cin,u.obrazovanie);
		cout<<"trydov staj "; cin>>u.trydovST;
		cout<<"zaplata "; cin>>u.zaplata;
		br1++;
		f.write((const char*)&u,sizeof(struct danni));
		cout<<"nov zapis: 1-da,0-ne\n";
		cin>>n;
	}
	f.close();
}
void update_egn()
{
	fstream f;
	f.open("slujitel.dat",ios::in|ios::out|ios::binary);
	if(!f)
	{
		cout<<"error\n";
		system("pause");
		return;
	}
	f.seekg(0,ios::beg);
	char search_egn[11];
	unsigned long pos;
	string nov_adres;
	string nov_otdel;
	string nova_dlajnost;
	string novo_obrazovanie;
	int nov_trydovST;
	double nova_zaplata;
	bool flag=1;
	cout<<"vavedi tarsene po egn"; cin>>search_egn;
	while(f.read((char*)&u,sizeof(struct danni)))
	{
		if(u.egn[11]==search_egn[11])
		{
		flag=0;
		cout<<"adres "; getline(cin,nov_adres); cin.ignore(1024,'\n');
		cout<<"otdel "; getline(cin,nov_otdel); 
		cout<<"dlajnost "; getline(cin,nova_dlajnost);
		cout<<"obrazovanie "; getline(cin,novo_obrazovanie);
		cout<<"trydov staj "; cin>>nov_trydovST;
		cout<<"zaplata "; cin>>nova_zaplata;
		    u.adres.assign(nov_adres);
			u.otdel.assign(nov_otdel); cout<<".";
			u.dlajnost.assign(nova_dlajnost);
			u.obrazovanie.assign(novo_obrazovanie);
			u.trydovST=nov_trydovST;
			u.zaplata=nova_zaplata;
			pos=f.tellg();
			pos=pos-sizeof(struct danni);
			f.seekg(pos);
			f.write((const char*)&u,sizeof(struct danni));
		}
		if(1) cout<<"nqma chovek s takova egn\n";
	}
	f.close();
}
void del_experence()
{
	fstream f;
	unsigned long pos;
	int flag=0;
	struct danni temp;
	f.open("slujitel.dat",ios::in|ios::out|ios::binary);
	if(!f) 
	{
		cout<<"error\n";
		system("pause");
		return;
	}
	unsigned long pos_del;
	f.seekg(0,ios::end);
	pos=f.tellg();
	pos=pos-sizeof(struct danni);
	f.seekg(pos);
	pos_del=pos;
	f.read((char*)&temp,sizeof(struct danni)); 
	if(temp.trydovST>30)
	{
		flag=1;
		unsigned long fd=_open("slujitel.dat",_O_RDWR);
		chsize(fd,pos_del);
		br1--;
	}
	else
	{
		f.seekg(0,ios::beg);
		while(f.read((char*)&u,sizeof(struct danni)))
		{
			if(u.trydovST>30)
			{
				flag=1;
				pos=f.tellg();
				pos=pos-sizeof(struct danni);
				f.seekg(pos);
				f.write((const char*)&temp,sizeof(struct danni));
				unsigned long fd=_open("slujitel.dat",_O_RDWR);
				chsize(fd,pos_del);
				br1--;
			}
		}
	}	
	if(flag=0) cout<<"nqma slujiteli s previshen trydov staj"<<endl;
	f.close();
}
void minsalary()
{
	fstream f;
	double min;
	f.open("slujitel.dat",ios::in);
	if(!f) 
	{
		cout<<"error\n";
		system("pause");
		return;
	}
	f.read((char*)&u,sizeof(struct danni));
	min=u.zaplata;
	while(f.read((char*)&u,sizeof(struct danni)))
	{
		if(u.zaplata<min) min=u.zaplata;
	}
	f.seekg(0,ios::beg);
	while(f.read((char*)&u,sizeof(struct danni)))
	{
		if(min==u.zaplata)
		{
		cout<<"ime "<<u.ime;
		cout<<"egn "<<u.egn;
		cout<<"adres "<<u.adres;
		cout<<"otdel "<<u.otdel;
		cout<<"dlajnost "<<u.dlajnost;
		cout<<"obrazovanie "<<u.obrazovanie;
		cout<<"trydov staj "<<u.trydovST;
		cout<<"zaplata "<<u.zaplata;
		}
	}
	f.close();
}
void position()
{
     fstream f;
     string dlaj;
     cout<<"vavedi dlajnost"; cin.ignore(1024,'\n');
     getline(cin,dlaj);
     int n;
     cout<<"vavedi godini trydov staj"; cin.ignore(1024,'\n');
     cin>>n;
	f.open("slujitel.dat",ios::in);
	if(!f) 
	{
		cout<<"error\n";
		system("pause");
		return;
	}
	 	while(f.read((char*)&u,sizeof(struct danni)))
	{
		if((u.dlajnost==dlaj)&&(u.trydovST>n))
		{
		cout<<"ime "<<u.ime;
		cout<<"egn "<<u.egn;
		cout<<"adres "<<u.adres;
		cout<<"otdel "<<u.otdel;
		cout<<"dlajnost "<<u.dlajnost;
		cout<<"obrazovanie "<<u.obrazovanie;
		cout<<"trydov staj "<<u.trydovST;
		cout<<"zaplata "<<u.zaplata;
		}
    }
	f.close();
}
void arr()
{
	fstream f;
	int br=0;
	int S=0;
	f.open("slujitel.dat",ios::in);
	if(!f) 
	{
		cout<<"error\n";
		system("pause");
		return;
	}
	f.read((char*)&u,sizeof(struct danni));
	 	while(f.read((char*)&u,sizeof(struct danni)))
	 	{
	 		S=S+u.zaplata; 
	 		br++;
		 }
	cout<<"srednata zaplata e "<<S/br<<endl<<endl;
	f.close();
}
void section()
{
	fstream f;
	cout<<"vavedi otdela ";
	string otd;
	getline(cin,otd);
	int br=0;
	f.open("slujitel.dat",ios::in);
	if(!f) 
	{
		cout<<"error\n";
		system("pause");
		return;
	}
	while(f.read((char*)&u,sizeof(struct danni)))
	{
		if(u.otdel==otd)
		{
			cout<<u.ime<<endl;
			br++;
		}
	}
	cout<<"procent na slyjiteli ot obshtiq broi"<<(br*100)/br1;
	f.close();
}
void egnn()
{
     fstream f;
     string egn1;
     cout<<"vavedi tarseno egn";
     getline(cin,egn1);
	f.open("slujitel.dat",ios::in);
	if(!f) 
	{
		cout<<"error\n";
		system("pause");
		return;
	}
	 	while(f.read((char*)&u,sizeof(struct danni)))
	{
		if(u.egn==egn1)
		{
		cout<<"ime "<<u.ime;
		cout<<"egn "<<u.egn;
		cout<<"adres "<<u.adres;
		cout<<"otdel "<<u.otdel;
		cout<<"dlajnost "<<u.dlajnost;
		cout<<"obrazovanie "<<u.obrazovanie;
		cout<<"trydov staj "<<u.trydovST;
		cout<<"zaplata "<<u.zaplata;
		}
    }
	f.close();
}
void all_information()
{
	fstream f;
	f.open("slujitel.dat",ios::in);
	if(!f) 
	{
		cout<<"error\n";
		system("pause");
		return;
	}
	 	while(f.read((char*)&u,sizeof(struct danni)))
	{
		cout<<"ime "<<u.ime<<endl;
		cout<<"egn "<<u.egn<<endl;
		cout<<"adres "<<u.adres<<endl;
		cout<<"otdel "<<u.otdel<<endl;
		cout<<"dlajnost "<<u.dlajnost<<endl;
		cout<<"obrazovanie "<<u.obrazovanie<<endl;
		cout<<"trydov staj "<<u.trydovST<<endl;
		cout<<"zaplata "<<u.zaplata<<endl<<endl;
    }
	f.close();
}
void big_del()
{
	
	bool a;
	cout<<"Are you sure you want to delete the file? \n";
	cout<<"type 1 for YES\n";
	cout<<"type 0 for NO\n";
	cin>>a;
	if(a==1)
	{
	if(remove("slujitel")==0) 
	cout<<"The fail is deleted !/n";
    }   
    return;
}
void del_egn()
{
	fstream f;
	unsigned long pos;
	int flag=0;
	struct danni temp;
	char search_egn[11];
	cout<<"vavedi tarsene po egn"<<endl;
	cin>>search_egn[11];
	f.open("slujitel.dat",ios::in|ios::out|ios::binary);
	if(!f) 
	{
		cout<<"error\n";
		system("pause");
		return;
	}
	unsigned long pos_del;
	f.seekg(0,ios::end);
	pos=f.tellg();
	pos=pos-sizeof(struct danni);
	f.seekg(pos);
	pos_del=pos;
	f.read((char*)&temp,sizeof(struct danni)); 
	if(temp.egn==search_egn)
	{
		flag=1;
		unsigned long fd=_open("slujitel.dat",_O_RDWR);
		chsize(fd,pos_del);
		br1--;
	}
	else
	{
		f.seekg(0,ios::beg);
		while(f.read((char*)&u,sizeof(struct danni)))
		{
			if(u.egn==search_egn)
			{
				flag=1;
				pos=f.tellg();
				pos=pos-sizeof(struct danni);
				f.seekg(pos);
				f.write((const char*)&temp,sizeof(struct danni));
				unsigned long fd=_open("slujitel.dat",_O_RDWR);
				chsize(fd,pos_del);
				br1--;
			}
		}
	}	
	if(flag=0) cout<<"nqma slujiteli s takova egn"<<endl;
	f.close();	
}
int main()
{
	int a1,a2;
	int a=-1;
	while(a!=0)
	{ 
	    
		cout<<"1- create system\n\n";
		cout<<"2- update\n\n";
		cout<<"3- reference\n\n";
		cout<<"4- delete fail\n\n";
		cout<<"5- exit\n\n";
		cout<<"type number "; 
		cin>>a;
	    switch(a)
	{
		case 1: create(); break;
		case 2: { 
		        cout<<"6- add a new employee\n\n";
		        cout<<"7- update existing information for employee\n\n";
		        cout<<"8- search with egn and delete information\n\n";
	            cout<<"9- delete information for people who have more experience\n\n";
	            cout<<"izbor"<<endl;
		        cin>>a1;
	            switch(a1)
	            {
	            	case 6: append(); break;
	                case 7: update_egn(); break;
	                case 8: del_egn(); break;
		            case 9: del_experence(); break;
				}
		   } 
		
		case 3: {
				cout<<"10- find minimum salary\n\n";
			    cout<<"11- find information for employee with position\n\n";
			    cout<<"12- average salary for all employees\n\n";
			   	cout<<"13- names of people who are in sertain section and percents\n\n";
			   	cout<<"14- find someone with egn and see his information\n\n";
			   	cout<<"15- see information of all staff\n\n";
			   	cout<<"izbor"<<endl;
		        cin>>a2;
		switch(a2)
		{
		case 10: minsalary(); break;
		case 11: position(); break;
		case 12: arr(); break;
		case 13: section(); break;
		case 14: egnn(); break;
		case 15: all_information(); break;
		}
		}
		case 4:  big_del(); break;
		case 5: default:exit(0);
	}
}
	return 0;        
	}


