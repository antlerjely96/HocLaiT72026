namespace HocLaiT72026;

public class Condition
{
    public void demo()
    {
        /* Cấu trúc điều khiển rẽ nhánh (Condition): Thực thi 1 khối lệnh khi 1 điều kiện nào đó được thỏa mãn
           Ví dụ: Nếu được từ 5 điểm trở lên thì qua môn, còn không thì học lại
           
           - if (basic): thực hiện 1 khối lệnh khi điều kiện trả về true
            if(điều kiện){
                Khối lệnh;
            }
            
            - if - else: thực hiện 1 khối lệnh khi điều kiện trả về true, thực hiện 1 khối lệnh khác khi điều kiện trả về false
            if(điều kiện){
                Khối lệnh được thực hiện khi điều kiện trả về true;
            } else {
                Khối lệnh được thực hiện khi điều kiện trả về false;
            }
            
            - if - else if - else: thực hiện các khối lệnh tương ứng với từng điều kiện trả về true
            if(điều kiện 1){
                Khối lệnh được thực hiện khi điều kiện 1 trả về true;
            } else if(điều kiện 2){
                Khối lệnh được thực hiện khi điều kiện 1 false, điều kiện 2 true;
            } else if(điều kiện 3){
                Khối lệnh được thực hiện khi điều kiện 1, 2 false, điều kiện 3 true;
            } ... 
            else {
                Khối lệnh được thực hiện khi tất cả các điều kiện trả về false;
            }
            
            - if lồng nhau: Khi 1 điều kiện trả về true, kiểm tra 1 điều kiện khác
            if(điều kiện 1){
                if(điều kiện 2){
                    Khối lệnh được thực hiện khi điều kiện 1, 2 true;
                } else if(điều kiện 3){
                    Khối lệnh được thực hiện khi điều kiện 1, 3 true, điều kiện 2 false;
                } else {
                    Khối lệnh được thực hiện khi điều kiện 1 true, điều kiện 2, 3 false;
                }
            } else if(điều kiện 4){
                if(điều kiện 5){
                    Khối lệnh được thực hiện khi điều kiện 1 false, điều kiện 4, 5 true;
                } else if(điều kiện 6){
                    Khối lệnh được thực hiện khi điều kiện 1, 5 false, điều kiện 4, 6 true;
                } else {
                    Khối lệnh được thực hiện khi điều kiện 4 true, điều kiện 1, 5, 6 false;
                }
            } else {
                if(điều kiện 7){
                    if(điều kiện 9){
                        Khối lệnh được thực hiện khi điều kiện 7, 9 true, điều kiện 1, 4 false;
                    }
                } else if(điều kiện 8){
                    Khối lệnh được thực hiện khi điều kiện 8 true, điều kiện 1, 4, 7 false;
                } else {
                    Khối lệnh được thực hiện khi điều kiện 1, 4, 7, 8 false;
                }
            }
        */

        /* 1. Nhap 1 so nguyen a tu ban phim. Kiem tra a là so am hay duong */
        //Khai bao a
        int a;
        //Nhap a
        Console.Write("a = ");
        a = int.Parse(Console.ReadLine());
        //Kiem tra a
        if (a > 0)
        {
            Console.WriteLine(a + " la so duong");
        } else if (a < 0)
        {
            Console.WriteLine(a + " la so am");
        }
        else
        {
            Console.WriteLine("a = 0");
        }
        
        /* 2. Nhap 1 so nguyen b tu ban phim. Kiem tra b la so chan hay le */
        //Khai bao b
        int b;
        //Nhap b
        Console.Write("b = ");
        b = int.Parse(Console.ReadLine());
        //Kiem tra b
        if (b % 2 == 0)
        {
            Console.WriteLine(b + " la so chan");
        }
        else
        {
            Console.WriteLine(b + " la so le");
        }
        
        /*
            3. Nhap diem tu ban phim (diem la so thuc)
            Kiem tra:
                Neu diem nho hon 0 hoac diem lon hon 10 thi hien thi nhap sai
                Con neu diem nho hon 5 thi hien thi "Yeu"
                Con neu diem nho hon 6.5 thi hien thi "Trung Binh"
                Con neu diem nho hon 8 thi hien thi "Kha"
                Con lai thi hien thi "Gioi"
        */
        //Khai bao diem
        double diem;
        //Nhap diem
        Console.Write("Diem = ");
        diem = double.Parse(Console.ReadLine());
        //Kiem tra diem
        if (diem < 0 || diem > 10)
        {
            Console.WriteLine("Nhap sai");
        } else if (diem < 5)
        {
            Console.WriteLine("Yeu");
        } else if (diem < 6.5)
        {
            Console.WriteLine("Trung Binh");
        } else if (diem < 8)
        {
            Console.WriteLine("Kha");
        }
        else
        {
            Console.WriteLine("Gioi");
        }
        
        /*
            4. Nhap 3 so thuc x, y, z tu ban phim.
            Kiem tra x, y, z co tao thanh tam giac khong.
        */
        //Khai bao bien
        double x, y, z;
        //Nhap bien
        Console.Write("x = ");
        x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        y = double.Parse(Console.ReadLine());
        Console.Write("z = ");
        z = double.Parse(Console.ReadLine());
        if (x > 0 && y > 0 && z > 0)
        {
            if (x + y > z && y + z > x && x + z > y)
            {
                Console.WriteLine(x + ", " + y + ", " + z + " tao thanh tam giac");
            }
            else
            {
                Console.WriteLine(x + ", " + y + ", " + z + " khong tao thanh tam giac");
            }
        }
        else
        {
            Console.WriteLine(x + ", " + y + ", " + z + " khong tao thanh tam giac");
        }

    }
}