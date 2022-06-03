using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApis.Code;
using XamarinApis.Views;

namespace XamarinApis
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainDoctores : MasterDetailPage
    {
        public MainDoctores()
        {
            InitializeComponent();
            ObservableCollection<MaterPageItem> menu = new ObservableCollection<MaterPageItem>
            {
                new MaterPageItem
                {
                    Titulo="Doctores",
                    Tipo = typeof(DoctoresView),
                    Icono = "sable.png"
                },

                new MaterPageItem
                {
                    Titulo="Favoritos",
                    Tipo=typeof(DoctoresFavoritosView),
                    Icono="bb8.png"
                },
                new MaterPageItem
                {
                    Titulo="Nuevo doctor",
                    Icono="clone.png"
                }
            };

            //DEBEMOS PONER UNA PAGINA COMO PRESENTACION

            this.lsvMenu.ItemsSource = menu;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MainPage)));
            this.lsvMenu.ItemSelected += LsvMenu_ItemSelected;
        }

        private void LsvMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}