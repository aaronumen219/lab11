using System;

class Person
{
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public DateTime DateOfBirth { get; set; }
  public string SocialSecurity { get; set; }
  public string Email { get; set; }
  public string PhoneNumber { get; set; }
  public Address PermanentAddress;

  public Person()
  {
    PermanentAddress = new Address();
    Console.WriteLine("person constructor 2, 0 parameters");
  }



  

  public Person(string fname, string lname)
  {
    FirstName = fname;
    LastName = lname;

    PermanentAddress = new Address();
    Console.WriteLine("Person constructor, 2 parameters");
  }





  public virtual void Intro()

  {
    Console.WriteLine("Hello my name is " + FirstName + 
    " " + LastName);
    PermanentAddress.Display();

  }

  public void IsBirthday()

  {
    if ((DateTime.Today.Month == DateOfBirth.Month) && (DateTime.Today.Day == DateOfBirth.Day))
      Console.WriteLine("It's your birthday!!");
    else
      Console.WriteLine("Today is not your birthday.");


  }


   
}