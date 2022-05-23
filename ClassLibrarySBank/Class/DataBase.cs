using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySBank.Class
{
    public class DataBase
    {
        public List<User> users = new List<User>
        {
            new User{Email = "xnox.45@hotmail.com", Password="123456", Person = new Person{ TaxNumber = "123456" } },
            new User{Email = "alef.natan@devbank.com", Password="123456",Person = new Person{ TaxNumber = "40028922" }},
            new User{Email = "wescley.nascimento@devBank.com", Password="123456", Person = new Person{ TaxNumber = "32222121" }}
        };

        public List<Person> persons = new List<Person>
        {
            new Person{Name = "Frederick Aquino", TaxNumber = "123456", BirthDate = DateTime.Parse("02/10/2002")},
            new Person{Name = "alef natan", TaxNumber = "40028922", BirthDate = DateTime.Parse("02/10/2002")},
            new Person{Name = "wescley nascimento", TaxNumber = "32222121", BirthDate = DateTime.Parse("02/10/2002")},
        };

        public List<Account> accounts = new List<Account>
        {
            new Account{Amout = 10000,Credit = 2000, TaxNumber = "123456"},
            new Account{Amout = 5000,Credit = 1000, TaxNumber = "40028922"},
            new Account{Amout = 5000,Credit = 1000, TaxNumber = "32222121"},
        };
    }
}
