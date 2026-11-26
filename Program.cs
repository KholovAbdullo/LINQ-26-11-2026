using System.Xml.Linq;

List<Employee> employees = new List<Employee>()
{
    new Employee 
    { 
        Name = "Ali", 
        Department = "Engineering", 
        Salary = 5000 
    },

    new Employee 
    { 
        Name = "Ahmad", 
        Department = "IT", 
        Salary = 4000 
    },

    new Employee 
    { 
        Name = "Karim", 
        Department = "Engineering", 
        Salary = 6000 
    },

    new Employee 
    { 
        Name = "Said", 
        Department = "HR", 
        Salary = 3000 
    },

    new Employee 
    { 
        Name = "Rustam", 
        Department = "IT", 
        Salary = 5000 
    }

};

//1 method syntax
// var res = employees.Where(x=>x.Department=="Engineering");
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name);
// }

//query syntax
// var res = from e in employees
//             where e.Department=="Engineering"
//             select e.Name;
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

//2 method syntax
// var res = employees.GroupBy(x=>x.Department)
//             .Select(x => new
//             {
//                 Department = x.Key,
//                 Salary = x.Average(x=>x.Salary)
//             });
// foreach (var item in res)
// {
//     Console.WriteLine("Department: "+item.Department+" "+" Avg: "+item.Salary);
// }

//query syntax
// var res = from e in employees
//             group e by e.Department into d 
//             select new
//             {
//                 Department = d.Key,
//                 Salary = d.Average(x=>x.Salary)
//             };
// foreach (var item in res)
// {
//     Console.WriteLine("Department: "+item.Department+" "+" Avg: "+item.Salary);
// }

//3 method syntax
// var res = employees.GroupBy(x=>x.Department)
//             .Select(x => new
//             {
//                 Department = x.Key,
//                 Avg = x.Average(x=>x.Salary)
//             }).OrderByDescending(x=>x.Avg).First();
// Console.WriteLine(res.Department+" "+res.Avg);

//query syntax
// var res = (from x in employees 
//             group x by x.Department into e
//             select new
//             {
//                 Department = e.Key,
//                 Avg = e.Average(x=>x.Salary)
//             }).OrderByDescending(x=>x.Avg).First();
// Console.WriteLine(res.Department+"  "+res.Avg);

//=================== Task 3 ====================
List<Order> orders = new List<Order>()
{
    new Order 
    {  
        OrderId = 1, 
        CustomerId = 101, 
        OrderDate = DateTime.Now, 
        TotalAmount = 500 
    },

    new Order 
    { 
        OrderId = 2, 
        CustomerId = 102, 
        OrderDate = DateTime.Now, 
        TotalAmount = 700 
    },

    new Order 
    {
         OrderId = 3, 
        CustomerId = 101, 
        OrderDate = DateTime.Now, 
        TotalAmount = 300 
    },

    new Order 
    { 
        OrderId = 4, 
        CustomerId = 103, 
        OrderDate = DateTime.Now, 
        TotalAmount = 900 
    },

    new Order 
    { 
        OrderId = 5, 
        CustomerId = 104, 
        OrderDate = DateTime.Now, 
        TotalAmount = 400 
    },

    new Order 
    { 
        OrderId = 6, 
        CustomerId = 105, 
        OrderDate = DateTime.Now, 
        TotalAmount = 800 
    },

    new Order 
    { 
        OrderId = 7, 
        CustomerId = 102, 
        OrderDate = DateTime.Now, 
        TotalAmount = 200 
    }
};

//1 method syntax
// var res = orders.GroupBy(x=>x.CustomerId)
//                 .Select(x => new
//                 {
//                     CustomerId = x.Key,
//                     TotalAmount = x.Sum(x=>x.TotalAmount)
//                 }).OrderByDescending(x=>x.TotalAmount).Take(5);
// foreach (var item in res)
// {
//     Console.WriteLine(item.CustomerId+"  "+item.TotalAmount);
// }

//query syntax
// var res = (from x in orders
//             group x by x.CustomerId into e
//             select new
//             {
//                 CustomerId = e.Key,
//                 TotalAmount = e.Sum(x=>x.TotalAmount)
//             }).OrderByDescending(x=>x.TotalAmount).Take(5);
// foreach (var item in res)
// {
//     Console.WriteLine(item.CustomerId+"  "+item.TotalAmount);
// }

//========================= Home Task ==========================
List<Employees> employeess = new List<Employees>()
{
    new Employees 
    { 
        Name = "Ali",
        Department = "IT", 
        Salary = 5000, 
        Age = 22 
    },

    new Employees 
    { 
        Name = "Ahmad", 
        Department = "HR", 
        Salary = 3000, 
        Age = 25 
    },

    new Employees 
    { 
        Name = "Karim", 
        Department = "IT", 
        Salary = 7000, 
        Age = 28 
    },
    new Employees 
    { 
        Name = "Said", 
        Department = "Design", 
        Salary = 4000, 
        Age = 24 
    },

    new Employees 
    { 
        Name = "Rustam", 
        Department = "HR", 
        Salary = 6000, 
        Age = 30 
    },

    new Employees 
    { 
        Name = "Bob", 
        Department = "Design", 
        Salary = 8000, 
        Age = 27 
    },

    new Employees 
    { 
        Name = "Salim", 
        Department = "IT", 
        Salary = 4500, 
        Age = 26 
    }
};
//1 method syntax
// var res = employeess.OrderByDescending(x=>x.Salary);
// foreach (var item in res)
// {
//     Console.WriteLine(item.Salary);
// }

//query syntax
// var res = from x in employeess
//             orderby x.Salary descending
//             select x.Salary;
// foreach (var item in res)
// {
//     Console.WriteLine(item);
// }

//2 method syntax
// var res = employeess.Where(x=>x.Salary>=5000);
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name+" "+item.Salary);
// }

//query syntax
// var res = from x in employeess
//             where x.Salary>=5000
//             select x;
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name+" "+item.Salary);
// }

//3 method syntax
// var res = employeess.OrderBy(x=>x.Salary);
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name+" "+item.Salary);
// }

//query syntax
// var res = from x in employeess
//             orderby x.Salary
//             select x;
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name+" "+item.Salary);
// }

//4 method syntax
// var res = employeess.Max(x=>x.Salary);
// Console.WriteLine(res);

//query syntax
// var res = (from x in employeess
//             select x.Salary).Max();
// Console.WriteLine(res);

//5 method syntax
// var res = employeess.Min(x=>x.Salary);
// Console.WriteLine(res);

//query syntax
// var res = (from x in employeess
//             select x.Salary).Min();
// Console.WriteLine(res);

//6 method syntax
// var res = employeess.GroupBy(x=>x.Name)
//             .Select(x => new
//             {
//                 Name=x.Key,
//                 Salary = x.Average(x=>x.Salary)
//             }).OrderByDescending(x=>x.Salary);
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name+" "+item.Salary);
// }

//query syntax
// var res = (from x in employeess
//             group x by x.Name into e
//             select new
//             {
//                 Name=e.Key,
//                 Salary = e.Average(x=>x.Salary)
//             }).OrderByDescending(x=>x.Salary);
// foreach (var i in res)
// {
// Console.WriteLine(i.Name+" "+i.Salary);
// }

//7 method syntax
// var res = employeess.Take(3);
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name+" "+item.Salary);
// }

//query syntax
// var res = (from x in employeess
//             select x).Take(3);
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name+" "+item.Salary);
// }

//8 method syntax
// var res = employeess.Sum(x=>x.Salary);
// Console.WriteLine(res);

//query syntax
// var res =   (from x in employeess
//             select x.Salary).Sum();
// Console.WriteLine(res);

//9 method syntax
// var res = employeess.OrderBy(x=>x.Department).ThenBy(x=>x.Salary);
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name+"  "+item.Department+"  "+item.Salary);
// }

//query syntax
// var res = from x in employeess
//             orderby x.Department,x.Salary
//             select x;
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name+"  "+item.Department+"  "+item.Salary);
// }

//10 method syntax
// var res = employeess.First();
// Console.WriteLine(res.Name+" "+res.Age);

//query syntax
// var res = (from x in employeess
//             select x).First();
// Console.WriteLine(res.Name+" "+res.Age);

//==================== Task 2 =====================
// StudentService service = new StudentService();
// service.AddStudent(new Student { Id = 1, Name = "Ali", Age = 18, Grade = 90 });
// service.AddStudent(new Student { Id = 2, Name = "Ahmad", Age = 20, Grade = 85 });
// service.AddStudent(new Student { Id = 3, Name = "Karim", Age = 18, Grade = 95 });

// foreach (var item in service.GetStudents())
// {
//     Console.WriteLine(item.Name);
// }

// service.UpdateStudent(new Student{Id=1,Name="Abdullo",Age=16,Grade=95});
// service.DeleteStudent(2);
// var res = service.GetStudentsByAge(16);
// foreach (var item in res)
// {
//     Console.WriteLine(item.Name+" "+item.Grade);
// }

// var res1 = service.GetStudentsByGrade();
// foreach (var item in res1)
// {
//     Console.WriteLine(item.Name+" "+item.Grade);
// }

//==================== Task 3 ========================
