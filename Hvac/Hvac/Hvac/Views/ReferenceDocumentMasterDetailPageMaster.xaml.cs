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
    public partial class ReferenceDocumentMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public ReferenceDocumentMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new ReferenceDocumentMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class ReferenceDocumentMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ReferenceDocumentMasterDetailPageMenuItem> MenuItems { get; set; }
            
            public ReferenceDocumentMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<ReferenceDocumentMasterDetailPageMenuItem>(new[]
                {
                    new ReferenceDocumentMasterDetailPageMenuItem { Id = 0, Title = "Home" },
                    new ReferenceDocumentMasterDetailPageMenuItem { Id = 1, Title = "Library" },
                    new ReferenceDocumentMasterDetailPageMenuItem { Id = 2, Title = "Service Manuals" },
                    new ReferenceDocumentMasterDetailPageMenuItem { Id = 3, Title = "Charts" },
                    new ReferenceDocumentMasterDetailPageMenuItem { Id = 4, Title = "Misc." },            
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