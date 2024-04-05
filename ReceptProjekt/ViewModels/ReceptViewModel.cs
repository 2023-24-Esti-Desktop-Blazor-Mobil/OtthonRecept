using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HttpService.Service;
using Shared.Models;
using Shared.Responses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ReceptProjekt.ViewModels
{
    public partial class ReceptViewModel : BaseViewModel
    {
        private readonly IReceptService? _receptService;
        //private readonly IIngredientService? _ingredientService;

        [ObservableProperty] private Recept _selectedRecept;
        [ObservableProperty] private ObservableCollection<Recept> _receptek = new();
        //[ObservableProperty] private ObservableCollection<Ingredient> _ingredients = new();

        public ReceptViewModel()
        {
            SelectedRecept = new Recept();
        }

        public ReceptViewModel(IReceptService? receptService
            
            //IIngredientService? ingredientService
            )
        {
            _selectedRecept = new Recept();
            _receptService = receptService;
            //_ingredientService = ingredientService;
        }

        public async override Task InitializeAsync()
        {
            await UpdateView();
        }
        [RelayCommand]
        private async Task DoSave(Recept newRecept)
        {
            MessageBoxResult result = MessageBox.Show("Biztosan menteni kívánja a receptet?", "Recept mentése", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                if (_receptService is not null)
                {
                    ControllerResponse result1;
                    if (newRecept.HasId)
                        result1 = await _receptService.UpdateAsync(newRecept);
                    else
                        result1 = await _receptService.InsertAsync(newRecept);

                    if (!result1.HasError)
                    {
                        await UpdateView();
                    }
                }
            }
        }

        [RelayCommand]
        private async Task DoRemove(Recept receptToDelete)
        {
            MessageBoxResult result = MessageBox.Show("Biztosan törölni kívánja a receptet?", "Recept törlése", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                if (_receptService is not null)
                {
                    ControllerResponse result1 = await _receptService.DeleteAsync(receptToDelete.Id);
                    if (result1.IsSuccess)
                    {
                        await UpdateView();
                    }
                }
            }
        }

        [RelayCommand]
        private void DoNewRecept()
        {
            MessageBoxResult result = MessageBox.Show("Biztosan új receptet kíván rögzíteni?", "Új recept rögzítése", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                SelectedRecept = new Recept();
            }
        }

        private async Task UpdateView()
        {
            //if (_ingredientService is not null)
            //{
              //  List<Ingredient> ingredients = await _ingredientService.SelectAllAsync();
               // Ingredients = new ObservableCollection<Ingredient>(ingredients);
            //}
            if (_receptService is not null)
            {
                List<Recept> receptek = await _receptService.SelectAllIncluded();
                Receptek = new ObservableCollection<Recept>(receptek);
            }


        }
    }
}

