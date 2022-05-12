#include<stdio.h>
#include<conio.h>
void main()
{
//Declration of int type variable.
int arr[10];
int i,pos,num;
clrscr();
printf("Enter the number\n:");
scanf("%d",&num);
for(i=0;i<num;i++)
{

scanf("%d",&arr[i]);
}
//position of the elements to be deleted:
printf("\nDefine the position of the array elements where you want to delete:\n");
scanf("%d",&pos);
//Check whether the deletion is possible or not:
if(pos>=num+1)
{
printf("\nDeletion is not possible");
}
else
{
for(i=pos-1;i<num;i++)
arr[i]=arr[i+1];
printf("\nThe resultunt array is\n:");
//display athe final array
for(i=0;i<num-1;i++)
printf("%d",arr[i]);
}
getch();
}
