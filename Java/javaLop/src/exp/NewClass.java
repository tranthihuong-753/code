package exp;

import java.util.Scanner;
import java.lang.Math;

public class NewClass {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.print("Bat dau : ");
        int a = scan.nextInt();
        scan.nextLine();
        System.out.print("Ket thuc: ");
        int b = scan.nextInt();
        scan.nextLine();
        int dap = 0;
        for(int i = a; i <= b ; i++){
            dap += Math.pow(2, i);
//            System.out.println("i = "+i);
//            System.out.println("dap2 = "+dap);
        }
        System.out.println("KQ = "+dap);
    }
}
