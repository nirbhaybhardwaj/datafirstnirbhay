class FreqA
{
public static void main(String[] args)
{
int[] arr1={1,2,3,1,6,4,3};
int[] arr2=new int[arr1.length];
int a=-1;
for(int i=0;i<arr1.length;i++)
{
int count=1;
for(int j=i+1;j<arr1.length;j++)
{
if (arr1[i]==arr1[j])
{
count++;
arr2[j]=a;
}
}
if(arr2[i]!=a)
{
arr2[i]=count;
}
}
for(int i=0;i<arr2.length;i++)
{
	if (arr2[i]!=a)
	{
		System.out.println("Frequency of "+arr1[i]+":"+arr2[i]);
	}
}
}
}