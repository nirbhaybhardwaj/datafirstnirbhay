class Even2
{
	public static void main(String[] args)
        {
          int[] arr={1,2,3,4,5,6,7};
          
		int[] res=even(arr);
                for(int i=0;i<res.length;i++)
                 {
                  if(res[i]>0)
                System.out.print(res[i]+" ");
                 }   
                 System.out.println();
              int[] pr=prime(arr);
                 for(int i=0;i<pr.length;i++)
                 {
                  if(res[i]>0)
                System.out.print(pr[i]+" ");
                 }
  	}
	static int[] even(int arr[])
	{
	   int[] ev=new int[arr.length]; 
            int p=0;
	  for(int i=0;i<arr.length;i++)
		{
		     if(arr[i]%2==0)
			{
				ev[p]=arr[i];
                                 p++;
			}
		}  
             return ev;	
	}
public static int[] prime(int[] ar)
{
int st[]=new int[ar.length];
boolean b;
int p=0;
for(int i=0;i<ar.length;i++)
{
b=true;
for(int j=2;j<ar[i];j++)
{
if(ar[i]%2==0)
{
b=false;
break;
}
}
if(b==true)
{
st[p]=ar[i];
p++;
}
}
return st;
}
}