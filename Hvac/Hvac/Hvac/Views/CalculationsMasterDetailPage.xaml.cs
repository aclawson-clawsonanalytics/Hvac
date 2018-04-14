using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hvac.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculationsMasterDetailPage : MasterDetailPage
    {
        public CalculationsMasterDetailPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as CalculationsMasterDetailPageMenuItem;
            if (item == null)
                return;

            if (item.Title == "Home")
            {
                Application.Current.MainPage = new HomeMasterDetailPage();
            }
            else
            {
                var page = (Page)Activator.CreateInstance(item.TargetType);
                page.Title = item.Title;

                Detail = new NavigationPage(page);
                IsPresented = false;

                MasterPage.ListView.SelectedItem = null;
            }            
        }
    }
}