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
            if (_cikkService is not null)
            {
                ControllerResponse result;
                if (newCikk.HasId)
                    result = await _cikkService.UpdateAsync(newCikk);
                else
                    result = await _cikkService.InsertAsync(newCikk);

                if (!result.HasError)
                {
                    await UpdateView();
                }
            }
        }

        [RelayCommand]
        private async Task DoRemove(Cikk cikkToDelete)
        {
            if (_cikkService is not null)
            {
                ControllerResponse result = await _cikkService.DeleteAsync(cikkToDelete.Id);
                if (result.IsSuccess)
                {
                    await UpdateView();
                }
            }
        }

        [RelayCommand]
        private void DoNewCikk()
        {
            SelectedCikk = new Cikk();
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

