/*<html><body>
<applet code="applet1.class" width=700 height=300 > </applet>
</body></html>
*/
import java.awt.*;
import java.awt.event.*;
import java.applet.*;
public class applet1 extends Applet implements ActionListener{
	Button bref1;
	Button bref2;
	int c1,c2;
	public void init(){
	bref1 = new Button("B1");
	bref2 = new Button("B2");
	c1=0;
	c2=0;
	this.add(bref1);
	this.add(bref2);
	bref1.addActionListener(this);
	bref2.addActionListener(this);
	}
	
	public void actionPerformed(ActionEvent ae){
		String s= ae.getActionCommand();
		if(s.equals("B1")) c1++;
		else c2++;
	showStatus("B1 is pressed "+c1+" times and B2 is pressed "+c2+" times");
	}
	
}