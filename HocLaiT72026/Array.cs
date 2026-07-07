namespace HocLaiT72026;

public class Array
{
    public void demo()
    {
        /* Mảng (Array): Là 1 tập hợp các phần tử có cùng kiểu dữ liệu với nhau
            - Khai báo mảng
                Khai báo mảng và chưa gán giá trị chi mảng
                    Kiểu_dữ_liệu[] tên_mảng = new kiểu_dữ_liệu[số_phần_tử];
                Khai báo mảng và gán giá trị
                    Kiểu_dữ_liệu[] tên_mảng = {giá_trị_1, giá_trị_2, ...};
            - Đặc điểm:
                Các phần tử trong mảng phải có cùng kiểu dữ liệu
                Mảng luôn có 1 số lượng phần tử xác định
                Các phần tử của mảng được phân biệt bởi 1 chỉ số được gọi là index
                Index luôn bắt đầu từ 0 đến n - 1 (n là số phần tử)
            - Truy xuất 1 phần tử của mảng
                tên_mảng[index]
            - Truy xuất lần lượt từng phần tử của mảng: Dùng vòng lặp chạy từ 0 đến n - 1
            - Mảng 1 chiều: mảng có giá trị của các phần tử là 1 giá trị nguyên tử
                => Làm việc với mảng 1 chiều thì phải dùng 1 vòng lặp
            - Mảng 2 chiều: mảng có giá trị của 1 phần tử là 1 mảng 1 chiều
                => Làm việc với mảng 2 chiều thì phải dùng 2 vòng lặp lồng nhau
        */
        int i = 0;
        /*
            1. Nhập và hiển thị mảng số nguyên có 5 phần tử
        */
        //Khai báo mảng số nguyên tên là arr có 5 phần tử
        int[] arr = new int[5];
        //Nhập lần lượt từng phần tử của mảng
        for (i = 0; i < 5; i++)
        {
            Console.Write("arr[" + i + "] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        //Hiển thị lần lượt từng phần tử của mảng
        Console.Write("Cac phan tu cua mang: ");
        for (i = 0; i < 5; i++)
        {
            Console.Write(arr[i] + "\t");
        }
        Console.WriteLine();
        
        /* 2. Nhập số nguyên a từ bàn phím.
            Nhập và hiển thị mảng số thực có a phần tử.
        */
        //Khai báo và nhập a
        int a;
        Console.Write("a = ");
        a = int.Parse(Console.ReadLine());
        //Khai bao mang
        double[] arr2 = new double[a];
        //Nhap mang
        for (i = 0; i < a; i++)
        {
            Console.Write("arr2[" + i + "] = ");
            arr2[i] = double.Parse(Console.ReadLine());
        }
        //Hien thi
        Console.Write("Mang vua nhap: ");
        for (i = 0; i < a; i++)
        {
            Console.Write(arr2[i] + "\t");
        }
        Console.WriteLine();
        
        /* 3. Nhap mang so nguyen co b phan tu (b nhap tu ban phim)
            Tinh tong cac phan tu trong mang
        */
        //Khai báo và nhập b
        int b;
        Console.Write("b = ");
        b = int.Parse(Console.ReadLine());
        //Khai bao mang
        int[] arr3 = new int[b];
        //Nhap mang
        for (i = 0; i < b; i++)
        {
            Console.Write("arr3[" + i + "] = ");
            arr3[i] = int.Parse(Console.ReadLine());
        }
        //Tính
        int tong = 0;
        for (i = 0; i < b; i++)
        {
            tong += arr3[i];
        }
        Console.WriteLine("Tong cac phan tu cua mang: " + tong);
        
        /* 4. Nhap mang so nguyen co d phan tu.
         Tinh tich cac phan tu chia het cho 3 hoac 5 */
        //Khai báo và nhập b
        int d;
        Console.Write("d = ");
        d = int.Parse(Console.ReadLine());
        //Khai bao mang
        int[] arr4 = new int[d];
        //Nhap mang
        for (i = 0; i < d; i++)
        {
            Console.Write("arr4[" + i + "] = ");
            arr4[i] = int.Parse(Console.ReadLine());
        }
        //Tinh
        int tong2 = 0;
        for (i = 0; i < d; i++)
        {
            if (arr4[i] % 3 == 0 || arr4[i] % 5 == 0)
            {
                tong2 += arr4[i];
            }
        }
        Console.WriteLine("Tong cac phan tu chia het cho 3 hoac 5: " + tong2);
        
        /* 5. Nhap mang so thuc co m phan tu.
            Tim gia tri nho nhat trong mang.
        */
        //Khai bao va nhap m
        int m;
        Console.Write("m = ");
        m = int.Parse(Console.ReadLine());
        //Khai bao mang
        double[] arr5 = new double[m];
        //Nhap mang
        for (i = 0; i < m; i++)
        {
            Console.Write("arr5[" + i + "] = ");
            arr5[i] = double.Parse(Console.ReadLine());
        }
        //Tim max
        double max = arr5[0];
        for (i = 0; i < m; i++)
        {
            if (max < arr5[i])
            {
                max = arr5[i];
            }
        }
        //Hien thi
        Console.WriteLine("Phan tu co gia tri lon nhat trong mang: " + max);
        
        /*
            6. Nhap mang so thuc co x phan tu. Sap xep mang theo chieu tang dan        
        */
    }
}