using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AspNetCoreTest.DataAcess.Tests
{
    [TestClass]
    public class PersonRepositoryTests
    {
        [TestMethod]
        public async Task AddNewPerson_ReturnsOk()
        {
            var repository = new PersonRepository();

            var person = new Person()
            {
                Name = "Eu",
                Surname = "Zaïð",
                Email = "Smçíçjam?",
                Age = 1,
                Adress = new Adress
                {
                    AdressNumber = 3,
                    AdressStreet = "Tante",
                    City = "Riga"
                },
                IsMale = true
            };

            await repository.AddAsync(person);
        }

        [TestMethod]
        public void GetSpecificPerson_ReturnsPerson()
        {
            var repository = new PersonRepository();

            var result = repository.GetByName("Eu");

            Assert.AreEqual(4, result.Count);
        }

        [TestMethod]
        public void GetSpecificPerson_ReturnsNoPerson()
        {
            var repository = new PersonRepository();

            var result = repository.GetByName("Dabi");

            Assert.AreEqual(0, result.Count);
        }
    }
}
