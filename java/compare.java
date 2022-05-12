 class compare
{
  public static void main(String args[])
 { 
  int a=2, b=12, c=12, d, e;
  d = c<(a<b?a:b)?c:((a<b)?a:b);
  e = c>(a>b?a:b)?c:((a>b)?a:b);
  System.out.println("the smallest no is " + d);
  System.out.println("the largest no is " + e);
 }
} 