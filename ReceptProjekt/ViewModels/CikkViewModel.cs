using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using Microsoft.Extensions.Primitives;
using Shared.Models;
using HttpService.Service;
using Shared.Responses;
using System.Windows;

namespace ReceptProjekt.ViewModels

{
    public partial class CikkViewModel : BaseViewModel


        {
            private readonly ICikkService? _cikkService;
            [ObservableProperty] private Cikk _selectedCikk;
            [ObservableProperty] private ObservableCollection<Cikk> _cikks = new ();

            public CikkViewModel()
            {   SelectedCikk = new Cikk();  }

             public CikkViewModel(ICikkService? cikkService)
            {
            _selectedCikk = new Cikk();
            _cikkService = cikkService;
            }
        public async override Task InitializeAsync()
        {
            await UpdateView();
        }
        [RelayCommand]
        private async Task DoSave(Cikk newCikk)
        {
            MessageBoxResult result = MessageBox.Show("Biztosan menteni kívánja a bejegyzést?", "Bejegyzés módosítása", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                if (_cikkService is not null)
                {
                    ControllerResponse result1;
                    if (newCikk.HasId)
                        result1 = await _cikkService.UpdateAsync(newCikk);
                    else
                        result1 = await _cikkService.InsertAsync(newCikk);

                    if (!result1.HasError)
                    {
                        await UpdateView();
                    }
                }
            }
        }

        [RelayCommand]
        private async Task DoRemove(Cikk cikkToDelete)
        {
            MessageBoxResult result = MessageBox.Show("Biztosan törölni kívánja a bejegyzést?", "Bejegyzés törlése", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                if (_cikkService is not null)
                {
                    ControllerResponse result1 = await _cikkService.DeleteAsync(cikkToDelete.Id);
                    if (result1.IsSuccess)
                    {
                        await UpdateView();
                    }
                }
            }
        }

        [RelayCommand]
        private void DoNewCikk()

        {
            MessageBoxResult result = MessageBox.Show("Biztosan új bejegyzést kíván létrehozni?", "Bejegyzés létrehozása", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            { SelectedCikk = new Cikk(); }
        }

        private async Task UpdateView()
        {
            if (_cikkService is not null)
            {
                List<Cikk> cikks = await _cikkService.SelectAllIncluded();
                Cikks = new ObservableCollection<Cikk>(cikks);
            }


        }




    }



    }

