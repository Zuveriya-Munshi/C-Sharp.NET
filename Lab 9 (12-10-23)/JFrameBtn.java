import java.awt.*;
import javax.swing.*;
import java.awt.event.*;
import java.applet.*;
class my_JFrame extends JFrame implements ActionListener{
 	JButton b1;
	JButton b2;
	String s="";
	my_JFrame(String title){
	super(title);
	b1 = new JButton("B1");
	b2 = new JButton("B2");
	setLayout(new FlowLayout());
	add(b1);
	add(b2);
	setLayout(new FlowLayout());
	b1.addActionListener(this);
	b2.addActionListener(this);
	}
	public void actionPerformed(ActionEvent ae){
	String s1=ae.getActionCommand();
	s=" Button " +s1+ " is Pressed";
	repaint();
	}
	public void paint(Graphics g){
	super.paint(g);
	g.drawString(s,200,200);
	}
}
class JFrameBtn{
	public static void main(String args[]){
	my_JFrame f = new my_JFrame("Sample Frame");
	f.setSize(500,400);
	f.setVisible(true);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}
}
