﻿using Nimble.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nimble.Data.Configuration
{
   
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            Property(g => g.Id).IsRequired();
            Property(g => g.DOB).IsRequired();
            Property(g => g.FirstName).IsRequired();
            Property(g => g.LastName).IsRequired();
            Property(g => g.Allowance).IsRequired();
            Property(g => g.Basic).IsRequired();
            Property(g => g.Communication).IsRequired(); 

            Property(g => g.PermanentCity);
            Property(g => g.PermanentCountry);
            Property(g => g.PermanentStreet);
            Property(g => g.PermanentStreet);

            Property(g => g.CurrentCity).IsRequired();
            Property(g => g.CurrentCountry).IsRequired();
            Property(g => g.CurrentState).IsRequired();
            Property(g => g.CurrentStreet).IsRequired();
        }
    }
}
