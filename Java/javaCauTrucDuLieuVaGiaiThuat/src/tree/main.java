package tree;

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

public class main {
    public static void main(String[] args) {
        myTree tree = new myTree();
        tree.root = new node(1);
        tree.root.left = new node(2);
        tree.root.right = new node(3);
        tree.root.left.left = new node(4);
        tree.root.left.right = new node(5);
        tree.root.right.left = new node(6);
        tree.root.right.right = new node(7);
        tree.root.left.right.left = new node(8);
//        tree.root.right.left.left = new node(9);
//        tree.root.right.left.right = new node(10);
//        tree.root.right.right.right = new node(11);
        // cay day du full BT 
//        tree.checkFullBT(tree.root);
//        System.out.println("Full BT " + tree.checkFullBT);
        // Chieu cao cay nhi phan 
//        int x = tree.hightBinaryTree(tree.root);
//        System.out.println("Chieu cao cay la " + x);
//        tree.showInOrder(tree.root);
//        System.out.println("");

        tree.showBreadth(tree.root);
        tree.isAllLessThan(tree.root, 8);
        System.out.println("");
        // check gia tri cua full cay 
//        System.out.println(tree.checkisAllLessThan);
        
        // loi 
//        System.out.println("");
//        System.out.println("check ban dau " + tree.checkisPerfect);
//        tree.checkisPerfect(tree.root);
//        System.out.println("check sau " + tree.checkisPerfect);

//        tree.isBinarySearchTree(tree.root);
//        System.out.println("");
//        System.out.println(tree.check);
    }
}
