using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HttpService.Service;
using Shared.Models;
using Shared.Responses;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ReceptProjekt.ViewModels
{
    public partial class SzemelyViewModel : BaseViewModel
    {
        private readonly ISzemelyService? _szemelyService;
        private readonly IKepzettsegService? _kepzettsegService;

        [ObservableProperty] private Szemely _selectedSzemely;
        [ObservableProperty] private ObservableCollection<Szemely> _szemelyek = new();
        [ObservableProperty] private ObservableCollection<Kepzettseg> _kepzettsegek = new();

        public SzemelyViewModel()
        { SelectedSzemely = new Szemely(); }

        public SzemelyViewModel(ISzemelyService? szemelyService, IKepzettsegService? kepzettsegService)
        {
            _selectedSzemely = new Szemely();
            _szemelyService = szemelyService;
            _kepzettsegService = kepzettsegService;
        }

        public async override Task InitializeAsync()
        {
            await UpdateView();
        }
        [RelayCommand]
        private async Task DoSave(Szemely newSzemely)
        {
            if (_szemelyService is not null)
            {
                ControllerResponse result;
                if (newSzemely.HasId)
                    result = await _szemelyService.UpdateAsync(newSzemely);
                else
                    result = await _szemelyService.InsertAsync(newSzemely);

                if (!result.HasError)
                {
                    await UpdateView();
                }
            }
        }

        [RelayCommand]
        private async Task DoRemove(Szemely szemelyToDelete)
        {
            if (_szemelyService is not null)
            {
                ControllerResponse result = await _szemelyService.DeleteAsync(szemelyToDelete.Id);
                if (result.IsSuccess)
                {
                    await UpdateView();
                }
            }
        }

        [RelayCommand]
        private void DoNewSzemely()
        {
            SelectedSzemely = new Szemely();
        }

        private async Task UpdateView()
        {
            if (_kepzettsegService is not null)
            {
                List<Kepzettseg> kepzettsegs = await _kepzettsegService.SelectAllAsync();
                Kepzettsegek = new ObservableCollection<Kepzettseg>(kepzettsegs);
            }
            if (_szemelyService is not null)
            {
                List<Szemely> szemelyek = await _szemelyService.SelectAllIncluded();
                Szemelyek = new ObservableCollection<Szemely>(szemelyek);
            }


        }
    }
    }


     