using Applictaion.Interfaces;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Applictaion.Services
{
    public class InstructorService : IInstructorService
    {
        private readonly IInstructorRepository _instructorRepository;

        public InstructorService(IInstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }

        public bool CreateInstructor(Instructor instructor)
        {
            if (instructor == null)
            {
                throw new ArgumentNullException(nameof(instructor), "Instructor cannot be null.");
            }
            if(string.IsNullOrWhiteSpace(instructor.Email) || !instructor.Email.Contains("@"))
            {
                throw new ArgumentException("A valid email address is required.");
            }
            if (string.IsNullOrWhiteSpace(instructor.FirstName) || string.IsNullOrWhiteSpace(instructor.LastName))
                throw new ArgumentException("First and Last name are required.");

            return _instructorRepository.CreateInstructor(instructor);
        }

        public bool DeleteInstructor(int id)
        {
            if(id <= 0)
                throw new ArgumentException("ID must be greater than zero.", nameof(id));
            return _instructorRepository.DeleteInstructor(id);
        }

        public Instructor? GetInstructorById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID must be greater than zero.", nameof(id));
            }
            return _instructorRepository.GetByID(id);
        }

        public IEnumerable<Instructor> GetInstructors()
        {
            return _instructorRepository.GetAllInstructors();
        }

        public bool UpdateInstructor(Instructor instructor)
        {
            if(instructor == null)
                throw new ArgumentNullException(nameof(instructor), "Instructor cannot be null.");

            if (instructor.Id <= 0)
                throw new ArgumentException("Instructor ID must be greater than zero.", nameof(instructor.Id));

            var existing = _instructorRepository.GetByID(instructor.Id);
            if (existing == null)
                return false;
            return _instructorRepository.UpdateInstructor(instructor);
        }
    }
}
