class buffer{
	int info;
	volatile int flag=0;
	buffer(){flag=0;}
	synchronized void put(int n){
		if(flag==1) {
		try{ 
			wait();
		 } 
		catch(InterruptedException e){
			System.out.println("Interrupted Exception");
		}
		}
		flag=1; 
		info=n;
		notify();
	}
	synchronized void get(){
		if(flag==0) {
		try{ 
			wait();
		 } 
		catch(InterruptedException e){
			System.out.println("Interrupted Exception");
		}
		}
		System.out.println("Information : " + info);
		flag=0;
		notify();
	}

}
class producer extends Thread{
	buffer b_ref;
	int pid;
	producer(buffer b, int id){
		super();
		b_ref=b;
		pid=id;
		this.start();
	}
	public void run(){
		for(int i=0;i<5;i++){
			b_ref.put(i); 
			try{
				Thread.sleep(100);
			} catch(InterruptedException e){
				System.out.println("Interrupted Exception");
			}
		}
	}
}
class consumer extends Thread{
	buffer b_ref;
	int cid;
	consumer(buffer b, int id){
		super();
		b_ref=b; 
		cid=id;
		start();
	}
	public void run(){
		for(int i=0;i<5;i++){
			b_ref.get();
			try{
				Thread.sleep(100);
			} catch(InterruptedException e){
				System.out.println("Interrupted Exception");
			}
		}
	}

}
class pc{
 public static void main(String args[]){
	buffer b_ref_main = new buffer();
	producer p_ref = new producer(b_ref_main,0);
	consumer c_ref = new consumer(b_ref_main,0);
	try
	{
		p_ref.join();
  		c_ref.join();
	}
	catch(InterruptedException e){
		System.out.println("Interrupted Exception");
	}
	
 }
}