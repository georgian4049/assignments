using System;
					
public class Program
{
	public static void Main()
	{int n;
	 string no,datas;
	 Console.Write("enter the no of data to be entered\n");
	 no=Console.ReadLine();
	 n=Convert.ToInt16(no);
	 int[] a=new int[n];
	 Console.Write("enter the data\n");
	 for(int i=0;i<n;i++)
	 {
		 datas=Console.ReadLine();
		 a[i]=Convert.ToInt16(datas);
		 if(i%2==0)
			 a[i]--;
		 else
			 a[i]++;
	 }
	 Console.Write("printing data\n");
	 for(int i=0;i<n;i++)
	 {
	 Console.Write(a[i]+"\n");
	 }
	}
}
