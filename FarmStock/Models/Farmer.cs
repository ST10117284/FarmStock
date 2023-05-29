using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

public class Farmer
{
    public int FarmerId { get; set; }

    [Required]
    public string FarmerName { get; set; }

    [Required]
    public string ProductName { get; set; }

    [Required]
    public string ProductType { get; set; }

    public string ProductDescription { get; set; }

    public DateTime DateCreated { get; set; }
}
