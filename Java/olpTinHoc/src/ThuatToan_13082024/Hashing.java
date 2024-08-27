/*
- Hàm băm 
- Dùng để mã hóa dữ liệu 
    - Kiểm tra sự toàn vẹn của tệp tin trước và sau khi tải lên mạng 
    - Xác minh mật khẩu
 */
package ThuatToan_13082024;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Hashing {
    public static void main(String[] args) {
        run_SDT();
    }
    // Tìm số điện thoại khi nhập vào tên 
    // Hàm băm . Input : chuỗi 
    static int hashFunction(String key, int bucketCount) {
        int hash = 0;
        for (char c : key.toCharArray()) {
            hash = (hash * 23 + c) % bucketCount;
        }
        return hash;
    }
    static String getPhoneNumber(String name, Map<Integer, List<String>> hashTable, int bucketCount) {
        int hash = hashFunction(name, bucketCount);
        List<String> bucket = hashTable.get(hash);
        if (bucket != null && !bucket.isEmpty()) {
            // Giả sử có một số điện thoại cho mỗi bucket
            return bucket.get(0);
        }
        return null;
    }
    static void run_SDT(){
        int bucketCount = 15; // Số lượng bucket phải đủ lớn
        Map<Integer, List<String>> hashTable = new HashMap<>();
        // Dữ liệu cần lưu
        Map<String, String> people = new HashMap<>();
        people.put("John Smith", "521-1234");
        people.put("Lisa Smith", "521-8976");
        people.put("Sandra Dee", "521-9655");
        // Lưu dữ liệu vào các bucket
        for (Map.Entry<String, String> entry : people.entrySet()){
            String name = entry.getKey();
            String phoneNumber = entry.getValue();
            int hash = hashFunction(name, bucketCount);
            // Tạo bucket nếu chưa tồn tại
            hashTable.putIfAbsent(hash, new ArrayList<>());
            // Thêm số điện thoại vào bucket tương ứng
            hashTable.get(hash).add(phoneNumber);
        }
        // Ví dụ tìm kiếm số điện thoại
        String phoneNumber = getPhoneNumber("John Smith", hashTable, bucketCount);
        System.out.println(phoneNumber); // In ra số điện thoại của John Smith        
    }
}
