﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace BlazorSimpleSurvey.Models
{
    public partial class Survey
    {
        public Survey()
        {
            SurveyItem = new HashSet<SurveyItem>();
        }

        public int Id { get; set; }
        public string SurveyName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int UserId { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<SurveyItem> SurveyItem { get; set; }
    }
}