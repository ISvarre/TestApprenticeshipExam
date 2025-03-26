using System.ComponentModel.DataAnnotations;
using PrøveFagprøve.Business.Rendering;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace PrøveFagprøve.Models.Pages
{
    public abstract class Destinasjon : SitePageData
    {
        [Display(
            GroupName =SystemTabNames.Content,
            Order = 100)]
        [UIHint(UIHint.Image)]

        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
        public virtual string Adresse { get; set; }
        public virtual string Postnummer { get; set; }
        public virtual string Poststed { get; set; }
        public virtual string Pris { get; set; }
    }
}
