package ham;

import java.awt.GridLayout;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.util.*;
import java.util.logging.Level;
import java.util.logging.Logger;
import static javatuan12.bai44.listStudent;
import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import javatuan12.student;

public class GUI {
    //khi nhấn Enter ở chế độ Console thì chuyển sang chế độ giao diện đồ họa
    //No tham số , Phái tự động đổi a thành hàm tạo của lớp chứa GUI thêm vào ngay dưới dòng gọi hàm 
    //Input no
    //Output GUI 
    public static void ECG() {
        System.out.println("Nhấn ENTER dể chuyển sang giao diện GUI .");
        Scanner b=new Scanner(System.in);
        //Chờ đợi mòn mỏi người dùng nhấn ENTER 
        b.nextLine();
        //a x=new a();       
    }
    
    //Hàm tạo giao diện cơ bản 
    //Tự thêm JButton, ... 
    //Input no
    //Output GUI 
    //Muốn có bảng thì phải liên kết với ham.GUI.table_st (thêm tham số JPanel cho tao_GUI , trong đó JPanel là kết quả trả về của table_st )
    public static void tao_GUI(){
        JFrame a=new JFrame();
        a.setExtendedState(JFrame.MAXIMIZED_BOTH);//Để jframe hiện lên full màn hình
        
        JPanel a1=new JPanel(new GridLayout(1, 1)); // Chia panel thành 2 hàng 1 cột 
        a1.setLocation(500, 500);

        JPanel b1=new JPanel();
        b1.setLocation(50, 50);
        JButton b11=new JButton("name_JButton");
        //nút khác
        b1.add(b11);        
        a1.add(b1);
        
        JPanel b2=new JPanel();
        b1.setLocation(50, 50);
        JTextField b21=new JTextField(30); // 30 là độ dài ký tự có thể nhìn thấy 
        //txt khác
        b2.add(b21);
        a1.add(b2);  
                
        JScrollPane a3=new JScrollPane(a1);
        a.add(a3);
        a.setVisible(true);
    }
    
    //Hàm tạo bảng chèn list vào một JPanel - Dùng list<student> của javatuan12.bai44 
    //Output JPanel chứa bảng 
    public static JPanel table_st(){
        List<student> a =listStudent();
        JPanel x=new JPanel();
        // Tạo bảng và mô hình dữ liệu mặc định
        DefaultTableModel model = new DefaultTableModel();
        JTable table = new JTable(model);  
        // Thêm các cột vào bảng
        model.addColumn("id");
        model.addColumn("name");
        model.addColumn("age");
        model.addColumn("sex");
        model.addColumn("point");
        // Thêm dữ liệu sinh viên vào bảng
        for (student s : a) {
            model.addRow(new Object[]{s.id, s.name, s.age, s.sex, s.point});
        }        

        // Thêm bảng vào JScrollPane để có thanh cuộn nếu cần
        JScrollPane scrollPane = new JScrollPane(table);
        x.add(scrollPane);

        return x;
    }
    
    //Dùng JDBC kết nối database 
    Connection conn=null;
    public static Connection abc(){
        //Thực thi code 
        try{
            //Đăng ký trình điều khiển JDBC 
            Class.forName("org.sqlite.JDBC");
            //Sử dụng JDBC tạo đường kết nối đến CSDL 
            Connection conn=DriverManager.getConnection("jdbc:sqlite:Name_database.db");
            JOptionPane.showMessageDialog(null,"kết nối đã được thiết lập");
            return conn;
        //Xử lý ngoại lệ    
        }catch(Exception e){ 
            JOptionPane.showMessageDialog(null, e);
            return null;
        }
    } 
        
    //Dùng flatlaf cho giao diện sang xịn mịn hơn 
    public static void use_flatlaf(){
        try {
            UIManager.setLookAndFeel(new com.formdev.flatlaf.FlatLightLaf());
        } catch (UnsupportedLookAndFeelException ex) {
            ex.printStackTrace();
        }          
    }
    
}
