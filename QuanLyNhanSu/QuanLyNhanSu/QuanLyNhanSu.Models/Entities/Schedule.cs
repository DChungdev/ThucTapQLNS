﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuanLyNhanSu.Models.Entities;

[Table("Schedule")]
public partial class Schedule
{
    [Key]
    public int ScheduleId { get; set; }

    [Column(TypeName = "date")]
    public DateTime WorkingDate { get; set; }

    [Column(TypeName = "text")]
    public string MorningActivity { get; set; }

    [Column(TypeName = "text")]
    public string AfternoonActivity { get; set; }

    [Column(TypeName = "text")]
    public string EveningActivity { get; set; }

    public int? EmployeeId { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("Schedules")]
    public virtual Employee Employee { get; set; }
}