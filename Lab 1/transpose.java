import java.util.*;
class transpose{
 public static void main(String []args){
	Scanner r = new Scanner(System.in);
	System.out.print("Enter number of row: ");
	int m = r.nextInt();
	System.out.print("Enter number of colums : ");
	int n = r.nextInt();
	int[][] arr = new int[m][n];
	System.out.print("Enter array elements : ");
	for(int i=0;i<m;i++){
	for(int j=0;j<n;j++){
	 arr[i][j] = r.nextInt();
	}
	}
	System.out.println("Transposed Matrix \n");
	for(int i=0;i<n;i++){
	for(int j=0;j<m;j++){

	 System.out.print(arr[j][i] + " ");
	}
	System.out.println();
	}
	
 }
}