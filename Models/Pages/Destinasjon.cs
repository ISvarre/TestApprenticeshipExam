using System.ComponentModel.DataAnnotations;
using PrøveFagprøve.Business.Rendering;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using EPiServer.Web.Routing;

namespace PrøveFagprøve.Models.Pages
{
    public abstract class Destinasjon : SitePageData
    {
        [Display(
            Name = "Beskrivelse",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string Description { get; set; }
        
        
        [Display(
            Name = "Adresse",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string Adresse { get; set; }
        
        [Display(
            Name = "Postnummer",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string Postnummer { get; set; }
        
        [Display(
            Name = "Poststed",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string Poststed { get; set; }
        
        [Display(
            Name = "Åpningstider",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual string OpeningTime { get; set; }
        
        [Display(
            Name = "Pris",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        public virtual string Pris { get; set; }
        
        [UIHint(UIHint.Image)]
        [Display(
            Name = "Bilde",
            GroupName = SystemTabNames.Content,
            Order = 60)]
        public virtual ContentReference Image { get; set; }
        
        [Display(
            Name = "Innhold",
            GroupName = SystemTabNames.Content,
            Order = 70)]
        public virtual XhtmlString MainBody { get; set; }

        public string GetImageUrl(UrlResolver urlResolver)
        {
            return Image != null ? urlResolver.GetUrl(Image) : string.Empty;
        }

        #region Hide
        
        [ScaffoldColumn(false)]
        public override string TeaserText { get; set; }

        [ScaffoldColumn(false)]
        public override ContentReference PageImage { get; set; }
        
        
        #endregion
    }
}
