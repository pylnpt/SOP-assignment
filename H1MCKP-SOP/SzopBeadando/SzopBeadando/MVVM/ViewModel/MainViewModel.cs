using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzopBeadando.BackEnd.Controllers;
using SzopBeadando.BackEnd.Model;
using SzopBeadando.Core;

namespace SzopBeadando.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand HomeviewCommand { get; set; }
        public RelayCommand ListViewCommand { get; set; }
        public RelayCommand LoginCommand { get; set; }
        public RelayCommand CheckCommand { get; set; }


        public HomeViewModel  HomeVM { get; set; }
        public ListViewModel ListVM { get; set; }
        private static object _currentView; 

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            ListVM = new ListViewModel();

            CurrentView = HomeVM;

            HomeviewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM; 
            });

            ListViewCommand = new RelayCommand(o =>
            {
                CurrentView = ListVM;
            });
        }
    }
}
