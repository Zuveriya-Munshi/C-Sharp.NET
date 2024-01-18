import java.applet.Applet;
import java.awt.Button;
import java.awt.GridLayout;
import java.awt.TextField;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class calculator extends Applet implements ActionListener {
    // Textfield to display the input and results
    private TextField t;

    // Array of buttons for digits, operators, equals, and clear
    private Button[] b;
    private Button[] op;
    private Button e;
    private Button cl;

    // Variable to store the current expression
    private StringBuilder expression;

    public void init() {
        // Set layout to GridLayout with 4 rows and 4 columns
        setLayout(new GridLayout(4, 4));

        // Initialize textfield
        t = new TextField();
        add(t);

        // Initialize expression
        expression = new StringBuilder();

        // Initialize digit buttons
        b = new Button[10];
        for (int i = 0; i < 10; i++) {
            b[i] = new Button(String.valueOf(i));
            b[i].addActionListener(this);
            add(b[i]);
        }

        // Initialize operator buttons
        op = new Button[]{
                new Button("+"),
                new Button("-"),
                new Button("*"),
                new Button("/")
        };

        for (Button operatorButton : op) {
            operatorButton.addActionListener(this);
            add(operatorButton);
        }

        // Initialize equals button
        e = new Button("=");
        e.addActionListener(this);
        add(e);

        // Initialize clear button
        cl = new Button("C");
        cl.addActionListener(this);
        add(cl);
    }

    public void actionPerformed(ActionEvent ae) {
        Button source = (Button) ae.getSource();
        String command = source.getLabel();

        // Handle digit buttons
        if (Character.isDigit(command.charAt(0))) {
            expression.append(command);
        }
        // Handle operator buttons
        else if ("+-*/".contains(command)) {
            expression.append(" ").append(command).append(" ");
        }
        // Handle equals button
        else if (command.equals("=")) {
            try {
                String result = evaluateExpression();
                t.setText(result);
                showStatus("Result: " + result);
            } catch (ArithmeticException ex) {
                t.setText("Error");
                showStatus("Error: " + ex.getMessage());
            }
        }
        // Handle clear button
        else if (command.equals("C")) {
            expression.setLength(0);
            t.setText("");
            showStatus("Cleared");
        }

        // Update textfield with the current expression
        t.setText(expression.toString());
    }

    private String evaluateExpression() {
        // Split the expression into operands and operator
        String[] tokens = expression.toString().split(" ");
        double operand1 = Double.parseDouble(tokens[0]);
        String operator = tokens[1];
        double operand2 = Double.parseDouble(tokens[2]);

        // Perform the calculation based on the operator
        double result;
        switch (operator) {
            case "+":
                result = operand1 + operand2;
                break;
            case "-":
                result = operand1 - operand2;
                break;
            case "*":
                result = operand1 * operand2;
                break;
            case "/":
                if (operand2 == 0) {
                    throw new ArithmeticException("Division by zero");
                }
                result = operand1 / operand2;
                break;
            default:
                throw new IllegalArgumentException("Invalid operator");
        }

        // Reset the expression for the next calculation
        expression.setLength(0);
        expression.append(result);

        return String.valueOf(result);
    }
}

/* <applet code="calculator.class" width=300 height=300></applet>*/

