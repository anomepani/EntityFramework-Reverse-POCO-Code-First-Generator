// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.com/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Registered to: Simon Hughes
// Company      : Reverse POCO
// Licence Type : Commercial
// Licences     : 1
// Valid until  : 03 NOV 2020
//
// Do not make changes directly to this file - edit the template instead.
//
// The following connection settings were used to generate this file:
//     Connection String Name: "McsfMultiDatabase"
//     Connection String:      "Data Source=(local);Initial Catalog=EfrpgTest;Integrated Security=True"
//     Multi-context settings: "Data Source=(local);Initial Catalog=EfrpgTest_Settings;Integrated Security=True"
// ------------------------------------------------------------------------------------------------
// Database Edition       : Developer Edition (64-bit)
// Database Engine Edition: Enterprise
// Database Version       : 14.0.2027.2

// <auto-generated>
// ReSharper disable CheckNamespace
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable NotAccessedVariable
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantCast
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// ReSharper disable UsePatternMatching
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Spatial;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Multi_context_single_filesBananaDbContext
{
    #region Database context interface

    public interface IBananaDbContext : IDisposable
    {
        DbSet<Stafford_ComputedColumn> Stafford_ComputedColumns { get; set; } // ComputedColumns

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbChangeTracker ChangeTracker { get; }
        DbContextConfiguration Configuration { get; }
        Database Database { get; }
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        DbEntityEntry Entry(object entity);
        IEnumerable<DbEntityValidationResult> GetValidationErrors();
        DbSet Set(Type entityType);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();
    }

    #endregion

    #region Database context

    public class BananaDbContext : DbContext, IBananaDbContext
    {
        public DbSet<Stafford_ComputedColumn> Stafford_ComputedColumns { get; set; } // ComputedColumns

        static BananaDbContext()
        {
            System.Data.Entity.Database.SetInitializer<BananaDbContext>(null);
        }

        /// <inheritdoc />
        public BananaDbContext()
            : base("Name=McsfMultiDatabase")
        {
        }

        /// <inheritdoc />
        public BananaDbContext(string connectionString)
            : base(connectionString)
        {
        }

        /// <inheritdoc />
        public BananaDbContext(string connectionString, DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        /// <inheritdoc />
        public BananaDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        /// <inheritdoc />
        public BananaDbContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        /// <inheritdoc />
        public BananaDbContext(ObjectContext objectContext, bool dbContextOwnsObjectContext)
            : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == DBNull.Value);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new Stafford_ComputedColumnConfiguration());

            // Indexes        
            modelBuilder.Entity<Stafford_ComputedColumn>()
                .Property(e => e.id)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("PK_Stafford_ComputedColumns", 1) { IsUnique = true, IsClustered = true })
                );

        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new Stafford_ComputedColumnConfiguration(schema));

            return modelBuilder;
        }
    }

    #endregion

    #region Database context factory

    public class BananaDbContextFactory : IDbContextFactory<BananaDbContext>
    {
        public BananaDbContext Create()
        {
            return new BananaDbContext();
        }
    }

    #endregion

    #region POCO classes

    // ComputedColumns
    public class Stafford_ComputedColumn
    {
        public int id { get; set; } // Id (Primary key)
        public string MyColumn { get; set; } // MyColumn (length: 10)
    }


    #endregion

    #region POCO Configuration

    // ComputedColumns
    public class Stafford_ComputedColumnConfiguration : EntityTypeConfiguration<Stafford_ComputedColumn>
    {
        public Stafford_ComputedColumnConfiguration()
            : this("Stafford")
        {
        }

        public Stafford_ComputedColumnConfiguration(string schema)
        {
            ToTable("ComputedColumns", schema);
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.MyColumn).HasColumnName(@"MyColumn").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
        }
    }


    #endregion

}
// </auto-generated>


