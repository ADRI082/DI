package iespablopicasso.es;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JPasswordField;
import javax.swing.JTextField;

public class ventana extends JFrame implements ActionListener {

	static final String USUARIO = "usuario";
	static final String PASSWORD = "password";

	static JLabel userLabel;
	static JTextField userText;
	static JLabel passwordLabel;
	static JTextField passwrodText;

	static ConexionDB miControladorDB;

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		miControladorDB = new ConexionDB();
		miControladorDB.conectar();

		JFrame frame = new JFrame("Demo application");
		frame.setSize(300, 150);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		JPanel panel = new JPanel();
		frame.add(panel);

		panel.setLayout(null);

		JLabel userLabel = new JLabel("User");
		userLabel.setBounds(10, 10, 80, 25);
		panel.add(userLabel);

		JTextField userText = new JTextField(20);
		userText.setBounds(100, 10, 160, 25);
		panel.add(userText);

		JLabel passwordLabel = new JLabel("Password");
		passwordLabel.setBounds(10, 40, 80, 25);
		panel.add(passwordLabel);

		JPasswordField passwordText = new JPasswordField(20);
		passwordText.setBounds(100, 40, 160, 25);
		panel.add(passwordText);

		JButton loginButton = new JButton("login");
		loginButton.setBounds(10, 80, 80, 25);
		panel.add(loginButton);

		loginButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				String password = String.valueOf(passwordText.getPassword());
				try {
					if (miControladorDB.comprobarUsuario(userText.getText(),password)) {

						System.out.println("Conectado Correctamente");
					} else {
						System.out.println("Usuario y/o contraseña incorrecta");
					}
				} catch (Exception ea) {
					ea.printStackTrace();
				}

			}

		});

		frame.setVisible(true);

	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub

	}

}
