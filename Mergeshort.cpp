#include<iostream>
using namespace std;
void print(int *Z,int n)
{
    for(int i=0;i<n;i++)
    {
        cout<< Z[i]<<" ";
    }
}



//***********************************Conquer ********************************
void con(int A[],int low,int mid,int high)
{
    int dubli[100];
    int i=low;
   int j=mid+1;
    int k=low;
    while(i<=mid&& j<=high){
    
    if(A[i]<A[j])
   { 
       dubli[k]=A[i];
    i++;
    k++;
    
}
else
{
   dubli[k]=A[j];
   j++;
   k++;
}

}
while(i<=mid)
{
  dubli[k]=A[i];
    i++;
    k++;
}
while(j<=high)
{
   dubli[k]=A[j];
   j++;
   k++;
}  
for(int temp=0;temp<=high;temp++)
{
    A[temp]=dubli[temp];
}
}
//*****************************Mergsort**************************************
void mergesort(int A[],int low, int high)
{
    int mid;
    if(low<high)
    {
        mid =(low+high)/2;
        mergesort( A,low ,mid);
        mergesort( A,mid+1 ,high);
        con(A,low,mid,high);
    }
}

int main()
{   int arr[]={10,2,4,55,23,80,13,5,25};
    int n;
    n=sizeof(arr)/sizeof(int);
    print(arr,n);
    cout<<endl;
    mergesort(arr,0,n-1);
    print(arr,n);
    return 0;
    
}