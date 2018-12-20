using leaddoubler.Models;
using leaddoubler.Services;
using Realms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace leaddoubler.ViewModels
{
    public class FirstViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private AllElements _allElements;
        private Values _values = new Values();
        private Realm _realm;
        public ICommand SubmitPressed { get; set; }
        internal INavigation Navigation { get; set; }
        private bool _isCreateNew;
        Transaction transaction;
        public AllElements AllElements
        {
            get
            {
                return _allElements;
            }
            set
            {
                _allElements = value;
                OnPropertyChanged("AllElements");
            }
        }
        public Values Values
        {
            get
            {
                return _values;
            }
            set
            {
                _values = value;
                OnPropertyChanged("Values");
            }
        }
        public FirstViewModel(bool isCreateNew, Transaction _transaction)
        {
            _isCreateNew = isCreateNew;
            GetDataFromJsonService service = new GetDataFromJsonService();
            _allElements=service.GetDataFromLocalJson();
            SubmitPressed = new Command(SubmitClicked);
            _realm = Realm.GetInstance();
            transaction = _transaction;
        }

        private void SubmitClicked()
        {
            IEnumerable<Values> rObj = _realm.All<Values>();
            _values.AgeValue = _allElements.Age.Value;
            _values.BudgetValue = _allElements.Budget.Value;
            _values.DateValue = _allElements.DatePicker.Value;
            _values.EffectivenessValue = _allElements.Effectiveness.Value;
            _values.EmailValue = _allElements.Email.Value;
            _values.GenderValue = _allElements.Gender.Value;
            _values.InterestRateValue = _allElements.InterestRate.Value;
            _values.LoanValue = _allElements.Loan.Value;
            _values.NotesValue = _allElements.Notes.Value;
            if (_isCreateNew==false)
            {
                transaction.Commit();
            }
            else
            {
                int number = rObj.Count() + 1;
                _values.Name = "Form №" + number;
                _realm.Add(_values);
                transaction.Commit();
            }
            Navigation.PopAsync();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        internal void OnDisappearing()
        {
            transaction.Dispose();
        }
    }
}
