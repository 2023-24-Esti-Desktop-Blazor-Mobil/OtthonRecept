using ReceptProjekt.ViewModels;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Data;

namespace ReceptProjekt.Views
{
    public partial class SzemelyView : UserControl
    {
        public SzemelyView()
        {
            InitializeComponent();
            //CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(SzemelyLista.ItemsSource);
            //view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));


        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (searchview.Visibility == System.Windows.Visibility.Collapsed)
            {
                searchview.Visibility = System.Windows.Visibility.Visible;
                searchgomb.Content = "Kilépés a keresésből";
            }
            else
            {
                searchview.Visibility = System.Windows.Visibility.Collapsed;
                searchgomb.Content = "Keresés";
            }
            }
    }
}
