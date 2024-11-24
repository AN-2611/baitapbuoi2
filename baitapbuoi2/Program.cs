    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    namespace StudentManagement
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
          
                // Tạo danh sách học sinh
                List<Student> students = new List<Student>
                {
                    new Student { Id = 1, Name = "An", Age = 16 },
                    new Student { Id = 2, Name = "Binh", Age = 15 },
                    new Student { Id = 3, Name = "Anh", Age = 17 },
                    new Student { Id = 4, Name = "Cuong", Age = 18 },
                    new Student { Id = 5, Name = "Bao", Age = 14 }
                };

                // a. In danh sách toàn bộ học sinh
                Console.WriteLine("Danh sách toàn bộ học sinh:");
                students.ForEach(s => Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}"));

                // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
                Console.WriteLine("\nHọc sinh có tuổi từ 15 đến 18:");
                var filteredStudents = students.Where(s => s.Age >= 15 && s.Age <= 18);
                foreach (var student in filteredStudents)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                }

                // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
                Console.WriteLine("\nHọc sinh có tên bắt đầu bằng chữ 'A':");
                var studentsWithA = students.Where(s => s.Name.StartsWith("A"));
                foreach (var student in studentsWithA)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                }

                // d. Tính tổng tuổi của tất cả học sinh trong danh sách
                int totalAge = students.Sum(s => s.Age);
                Console.WriteLine($"\nTổng tuổi của tất cả học sinh: {totalAge}");

                // e. Tìm và in ra học sinh có tuổi lớn nhất
                int maxAge = students.Max(s => s.Age);
                var oldestStudents = students.Where(s => s.Age == maxAge);
                Console.WriteLine("\nHọc sinh có tuổi lớn nhất:");
                foreach (var student in oldestStudents)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                }

                // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra
                Console.WriteLine("\nDanh sách học sinh sắp xếp theo tuổi tăng dần:");
                var sortedStudents = students.OrderBy(s => s.Age);
                foreach (var student in sortedStudents)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                }
            }
        }
    }
