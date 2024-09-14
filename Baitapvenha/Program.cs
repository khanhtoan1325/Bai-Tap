using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapvenha
{
    internal class Program
    {
        // Khai báo các thuộc tính
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Lệnh không bị lỗi font chữ khi viết tiếng việt
            // Khởi tạo list danh sách
            List<Student> students = new List<Student>()
            {
                new Student() { Id = 1, Name = " An ", Age = 21 },
                new Student() { Id = 2, Name = " Thịnh ", Age = 18 },
                new Student() { Id = 3, Name = " Anh ", Age = 20 },
                new Student() { Id = 4, Name = " Toàn ", Age = 22 },
                new Student() { Id = 5, Name = " Đạt ", Age = 15 },
            };
            // A. In danh sách toàn bộ học sinh
            Console.WriteLine("Danh sách học sinh"); // Xuất kết quả 
            students.ForEach(s => Console.WriteLine($"Id: {s.Id},Name: {s.Name},Age: {s.Age}")); //Đọc kết quả từ list

            // B. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18 
            Console.WriteLine("\nHọc sinh có kết có độ tuổi từ 15 đến 18: ");
            var tuoi = students.Where(s => s.Age >= 15 && s.Age <= 18);
            // Dùng foreach để duyệt từng kết quả trong list để trả về kết quả 
            foreach (var t in tuoi)
            {
                Console.WriteLine($"Id: {t.Id},Name: {t.Name},Age: {t.Age}");
            }
            //C. Tìm và in ra học sinh có tên bắt đầu bằng chữ A 
            // Dùng .Trim() Để xóa toàn bộ khoảng trắng ở đầu và cuối chuỗi
            Console.WriteLine("\nHọc sinh có tên bắt đầu bằng chữ A:");
            var A = students.Where(s => s.Name.Trim().StartsWith("A")); 
            foreach (var kq in A)
            {
                Console.WriteLine($"Id: {kq.Id}, Name: {kq.Name}, Age: {kq.Age}"+" ");
            }
            //D.Tính tổng tuổi của tất cả học sinh trong danh sách
            Console.WriteLine("\nTính tổng tuổi của tất cả học sinh: ");
            var tong = students.Sum(s  => s.Age);
            Console.WriteLine($"Tổng tuổi: {tong}");

            //E. Tìm và in ra học sinh có tuổi lớn nhất
            Console.WriteLine("\nHọc sinh có tuổi lớn nhất là: ");
            var lonNhat = students.OrderByDescending(s => s.Age).FirstOrDefault();
            if (lonNhat != null )
            {
                Console.WriteLine($"Id: {lonNhat.Id}, Name: {lonNhat.Name}, Age: {lonNhat.Age}" + " ");
            }

            //F. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
            Console.WriteLine("\nDanh sách học sinh sắp xếp theo thứ tự tăng dần: ");
            var tangDan = students.OrderBy(s => s.Age).ToList();
            tangDan.ForEach(s => Console.WriteLine($"Id: {s.Id},Name: {s.Name},Age: {s.Age}"));




            Console.ReadKey();
        }
    }
}
