/* Biến (Variable): 1 ô nhớ để lưu trữ giá trị được nhập từ bàn phím hoặc được trả về từ trong chương trình
    - Đặc điểm của biến:
        + Mỗi biến có 1 kiểu dữ liệu xác định
        + Giá trị của biến có thể thay đổi trong quá trình chạy chương trình
        + Biến là duy nhất: trong 1 chương trình không có 2 biến giống nhau
    - Khai báo biến:
        + Khai báo biến nhưng không gán giá trị cho biến
            Kiểu_dữ_liệu tên_biến;
        + Khai báo và gán giá trị cho biến
            Kiểu_dữ_liệu tên_biến = giá_trị;
    - Quy tắc đặt tên biến:
        + Tên biến chỉ chứa ký tự chữ cái (hoa, thường), chữ số, _
        + Tên biến không được bắt đầu bằng số
        + Tên biến không trùng từ khóa
        + Tên biến phân biệt hoa thường (Ví dụ: Biến abc khác Abc)
        + Tên biến không được trùng nhau
*/
int soNguyen;
double soThuc = 1.0;
/* Kiểu dữ liệu (data type): Kiểu giá trị mà biến có thể chứa, mỗi kiểu dữ liệu sẽ chiếm 1 lượng bộ nhớ nhất định
    Số nguyên (integer): int
    Số thực: float, double
    Ký tự (Character): char
        char kyTu = 'a';
    Chuỗi: string
        string chuoi = "abc";
    2 trạng thái (True or False): boolean
*/

/* Từ khóa (Keyword): từ được xây dựng sẵn trong ngôn ngữ lập trình
    - Mỗi từ khóa có 1 chức năng nhất định và không thể thay đổi chức năng
    - Một số từ khóa hay dùng: int, float, double, char, string, class, public, protected, private, if, else, switch, case, break, continue, for, while, do 
*/

/* Toán tử: Ký hiệu thể hiện các phép toán
    Toán tử số học: +, -, *, /, %
    Toán tử quan hệ: >, <, >=, <=, ==, !=
    Toán tử logic: &&, ||, !
        Tất cả các biểu thức trả về true thì toán tử && trả về true
        Tất cả các biểu thức trả về false thì toán tử || trả về false
        !True => False
    Toán tử gán: =, +=, -=, *=, /=, %=
        a += b => a = a + b
        a -= b => a = a - b
        a *= b => a = a * b
        a /= b => a = a / b
        a %= b => a = a % b
    Toán tử điều kiện: ? :
        int c = (a < b) ? 5 : 6
        
    int + int => int        float + int => float
    int - int => int        float - int => float
    int * int => int        float * int => float
    int / int => int        float / int => float
    Ép kiểu: chuyển đổi từ kiểu dữ liệu này sang kiểu dữ liệu khác
        (Kiểu_dữ_liệu)tên_biến
            Ví dụ: (float)a
*/

/* Nhập xuất cơ bản
    + Xuất:
        In xong không xuống dòng: Console.Write(tên_biến); hoặc Console.Write("chuỗi");
        In xong xuống dòng: Console.WriteLine(tên_biến); hoặc Console.WriteLine("chuỗi");
    + Nhập
        Nhập 1 ký tự từ bàn phím, lưu dưới dạng số, lấy ở bảng mã ascii: Console.Read();
        Nhập 1 chuỗi các ký tự, nhập thế nào thì lưu như thế: Console.ReadLine();
    - Trôi lệnh: Từ nhập số => Nhập chữ sẽ bị bỏ qua 1 lệnh nhập chữ
*/

Console.Write("He");
Console.WriteLine("llo");
Console.WriteLine(" World");

int a = Console.Read();
Console.WriteLine("a = " + a);
Console.ReadLine();
string b = Console.ReadLine();
Console.WriteLine("b = " + b);

/* 1. Nhập 2 số nguyên m, n từ bàn phím. Tính +, -, *, / */
//Khai bao m, n
int m, n;
//Nhap m, n
Console.Write("m = ");
m = int.Parse(Console.ReadLine());
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
//Tính +, -, *, /
int tong = m + n;
int hieu = m - n;
int tich = m * n;
double thuong = (double)m / n;
//Hiển thị +, -, *, /
Console.WriteLine("m + n = " + tong);
Console.WriteLine("m - n = " + hieu);
Console.WriteLine("m * n = " + tich);
Console.WriteLine("m / n = " + thuong);

/* 2. Nhap 2 so thuc x, y. Tinh +, -, *, / */
//Khai bao x, y
double x, y;
//Nhap x, y
Console.Write("x = ");
x = double.Parse(Console.ReadLine());
Console.Write("y = ");
y = double.Parse(Console.ReadLine());
//Tinh va hien thi
Console.WriteLine("x + y = " + (x + y));
Console.WriteLine("x - y = " + (x - y));
Console.WriteLine("x * y = " + (x * y));
Console.WriteLine("x / y = " + (x / y));

//Khai bao a
int a1;
//Nhap a
Console.Write("a = ");
a1 = int.Parse(Console.ReadLine());
//Kiem tra a
if (a1 > 0)
{
    Console.WriteLine(a1 + " la so duong");
} else if (a1 < 0)
{
    Console.WriteLine(a1 + " la so am");
}
else
{
    Console.WriteLine("a = 0");
}