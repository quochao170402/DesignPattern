using System.ComponentModel.DataAnnotations;

namespace AbstractFactory.Enums;

public enum Type
{
    [Display(Name = "Chair")]
    Chair,
    [Display(Name = "Sofa")]
    Sofa,
    [Display(Name = "Table")]
    Table
}
