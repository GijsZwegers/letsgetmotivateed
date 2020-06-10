using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using NpgsqlTypes;

namespace LetsGetMotivated.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; private set; }
        [Required]
        public string Name { get; private set; }
        [Required]
        public string Description { get; private set; }
        [Required]
        public DateTime StartDate { get; private set; }
        [Required]
        public DateTime FinishedDate { get; private set; }
        [Required]
        public DateTime PlannedDate { get; private set; }

        public Tasks(int id, string name, string description, DateTime startDate, DateTime finishedDate, DateTime plannedDate)
        {
            Id = id;
            Name = name;
            Description = description;
            StartDate = startDate;
            FinishedDate = finishedDate;
            PlannedDate = plannedDate;
        }

        public Tasks()
        {
        }
    }
}
