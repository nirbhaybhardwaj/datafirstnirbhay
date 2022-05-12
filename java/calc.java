 class calc
{
  public static void main(String args[])
 { 
 java.util.Scanner input = new java.util.Scanner(System.in);
	System.out.println("Enter the first no.");
	int n1 = input.nextInt();
	System.out.println("Enter the second no.");
	int n2 = input.nextInt();
	int result = 0;
	System.out.println("Enter the operator(+,-,*,/) ");
	char operator = input.next().charAt(0);
	switch(operator)
	{
		case '+':
		result = n1+n2;
		System.out.println("The result is " + result);
		break;
		case '-':
		result = n1-n2;
		System.out.println("The result is " + result);
		break;
		case '*':
		result = n1*n2;
		System.out.println("The result is " + result);
		break;
		case '/':
		result = n1/n2;
		System.out.println("The result is " + result);
		break;
		default:
		System.out.println("Invalid operator");
		
	}
 }

 }
 
