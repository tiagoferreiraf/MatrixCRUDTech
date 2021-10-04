using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixCRUDTech.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName="nvarchar(250)")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        [DisplayName("Nome")]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Matricula")]
        public int EmpCode { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Cargo")]
        public int Position { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Localização")]
        public int OfficeLocation { get; set; }
    }
}
