using System;
					
public class Program
{
	public static void Main()
	{
		int i,j,l=0;
		bool k;
		int rows=Convert.ToInt32(Console.ReadLine());
		for(i=0;i<=rows;i++)
		{
			k=true;
		 for(j=0;j<(rows*2);j++)
		 {
		   if((j>=(rows+1)-i && j<=(rows-1)+i) && k)
		   {
		     Console.Write(l++);
			   k=false;
		   }
			 else
			 {
				 Console.Write(" ");
				 k=true;
			 }
		  }
			Console.WriteLine();
		}
	}
}
