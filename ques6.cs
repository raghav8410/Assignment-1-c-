using System;
					
public class Program
{
	public int LCM(int number1,int number2)
		{
			int m=number1,n=number2;
		
		int maxElement = (number1>number2 )? number1 : number2 ;
		
		while(number1 != number2)
		{	
			
		if(number1 > number2)
		{
			number1=number1-number2;
		}
		else
		{
			number2=number2-number1;	
		}
		}
		
		return ((m*n)/number1);
		}
	public static void Main()
	{
		
		Console.WriteLine("Enter the first number");
		int number1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the second number");
		int number2=Convert.ToInt32(Console.ReadLine());
		
		Program p=new Program();
		Console.WriteLine(p.LCM(number1,number2));
	}
}

