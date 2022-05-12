#include<stdio.h>
#include<conio.h>
void main()
{
int arr[10],i;
clrscr();
printf("Enter the total Elements of array:\n");
for(i=0;i<10;i++)
{
scanf("%d",&arr[i]);
}
for(i=0;i<10;i++)
{
printf("\n%d",arr[i]);
}
printf("\n");

getch();
}
