package exp;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class trang {
    public static void main(String[] args) {
        // URL kết nối đến SQL Server
        String connectionUrl = "jdbc:sqlserver://172.17.155.100:1433;databaseName=QLMUONSACH;user=trang;password=123;encrypt=true;trustServerCertificate=true";

        Connection connection = null;

        try {
            // Đăng ký driver SQL Server (nếu cần)
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");

            // Tạo kết nối
            connection = DriverManager.getConnection(connectionUrl);

            // Kiểm tra nếu kết nối thành công
            if (connection != null) {
                System.out.println("Connected to the database!");
            }
        } catch (SQLException e) {
            e.printStackTrace();
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        } finally {
            // Đóng kết nối
            if (connection != null) {
                try {
                    connection.close();
                } catch (SQLException ex) {
                    ex.printStackTrace();
                }
            }
        }
    }
}