import java.util.Scanner;
class Exe{
	public static void main(String [] args){
		Scanner sc = new Scanner(System.in);
		System.out.print("Please Enetr your name : ");
		String name=sc.nextLine();
		System.out.print("Please Enetr Your number :");
		int no=sc.nextInt();
		int ctr=0;
		
		do
		{
			
			System.out.println(name);
			ctr=ctr+1;
			}while(ctr<no);
			 
			 
	
		
		
		
		
	}
	
}