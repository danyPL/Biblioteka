using Biblioteka.Model;

namespace Biblioteka
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
         
        }
      
        public void Wypozycz(object sender,EventArgs e)
        {
            try
            {
                int id = Convert.ToInt16(wypozyc.Text);
                int potopilosc = Convert.ToInt16(PotopIlosc.Text);
                int tadueszilosc = Convert.ToInt16(TadeuszIlosc.Text);
                int zbrodniailosc = Convert.ToInt16(ZbrodniaIlosc.Text);

                switch (id)
                {
                    case 1:
                        if(potopilosc> 0)
                        {
                            potopilosc--;
                            PotopIlosc.Text = $"{potopilosc}";

                            DisplayAlert("Dziekujemy", "Dziekujemy za wypozycznie ksiazki Potop - Henryk Sienkiewicz", "OK");
                        }
                        else
                        {
                            DisplayAlert("Error", "Wybrana książka jest niedostepna", "OK");

                        }

                        break;
                    case 2:
                        if (tadueszilosc > 0)
                        {
                            tadueszilosc--;
                            PotopIlosc.Text = $"{tadueszilosc}";

                            DisplayAlert("Dziekujemy", "Dziekujemy za wypozycznie ksiazki Pan Tadeusz - Adam Miczkiewicz", "OK");
                        }
                        else
                        {
                            DisplayAlert("Error", "Wybrana książka jest niedostepna", "OK");

                        }

                        break;
                    case 3:
                        if (zbrodniailosc > 0)
                        {
                            zbrodniailosc--;
                            PotopIlosc.Text = $"{zbrodniailosc}";

                            DisplayAlert("Dziekujemy", "Dziekujemy za wypozycznie ksiazki Pan Tadeusz - Adam Miczkiewicz", "OK");
                        }
                        else
                        {
                            DisplayAlert("Error", "Wybrana książka jest niedostepna", "OK");

                        }

                        break;
                }
            }
            catch (Exception ex) {
                DisplayAlert("Error", "Nie ma książki o takim ID", "OK");
            
            }
        }
    }

}

