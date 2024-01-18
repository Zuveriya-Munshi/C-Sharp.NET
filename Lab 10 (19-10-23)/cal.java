import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class cal extends JFrame implements ActionListener {
    JButton add;
    JButton sub;
    JButton mul;
    JButton div;
    JButton clr;

    JTextField t1;
    JTextField t2;
    JLabel l1;
    JLabel l2;
    JPanel p1;
    JPanel p2;
    // JLabel statusBar;s

    public cal(String title) {
        super(title);

        // Initialize panels
        p1 = new JPanel();
        p2 = new JPanel();

        add = new JButton("Add");
        sub = new JButton("Sub");
        mul = new JButton("Mul");
        div = new JButton("Div");
        clr = new JButton("Clear");
        t1 = new JTextField(10);
        l1 = new JLabel("Num1");
        t2 = new JTextField(10);
        l2 = new JLabel("Num2");

        setLayout(new GridLayout(2, 1));
        this.add(p1);
        this.add(p2);
        // this.add(statusBar);

        p1.add(t1);
        p1.add(l1);
        p1.add(t2);
        p1.add(l2);
        p2.add(add);
        p2.add(sub);
        p2.add(mul);
        p2.add(div);
        p2.add(clr);
        

        add.addActionListener(this);
        sub.addActionListener(this);
        mul.addActionListener(this);
        div.addActionListener(this);
        clr.addActionListener(this);
    }

    public cal() {
        this("Calculator Frame");
    }

    public void actionPerformed(ActionEvent ae) {
        String s = ae.getActionCommand();
        String num1 = t1.getText();
            String num2 = t2.getText();
            if (!num1.isEmpty() || !num2.isEmpty()) {
                int n1 = Integer.parseInt(num1);
            int n2 = Integer.parseInt(num2);
            int ans=0;
           
        if (s.equals("Add")) {
             ans = n1+n2;
             t1.setText(Integer.toString(ans));
             t2.setText("");
        } else if (s.equals("Sub")) {
               ans = n1-n2;
                t1.setText(Integer.toString(ans));
                t2.setText("");

        } else if(s.equals("Mul")){
            ans = n1*n2;
                t1.setText(Integer.toString(ans));
                t2.setText("");

        }
        else if(s.equals("Div")){
            ans = n1/n2;
                t1.setText(Integer.toString(ans));
                t2.setText("");

        }
         else if (s.equals("Clear")) {
            t1.setText("");
            t2.setText("");

        }
                // statusBar.setText("Error: Please enter valid numbers in both fields.");
            }
            
    }

    public static void main(String[] args) {
        cal c = new cal();
        c.setSize(500, 500);
        c.setVisible(true);
        c.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
}
