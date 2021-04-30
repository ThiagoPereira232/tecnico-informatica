/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bd;
import java.sql.*;

/**
 *
 * @author Thiago
 */
public class Bd {

    private static Connection con = null;
    private static final String driver = "com.mysql.jdbc.Driver";
    private static final String url = "jdbc:mysql://localhost/aluno";
    private static final String usuario = "root";
    private static final String senha = "";

    public static Connection getCon() {
        try {
            if (con == null || con.isClosed()) {
                Class.forName(driver);
                con = DriverManager.getConnection(url, usuario, senha);
            }
        } catch (Exception e) {
            System.out.println(" erro na conexao\n" + e.getMessage());
        }
        return con;
    }

    public static void setCon(Connection cone) {
        con = cone;
    }
}
