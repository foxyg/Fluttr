using System;

namespace API.DTOs;

public class PhotoDto
{
    public required string Id { get; set; } 
    public string? Url { get; set; }
    public bool IsMain { get; set; }
}
