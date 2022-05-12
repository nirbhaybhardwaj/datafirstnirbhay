class test
{
	public static void main(String args[])
	{
		java.util.Scanner input = new java.util.Scanner(System.in);
		
		System.out.print("How many elements you want in an Array: ");
		int size = input.nextInt();
		int arr[] = new int[size];

		for(int i=0; i<size; i++)
		{
			System.out.print("At index " + i + " : ");
			int num = input.nextInt();
			arr[i] = num;	
		}

		System.out.println("Entered Array: ");
		System.out.println(java.util.Arrays.toString(arr));
		
		int store=0;
		int ctr=0;

		while(ctr<arr.length)
		{
			int ptr = ctr + 1;
			while(ptr<arr.length)
			{
				if(arr[ctr]>arr[ptr])
				{
					store = arr[ctr];
					arr[ctr] = arr[ptr];
					arr[ptr] = store;
				}
				ptr++;
			}
			ctr++;
		}
		System.out.println("Sorted Array: ");
		System.out.println(java.util.Arrays.toString(arr));
	}
}