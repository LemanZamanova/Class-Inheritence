namespace class_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Leman", "Zamanova", "BB209", 85, true);
            Student student2 = new Student("Elsad", "Rzazade", "BB208", 94, true);
            student1.GetInfo();
            student1.GetDiplomDegree();
            student1.CheckGraduation();
            student2.GetInfo();
            student2.CheckGraduation();
            student2.GetDiplomDegree();
        }
    }
}
