using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hvac.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServiceRecordMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public ServiceRecordMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new ServiceRecordMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class ServiceRecordMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ServiceRecordMasterDetailPageMenuItem> MenuItems { get; set; }
            
            public ServiceRecordMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<ServiceRecordMasterDetailPageMenuItem>(new[]
                {
                    new ServiceRecordMasterDetailPageMenuItem { Id = 0, Title = "Page 1" },
                    new ServiceRecordMasterDetailPageMenuItem { Id = 1, Title = "Page 2" },
                    new ServiceRecordMasterDetailPageMenuItem { Id = 2, Title = "Page 3" },
                    new ServiceRecordMasterDetailPageMenuItem { Id = 3, Title = "Page 4" },
                    new ServiceRecordMasterDetailPageMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}