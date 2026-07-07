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
    }
}