using System;
					
public class Program
{
	public bool IsDivisible(int number)
	{
		if(number%3==0 || number%7==0)
		{return true;}
		
		return false;
	}
}

public class main
{
  public static void Main()
  {
    string input=Console.ReadLine();
	  int values=Convert.ToInt32(input);
	  Program p=new Program();
	  Console.WriteLine(p.IsDivisible(values));
  }
}
