namespace HocLaiT72026;

public class Loop
{
    public void demo()
    {
        /* Vòng lặp (Loop): thực hiện 1 khối lệnh lặp đi lặp lại nhiều lần
            - for, while, do - while
            
            for
                Cú pháp
                    for(tham số 1; tham số 2; tham số 3){
                        Khối lệnh;
                    }
                Cách sử dụng:
                    Chỉ sử dụng khi biết trước số lần lặp
                Đặc điểm:
                    Kiểm tra tham số 2 trước, sau đó mới chạy khối lệnh
                    => Có thể thực hiện khối lệnh 0 hoặc n lần
            
            while
                Cú pháp
                    tham số 1;
                    while(tham số 2){
                        Khối lệnh;
                        tham số 3;
                    }
                Cách sử dụng:
                    Sử dụng khi biết trước hoặc không biết trước số lần lặp
                Đặc điểm:
                    Kiểm tra tham số 2 trước, sau đó mới chạy khối lệnh
                    => Có thể thực hiện khối lệnh 0 hoặc n lần
            
            do - while
                Cú pháp
                    K1:
                    tham số 1;
                    do {
                        Khối lệnh;
                        tham số 3;
                    } while(tham số 2);
                    
                    K2:
                    do {
                        tham số 1;
                        Khối lệnh;
                    } while(tham số 2);
                Cách sử dụng:
                    Sử dụng khi biết trước hoặc không biết trước số lần lặp
                Đặc điểm:
                    Thực hiện khối lệnh trước, sau đó mới kiểm tra tham số 2
                    => Luôn thực hiện ít nhất 1 lần
                
            Tham số 1: Thời điểm bắt đầu vòng lặp => không có tham số 1: lỗi cú pháp
            Tham số 2: Điều kiện duy trì vòng lặp => không có tham số 2: vòng lặp vô hạn (chạy không bao giờ dừng)
                Khi tham số 2 trả về true thì vòng lặp tiếp tục được thực hiện
                Khi trả về false thì vòng lặp kết thúc
            Tham số 3: Bước nhảy của vòng lặp => không có tham số 3: vòng lặp vô hạn
                Tác dụng: thay đổi tham số 1
        */
        
        /* 1. In ra các số từ 1 đến 100 */
        int i = 1;
        
        Console.WriteLine("---for---");
        for (i = 1; i <= 100; i++)
        {
            Console.Write(i + "\t");
        }
        Console.WriteLine();
        
        Console.WriteLine("---while---");

        i = 1;
        while (i <= 100)
        {
            Console.Write(i + "\t");
            i++;
        }
        Console.WriteLine();
        
        Console.WriteLine("---do - while---");
        i = 1;
        do
        {
            Console.Write(i + "\t");
            i++;
        } while (i <= 100);
        Console.WriteLine();
        /*
            2. Nhập số nguyên n từ bàn phím. In ra các số từ 1 đến n
        */
        //Khai báo n
        int n;
        //Nhập n
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        //Vòng lặp từ 1 đến n
        for (i = 1; i <= n; i++)
        {
            Console.Write(i + "\t");
        }
        Console.WriteLine();
        
        /*
            3. Nhập số nguyên a từ bàn phím.
            Tính tổng các số từ 1 đến a       
        */
        //Khai báo a
        int a;
        //Nhap
        Console.Write("a = ");
        a = int.Parse(Console.ReadLine());
        int tong = 0;
        //Vòng lặp
        for (i = 1; i <= n; i++)
        {
            tong += i;
        }
        //Hiển thị kết quả
        Console.WriteLine("Tong cac so tu 1 den n: " + tong);
        
        /*
            4. Nhập số nguyên b từ bàn phím. Tính b!
        */
        //Khai báo b
        int b;
        //Nhap b
        Console.Write("b = ");
        b = int.Parse(Console.ReadLine());
        int giaiThua = 1;
        //Kiem tra
        if (b < 0)
        {
            Console.WriteLine("Khong co giai thua");
        }
        else
        {
            for (i = 1; i <= b; i++)
            {
                giaiThua *= i;
            }
            Console.WriteLine(b + "! = " + giaiThua);
            
        }
        
    }
}