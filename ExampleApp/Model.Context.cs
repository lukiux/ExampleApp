﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExampleApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PACK_PACKING> PACK_PACKING { get; set; }
        public virtual DbSet<PACK_WASHINGLABELS> PACK_WASHINGLABELS { get; set; }
    
        public virtual int INCREASE_BOXHEIGHT_BY_100(Nullable<decimal> iD, Nullable<decimal> bOXHEI)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(decimal));
    
            var bOXHEIParameter = bOXHEI.HasValue ?
                new ObjectParameter("BOXHEI", bOXHEI) :
                new ObjectParameter("BOXHEI", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INCREASE_BOXHEIGHT_BY_100", iDParameter, bOXHEIParameter);
        }
    
        public virtual int OUTPARAM(ObjectParameter oUTP)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("OUTPARAM", oUTP);
        }
    
        public virtual ObjectResult<SELECT_PACK_PACKING_BY_ID_Result> SELECT_PACK_PACKING_BY_ID(string p_ID)
        {
            var p_IDParameter = p_ID != null ?
                new ObjectParameter("P_ID", p_ID) :
                new ObjectParameter("P_ID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SELECT_PACK_PACKING_BY_ID_Result>("SELECT_PACK_PACKING_BY_ID", p_IDParameter);
        }
    }
}
