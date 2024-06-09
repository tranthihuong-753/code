/*
Lập hai lớp: Shape và Circle.

Lớp Shape:
có một thuộc tính là color được khai báo với phạm vi truy cập protected, cho phép lớp con truy cập vào thuộc tính này. 
Lớp cũng có một hàm tạo (constructor) nhận vào tham số color để khởi tạo thuộc tính.
Ngoài ra, lớp còn có phương thức displayColor() để hiển thị thông tin về màu sắc lên màn hình.

Lớp Circle:
là một lớp con của lớp Shape, kế thừa thuộc tính và phương thức từ lớp cha.

Bổ sung thuộc tính và phương thức:

Lớp Circle có thêm một thuộc tính là radius (bán kính) và một hàm tạo khác nhận thêm tham số color và radius. 
Hàm tạo này gọi hàm tạo của lớp cha để khởi tạo thuộc tính color.

Lớp Circle cũng có một phương thức riêng là displayCircleInfo() để hiển thị thông tin về hình tròn gồm màu sắc và bán kính.

Trong phần chạy chương trình (hàm main), khai báo và cấp phát một đối tượng Circle mới với màu sắc là "Red" và bán kính là 5.0.
Sau đó, gọi phương thức displayCircleInfo() để hiển thị thông tin về hình tròn lên màn hình.
 */
package javatuanTET;

class Shape{
    protected String color;
    public String setC(){
        return color;
    }
    public void getC(String a){
        this.color=a;
    }
    
    public void displayColor(){
        System.out.println("Color : "+ color);
    } 
    
}

class Circle extends Shape{
    private double radius;

    public void ABC(String a, double b){
        color=a;
        radius=b;
    }
    
    public void displayCircleInfo(){
        System.out.println("Color: "+color);
        System.out.println("Radius: "+radius);
    }
}

public class bai_7 {
    public static void main(String[] args){
        Circle a=new Circle();
        a.ABC("RED", 5.0);
        a.displayCircleInfo();
    }
}
