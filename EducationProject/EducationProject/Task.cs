//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EducationProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskUrl { get; set; }
        public string TaskStartDate { get; set; }
        public int TaskDuration { get; set; }
        public int TaskPoint { get; set; }
        public string TaskDetails { get; set; }
        public int TaskCategoryId { get; set; }
        public int StudentId { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual TaskCategory TaskCategory { get; set; }
    }
}
