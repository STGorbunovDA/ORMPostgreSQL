namespace ORMPostgreSQL
{
    internal class Worker
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string? FullName { get; set; }

        public Worker() { }
        public Worker(string fullName, int age, int salary)
        {
            Age = age;
            Salary = salary;
            FullName = fullName;
        }

        public override string ToString() => $"[{Id} {FullName} {Age} {Salary}]";

    }
}
