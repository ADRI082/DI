package iespablopicasso.es;

import java.sql.DriverManager;
import java.sql.SQLException;

import com.mysql.jdbc.Statement;

import java.sql.Connection;


public class ConexionDB {
	
	 private static final String CONTROLADOR = "com.mysql.jdbc.Driver";
	    private static final String URL = "jdbc:mysql://localhost:3306/usuarios";
	    private static final String USUARIO = "root";
	    private static final String CLAVE = "yesica213";
	    
	    private Connection conexion;
	    
	    public ConexionDB() {
	    	conexion = null;
	    }

	    public Connection conectar() {
	        
	        
	        try {
	            Class.forName(CONTROLADOR);
	            conexion =  DriverManager.getConnection(URL, USUARIO, CLAVE);
	            System.out.println("Exito");
	        } catch (ClassNotFoundException e) {
	            System.out.println("Error al cargar el controlador");
	            e.printStackTrace();

	        } catch (SQLException e) {
	            System.out.println("Error en la conexión");
	            e.printStackTrace();
	        }
	        
	        return conexion;
	       
	    }
	
	    
	    public boolean comprobarUsuario(String usuario,String password) throws SQLException {
	    	
	    	var s = conexion.createStatement();
	    	var rs = s.executeQuery ("select usuario,password from usuarios Where usuario = '" + usuario + "' AND " + " password = '" + password + "'");
	    	
	    	
	    	
	    	return rs.next();
	    	
	    	
	    }
	
	
	

}
