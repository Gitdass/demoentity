﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace democlasslib
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dassEntities : DbContext
    {
        public dassEntities()
            : base("name=dassEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employer> Employers { get; set; }
        public virtual DbSet<JSeeker> JSeekers { get; set; }
    
        [DbFunction("dassEntities", "ShowAllDetails")]
        public virtual IQueryable<ShowAllDetails_Result> ShowAllDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ShowAllDetails_Result>("[dassEntities].[ShowAllDetails]()");
        }
    
        public virtual int InsertData(string p_FirstName, string p_MiddleName, string p_LastName, string p_City, string p_State, string p_Country)
        {
            var p_FirstNameParameter = p_FirstName != null ?
                new ObjectParameter("p_FirstName", p_FirstName) :
                new ObjectParameter("p_FirstName", typeof(string));
    
            var p_MiddleNameParameter = p_MiddleName != null ?
                new ObjectParameter("p_MiddleName", p_MiddleName) :
                new ObjectParameter("p_MiddleName", typeof(string));
    
            var p_LastNameParameter = p_LastName != null ?
                new ObjectParameter("p_LastName", p_LastName) :
                new ObjectParameter("p_LastName", typeof(string));
    
            var p_CityParameter = p_City != null ?
                new ObjectParameter("p_City", p_City) :
                new ObjectParameter("p_City", typeof(string));
    
            var p_StateParameter = p_State != null ?
                new ObjectParameter("p_State", p_State) :
                new ObjectParameter("p_State", typeof(string));
    
            var p_CountryParameter = p_Country != null ?
                new ObjectParameter("p_Country", p_Country) :
                new ObjectParameter("p_Country", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertData", p_FirstNameParameter, p_MiddleNameParameter, p_LastNameParameter, p_CityParameter, p_StateParameter, p_CountryParameter);
        }
    
        public virtual int Updatedata(Nullable<int> p_Jid, string p_FirstName, string p_MiddleName, string p_LastName, string p_City, string p_State, string p_Country)
        {
            var p_JidParameter = p_Jid.HasValue ?
                new ObjectParameter("p_Jid", p_Jid) :
                new ObjectParameter("p_Jid", typeof(int));
    
            var p_FirstNameParameter = p_FirstName != null ?
                new ObjectParameter("p_FirstName", p_FirstName) :
                new ObjectParameter("p_FirstName", typeof(string));
    
            var p_MiddleNameParameter = p_MiddleName != null ?
                new ObjectParameter("p_MiddleName", p_MiddleName) :
                new ObjectParameter("p_MiddleName", typeof(string));
    
            var p_LastNameParameter = p_LastName != null ?
                new ObjectParameter("p_LastName", p_LastName) :
                new ObjectParameter("p_LastName", typeof(string));
    
            var p_CityParameter = p_City != null ?
                new ObjectParameter("p_City", p_City) :
                new ObjectParameter("p_City", typeof(string));
    
            var p_StateParameter = p_State != null ?
                new ObjectParameter("p_State", p_State) :
                new ObjectParameter("p_State", typeof(string));
    
            var p_CountryParameter = p_Country != null ?
                new ObjectParameter("p_Country", p_Country) :
                new ObjectParameter("p_Country", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Updatedata", p_JidParameter, p_FirstNameParameter, p_MiddleNameParameter, p_LastNameParameter, p_CityParameter, p_StateParameter, p_CountryParameter);
        }
    }
}