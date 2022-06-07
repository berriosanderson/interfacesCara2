using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesCara
{
  internal class Student
  {

    private string FirstN { get; set; }
    private string LastN { get; set; }
    private string Specialty { get; set; }

    #region constructores 

    public Student(string firstname, string lastname, string empnumber)
    {
      FirstN = firstname;
      LastN = lastname;
      Specialty = empnumber;
    }

    #endregion

  }
}
