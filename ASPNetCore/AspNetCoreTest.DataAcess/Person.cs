using System;

namespace AspNetCoreTest.DataAcess
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public Adress Adress { get; set; }
        public bool IsMale { get; set; }
    }
}
