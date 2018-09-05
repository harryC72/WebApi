using IssueTrackerShared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IssueTracker.Dto
{
    public class IssueDto
    {
        public int Id { get; set; }

        [Required]
        public DateTime? ReportedOn { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        public int? DepartmentId { get; set; }

        [Required]
        public string DescriptionOfProblem { get; set; }

        [Required]
        public Issue.SeverityLevel? Severity { get; set; }

        public bool Reproducible { get; set; }



        public Issue ToModel()
        {
            return new Issue()
            {
                Id = Id,
                ReportedOn = ReportedOn.Value,
                Name = Name,
                Email = Email,
                DepartmentId = DepartmentId.Value,
                Severity = Severity.Value,
                Reproducible = Reproducible,
                DescriptionOfProblem = DescriptionOfProblem,

            };
        }

    }
}