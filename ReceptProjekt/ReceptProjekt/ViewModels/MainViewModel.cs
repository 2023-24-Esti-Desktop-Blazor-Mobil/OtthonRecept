using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace ReceptProjekt.ViewModels

{

	public partial class MainViewModel : BaseViewModel
	{
        private BelepesViewModel _belepesViewModel;
        private CikkViewModel _cikkViewModel;
        private ReceptViewModel _receptViewModel;
        private SzemelyViewModel _szemelyViewModel;
       
        public MainViewModel()
        {
            _belepesViewModel = new BelepesViewModel();
            _cikkViewModel = new CikkViewModel();
            _receptViewModel = new ReceptViewModel();
            _szemelyViewModel = new SzemelyViewModel();
        }

        public MainViewModel(
            BelepesViewModel belepesViewModel,
            CikkViewModel cikkViewModel,
            ReceptViewModel receptViewModel,
            SzemelyViewModel szemelyViewModel

            )
        {
            _belepesViewModel = belepesViewModel;
            _cikkViewModel = cikkViewModel;
            _receptViewModel = receptViewModel;
            _szemelyViewModel = szemelyViewModel;
         
        }



        [ObservableProperty]
		private BaseViewModel _childViewModel = new BelepesViewModel();
		[ObservableProperty]
		private string _statusBarText = "";

		[RelayCommand]
		public async Task ShowReceptView()
		{
			await _receptViewModel.InitializeAsync();
            ChildViewModel = new ReceptViewModel();
			StatusBarText = "Receptek szerkesztése";
		}
		[RelayCommand]
		private void HideReceptView() {
			ChildViewModel = new BelepesViewModel();
		}
		[RelayCommand]
        public async Task ShowCommentView()
        {
            await _cikkViewModel.InitializeAsync();
            ChildViewModel = new CikkViewModel();
            StatusBarText = "Kommentek szerkesztése";
        }
		[RelayCommand]
        private async Task ShowSzemelyView()
        {
            await _szemelyViewModel.InitializeAsync();
            ChildViewModel = new SzemelyViewModel();
            StatusBarText = "Személyek szerkesztése";
        }
    }
}