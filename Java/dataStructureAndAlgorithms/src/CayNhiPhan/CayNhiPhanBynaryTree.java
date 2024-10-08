package CayNhiPhan;

import java.util.LinkedList;
import java.util.Queue;

class node{
    int value;
    node left, right;
    node(){
        value = 0;
    }
    node(int x){
        value = x; 
    }
}

public class CayNhiPhanBynaryTree {
    node root;
    // Ham xac dinh node co ton tai hay khong
    boolean isEmpty(){
        return (root == null);
    }    
    // In ra gia tri cua node p 
    void visit(node p){
        if(p == null){
            return;
        }else{
            System.out.print("    " + p.value);
        }
    }
    // Ham xoa cay 
    void clear(node p){
        p = null;
    }
    // Ham tim kien mot node co gia tri x 
    node search(int x){
        node ans = null;
        if(root == null){
            return null;
        }
        if(root.value == x){
            return root;
        } else {
            CayNhiPhanBynaryTree leftTree = new CayNhiPhanBynaryTree();
            leftTree.root = root.left;
            node leftAns = leftTree.search(x);
            if(leftAns != null ) return leftAns;
            else {
                CayNhiPhanBynaryTree rightTree = new CayNhiPhanBynaryTree();
                rightTree.root = root.right;
                node rightAns = rightTree.search(x);
                if(rightAns != null ) return rightAns;
            }
        }
        return ans;
    }
    // Duyet cay nhi phan theo tiền thứ tự 
    void showPreOrder(node p){
        if(p == null){
            return ; 
        }else{
            visit(p);
            showPreOrder(p.left);
            showPreOrder(p.right);
        }
    }    
    // Duyet cay nhi phan theo trung thứ tự 
    void showInOrder(node p){
        if(p == null){
            return;
        }else{
            showInOrder(p.left);
            visit(p);
            showInOrder(p.right);
        }        
    }        
    // Duyet cay nhi phan theo hậu thứ tự 
    void showPostOrder(node p){
        if(p == null){
            return;
        }else{
            showPostOrder(p.left);
            showPostOrder(p.right);
            visit(p);
        }
    }  
    //Ham hien thi một cây theo bề rộng Breadth-first. 
    void showBreadth(node p){
        if (root == null) {
            return;
        }
        Queue<node> queue = new LinkedList<>();
        queue.add(root);
        //!queue.isEmpty()
        boolean check = false;
        while(check == false) {
//            System.out.println(check);
            node current = queue.poll(); // Lay gia tri va xoa phan tu dau cua quere 
            if(current == null){
                check = false;
            }else{
                visit(current);
                if (current.left != null) {
                    queue.add(current.left);
                }
                if (current.right != null) {
                    queue.add(current.right);
                }                  
            }
        }
    }    
    //Kiểm tra nếu khóa x không tồn tại trong cây thì chèn nút mới có giá trị x vào cây.
    void insert(int x){
        node node = search(x);
        if(node == null){
            //Chen vao vi tri duoi cung, ben trai 
            node = root;
            // Tim vi tri gan cuoi cua (vi tri duoi cung, ben trai )
            while(node.left != null){
                node = node.left;
            }
            // Tao lien ket moi luu duoc ngoai ham :((( 
            node.left = new node(x);
        }else{
            System.out.println("Da ton tai "+node+" co gia tri "+x);
        }
    }
    //Ham Đếm và trả về số lượng nút trong cây.
    int count(node p) {
        // Neu node dau la null thi cay rong                                                                                                                                                
        if (p == null) {
            return 0;
        }
        // Khi node la leaf thi return 1 
        int n = 1 + count(p.left) + count(p.right);
        return n;
    }    
    // Ham kiem tra cay co phai la full binary tree
    boolean checkFullBT = true;
    void checkFullBT(node p){
        if(p.left == null){
            return;
        }
        if(p.left == null || p.right == null){
            checkFullBT = false;
        }
        if(checkFullBT != false){
            checkFullBT(p.left);
            checkFullBT(p.right);
        }
    }
    // boolean isComplete 
    boolean checkisComplete = true;
    Queue<node> qu = new LinkedList<>();
    void checkisComplete(node p){
        // Duyet theo queue 
        // Lay ra phan tu dau , them left va right cua phan tu dau vao 
        // Neu gap null thi kiem tra not cac phan tu con lai co left va right khong . Co thi checkisComplete = false 
        
    }    
    // boolean isPerfect
    boolean checkisPerfect = true;
    void checkisPerfect(node p){
        if(p == null){
            return;
        }
        Queue<node> qu = new LinkedList<>();
        qu.add(p);
        
    }
    // Hàm kiểm tra xem tất cả các nút của 1 cây có giá trị bé hơn giá trị m
    boolean checkisAllLessThan = true;
    void isAllLessThan(node p, int m){
        if(p == null){
            return;
        }
        if(p.value >= m){
            checkisAllLessThan = false;
        }
        if(checkisAllLessThan != false){
            isAllLessThan(p.left, m);
            isAllLessThan(p.right, m);
        }
    }    
    public static void main(String[] args) {
        
    }
        // Ham kiem tra mot cay nhi phan co phai la cay nhi phan tim kiem hay khong 
    boolean check = true;
    void isBinarySearchTree(node p){
        if(p.left == null && p.right == null){
            return;
        }
        if(p.left == null){
            if(!(p.value < p.right.value)){
                check = false;
                return;
            }
        }else if (p.right == null){
            if(!(p.left.value < p.value)){
                check = false;
                return;
            }
        }else{
            if(!(p.value < p.right.value && p.left.value < p.value)){
                check = false;
                return;
            }
        }
//        System.out.println(check);
        if(check != false){
//            System.out.println(check);
            isBinarySearchTree(p.left);
            isBinarySearchTree(p.right);            
        }
    }
}
