using System;
					
public class Program
{
	int sum=0,i;
	public int Sum(int length)
	{
		Console.Write("The Sum of odd Natural Number upto {0} terms :",length);
		for(i=1;i<=length*2;i=(i+2))
		{
			sum=sum+i;
		}
	  return sum;
	}
	
	public void Elements(int length)
	{
		Console.Write("The odd numbers are :");
		for(i=1;i<=length*2;i=(i+2))
		{
			Console.Write(i+" ");
		}
	}
	
	public static void Main()
	{
		Console.Write("Input number of terms :");
		int length=Convert.ToInt32(Console.ReadLine());	
		Program p=new Program();
		p.Elements(length);
		Console.WriteLine();
		Console.WriteLine(p.Sum(length));
	}
}
