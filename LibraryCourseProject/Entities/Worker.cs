using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
   public class Worker
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public double Salary { get; set; }
        public Filial Filial { get; set; }
        public int Filial_Id { get; set; }
        public string Note { get; set; } = "empty";

        public Worker Clone()
        {
            Worker worker = new Worker()
            {
                 Age=this.Age,
                  Filial=this.Filial,
                   Filial_Id=this.Filial_Id ,
                    Id=this.Id,
                     Name=this.Name,
                      No=this.No,
                       Note=this.Note,
                        PhoneNumber=this.PhoneNumber,
                         Salary=this.Salary,
                          Surname=this.Surname
            };
            return worker;
        }
    }
}

