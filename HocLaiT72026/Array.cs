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
    }
}