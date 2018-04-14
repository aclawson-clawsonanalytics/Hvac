﻿using System;
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
    public partial class CalculationsMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public CalculationsMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new CalculationsMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class CalculationsMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<CalculationsMasterDetailPageMenuItem> MenuItems { get; set; }
            
            public CalculationsMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<CalculationsMasterDetailPageMenuItem>(new[]
                {
                    new CalculationsMasterDetailPageMenuItem { Id = 0, Title = "Home" },
                    new CalculationsMasterDetailPageMenuItem { Id = 1, Title = "Air Flow" },
                    new CalculationsMasterDetailPageMenuItem { Id = 2, Title = "Refrigerant" },
                    new CalculationsMasterDetailPageMenuItem { Id = 3, Title = "Electrical" },
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