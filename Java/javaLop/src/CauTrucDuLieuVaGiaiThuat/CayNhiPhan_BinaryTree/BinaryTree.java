package CauTrucDuLieuVaGiaiThuat.CayNhiPhan_BinaryTree;

import static BaiTap.Palindrome.checkPalindrome;

class node{
    int data;
    node left, right;
    node(int d){
        data = d;
    }
}

public class BinaryTree {
    public static void main(String[] args) {
        // Tạo cây nhị phân https://images.search.yahoo.com/search/images;_ylt=Awr93fyKmcNmzHgS2jJXNyoA;_ylu=Y29sbwNncTEEcG9zAzEEdnRpZAMEc2VjA3BpdnM-?p=cay+nhi+phan&fr2=piv-web&type=E210US91215G91642&fr=mcafee#id=0&iurl=https%3A%2F%2Fresources.stdio.vn%2Fcontent%2Farticle%2F5ef62d665ef9e26f89a5c766%2Fresources%2Fres-1596355616-1596355616941.png&action=click
        BinaryTree bt = new BinaryTree();
        bt.root = new node(8);
        bt.root.left = new node(2);
        bt.root.right = new node(9);
        bt.root.left.left = new node(1);
        bt.root.left.right = new node(9);
        bt.root.right.left = new node(9);
        bt.root.right.right = new node(6);
        
//        System.out.println("Cay day du Full binary tree <1 node co 0/2 con> " + checkFullBinaryTree(bt.root));
//        System.out.println("Cay hoan hao Perpect binary true<1 node co 0/2 con && them node thi tang level cay> " + checkPerfectBinaryTree(bt.root));
//        System.out.println("Cay hoan chinh Complete binary tree <1 node co 0/2 con && hoan chinh thien ve ben trai > " + checkComBinaryTree(bt.root));

        // Test 1: Tạo cây đầy đủ, hoàn hảo, hoàn chỉnh 
        node root1 = new node(1);
        root1.left = new node(2);
        root1.right = new node(3);
        root1.left.left = new node(4);
        root1.left.right = new node(5);
        root1.right.left = new node(6);
        root1.right.right = new node(7);     
//        System.out.println("Cay day du Full binary tree <1 node co 0/2 con> " + checkFullBinaryTree(root1));
//        System.out.println("Cay hoan hao Perpect binary true<1 node co 0/2 con && them node thi tang level cay> " + checkPerfectBinaryTree(root1));
//        System.out.println("Cay hoan chinh Complete binary tree <1 node co 0/2 con && hoan chinh thien ve ben trai > " + checkComBinaryTree(root1));
//        
        // Test 2 : no full, no perpect, no complete 
        node root2 = new node(1);
        root2.left = new node(2);
        root2.right = new node(3);
        root2.left.left = new node(4);
        root2.left.right = new node(5);
        root2.right.left = new node(6);        
//        System.out.println("Cay day du Full binary tree <1 node co 0/2 con> " + checkFullBinaryTree(root2));
//        System.out.println("Cay hoan hao Perpect binary true<1 node co 0/2 con && them node thi tang level cay> " + checkPerfectBinaryTree(root2));
//        System.out.println("Cay hoan chinh Complete binary tree <1 node co 0/2 con && hoan chinh thien ve ben trai > " + checkComBinaryTree(root2));
//        
        // Test 3 : full, no perpect, complete 
        node root3 = new node(1);
        root3.left = new node(2);
        root3.right = new node(3);
        root3.left.left = new node(4);
        root3.left.right = new node(5);        
//        System.out.println("Cay day du Full binary tree <1 node co 0/2 con> " + checkFullBinaryTree(root3));
//        System.out.println("Cay hoan hao Perpect binary true<1 node co 0/2 con && them node thi tang level cay> " + checkPerfectBinaryTree(root3));
//        System.out.println("Cay hoan chinh Complete binary tree <1 node co 0/2 con && hoan chinh thien ve ben trai > " + checkComBinaryTree(root3));       

        // Test 1: Tạo một cây nhị phân tìm kiếm
        node root11 = new node(10);
        root11.left = new node(5);
        root11.right = new node(15);
        root11.left.left = new node(3);
        root11.left.right = new node(7);
        root11.right.left = new node(12);
        root11.right.right = new node(18);        
//        System.out.println("Cay nhi phan tim kiem " + checkBST(root11, null, null));
        
        // Test 2: Tạo một cây là cây nhị phân tìm kiếm
        node root22 = new node(10);
        root22.left = new node(5);
        root22.right = new node(15);
        root22.left.left = new node(3);
        root22.left.right = new node(7);
        root22.right.left = new node(14);
        System.out.println("ban dau");
        showIn(root22);
        System.out.println("");
//        System.out.println("Cay nhi phan tim kiem " + checkBST(root22, null, null));
        add(6);
        System.out.println("sau khi xoa 6");
        showIn(root22);
    }
    static node root;
    // Ham hien thi cay theo chieu sau InOrder 
    static void showIn(node p){
        if(p == null){
            return;
        }else{
            showIn(p.left);
            visit(p);
            showIn(p.right);
        }        
    }   
    // In ra gia tri cua node p 
    static void visit(node p){
        if(p == null){
            return;
        }else{
            System.out.print("    " + p.data);
        }
    }
    // Cây nhị phân đầy đủ Full binary tree 
    // 1 node có 0/2 con 
    // 2TH : left && right == null HOẶC left || right == null 
    // return ham(p.left && p.right)
    static boolean checkFullBinaryTree(node p){
        if(p.left == null && p.right == null){
            return true;
        }
        if(p.left == null || p.right == null){
            return false;
        }    
        return checkFullBinaryTree(p.left) && checkFullBinaryTree(p.right);
    }
    // Cây nhị phân hoàn hảo Perfect binary tree
    // 1 node có 0/2 con && nếu thêm node thì tăng level cây 
    // 2TH: left && right == null HOAC left || right == null 
    // highleft , highright -> Khac nhau return false 
    // return ham(p.left)&&ham(p.right)
    static boolean checkPerfectBinaryTree(node p){
        if(p.left == null && p.right == null){
            return true;
        }
        if(p.left == null || p.right == null){
            return false;
        }         
        int high_left = high(p.left);
        int high_right = high(p.right);
        if(high_left != high_right){
            return false;
        }
        return checkPerfectBinaryTree(p.left) && checkPerfectBinaryTree(p.right);
    }    
    // Ham tinh chieu cao
    static int high(node p){
        if (p == null) {
            return -1; 
        }
        int high_left = high(p.left);
        int high_right = high(p.right);
        return Math.max(high_left, high_right) + 1;
    }    
    // Cây nhị phân hoàn chỉnh Complete binary tree 
    // 1 node có 0/2 con && hoàn chỉnh thiên về bên trái 
    // 2TH: left && right == null HOAC left || right == null
    // highleft, highright -> < return false 
    // return ham(p.left) && ham(p.right)
    static boolean checkComBinaryTree(node p){
        if(p.left == null && p.right == null){
            return true;
        }
        if(p.left == null || p.right == null){
            return false;
        }         
        int high_left = high(p.left);
        int high_right = high(p.right);
        if(high_left < high_right){
            return false;
        }
        return checkComBinaryTree(p.left) && checkComBinaryTree(p.right);
    }    
    // Cây nhị phân tìm kiếm search binary tree 
    static boolean checkBST(node p, Integer min, Integer max) {
        if (p == null) {
            return true; 
        }
        if (min != null && p.data <= min) {
            return false;
        }
        if (max != null && p.data >= max) {
            return false;
        }
        return checkBST(p.left, min, p.data) &&  checkBST(p.right, p.data, max);
    }
    // Cây nhị phân cân bằng 
    static boolean checkBalanced(node p) {
        if (p == null) {
            return true; 
        }
        int high_left = high(p.left);
        int high_right = high(p.right);
        if (Math.abs(high_left - high_right) <= 1 && checkBalanced(p.left) && checkBalanced(p.right)) {
            return true;
        }
        return false;
    }    
    // Cây AVL 
    static boolean checkAVL(node p){
        return checkBST(p, null, null) && checkBalanced(p);
    }
      // Hàm đếm số node có giá trị dương
    static int count(node p) {
        if (p == null) {
            return 0; // Nếu node hiện tại là null, trả về 0
        }
        // Đếm node hiện tại nếu giá trị của nó dương
        int currentCount = (p.data > 0) ? 1 : 0;
        // Đệ quy để đếm các node trong cây con trái và cây con phải
        return currentCount + count(p.left) + count(p.right);
    }
     // Hàm đếm số node có giá trị là số Palindrome 
    static int countPalindrome(node p){
        if(p == null){
            return 0;
        }
        boolean check = checkPalindrome(p.data); // import static BaiTap.Palindrome.checkPalindrome;
        int count = (check) ? 1 : 0 ; 
        return count + countPalindrome(p.left) + countPalindrome(p.right);
    }
    // Xóa 1 node x trong cây nhị phân tìm kiếm
    // Hàm tìm giá trị nhỏ nhất trong cây con bên phải
    static node findMin(node p) {
        while (p.left != null) {
            p = p.left;
        }
        return p;
    }
    // Hàm xóa một node có giá trị x
    static node deleteNode(node root, int x) {
        if (root == null) {
            return root;
        }
        // Duyệt cây để tìm node cần xóa
        if (x < root.data) {
            root.left = deleteNode(root.left, x);
        } else if (x > root.data) {
            root.right = deleteNode(root.right, x);
        } else {
            // Node cần xóa được tìm thấy
            // Trường hợp node chỉ có một con hoặc không có con
            if (root.left == null) {
                return root.right;
            } else if (root.right == null) {
                return root.left;
            }
            // Trường hợp node có hai con
            node temp = findMin(root.right); // Tìm giá trị nhỏ nhất ở cây con bên phải
            root.data = temp.data; // Thay thế giá trị của node cần xóa bằng giá trị của node nhỏ nhất
            root.right = deleteNode(root.right, temp.data); // Xóa node nhỏ nhất vừa thay thế
        }  
        return root;
    }
    
    // Hàm thêm một node có giá trị x vào cây nhị phân tìm kiếm
    static void add(int x) {
        root = addRec(root, x);
    }
    // Hàm đệ quy để thêm node vào cây
    static node addRec(node root, int x) {
        // Nếu cây rỗng, tạo một node mới và trả về node đó
        if (root == null) {
            root = new node(x);
            return root;
        }
        // Nếu giá trị x nhỏ hơn giá trị của node hiện tại, thêm vào cây con bên trái
        if (x < root.data) {
            root.left = addRec(root.left, x);
        }
        // Nếu giá trị x lớn hơn giá trị của node hiện tại, thêm vào cây con bên phải
        else if (x > root.data) {
            root.right = addRec(root.right, x);
        }
        // Trả về node hiện tại (không có thay đổi gì)
        return root;
    }
}
