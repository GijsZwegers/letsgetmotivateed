using LetsGetMotivated.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsGetMotivated.DAL.Maps
{
    public class TasksMap
    {
        //private EntityTypeBuilder<Tasks> entityBuilder;

        public TasksMap(EntityTypeBuilder<Tasks> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.ToTable("tasks");

            entityBuilder.Property(x => x.Id).HasColumnName("id");
            entityBuilder.Property(x => x.Name).HasColumnName("name");
            entityBuilder.Property(x => x.Description).HasColumnName("description");
            entityBuilder.Property(x => x.StartDate).HasColumnName("startdate");
            entityBuilder.Property(x => x.FinishedDate).HasColumnName("finisheddate");
            entityBuilder.Property(x => x.PlannedDate).HasColumnName("planneddate");
        }
    }
}
