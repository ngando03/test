using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;

namespace MvcMovie.Models;

public class MvcMovie
{
    public int Id { get; set; }
    public string? Title {get; set;}
    [DataType(DataType.Date)]
    public DateTime ReleaseDate {get; set;}
    public string? Genre {get; set;}
    public decimal Price {get; set;}
}