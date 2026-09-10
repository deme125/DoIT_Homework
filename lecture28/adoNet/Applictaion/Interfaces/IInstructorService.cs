using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Applictaion.Interfaces
{
    public interface IInstructorService
    {
        IEnumerable<Instructor> GetInstructors();
        Instructor? GetInstructorById(int id);
        bool CreateInstructor(Instructor instructor);
        bool UpdateInstructor(Instructor instructor);
        bool DeleteInstructor(int id);
    }
}
