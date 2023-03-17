using System.Collections;

namespace ArrayListTrongCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo 1 danh sách kiểu ArrayList rỗng
            ArrayList arrPersons = new ArrayList();

        }
    }
}
public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name;}
        set {name = value;}
    }
    public int Age
    {
        get {return age;}
        set { age = value;}
    }

    // Tạo 1 constructor có tham số để tiện cho việc khởi tạo nhanh đối tượng Person với các giá trị cho sẵn.
    public Person (string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }

     /// Override phương thức ToString để khi cần có thể in thông tin của object ra cho nhanh.
     public Override string ToString()
    {
        return "Name: " + name + " | Age: " +age;
    }
     
}

public class SortPersons : IComparer
{
    public int Compare (object x, object y)
    {
        // Ép kiểu 2 object truyền vào về Person.
        Person p1 = x as Person;
        Person p2 = y as Person;

        //ném ra lỗi để lập trình viên sửa chữa.
        if (p1 == null || p2 == null) 
        {
            throw new InvalidOperationException();
        }
        else
        {
            if (p1.Age < p2.Age)
        }

    }
}

