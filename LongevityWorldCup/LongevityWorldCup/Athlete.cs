using System;
using System.Collections;
using System.Net.Mime;
using Avalonia.Media;

namespace LongevityWorldCup;

public class Athlete
{
    public string Name { get; set; }
    public int Rank { get; set;}
    public string Sponsor { get;set; }
    public double AgeReduction { get;set; }
    public MediaContact MediaContact { get;set; }
    public IImage Picture { get; set; }
}

public class MediaContact
{
}