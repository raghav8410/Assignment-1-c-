using System;
					
public class Program
{
	int j;
	float average,sum=0;
	
	public float Sum(float[] Array)
	{
		for(j=0;j<10;j++)
		{
	   sum=sum+Array[j];
		}
		
		return sum;
	}
	
	public float Average(float sum)
	{
		average=sum/10;
		
		return average;
		
	}
	public static void Main()
	{
		int i;
		float result;
		float[] Array1=new float[10];
		Program p=new Program();
		Console.WriteLine("Enter the element of list");
		 for(i=0;i<10;i++)
	     {
	  	  Array1[i] = Convert.ToInt32(Console.ReadLine());
	     }
		result=p.Sum(Array1);
		Console.WriteLine("The sum is {0}",result);
		Console.WriteLine("The average is {0}",p.Average(result));
	}
}
