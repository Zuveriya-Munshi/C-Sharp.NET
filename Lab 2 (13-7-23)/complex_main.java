class complex
{
	int r,i;
	complex()
	{
	  r=0;
	  i=0;
	}
	complex(int d_r, int d_i)
	{
	  r=d_r;
	  i=d_i;
	}
	void display()
	{
	  System.out.println(r + "+" + i + "i");
	}
	complex add_complex(complex d_c_ref)
	{
	  complex res_ref = new complex();
	  res_ref.r = r+d_c_ref.r; 
	  res_ref.i = i+d_c_ref.i; 
	  return res_ref;
	}
}
class complex_main
{
  public static void main(String args[])
  {
	complex c_ref1 = new complex(3,6);
	c_ref1.display();
	complex c_ref2 = new complex(2,5);
	c_ref2.display();
	complex result;
	result = c_ref1.add_complex(c_ref2);
	result.display();
  }
}
