//------------------------------------------------------------------------------
// <auto-generated>
// </auto-generated>
//------------------------------------------------------------------------------




using System.Data.Entity.ModelConfiguration;
using System.Runtime.Serialization;
using Core.Entities;

namespace DataAccess.UserModule.UnitOfWork.Mapping
{
    using System;
    using System.Collections.Generic;
    
    public partial class StatusMapping:EntityTypeConfiguration<Core.Entities.User.Status>
    {
        
        public StatusMapping()
        {
                // Primary Key
                this.HasKey(t => t.Id);
    
    
                // Properties
     
                    this.Property(t => t.Name).IsRequired()
    .HasMaxLength(50);
    
    
    
                this.ToTable("Status","dbo");
        this.Property(t => t.Id).HasColumnName("Id");
        this.Property(t => t.Name).HasColumnName("Name");
        this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
    
    
        }
    
        
        
        
    
        
        
        
        
    }
}
