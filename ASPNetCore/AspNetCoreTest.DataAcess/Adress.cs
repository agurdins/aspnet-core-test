using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreTest.DataAcess
{
    public class Adress
    {
        public int Id { get; set; }
        public string AdressStreet { get; set; }
        public int AdressNumber { get; set; }
        public string City { get; set; }
        public List<Person> People { get; set; }
    }
}
