﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PerceptronXfmsAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PerceptronXfmsDatabaseEntities : DbContext
    {
        public PerceptronXfmsDatabaseEntities()
            : base("name=PerceptronXfmsDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ResultsVisualize> ResultsVisualizes { get; set; }
        public virtual DbSet<SearchResultsFile> SearchResultsFiles { get; set; }
        public virtual DbSet<SearchXfmsQuery> SearchXfmsQueries { get; set; }
    }
}
