package tree;

public class myAVLtree {
    node p;
    //Viết hàm kiểm tra 1 cây có phải cây AVL hay không = phai la cay tim kiem va chieu cao khong qua 1 
    boolean isAVL(node p){
//        boolean check = true;
        if(p == null){
            return true;
        }
        if((help_isAVL_high(p.left) - help_isAVL_high(p.right)) > 1){
            return false;
        }
        return isAVL(p.left) && isAVL(p.right);
    }
    // Tìm chiều cao 
    int help_isAVL_high(node p){
        if(p == null){
            return -1;
        }
        return 1 + Math.max(help_isAVL_high(p.left), help_isAVL_high(p.right));
    }
}
