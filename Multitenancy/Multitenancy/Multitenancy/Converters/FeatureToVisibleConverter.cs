using Multitenancy.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Multitenancy.Converters
{
    public class FeatureToVisibleConverter : IValueConverter
    {
        public ITenantService TenantService { get; set; }
        public FeatureToVisibleConverter(ITenantService tenantService)
        {
            TenantService = tenantService;
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return TenantService.ExistingFeature((string)parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
