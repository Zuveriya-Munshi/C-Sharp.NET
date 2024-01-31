using System;
class transpose{
 public static void Main(String []args){
	Console.Write("Enter number of row: ");
	int m = Convert.ToInt32(Console.ReadLine());
	Console.Write("Enter number of colums : ");
	int n = Convert.ToInt32(Console.ReadLine());
	int[,] arr = new int[m,n];
	Console.Write("Enter array elements : ");
	for(int i=0;i<m;i++){
	for(int j=0;j<n;j++){
	 arr[i,j] = Convert.ToInt32(Console.ReadLine());
	}
	}
	Console.WriteLine("Transposed Matrix \n");
	for(int i=0;i<n;i++){
	for(int j=0;j<m;j++){

	 Console.Write(arr[j,i] + " ");
	}
	Console.WriteLine();
	}
	
 }
}