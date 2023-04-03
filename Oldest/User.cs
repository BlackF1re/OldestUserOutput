using System.Runtime.Versioning;

namespace Oldest;

public class User : IComparable<User>
{

    public int ID { get; set; }
    public string Fname { get; set; }
    public string Sname { get; set; }
    public string Lname { get; set; }
    public int Age { get; set; }

    public User(int id, string fname, string sname, string lname, int age)
    {
        this.ID = id;
        this.Fname = fname;
        this.Sname = sname;
        this.Lname = lname;
        this.Age = age;
    }

    public int CompareTo(User? otherUser)
    {
        return Age.CompareTo(otherUser.Age);
    }
}