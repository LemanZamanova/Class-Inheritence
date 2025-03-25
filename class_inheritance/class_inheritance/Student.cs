namespace class_inheritance
{
    internal class Student
    {
        public string name;
        public string surname;
        public string group;
        public int point;
        public bool IsGraduated;

        public Student(string name, string surname, string group, int point, bool IsGraduated)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
            this.point = point;
            this.IsGraduated = IsGraduated;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {name} {surname} Group:{group} point:{point} Graduate status:{IsGraduated}");
        }

        public void CheckGraduation()
        {
            if (IsGraduated)
            {
                Console.WriteLine("graduated");
            }
            else
            {
                Console.WriteLine("didn't graduate");
            }
        }
        public void GetDiplomDegree()
        {
            if (point > 90)
            {
                Console.WriteLine("Distinction diploma");
            }
            else if (point > 80 && point <= 90)
            {
                Console.WriteLine("Merit diploma");
            }
            else if (point >= 65 && point <= 80)
            {
                Console.WriteLine("Past diploma");
            }
            else
            {
                Console.WriteLine("will not receive a diploma");
            }
        }

    }
}
