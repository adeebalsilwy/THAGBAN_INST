﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace THAGBAN_INST.DATA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_max_instEntities : DbContext
    {
        public db_max_instEntities()
            : base("name=db_max_instEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_BUY> TB_BUY { get; set; }
        public virtual DbSet<TBL_ACTIVE_SYSTEM> TBL_ACTIVE_SYSTEM { get; set; }
        public virtual DbSet<TBL_ATTENDS> TBL_ATTENDS { get; set; }
        public virtual DbSet<TBL_CATEGORIES> TBL_CATEGORIES { get; set; }
        public virtual DbSet<TBL_COURS> TBL_COURS { get; set; }
        public virtual DbSet<TBL_DEPT> TBL_DEPT { get; set; }
        public virtual DbSet<TBL_EMPLOYEES> TBL_EMPLOYEES { get; set; }
        public virtual DbSet<TBL_FOLDER> TBL_FOLDER { get; set; }
        public virtual DbSet<TBL_GREIVANCES> TBL_GREIVANCES { get; set; }
        public virtual DbSet<TBL_HOLIDAY_TYPE> TBL_HOLIDAY_TYPE { get; set; }
        public virtual DbSet<TBL_HOLIDAYS> TBL_HOLIDAYS { get; set; }
        public virtual DbSet<TBL_INST> TBL_INST { get; set; }
        public virtual DbSet<TBL_JOB> TBL_JOB { get; set; }
        public virtual DbSet<TBL_LECT_COURS> TBL_LECT_COURS { get; set; }
        public virtual DbSet<TBL_LECT_MARK> TBL_LECT_MARK { get; set; }
        public virtual DbSet<TBL_LECT_MATRIAL> TBL_LECT_MATRIAL { get; set; }
        public virtual DbSet<TBL_LECT_TECH_COURS> TBL_LECT_TECH_COURS { get; set; }
        public virtual DbSet<TBL_LECTUER> TBL_LECTUER { get; set; }
        public virtual DbSet<TBL_LEVLE> TBL_LEVLE { get; set; }
        public virtual DbSet<TBL_MARKS> TBL_MARKS { get; set; }
        public virtual DbSet<TBL_OPRATION> TBL_OPRATION { get; set; }
        public virtual DbSet<TBL_OUT_OPTION> TBL_OUT_OPTION { get; set; }
        public virtual DbSet<TBL_OutCome> TBL_OutCome { get; set; }
        public virtual DbSet<TBL_PART_SALARY> TBL_PART_SALARY { get; set; }
        public virtual DbSet<TBL_ROULLS_LECTUER> TBL_ROULLS_LECTUER { get; set; }
        public virtual DbSet<TBL_SALARY> TBL_SALARY { get; set; }
        public virtual DbSet<TBL_SEND_STUD__COURS> TBL_SEND_STUD__COURS { get; set; }
        public virtual DbSet<TBL_SEND_STUD_LECT> TBL_SEND_STUD_LECT { get; set; }
        public virtual DbSet<TBL_SEND_STUD_SPEC> TBL_SEND_STUD_SPEC { get; set; }
        public virtual DbSet<TBL_SEND_TECT_LECT> TBL_SEND_TECT_LECT { get; set; }
        public virtual DbSet<TBL_SERVICE_TYPE> TBL_SERVICE_TYPE { get; set; }
        public virtual DbSet<TBL_SERVICES> TBL_SERVICES { get; set; }
        public virtual DbSet<TBL_SIRYAL_STUDENTS> TBL_SIRYAL_STUDENTS { get; set; }
        public virtual DbSet<TBL_SPE_COURS> TBL_SPE_COURS { get; set; }
        public virtual DbSet<TBL_SPECIAL> TBL_SPECIAL { get; set; }
        public virtual DbSet<TBL_STORS> TBL_STORS { get; set; }
        public virtual DbSet<TBL_STUD_LECT> TBL_STUD_LECT { get; set; }
        public virtual DbSet<TBL_STUD_SPEC> TBL_STUD_SPEC { get; set; }
        public virtual DbSet<TBL_STUD_STUDY_COURS> TBL_STUD_STUDY_COURS { get; set; }
        public virtual DbSet<TBL_STUDENTS> TBL_STUDENTS { get; set; }
        public virtual DbSet<TBL_SUPPLIERS> TBL_SUPPLIERS { get; set; }
        public virtual DbSet<TBL_SuppliersPayments> TBL_SuppliersPayments { get; set; }
        public virtual DbSet<TBL_TERMS> TBL_TERMS { get; set; }
        public virtual DbSet<TBL_USERS> TBL_USERS { get; set; }
        public virtual DbSet<TBL_YEARS> TBL_YEARS { get; set; }
        public virtual DbSet<TBL_YEARS_MARK> TBL_YEARS_MARK { get; set; }
    }
}
