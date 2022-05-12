#include<iostream>
using namespace std;
void print(int *A,int n)
{
    for(int i=0;i<n;i++)
    {
        cout<<A[i]<<" ";
    }
    cout<<endl;
}
//***************partition***************
int partition(int A[],int low,int high)
{
int i,j,pivot,temp;
pivot=A[low];
i=low+1;
j=high;
do
{
    while(A[i]<=pivot)
    {
        i++;
    }
    while(A[j]>pivot)
    {
        j--;
    }
   if(i<j)
    {
        temp=A[i];
        A[i]=A[j];
        A[j]=temp;
   }
}
while(i<j);

    temp=A[low];
    A[low]=A[j];
    A[j]=temp;
    return j;
}
//******************************************************
void quicksort(int A[],int low,int high)
{
    int index;
    if(low<high)
    {
       index=partition(A,low,high);
       quicksort(A,low,index-1);
       quicksort(A,index+1,high);
    }
}
//********************main program********************
int main()
{
    int arr[]={6,9,4,5,0,2,3,11,5};
    int n=sizeof (arr)/sizeof(int);
    print(arr,n);
    quicksort(arr,0,n-1);
    print(arr,n);
    return 0;
}











