﻿using System.ComponentModel.DataAnnotations;

namespace Spring.Models;

public class Furniture
{
    public int Id { get; set; }
    public string? Name { get; set; }
  
    public string? Type { get; set; }
    public decimal Price { get; set; }
}