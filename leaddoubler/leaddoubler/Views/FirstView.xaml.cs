using leaddoubler.CustomControls;
using leaddoubler.Models;
using leaddoubler.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace leaddoubler.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstView : ContentPage
    {
        double StepValue=1;
        private FirstViewModel _firstViewModel;
        public FirstView(FirstViewModel firstViewModel)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
            _firstViewModel = firstViewModel;
            _firstViewModel.Navigation = Navigation;
            BindingContext = _firstViewModel;
            StepValue = _firstViewModel.AllElements.InterestRate.StepSize;
            var coolLabel = new FontAwesomeIcon(FontAwesomeIcon.Icon.User)
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions=LayoutOptions.Center
            };
            var coolLabelFile = new FontAwesomeIcon(FontAwesomeIcon.Icon.File)
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            var coolLabelCaretDown = new FontAwesomeIcon(FontAwesomeIcon.Icon.CaretDown)
            {
                HorizontalOptions = LayoutOptions.EndAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness { Right = 7 }
            };
            emailGrid.Children.Add(coolLabel, 0, 1);
            pictureGrid.Children.Add(coolLabelFile, 0, 1);
            ageGrid.Children.Add(coolLabelCaretDown, 0, 1);
            switch(_firstViewModel.AllElements.Gender.Value)
            {
                case "Male":
                    Label0Tapped(this, null);
                    break;
                case "Female":
                    Label1Tapped(this, null);
                    break;
            }
            switch (_firstViewModel.AllElements.Loan.Value)
            {
                case "F1":
                    LabelLoan0Tapped(this, null);
                    break;
                case "F3":
                    LabelLoan1Tapped(this, null);
                    break;
                case "F5":
                    LabelLoan2Tapped(this, null);
                    break;
            }
            switch (_firstViewModel.AllElements.Age.Value)
            {
                case "10-16 years":
                    selectAge.Text = _firstViewModel.AllElements.Age.Items[1];
                    break;
                case "16-20 years":
                    selectAge.Text = _firstViewModel.AllElements.Age.Items[2];
                    break;
                case "20+ years":
                    selectAge.Text = _firstViewModel.AllElements.Age.Items[3];
                    break;
            }
            _firstViewModel.AllElements.Budget.Value = firstViewModel.AllElements.Budget.Value;
            _firstViewModel.AllElements.InterestRate.Value = firstViewModel.AllElements.InterestRate.Value;
            sliderInterestRate.Minimum = _firstViewModel.AllElements.InterestRate.Min;
            sliderInterestRate.Maximum = _firstViewModel.AllElements.InterestRate.Max;
            sliderInterestRate.Value = _firstViewModel.AllElements.InterestRate.Value;
            List<string> itemsEffectiveness = _firstViewModel.AllElements.Effectiveness.Items;
            sliderEffectiveness.Minimum = 0;
            sliderEffectiveness.Maximum = itemsEffectiveness.Count - 1;
            sliderEffectiveness.Value = itemsEffectiveness.IndexOf(_firstViewModel.AllElements.Effectiveness.Value);
            datePicker.Format = _firstViewModel.AllElements.DatePicker.DateFormat;
            datePicker.Date = _firstViewModel.AllElements.DatePicker.Value.DateTime;
        }

        private void SliderInterstRate_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / StepValue);
            var n = newStep * StepValue;
            _firstViewModel.AllElements.InterestRate.Value = n;
            if (n > sliderInterestRate.Maximum)
            {
                _firstViewModel.AllElements.InterestRate.Value = sliderInterestRate.Maximum;
            }
            sliderInterestRate.Value = n;
        }

        private void SliderEffectiveness_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / 1.0);
            _firstViewModel.AllElements.Effectiveness.Value = _firstViewModel.AllElements.Effectiveness.Items[Convert.ToInt32(newStep)];
            sliderEffectiveness.Value = newStep;
        }

		private async void PictureEntryFocused(object sender, EventArgs e)
		{
            entryPicture.Unfocus();
			Stream stream = await DependencyService.Get<IPicturePicker>().GetImageStreamAsync();

			if (stream != null)
			{
				Image image = new Image
				{
					Source = ImageSource.FromStream(() => stream),
					BackgroundColor = Color.Gray
				};
                entryPicture.Text = "photo.jpg";
			}
			else
			{
				
			}
		}

		private void Label0Tapped(object sender, EventArgs e)
        {
            ChangeBackgroundColorForButtons(lbl0, lbl1, lbl2);
            interestRateGrid.IsVisible = true;
            ageGrid.IsVisible = false;
            loanGrid.IsVisible = true;
            _firstViewModel.AllElements.Gender.Value = _firstViewModel.AllElements.Gender.Items[0];
        }

        private void Label1Tapped(object sender, EventArgs e)
        {
            ChangeBackgroundColorForButtons(lbl1, lbl0, lbl2);
            interestRateGrid.IsVisible = false;
            ageGrid.IsVisible = true;
            loanGrid.IsVisible = false;
            _firstViewModel.AllElements.Gender.Value = _firstViewModel.AllElements.Gender.Items[1];
        }

        private void Label2Tapped(object sender, EventArgs e)
        {
            ChangeBackgroundColorForButtons(lbl2, lbl0, lbl1);
            interestRateGrid.IsVisible = false;
            ageGrid.IsVisible = false;
            loanGrid.IsVisible = false;
            _firstViewModel.AllElements.Gender.Value = _firstViewModel.AllElements.Gender.Items[2];
        }

        private void LabelLoan0Tapped(object sender, EventArgs e)
        {
            ChangeBackgroundColorForButtons(loanLbl0, loanLbl1, loanLbl2);
            _firstViewModel.AllElements.Loan.Value = _firstViewModel.AllElements.Loan.Items[0];
        }

        private void LabelLoan1Tapped(object sender, EventArgs e)
        {
            ChangeBackgroundColorForButtons(loanLbl1, loanLbl0, loanLbl2);
            _firstViewModel.AllElements.Loan.Value = _firstViewModel.AllElements.Loan.Items[1];
        }

        private void LabelLoan2Tapped(object sender, EventArgs e)
        {
            ChangeBackgroundColorForButtons(loanLbl2, loanLbl0, loanLbl1);
            _firstViewModel.AllElements.Loan.Value = _firstViewModel.AllElements.Loan.Items[2];
        }

        private void ChangeBackgroundColorForButtons(Label green, Label grey1, Label grey2)
        {
            green.BackgroundColor = Color.FromHex("#68A179");
            green.TextColor = Color.White;
            grey1.BackgroundColor = Color.FromHex("#eeeeee");
            grey1.TextColor = Color.FromHex("#555555");
            grey2.BackgroundColor = Color.FromHex("#eeeeee");
            grey2.TextColor = Color.FromHex("#555555");
        }

        private void EmailEntryFocused(object sender, EventArgs e)
        {
            emailBorderLeft.BackgroundColor=Color.FromHex("#81a8c5");
        }

        private void EmailEntryUnfocused(object sender, EventArgs e)
        {
            emailBorderLeft.BackgroundColor = Color.FromHex("#d8e0e4");
        }

        private async void AgeFocused(object sender, EventArgs e)
        {
            selectAge.Unfocus();
            string age= await DisplayActionSheet(_firstViewModel.AllElements.Age.DefaultValue, "Cancel", null,
                     _firstViewModel.AllElements.Age.Items[1], _firstViewModel.AllElements.Age.Items[2], _firstViewModel.AllElements.Age.Items[3]);
            if(!String.IsNullOrWhiteSpace(age) && age!="Cancel")
            {
                selectAge.Text = age;
                _firstViewModel.AllElements.Age.Value = age;
            }
            
        }

        private void NotesTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(editorNotes.Text))
            {
                placeholderNotes.IsVisible = false;
            }
            else
            {
                placeholderNotes.IsVisible = true;
            }
        }

        private void OnSumbitClicked(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(entryEmail.Text) || entryEmail.Text.Length< _firstViewModel.AllElements.Email.MinChars ||
                entryEmail.Text.Length> _firstViewModel.AllElements.Email.MaxChars)
            {
                DisplayAlert("Error", "Email isn't correct", "OK");
                return;
            }

            DisplayAlert("Success", "You made it!", "OK");
        }

        private void datePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            _firstViewModel.AllElements.DatePicker.Value = datePicker.Date;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            (BindingContext as FirstViewModel)?.OnDisappearing();
            BindingContext = null;
            btnSubmit.IsEnabled = true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            btnSubmit.IsEnabled = false;
        }
    }
}