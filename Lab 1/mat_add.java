import java.util.*;
class mat_add{
 public static void main(String args[]){
	Scanner r = new Scanner(System.in);
	System.out.print("Enter number of row: ");
	int m = r.nextInt();
	System.out.print("Enter number of colums : ");
	int n = r.nextInt();
	int a[][] = new int[m][n];
	int[][] b = new int[m][n];
	int[][] c = new int[m][n];
	System.out.print("Enter elements of a[][] : ");
	for(int i=0;i<m;i++){
	  for(int j=0;j<n;j++){
		a[i][j] = r.nextInt();
	  }
	}
	System.out.print("Enter elements of b[][] : ");
	for(int i=0;i<m;i++){
	  for(int j=0;j<n;j++){
		b[i][j] = r.nextInt();
	  }
	}
	System.out.print("Addition of a[][] + b[][] \n");
	for(int i=0;i<m;i++){
	  for(int j=0;j<n;j++){
		c[i][j] = a[i][j] + b[i][j];
		System.out.print(c[i][j] + " ");
	  }
	System.out.println();
	}
 }
}