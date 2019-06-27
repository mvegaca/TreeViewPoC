using TreeViewPoC.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TreeViewPoC.TemplateSelectors
{
    public class SampleDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CompanyTemplate { get; set; }

        public DataTemplate OrderTemplate { get; set; }

        public DataTemplate OrderDetailTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            switch (item)
            {
                case SampleCompanyViewModel company:
                    return CompanyTemplate;
                case SampleOrderViewModel order:
                    return OrderTemplate;
                case SampleOrderDetailViewModel orderDetail:
                    return OrderDetailTemplate;
            }

            return base.SelectTemplateCore(item);
        }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            switch (item)
            {
                case SampleCompanyViewModel company:
                    return CompanyTemplate;
                case SampleOrderViewModel order:
                    return OrderTemplate;
                case SampleOrderDetailViewModel orderDetail:
                    return OrderDetailTemplate;
            }

            return base.SelectTemplateCore(item, container);
        }
    }
}
