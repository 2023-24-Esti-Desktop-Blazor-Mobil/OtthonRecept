using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ReceptProjekt.ViewModels
{
    public partial class ReceptViewModel : BaseViewModel
    {
        [ObservableProperty] private Recept _recipe;
        [ObservableProperty] private string _description;
        [ObservableProperty] private DateTime _idopont;
        //[ObservableProperty] private ObservableCollection<string> _measurements = new ObservableCollection<string>(new Measurements().AllMeasurementTypes);
        [ObservableProperty] private ObservableCollection<Ingredient> _ingredients = new ObservableCollection<Ingredient>();
        [ObservableProperty] private Ingredient _selectedIngredient;
        [ObservableProperty] private ObservableCollection<Recept> _receptek = new ObservableCollection<Recept>();

        public ReceptViewModel()
        {
            _selectedIngredient = new Ingredient();
            _recipe = new Recept();
        }
        private string _selectedMeasurementType = string.Empty;
        public string SelectedMeasurementType
        {
            get => _selectedMeasurementType;
            set
            {
                SetProperty(ref _selectedMeasurementType, value);
                
            }
        }

        [RelayCommand]
        void AddIngredient(Ingredient selectedIngredient)
        {
            //selectedIngredient.Id = Ingredients.Count;
            Ingredients.Add(selectedIngredient);
            OnPropertyChanged(nameof(Ingredients));
            SelectedIngredient = new Ingredient();
        }
        [RelayCommand]
        void RemoveIngredient(Ingredient selectedIngredient)
        {
            Ingredients.Remove(selectedIngredient);
            for (int newId = 0; newId < Ingredients.Count; newId++)
            {
                
                //Ingredients[newId].Id = newId;
            }
            OnPropertyChanged(nameof(Ingredients));
            SelectedIngredient = new Ingredient();
        }

        [RelayCommand]
        void EditIngredient(Ingredient selectedIngredient)
        {
            ObservableCollection<Ingredient> newIngredientList = new ObservableCollection<Ingredient>(Ingredients);
            Ingredient markForEditIngredient = newIngredientList.FirstOrDefault(x => x.Id == selectedIngredient.Id);
            markForEditIngredient = selectedIngredient;

            Ingredients = newIngredientList;
            /*int i = Ingredients.IndexOf(markForEditIngredient);
            Ingredients[i] = selectedIngredient;*/
            OnPropertyChanged(nameof(Ingredients));
            SelectedIngredient = new Ingredient();
        }
        [RelayCommand]
        public void DoNewRecipe() { Recipe = new Recept(); }


        [RelayCommand]
        public void DoSave(Recept recep)
        {
            Idopont = DateTime.Now;
            Idopont = recep.Idopont;
            Receptek.Add(recep);
            DoNewRecipe();
            }
        [RelayCommand]
        void DoEdit(Recept recipe)
        {
            ObservableCollection<Recept> newReceptList = new ObservableCollection<Recept>(Receptek);
            Recept markForEditRecept = newReceptList.FirstOrDefault(x => x.Name == recipe.Name);
            markForEditRecept = recipe;

            Receptek = newReceptList;
            OnPropertyChanged(nameof(Receptek));
            recipe = new Recept();
        }
        //private void UpLoad()
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Filter = "Image files | *.bmp; *.jpg; *.png";
        //    openFileDialog.FilterIndex = 1;
        //    if (openFileDialog.ShowDialog() == true)
        //    { imagePictures.Source = new BitmapImage(new Uri(openFileDialog.FileName)); };
        //}
        //[RelayCommand]
        //void DoSend()
        //{
        //  string message = "Biztos módosítod az adatbázist a szerveren?";
        //string titel = "ADATBÁZIS FRISSITÉS";
        //MessageBoxButton button = MessageBoxButton.OKCancel;
        //MessageBoxIcon icon = MessageBoxIcon.Warning;
        //MessageBoxResult result;
        //result = MessageBox.Show(message, titel, button, icon);
        //MessageBox.Show(result.ToString());
        //if (result == MessageBoxResult.OK) { }
        //else { }
        //}


    }
}
