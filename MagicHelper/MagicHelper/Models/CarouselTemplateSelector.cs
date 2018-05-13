using MagicHelper.Views;
using Xamarin.Forms;

namespace MagicHelper.Models
{
    public class CarouselTemplateSelector : DataTemplateSelector
    {
        private static int CreatedPagesCounter { get; set; }

        public DataTemplate ImageTemplate { get; set; }
        public DataTemplate InformationTemplate { get; set; }
        public DataTemplate RulingTemplate { get; set; }

        public CarouselTemplateSelector()
        {
            
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            switch (CreatedPagesCounter)
            {
                case 1:
                    CreatedPagesCounter++;
                    return InformationTemplate = new DataTemplate(typeof(CarouselInformationView));
                case 2:
                    CreatedPagesCounter = 0;
                    return RulingTemplate = new DataTemplate(typeof(CarouselRulingView));
            }
            return ImageTemplate = new DataTemplate(typeof(CarouselImageView));
        }
    }
}