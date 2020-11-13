using System;

class Faculty : Person
{
  public string ID {get; set;}
  public string Title {get; set;}
  public DateTime DateOfEmployment {get; set;}
  public string Employer {get; set;}
  public  double YearlySalary {get; set;}
  public  bool Tenured {get; set;}


  public Faculty() : base()
  {

    Console.WriteLine("0 parameter constructor");
    Title = "Instructor";


  }

  public Faculty(string fname, string lname) : base(fname, lname)
  {
    Console.WriteLine("StudentConstructor");
    Title = "Instructor";
  }
 
public void GrantTenure()
{
  if (((DateOfEmployment.Year + 5) <= DateTime.Today.Year) && (DateTime.Today.Month >= DateOfEmployment.Month) && (DateTime.Today.Day >= DateOfEmployment.Day))
    Tenured = true;
  else 
    Tenured = false;
  Console.WriteLine(Tenured);


}

public void Promote()
{
  
  
 
  if ((Title == "Instructor") && ((DateOfEmployment.Year + 2) < DateTime.Today.Year) && (DateTime.Today.Month > DateOfEmployment.Month) && (DateTime.Today.Day > DateOfEmployment.Day)) 
    {
      Title = "Assistant Professor";
      Console.WriteLine("Faculty promoted to Assistant professor rank.");
      return;
    }
  if ((Title == "Assistant Professor") && ((DateOfEmployment.Year + 5) < DateTime.Today.Year) && (DateTime.Today.Month > DateOfEmployment.Month) && (DateTime.Today.Day > DateOfEmployment.Day)) 
    {
      Title = "Associate Professor";
      Console.WriteLine("Faculty promoted to Associate professor rank.");
      return;
    }
  if ((Title == "Associate Professor") && ((DateOfEmployment.Year + 10) < DateTime.Today.Year) && (DateTime.Today.Month > DateOfEmployment.Month) && (DateTime.Today.Day > DateOfEmployment.Day))
  {
    Title = "Professor";
    Console.WriteLine("Faculty promoted to Professor rank.");
    return;
  } 
  if (Title == "Professor")
  {
    Console.WriteLine("No more promotion possible.");
    return;
  }

}
public override void Intro()
{
  base.Intro();
  Console.WriteLine("I work as as " + Title + " at " + Employer + " since " + DateOfEmployment.Year + ".");


}

}
