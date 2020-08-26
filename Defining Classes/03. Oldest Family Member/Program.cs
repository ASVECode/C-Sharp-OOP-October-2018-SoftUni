using System;

namespace _03._Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] members = Console.ReadLine().Split(separator: " ");
                Person member = new Person(members[0], int.Parse(members[1]));
                family.AddMember(member);
            }
            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
