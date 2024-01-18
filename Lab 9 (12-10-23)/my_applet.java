/*<html><body>
<applet code="my_applet.class" width=700 height=300 > </applet>
</body></html>
*/
import java.awt.*;
import java.awt.event.*;
import java.applet.*;
import javax.swing.*;
public class my_applet extends Applet implements ActionListener,ItemListener{
 	JCheckBox jcb1;
	JCheckBox jcb2;
	JButton b1;
	JButton b2; String s="";
	public void init(){
	b1 = new JButton("B1");
	b2 = new JButton("B2");
	jcb1 = new JCheckBox("A");
	jcb2 = new JCheckBox("B");
	setLayout(new GridLayout(2,2));
	add(jcb1); add(jcb2);
	add(b1); add(b2);
	jcb1.addItemListener(this);
	jcb2.addItemListener(this);
	b1.addActionListener(this);
	b2.addActionListener(this);

	}
	public void actionPerformed(ActionEvent ae){
	String s1=ae.getActionCommand();
	if(s1.equals("B1")) showStatus("Button B1 Pressed");
	else showStatus("Button B2 Pressed");
	repaint();
	}
	public void itemStateChanged(ItemEvent ie){

	if(jcb1.isSelected() && jcb2.isSelected()) 
		showStatus("Both checkboxes are Selected");
	else if(!jcb1.isSelected() && jcb2.isSelected())
		showStatus("A checkbox is not Selected , B checkbox is Selected");
	else if(!jcb2.isSelected() && jcb1.isSelected()) 
		showStatus("A checkbox is Selected, B checkbox is not Selected");
	else
		showStatus("Both checkboxes are not Selected");
	}
	

}