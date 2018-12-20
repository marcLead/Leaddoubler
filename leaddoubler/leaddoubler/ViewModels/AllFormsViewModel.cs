using leaddoubler.Models;
using leaddoubler.Views;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace leaddoubler.ViewModels
{
    public class AllFormsViewModel
    {
        public IEnumerable<Values> Forms { get; set; }
        private Realm _realm;
        public ICommand AddCommand { get; set; }
        internal INavigation Navigation { get; set; }
        public AllFormsViewModel()
        {
            _realm = Realm.GetInstance();            
            Forms = _realm.All<Values>();
            AddCommand = new Command(AddClicked);
        }

        public void AddClicked()
        {
            var transaction = _realm.BeginWrite();
            FirstViewModel firstViewModel = new FirstViewModel(true,transaction) { Navigation = Navigation };
            Navigation.PushAsync(new FirstView(firstViewModel));
        }

        internal void EditItem(Values values)
        {
            var transaction = _realm.BeginWrite();
            FirstViewModel fistViewModel = new FirstViewModel(false,transaction);
            fistViewModel.AllElements.Age.Value = values.AgeValue;
            fistViewModel.AllElements.Budget.Value = values.BudgetValue;
            fistViewModel.AllElements.DatePicker.Value = values.DateValue;
            fistViewModel.AllElements.Effectiveness.Value = values.EffectivenessValue;
            fistViewModel.AllElements.Email.Value = values.EmailValue;
            fistViewModel.AllElements.Gender.Value = values.GenderValue;
            fistViewModel.AllElements.InterestRate.Value = values.InterestRateValue;
            fistViewModel.AllElements.Loan.Value = values.LoanValue;
            fistViewModel.AllElements.Notes.Value = values.NotesValue;
            fistViewModel.Values = values;
            Navigation.PushAsync(new FirstView(fistViewModel));
        }
    }
}
