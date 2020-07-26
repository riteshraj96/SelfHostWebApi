using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Model
{
    public class Data
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string EmailId { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }

        public Data(String firstname, string secondname, string emailid, string gender, DateTime dob)
        {
            this.FirstName = firstname;
            this.SecondName = secondname;
            this.EmailId = emailid;
            this.Gender = gender;
            this.Dob = dob;
        }
    }
}
