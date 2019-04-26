#include <iostream>
using namespace std;
int main()
{
long long put,br3,chislo,aes,br,br4,ae,otgovor,kilogrami,br2,chislo2,opit,l_ch=0,poznato;
  for(opit=0;opit<=3;opit++)
  {
  l_ch=l_ch+68;
  cout<<"vuvedi pasword ";
               cin>>chislo2;
       if(chislo2==159753)
       {
          for(br2=0;br2>=0;br2++)
          {
            cout<<"\n0.Kilogrami \n";
            cout<<"1.Matematika \n";
            cout<<"2.Vupros\n";
            cout<<"3.lubimo chislo\n";
            cout<<"4.vuvedi otcenkite si po ae\n";
            cout<<"-----------------------------\n";
            cin>>chislo;
              if(chislo==0)
              {
               cout<<" kolko kilograma tejish ";
               cin>>kilogrami;
                 if(kilogrami<=50)
                 {
                   cout<<"ti si slab \n";
                 }
                 else
                 {
                   cout<<"debel si\n";
                 }
                }
              else
              {
                if(chislo==1)
                {
                  for(br=0;br>=0;br=br+21)
                  {
                    cout<<"kolko e "<                    
					cin>>otgovor;
                      if(otgovor==br+97)
                      {
                        cout<<"vqrno";
                      }
                      else
                      {
                        cout<<"greshno";
                      }
                  }
                }
                else
                {
                    if(chislo==2)
                    {
                      cout<<"Po koi put shte minesh\n";
                      cout<<"Kratkiq (1)\n";
                      cout<<"_______________\n";
                      cout<<"---------------\n";
                      cout<<"Ili po dulgiq (2)\n";
                      cout<<"---------------------------------------------\n";
                      cout<<"_____________________________________________\n";
                      cin>>put;
                        if(put==1)
                        {
                          cout<<"Sgreshi!! Kratkite putishta sigorno sa tqsni i sa samo kozi puteki.";
                        }
                        else
                        {
                          cout<<"Umen si.Po tozi put shte minesh bez zatrudnenie.";
                        }
                    }
                    else
                    {
                        if(chislo==3)
                        {

                        int a;
                        int b;
                        int c = 0;
                        while(true)
                        {
                        cin.clear();
                        c = 0;


                        cout<<"Koe mi e lubimoto chislo !?";                       
						do
                        {
                        cout<<"Dai svoeto predlojenie:";
                        cin >> b;
                        if(b > a)
                         {
                        cout<<"Tvarde Golqmo Chislo!"<< endl;                       }
                        if(b < a)
                        {
                        cout<<"Tvarde Malko Chislo!"<< endl;                       }
                        c ++;
                        }while(b > a || b < a);
                        cout << "Bravoi ti pozna lubimoto mi chislo!!!"<                        cout << "Ti napravi" <<" ";
                         }

                                                 }
                                                 else
                                                 {
                                                     if(chislo==4)
                                                     {
                                                       for(br4=0;br4<=15;br4++)
                                                       {
                                                       cout<<"kolko imash po ae ";
                                                       cin>>ae;
                                                       aes=ae+ae;
                                                       }
                                                       aes=aes%10;
                                                                                                       }
                                                 }
                     }
                 }
               }
               }
                  }
                 else
                 {
                   cout<<"greshna pasword ";
                 }
  }
return 0;
}

