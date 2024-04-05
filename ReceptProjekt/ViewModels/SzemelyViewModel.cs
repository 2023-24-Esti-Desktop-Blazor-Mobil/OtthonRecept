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
            MessageBoxResult result = System.Windows.MessageBox.Show("Biztosan menteni kívánja a személyt?", "Személy mentése", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)

            {
                if (_szemelyService is not null)
                {
                    ControllerResponse result1;
                    if (newSzemely.HasId)
                        result1 = await _szemelyService.UpdateAsync(newSzemely);
                    else
                        result1 = await _szemelyService.InsertAsync(newSzemely);

                    if (!result1.HasError)
                    {
                        await UpdateView();
                    }
                }
            }
        }

        [RelayCommand]
        private async Task DoRemove(Szemely szemelyToDelete)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("Biztosan törölni kívánja a személyt?", "Személy törlése", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
                if (_szemelyService is not null)
            {
                ControllerResponse result1 = await _szemelyService.DeleteAsync(szemelyToDelete.Id);
                if (result1.IsSuccess)
                {
                    await UpdateView();
                }
            }
        }

        [RelayCommand]
        private void DoNewSzemely()
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("Biztosan új személyt rögzít?", "Személy rögzítése", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            { SelectedSzemely = new Szemely(); }
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


     