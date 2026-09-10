using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Instructor
    {
        /*
         CREATE TABLE [dbo].[INSTRUCTORS](
	[IstructorID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[Email] [varchar](50) NOT NULL,

        */

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "Instructor ID: " + Id + ", Name: " + FirstName + " " + LastName + ", Email: " + Email;
        }
    }
}
