// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   	ViewModel.tt
// Version:		2.0
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Controls = WPAppStudio.Controls;
using Entities = WPAppStudio.Entities;
using EntitiesBase = WPAppStudio.Entities.Base;
using IServices = WPAppStudio.Services.Interfaces;
using IViewModels = WPAppStudio.ViewModel.Interfaces;
using Localization = WPAppStudio.Localization;
using Repositories = WPAppStudio.Repositories;
using Services = WPAppStudio.Services;
using ViewModelsBase = WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of Microsoft_Videos ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class Microsoft_VideosViewModel : ViewModelsBase.VMBase, IViewModels.IMicrosoft_VideosViewModel
    {       

		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		private readonly IServices.ILockScreenService _lockScreenService;
		private readonly Repositories.IAboutTheseChannels_about _aboutTheseChannels_about;
		private readonly Repositories.IMicrosoft_microsoftvideos _microsoft_microsoftvideos;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="Microsoft_VideosViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        /// <param name="lockScreenService">The Lock Screen Service.</param>
        /// <param name="aboutTheseChannels_about">The About These Channels_about.</param>
        /// <param name="microsoft_microsoftvideos">The Microsoft_microsoftvideos.</param>
        public Microsoft_VideosViewModel(IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService, IServices.ILockScreenService lockScreenService, Repositories.IAboutTheseChannels_about aboutTheseChannels_about, Repositories.IMicrosoft_microsoftvideos microsoft_microsoftvideos)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
			_lockScreenService = lockScreenService;
			_aboutTheseChannels_about = aboutTheseChannels_about;
			_microsoft_microsoftvideos = microsoft_microsoftvideos;
        }
		
	
		private ObservableCollection<EntitiesBase.YouTubeVideo> _microsoft_VideosListControlCollection;

        /// <summary>
        /// Microsoft_VideosListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.YouTubeVideo> Microsoft_VideosListControlCollection
        {
            get
            {
				
                if(_microsoft_VideosListControlCollection == null)
					GetMicrosoft_VideosListControlCollectionData();
				return _microsoft_VideosListControlCollection;     
            }
            set
            {
                SetProperty(ref _microsoft_VideosListControlCollection, value);
            }
        }
	
		private int _microsoft_VideosListControlCollectionPageNumber;

        /// <summary>
        /// Microsoft_VideosListControlCollectionPageNumber property.
        /// </summary>		
        public int Microsoft_VideosListControlCollectionPageNumber
        {
            get
            {
				return _microsoft_VideosListControlCollectionPageNumber;
            }
            set
            {
                SetProperty(ref _microsoft_VideosListControlCollectionPageNumber, value);
            }
        }
	
		private EntitiesBase.YouTubeVideo _selectedMicrosoft_VideosListControlCollection;

        /// <summary>
        /// SelectedMicrosoft_VideosListControlCollection property.
        /// </summary>		
        public EntitiesBase.YouTubeVideo SelectedMicrosoft_VideosListControlCollection
        {
            get
            {
				return _selectedMicrosoft_VideosListControlCollection;
            }
            set
            {
                _selectedMicrosoft_VideosListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IMicrosoft_DetailVideosViewModel>(_selectedMicrosoft_VideosListControlCollection);
            }
        }
	
		private string _currentAboutTheseChannels_InfoHtmlControl;

        /// <summary>
        /// CurrentAboutTheseChannels_InfoHtmlControl property.
        /// </summary>		
        public string CurrentAboutTheseChannels_InfoHtmlControl
        {
            get
            {
				
                if(_currentAboutTheseChannels_InfoHtmlControl == null)
					_currentAboutTheseChannels_InfoHtmlControl = _aboutTheseChannels_about.Get();
				return _currentAboutTheseChannels_InfoHtmlControl;     
            }
            set
            {
                SetProperty(ref _currentAboutTheseChannels_InfoHtmlControl, value);
            }
        }

        /// <summary>
        /// Delegate method for the RefreshMicrosoft_VideosListControlCollectionCommand command.
        /// </summary>
        public async void RefreshMicrosoft_VideosListControlCollectionCommandDelegate() 
        {
			try
			{
				LoadingMicrosoft_VideosListControlCollection = true;
				var items = await  _microsoft_microsoftvideos.Refresh();
				Microsoft_VideosListControlCollection = items;
				Microsoft_VideosListControlCollectionPageNumber = 0;
			}
            catch (Exception ex)
            {
				Microsoft_VideosListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.youtubeError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingMicrosoft_VideosListControlCollection = false;
			}
        }
		
		
        private bool _loadingMicrosoft_VideosListControlCollection;
		
        public bool LoadingMicrosoft_VideosListControlCollection
        {
            get { return _loadingMicrosoft_VideosListControlCollection; }
            set { SetProperty(ref _loadingMicrosoft_VideosListControlCollection, value); }
        }

        private ICommand _refreshMicrosoft_VideosListControlCollectionCommand;

        /// <summary>
        /// Gets the RefreshMicrosoft_VideosListControlCollectionCommand command.
        /// </summary>
        public ICommand RefreshMicrosoft_VideosListControlCollectionCommand
        {
            get { return _refreshMicrosoft_VideosListControlCollectionCommand = _refreshMicrosoft_VideosListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(RefreshMicrosoft_VideosListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GetMicrosoft_VideosListControlCollectionCommand command.
        /// </summary>
        public  void GetMicrosoft_VideosListControlCollectionCommandDelegate(int pageNumber= 0) 
        {
				GetMicrosoft_VideosListControlCollectionData(pageNumber);
        }
		

        private ICommand _getMicrosoft_VideosListControlCollectionCommand;

        /// <summary>
        /// Gets the GetMicrosoft_VideosListControlCollectionCommand command.
        /// </summary>
        public ICommand GetMicrosoft_VideosListControlCollectionCommand
        {
            get { return _getMicrosoft_VideosListControlCollectionCommand = _getMicrosoft_VideosListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(GetMicrosoft_VideosListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechAboutTheseChannels_InfoHtmlControlCommand command.
        /// </summary>
        public  void TextToSpeechAboutTheseChannels_InfoHtmlControlCommandDelegate() 
        {
				_speechService.TextToSpeech(CurrentAboutTheseChannels_InfoHtmlControl);
        }
		

        private ICommand _textToSpeechAboutTheseChannels_InfoHtmlControlCommand;

        /// <summary>
        /// Gets the TextToSpeechAboutTheseChannels_InfoHtmlControlCommand command.
        /// </summary>
        public ICommand TextToSpeechAboutTheseChannels_InfoHtmlControlCommand
        {
            get { return _textToSpeechAboutTheseChannels_InfoHtmlControlCommand = _textToSpeechAboutTheseChannels_InfoHtmlControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechAboutTheseChannels_InfoHtmlControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareAboutTheseChannels_InfoHtmlControlCommand command.
        /// </summary>
        public  void ShareAboutTheseChannels_InfoHtmlControlCommandDelegate() 
        {
				_shareService.Share(@"About Mr. Bean", CurrentAboutTheseChannels_InfoHtmlControl);
        }
		

        private ICommand _shareAboutTheseChannels_InfoHtmlControlCommand;

        /// <summary>
        /// Gets the ShareAboutTheseChannels_InfoHtmlControlCommand command.
        /// </summary>
        public ICommand ShareAboutTheseChannels_InfoHtmlControlCommand
        {
            get { return _shareAboutTheseChannels_InfoHtmlControlCommand = _shareAboutTheseChannels_InfoHtmlControlCommand ?? new ViewModelsBase.DelegateCommand(ShareAboutTheseChannels_InfoHtmlControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartAboutTheseChannels_InfoHtmlControlCommand command.
        /// </summary>
        public  void PinToStartAboutTheseChannels_InfoHtmlControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.IMicrosoft_VideosViewModel), CreateTileInfoAboutTheseChannels_InfoHtmlControl());
        }
		

        private ICommand _pinToStartAboutTheseChannels_InfoHtmlControlCommand;

        /// <summary>
        /// Gets the PinToStartAboutTheseChannels_InfoHtmlControlCommand command.
        /// </summary>
        public ICommand PinToStartAboutTheseChannels_InfoHtmlControlCommand
        {
            get { return _pinToStartAboutTheseChannels_InfoHtmlControlCommand = _pinToStartAboutTheseChannels_InfoHtmlControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartAboutTheseChannels_InfoHtmlControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the SetLockScreenCommand command.
        /// </summary>
        public  void SetLockScreenCommandDelegate() 
        {
				_lockScreenService.SetLockScreen("LockScreen-2a9c40ea-a8f3-4e4e-94ef-57933044563f.jpg");
        }
		

        private ICommand _setLockScreenCommand;

        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
        public ICommand SetLockScreenCommand
        {
            get { return _setLockScreenCommand = _setLockScreenCommand ?? new ViewModelsBase.DelegateCommand(SetLockScreenCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the AboutCommand command.
        /// </summary>
        public  void AboutCommandDelegate() 
        {
				_navigationService.NavigateTo<IViewModels.IAboutViewModel>();
        }
		

        private ICommand _aboutCommand;

        /// <summary>
        /// Gets the AboutCommand command.
        /// </summary>
        public ICommand AboutCommand
        {
            get { return _aboutCommand = _aboutCommand ?? new ViewModelsBase.DelegateCommand(AboutCommandDelegate); }
        }

        private async void GetMicrosoft_VideosListControlCollectionData(int pageNumber = 0)
        {
	
			try
			{
				LoadingMicrosoft_VideosListControlCollection = true;
				Microsoft_VideosListControlCollectionPageNumber = pageNumber;

                if (pageNumber == 0)
				{
					var items = await _microsoft_microsoftvideos.GetData(pageNumber);
                    Microsoft_VideosListControlCollection = items;
				}
                else   
				{
					var items = await _microsoft_microsoftvideos.GetData(pageNumber);
                    foreach (var item in items)                    
                        Microsoft_VideosListControlCollection.Add(item);
				}
			}
            catch (Exception ex)
            {
				Microsoft_VideosListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.youtubeError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingMicrosoft_VideosListControlCollection = false;
			}
		}
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the AboutTheseChannels_InfoHtmlControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoAboutTheseChannels_InfoHtmlControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = @"About Mr. Bean",
                Title = @"About Mr. Bean",
                BackTitle = @"About Mr. Bean",
                BackContent = CurrentAboutTheseChannels_InfoHtmlControl,
                Count = 0,
                BackgroundImagePath = string.Empty,
                BackBackgroundImagePath = string.Empty,
                LogoPath = "Logo-249d64f4-648d-4391-b714-56b80fa53b89.png"
            };
            return tileInfo;
        }
    }
}