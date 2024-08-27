package day10082024;

public class SinhDayNhiPhan {
    public static void main(String[] args) {
        System.out.println(DtoB(1));
    }
    static void sinhdaybinary(int n){
        String[] arr = new String[2^n];
        for(int i = 0 ; i < arr.length ; i++){
            
        }
    }
    // Ham tim mot so dang binary 
    // Input : so nguyen he muoi 
    // Output : Dang binary 
    static String DtoB(int x){
        boolean check = true;
        int n = 0 ;
        String out = ""; // dau ra 
        int outint = 0; // tinh tong cua 2^k 
        while(check){
            System.out.println("outint = "+outint);
            if((outint += (Math.pow(2, n))) <= x ){
                out += "1";
                outint+= Math.pow(2, n);
            }
            if(outint == x){
                check = false;
            }
            if( (outint += Math.pow(2, n)) > x ){
                out += "0";
            }
            outint++;
        }
        return out;
    }
}
