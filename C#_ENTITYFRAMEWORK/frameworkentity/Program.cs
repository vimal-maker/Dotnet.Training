using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frameworkentity
{
    class Program
    {
        static void Main(string[] args)
        {
            studentEFDBEntities context = new studentEFDBEntities();
            //var Student = new student()
            //{
            //    StdID = 1,
            //    name = "vimal",
            //    Rollno = 15117,
            //    DeptID = 2

            //};
            //context.students.Add(Student);
            //context.SaveChanges();

            //var Student2 = new student()
            //{
            //    StdID = 2,
            //    name = "mohan",
            //    Rollno = 15116,
            //    DeptID = 3

            //};
            //context.students.Add(Student2);


            //var Student3 = new student()
            //{
            //    StdID = 3,
            //    name = "anup",
            //    Rollno = 15118,
            //    DeptID = 1

            //};
            //context.students.Add(Student3);
            //context.SaveChanges();


            LinqToEntity();
            ModifyStudent();
        }
        public static void LinqToEntity()
        {
            studentEFDBEntities context = new studentEFDBEntities();
            var student = context.student;
            var stdlist = from std in student
                          orderby std.Department
                          select std;
            foreach(var std in student)
            {
                Console.WriteLine("StdID:{0},name:{1},Rollno:{2}", std.StdID, std.name, std.Rollno);
            }
        }
        public static void ModifyStudent()
        {
            studentEFDBEntities context = new studentEFDBEntities();
            var students = context.student;
            var stdlist = from std in students
                          orderby std.Rollno
                          select std;
            foreach(var std in students)
            {
                if(std.StdID == 2)
                    std.name = "soona pana";

            }
              context.student.Add(students);
            context.SaveChanges();
        }
    }
}
