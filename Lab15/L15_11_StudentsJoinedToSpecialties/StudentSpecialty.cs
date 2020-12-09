using System;
using System.Collections.Generic;
using System.Text;

namespace L15_11_StudentsJoinedToSpecialties
{
    class StudentSpecialty
    {
        public string SpecialityName { get; set; }
        public int FacultyNumber { get; set; }
        public StudentSpecialty(string specialty, int faculty)
        {
            SpecialityName = specialty;
            FacultyNumber = faculty;
        }
    }
}
