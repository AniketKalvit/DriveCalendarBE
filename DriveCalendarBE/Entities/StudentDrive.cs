﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DriveCalendarBE.Entities
{
    [Table("tblStudentDrive")]
    public class StudentDrive
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int DriveId { get; set; }
        public int StatusId { get; set; }
    }
}
