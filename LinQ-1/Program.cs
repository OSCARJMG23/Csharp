using LinQ_1;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
    };

        var filteredResult = studentList.Where((s, i) =>
        {
            if (i % 2 == 0) // if it is even element
                return true;

            return false;
        });

        foreach (var std in filteredResult)
            Console.WriteLine(std.StudentName);
        var orderByResult = from s in studentList
                    orderby s.StudentName 
                    select s;

        var orderByDescendingResult = from s in studentList
            orderby s.StudentName descending
            select s;
        Console.WriteLine("Ascending Order:");
		
		foreach (var std in orderByResult)
            Console.WriteLine(std.StudentName);
		
		Console.WriteLine("Descending Order:");
		
		foreach (var std in orderByDescendingResult)
            Console.WriteLine(std.StudentName);
        

        var multiSortingResult = from s in studentList
                    orderby s.StudentName, s.Age 
                    select s;
		
		
		foreach (var std in multiSortingResult)
			Console.WriteLine("Name: {0}, Age {1}",std.StudentName, std.Age);

            
        var groupedResult = from s in studentList
                group s by s.Age;

//iterate each group        
        foreach (var ageGroup in groupedResult)
        {
            Console.WriteLine("Age Group: {0}", ageGroup .Key); //Each group has a key 
                    
            foreach(Student s in ageGroup) // Each group has inner collection
                Console.WriteLine("Student Name: {0}", s.StudentName);
        }
    }        
}