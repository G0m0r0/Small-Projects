#include <iostream>
using namespace std;
struct List
	{
		int x, y, z; 
		List *link; 
	};
List * head, *pt; 
int n;  
void AddFirst(int x1, int y1, int z1, List *&head)
{
	List *q;
	q=new List;
	q->x=x1;
	q->y=y1;
	q->z=z1;
	q->link=head;
	head=q;
}
void create(int n, List *&p)
		{	int x1,y1,z1, i;
			p=NULL;
			for (i=1;i<=n;i++)
			   {
			      cout<<">";
	        	      cin>>x1>>y1>>z1;
			      AddFirst(x1,y1,z1, p);
			    }
		}
void obhod(List *&head)
{
   List	*p=head;
   while ( p!=NULL)
        {
	 cout<<p->x<<", "<<p->y<<", "<<p->z<<", ";
	 p=p->link;
	 cout<<endl;
	}
}
int main()
{
	cout<<"vavedete br na tochkite";
	cin>>n;
	create(n, head);
	obhod(head);
	system("Pause");
	return 0;
}

