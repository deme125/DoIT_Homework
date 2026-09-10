using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IInstructorRepository
    {
        /* 
         Get / Read: ყველა ინსტრუქტორის სიის წაკითხვა და გამოსახვა;

§ GetById: ინსტრუქტორის წამოღება უნიკალური ID-ის მიხედვით;

§ Create / Insert: ახალი ინსტრუქტორის დამატება ბაზაში;

§ Update: არსებული ინსტრუქტორის მონაცემების რედაქტირება/განახლება;

§ Delete: ინსტრუქტორის წაშლა ბაზიდან.*/

        IEnumerable<Instructor> GetAllInstructors();
        Instructor GetByID(int id);
        bool CreateInstructor(Instructor instructor);
        bool UpdateInstructor(Instructor instructor);
        bool DeleteInstructor(int id);
    }
}
