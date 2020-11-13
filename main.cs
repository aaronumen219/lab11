using System;

class MainClass {
  public static void Main (string[] args) {
    /*Address addr1 = new Address();
    addr1.AddressLine1 = "1234 Main St";
    addr1.AddressLine2 = "Apt 102";
    addr1.City = "Cleveland";
    addr1.State = "OH";
    addr1.Zipcode = "44143";
    

    addr1.Display(); */
/*
    Person p1 = new Person();
    p1.FirstName = "John";
    p1.LastName = "Smith";

    p1.PermanentAddress.AddressLine1 = "1234  Main St";
    p1.PermanentAddress.City = "Cleveland";
    p1.PermanentAddress.State = "OH";
    p1.PermanentAddress.Zipcode = "44143";
    p1.DateOfBirth = Convert.ToDateTime("11/13/1994");

    p1.Intro();
    p1.IsBirthday();
    */
    Console.WriteLine("This is Faculty 1.");
    
    Faculty s1 = new Faculty();
    
    s1.FirstName = "Kara";
    s1.LastName = "Kaiser";
    s1.DateOfBirth = Convert.ToDateTime("01/01/1989");
    
    s1.PermanentAddress.AddressLine1 = "44 Side St";
    s1.PermanentAddress.City = "Cleveland";
    s1.PermanentAddress.State = "OH";
    s1.PermanentAddress.Zipcode = "44143";
    s1.ID = "12345";
    s1.Title ="Associate Professor";
    s1.DateOfEmployment = Convert.ToDateTime("01/01/2000");
    s1.Employer = "CWRU";
    s1.YearlySalary = 123456;
    s1.Tenured = false;
    s1.Intro();
    s1.IsBirthday();
    s1.GrantTenure();
    s1.Promote();
    
  
   
    /*
    Console.WriteLine("This is student2");
    Student s2 = new Student("Andrew" , "Peggman");
    
    s2.DateOfBirth = Convert.ToDateTime("01/01/1989");
    
    s2.PermanentAddress.AddressLine1 = "44 Side St";
    s2.PermanentAddress.City = "Cleveland";
    s2.PermanentAddress.State = "OH";
    s2.PermanentAddress.Zipcode = "44143";
    s2.School = "Ohio State University";
    s2.Intro();
    s2.IsBirthday();
    s2.SetAcademicStanding();
    s2.GPA = 2.75;
 
    Console.WriteLine(s2.AcademicStanding);
    */
  }
  
}