class child extends Thread{
String msg;
int th_id;
child(String name, int id,String m){
	super(name);
	msg=m;
	th_id=id;
	start();
}
public void run(){
	try{
	    	for(int i=0;i<4;i++){
			System.out.println( " Id : " + th_id + " Message : " + msg + " Iteration : " + i);
			Thread.sleep(100);
		}
	}
	catch(InterruptedException e){
	System.out.println("Interrupted Exception");
	}
}
}
class main_thread{
  public static void main(String args[]){
	child c1 = new child("Child 1",1,"Running from Child 1");
	child c2 = new child("Child 2",2,"Running from Child 2");
	child c3 = new child("Child 3",3,"Running from Child 3");
	try{
	    	for(int i=0;i<5;i++){
			System.out.println("Main Thread : " + i);
			Thread.sleep(20);
		}
	}
	catch(InterruptedException e){
	System.out.println("Interrupted Exception from main");
	}
	try{
	    	c1.join(); c2.join(); c3.join();
	}
	catch(InterruptedException e){
	System.out.println("Interrupted Exception from main");
	}
  }	
}


