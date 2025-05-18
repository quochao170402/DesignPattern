using System.ComponentModel.DataAnnotations;

namespace AbstractFactory.Enums;

public enum Style
{
    [Display(Name = "Art Deco")] ArtDeco,
    [Display(Name = "Victorian")] Victorian,
    [Display(Name = "Modern")] Modern
}