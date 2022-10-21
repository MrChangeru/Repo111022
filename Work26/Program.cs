using System;

namespace Work26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива -> ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n,n];
            int i=0,j=0,z=n,x=1;
            do{
                for(;j<z;j++)a[i,j]=x++;
                j--;i++;
                for(;i<z;i++)a[i,j]=x++;
                i--;j--;
                for(;j>=n-z;j--)a[i,j]=x++;
                j++;i--;z--;
                for(;i>=n-z;i--)a[i,j]=x++;
                i++;j++;
            }while(x<=n*n);
            for(i=0;i<n;i++){
                for(j=0;j<n;j++){
                    if(a[i,j]>0 && a[i,j]<10)Console.Write("0");
                    Console.Write("{0} ",a[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}