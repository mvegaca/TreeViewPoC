using TreeViewPoC.Core.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TreeViewPoC.TemplateSelectors
{
    public class SampleDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CompanyTemplate { get; set; }

        public DataTemplate OrderTemplate { get; set; }

        public DataTemplate OrderDetailTemplate { get; set; }

        public DataTemplate DataTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            return GetTemplate(item) ?? base.SelectTemplateCore(item);
        }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            return GetTemplate(item) ?? base.SelectTemplateCore(item, container);
        }

        private DataTemplate GetTemplate(object item)
        {
            switch (item)
            {
                case SampleCompany company:
                    return CompanyTemplate;
                case SampleOrder order:
                    return OrderTemplate;
                case SampleOrderDetail orderDetail:
                    return OrderDetailTemplate;
                case SampleData data:
                    return DataTemplate;
            }

            return null;
        }
    }
}
