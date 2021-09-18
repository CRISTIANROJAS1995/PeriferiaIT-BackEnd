//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Entities.User
{
    using System;
    using System.Collections.Generic;
    
    public partial class Goals
    {
        public Goals()
        {
            this.GoalBalance = new HashSet<GoalBalance>();
            this.GoalDetail = new HashSet<GoalDetail>();
            this.GoalTransaction = new HashSet<GoalTransaction>();
        }
    
        public int Id { get; set; }
        public int Emoji { get; set; }
        public string NameGoal { get; set; }
        public decimal TotalValue { get; set; }
        public int Periodicity { get; set; }
        public decimal CuoteValue { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int MonthNumber { get; set; }
    
        public virtual ICollection<GoalBalance> GoalBalance { get; set; }
        public virtual ICollection<GoalDetail> GoalDetail { get; set; }
        public virtual ICollection<GoalTransaction> GoalTransaction { get; set; }
    }
}
