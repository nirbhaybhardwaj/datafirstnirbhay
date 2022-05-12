import java.util.Scanner;
class Starmethod
{
	public static void main(String[] args)
	{
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter the row=");
		int r=sc.nextInt();
		System.out.print("Enter the col=");
		int c=sc.nextInt();
		starPaternI(r,c);
	}
	static void starPaternI(int r,int c )
	{
		for(int i=0;i<=r;i++)
		{
			for(int j=0;j<=c;j++)
			{
				System.out.print("*");
			}
			System.out.println();
		}
	}
}