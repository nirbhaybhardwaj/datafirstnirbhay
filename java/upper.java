class Test1
{
 public static void main(Stringargs[])
 {
  int upper=0,int lower=0;
  java.util.Scanner input new java.util.Scanner(System.in);
  String name=input.nextline();
   for(int ctr=0;ctr<name.length();ctr++)
   {
    if (name.charAt(ctr)>="A" && name.charAt(ctr)<="Z")
	    upper++
     else
	    lower++;
	}
	 System.out.println("Upper is:"+Upper);
	 System.out.println("Lower is:"+Lower);
 }
}