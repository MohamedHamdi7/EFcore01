using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EF_ASSIGNMENT01.Entity_ITI
{
    internal class Instructor
    {
        public int ID { get; set; }
        public string  NAme { get; set; }
        public string Address { get; set; }
    }

    class Depertment
    {
        public int Id { get; set; }
        public string  Name { get; set; }   

    }

    [Table("Courses")]
    class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CrsId { get; set; }

        [MaxLength(50) ]
        [Required]
        public String Name { get; set; }

        [Column(TypeName="money")]
        [DataType(DataType.Currency)]
        public double Cost { get; set; }

    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long Number { get; set; }

    }

    class Topic
    {
        public int ID { get; set; }
        public String Name { get; set; }
    }



}
