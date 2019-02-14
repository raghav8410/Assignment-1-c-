using System;
					
public class Program
{
	int i;
	int[] array1=new int[5];
	int[] array2=new int[5];
	
	public void MultiplyCorrespondingElement()
	{
	   Console.WriteLine("Enter the element of Array1");
	  for(i=0;i<4;i++)
	  {
	  	array1[i] = Convert.ToInt32(Console.ReadLine());
	  }
	
	  Console.WriteLine("Enter the element of Array2");
	  for(i=0;i<4;i++)
	  {
	    array2[i]= Convert.ToInt32(Console.ReadLine());
	  }
	   
	  for(i=0;i<4;i++)
	  {
	    Console.Write(array1[i]*array2[i] + " ");
	  }
	}
public static void Main()
  {
	  Program p=new Program();
	  p.MultiplyCorrespondingElement();
  }	
}

