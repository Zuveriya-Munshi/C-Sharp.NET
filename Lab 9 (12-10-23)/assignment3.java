/*
<html>
<body>
<applet code = "assignment3.class" width="300" height="300"></applet>
</body>
<html>
*/
import java.applet.*;
import java.awt.*;
import java.awt.event.*;

public class assignment3 extends Applet implements ActionListener{
    Button b[];
    String s1="";
    String s2="";
    String op="";
    int flag=0;
    int n1,n2;
    public void init(){
        setLayout(new GridLayout(4,4));
        b=new Button[16];
        for(int i=0;i<16;i++){
           if(i==3) b[i]=new Button("+");
           else if(i==7) b[i]=new Button("-");
           else if(i==11) b[i]=new Button("*");
           else if(i==15) b[i]=new Button("=");
           else if(i==13) b[i]=new Button("0");
           else if(i<3)  b[i]=new Button(Integer.toString(i+1));
           else if(i<7)  b[i]=new Button(Integer.toString(i));
           else if(i<11) b[i]=new Button(Integer.toString(i-1));
           else b[i]=new Button(" ");
          this.add(b[i]);
          b[i].addActionListener(this);
        }
    }
    public void actionPerformed(ActionEvent a){
        String ip=a.getActionCommand();
        showStatus(ip);
        if(ip.equals("=")){
             n1=Integer.parseInt(s1);
             n2=Integer.parseInt(s2);
             switch(op){
                 case "+":
                     showStatus(Integer.toString(n1+n2));
                     break;
                 case "-":
                     showStatus(Integer.toString(n1-n2));
                     break;
                 case "*":
                     showStatus(Integer.toString(n1*n2));
                     break;
             }
             s1=op=s2="";
             flag=0;
        }
        else if(ip.equals("*") || ip.equals("+") || ip.equals("-")){
            op=ip;
            flag=1;
        }else if(flag==0){
            s1+=ip;
            showStatus(s1);
        }else{
            s2+=ip;
        }
    }
}
