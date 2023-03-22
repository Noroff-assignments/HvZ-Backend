using System.ComponentModel.DataAnnotations;

namespace hvz_backend.Models.Enums
{
    public enum ItemType
    {
        [Display(Name = "Generade")]
        GENERADE,
        [Display(Name = "Nerfgun")]
        NERFGUN,
        [Display(Name = "Ammo")]
        AMMO
    }
}
