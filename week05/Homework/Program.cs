class Program
{
    static void Main(string[] args)
    {
        // Test assignments with Nigerian context
        Assignment physics = new Assignment("Thomas Etiuzale", "Physics: Motion in Edo State");
        Console.WriteLine(physics.GetSummary());

        MathAssignment math = new MathAssignment(
            "Oshomah Etiuzale", 
            "Mathematics: Simple Geometry", 
            "4.1", 
            "5-15, 20-22"
        );
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment history = new WritingAssignment(
            "Daniel Edosa", 
            "History: Oba Ewuare's Reign", 
            "Economic Reforms in 15th Century Benin"
        );
        Console.WriteLine(history.GetSummary());
        Console.WriteLine(history.GetWritingInformation());
        
        WritingAssignment culture = new WritingAssignment(
            "Yoyo Etiuzale", 
            "Cultural Studies: Edo Festivals", 
            "Igue Festival Traditions"
        );
        Console.WriteLine(culture.GetSummary());
        Console.WriteLine(culture.GetWritingInformation());
    }
}