using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace C_lab4.ViewModels
{
    public class MainViewModel: SimpleViewModel
    {
        private CountryRepository Countries { get; set; }
        private Country selectedCountry;

        public ICommand Previous { get;set; }
        public ICommand Next { get;set; }
        private int index;

        public MainViewModel()
        {
            Countries = new CountryRepository();
            Countries.GetCountries();
            selectedCountry = Countries.Countries[index];

            Next = new Command(NextButtonClicked);
            Previous = new Command(PreviousButtonClicked);
        }

        public void NextButtonClicked()
        {
            index++;

            if (index > 2)
            {
                index = 0;
            }
            SetSelectedCountry();
        }

        public void PreviousButtonClicked()
        {
            index--;

            if (index < 0)
            {
                index = 0;

            }
            SetSelectedCountry();
        }

        public void SetSelectedCountry()
        {
            SelectedCountry = Countries.Countries[index];
        }

        public Country SelectedCountry
        {

            get
            {
                return selectedCountry;
            }

            set
            {
                    SetPropertyValue(ref selectedCountry, value);
            }
        }
    }
}
