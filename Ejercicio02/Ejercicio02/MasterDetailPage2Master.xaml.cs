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

namespace Ejercicio02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage2Master : ContentPage
    {
        public ListView ListView;

        public MasterDetailPage2Master()
        {
            InitializeComponent();

            BindingContext = new MasterDetailPage2MasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailPage2MasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailPage2MenuItem> MenuItems { get; set; }
            
            public MasterDetailPage2MasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailPage2MenuItem>(new[]
                {
                    new MasterDetailPage2MenuItem { Id = 0, Title = "Page 1" },
                    new MasterDetailPage2MenuItem { Id = 1, Title = "Page 2" },
                    new MasterDetailPage2MenuItem { Id = 2, Title = "Page 3" },
                    new MasterDetailPage2MenuItem { Id = 3, Title = "Page 4" },
                    new MasterDetailPage2MenuItem { Id = 4, Title = "Page 5" },
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