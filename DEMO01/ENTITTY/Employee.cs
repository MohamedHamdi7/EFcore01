using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO01.ENTITTY
{

    //Efcore suppert 4 ways to mapping classes to DB(Table -View- Function)
    //1- by convention(default behaviour) any class to table
    //2-Data Annotation (Set of Attributes Used for data validation



    //internal class Employee
    //{

    //    //table named :Employees
    //    public  int ID { get; set; } //public numeric property named ID or (Name of class+ID)/ REQUERID(NOT ALLOW NULL)
    //    public string  Name { get; set; } //REFERENCE TYPE :REQUIRED (NOT ALLOW NULL) /NVARCHAR(MAX)
    //    public double  Salary { get; set; } // VALUE TYPE: float(salary)/ Required
    //    public int? Age { get; set; } //VALUE TYPE : OPTIONAL / INT AGE
    //    public String?  Email { get; set; } // REFERENCE TYPE : OPTIONAL /NVARCHAR(MAX)
    //    public DateTime Dateofcreation { get; set; }  // datetime2/ required
    //}




    // by Data Annotation
    //[Table("hamada",Schema ="dbo")]
    internal class Employee
    {

        [Key]  //primary key 
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //identity none
        public int EmpId { get; set; }

        [Required]
        [Column("hamada",TypeName ="Varchar")]
        [MaxLength(50)]
        [StringLength(50,MinimumLength =20)]
    
        public string Name { get; set; }

        [Column(TypeName ="money")]
        [DataType(DataType.Currency)]
        public double Salary { get; set; }

        [Range(20,50)] // validation based on atrributes not mean for DB
        public int? Age { get; set; }

        [EmailAddress]
        public String? Email { get; set; }

        [Phone]
        [DataType(DataType.PhoneNumber)]
        public int Phonenumber { get; set; }
        [NotMapped]
        public double Totalsalary { get; set; }
        public DateTime Dateofcreation { get; set; }  
    }


    class Department
    {
        public int ID { get; set; }
        public string Salary { get; set; }
    }
}
