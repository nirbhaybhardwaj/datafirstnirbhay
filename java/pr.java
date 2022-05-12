import java.util.Scanner;
class A
{
public static void main(String args[])
{
Scanner sc=new Scanner(System.in);
int b=1;
int a=sc.nextInt();
for(int i=2;i<a;i++)
{
if(a%i==0)
{
b=b+1;
}
}
if (b==1)
{
System.out.println(a+" is prime number");
}
else
{
System.out.println(a+" is not prime number");
}
}
}