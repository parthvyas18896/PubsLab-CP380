using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using CP380_PubsLab.Models;

namespace CP380_PubsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            using var dbcontext = new Models.PubsDbContext();

            if (dbcontext.Database.CanConnect())
            {
                Console.WriteLine("Yes, I can connect");
            }


            //foreach (var j in dbcontext.Jobs)
            //{
            //  Console.WriteLine($"{j.desc}");
            //}

            // 1:Many practice
            //
            // TODO: - Loop through each employee
            //       - For each employee, list their job description (job_desc, in the jobs table)


            var q = dbcontext.Employee;
            Console.WriteLine($"{q.ToQueryString()}");
            foreach (var e in q.Include(e => e.Job))
            {
                Console.WriteLine($"{e.Emp_id} -> {e.Job.Desc}");
            }



            // TODO: - Loop through all of the jobs
            //       - For each job, list the employees (first name, last name) that have that job


            foreach (var a in dbcontext.Jobs.Include(d => d.Employee))
            {


                var employessjob = a.Employee.Select(d => new { EmpId = d.Emp_id, FName = d.Firstname, LName = d.Lastname, Job_Desc = a.Desc }).ToList();
                var empl_Job = String.Join(",", employessjob);
                Console.WriteLine($"{a.Desc} -> {empl_Job}");
            }

            //foreach (var a in dbcontext.Employee.Include(d => d.Job))
            //{


            //    var employessjob = a.Job.Select(a => new { Job_Id = a.job_id, Job_Desc = a.job_desc, Employee = a.Employee.Select(d => new { FirstName = d.fname, LastName = d.lname }) }).ToList();
            //    var empl_Job = String.Join(",", employessjob);
            //    Console.WriteLine($"{a.Firstname}{a.Lastname} -> {empl_Job}");
            //}



            // Many:many practice
            //
            // TODO: - Loop through each Store
            //       - For each store, list all the titles sold at that store
            //
            //var q = dbcontext.Stores.Include(a => a.Sales);
            //Console.WriteLine(q.ToQueryString());

            var storeTitles = dbcontext.Stores.Select(s => new { Store = s.stor_name, Titles = s.Sales.Select(sl => sl.Title.title) }).ToList();


            Console.WriteLine("\n#Stores | Titles ");
            foreach (var store in storeTitles)
            {
                var strJoin = String.Join(",", store.Titles);
                Console.WriteLine($"\n{store.Store} -> {strJoin}");
            }
            // e.g.
            //  Bookbeat -> The Gourmet Microwave, The Busy Executive's Database Guide, Cooking with Computers: Surreptitious Balance Sheets, But Is It User Friendly?

            // TODO: - Loop through each Title
            //       - For each title, list all the stores it was sold at

            var Titlestore = dbcontext.Titles.Select(t => new { TitleName = t.title, StoreList = t.Sales.Select(sl => sl.Store.stor_name) }).ToList();


            Console.WriteLine("\n#Titles | Stores ");
            foreach (var title in Titlestore)
            {
                var strJoin = String.Join(",", title.StoreList);
                Console.WriteLine($"\n{title.TitleName} -> {strJoin}");
            }
            //
            // e.g.
            //  The Gourmet Microwave -> Doc-U-Mat: Quality Laundry and Books, Bookbeat
        }
    }
}

