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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ReceptProjekt.ViewModels
{
    public partial class ReceptViewModel : BaseViewModel
    {
        private readonly IReceptService? _receptService;
        private readonly IIngredientService? _ingredientService;

        [ObservableProperty] private Recept _selectedRecept;
        [ObservableProperty] private ObservableCollection<Recept> _receptek = new();
        [ObservableProperty] private ObservableCollection<Ingredient> _ingredients = new();

        public ReceptViewModel()
        {
            _selectedRecept = new Recept();
        }

        public ReceptViewModel(IReceptService? receptService, IIngredientService? ingredientService)
        {
            _selectedRecept = new Recept();
            _receptService = receptService;
            _ingredientService = ingredientService;
        }

        public async override Task InitializeAsync()
        {
            await UpdateView();
        }
        [RelayCommand]
        private async Task DoSave(Recept newRecept)
        {
            if (_receptService is not null)
            {
                ControllerResponse result;
                if (newRecept.HasId)
                    result = await _receptService.UpdateAsync(newRecept);
                else
                    result = await _receptService.InsertAsync(newRecept);

                if (!result.HasError)
                {
                    await UpdateView();
                }
            }
        }

        [RelayCommand]
        private async Task DoRemove(Recept receptToDelete)
        {
            if (_receptService is not null)
            {
                ControllerResponse result = await _receptService.DeleteAsync(receptToDelete.Id);
                if (result.IsSuccess)
                {
                    await UpdateView();
                }
            }
        }

        [RelayCommand]
        private void DoNewRecept()
        {
            SelectedRecept = new Recept();
        }

        private async Task UpdateView()
        {
            if (_ingredientService is not null)
            {
                List<Ingredient> ingredients = await _ingredientService.SelectAllAsync();
                Ingredients = new ObservableCollection<Ingredient>(ingredients);
            }
            if (_receptService is not null)
            {
                List<Recept> receptek = await _receptService.SelectAllIncluded();
                Receptek = new ObservableCollection<Recept>(receptek);
            }


        }
    }
}

