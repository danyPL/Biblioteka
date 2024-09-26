using Biblioteka.Model;
using System;
using System.Collections.ObjectModel;

namespace Biblioteka
{
    public partial class MainPage : ContentPage
    {
        public List<Book> Books { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Books = new List<Book>
            {
                new Book { Id = 1, Name = "Potop - Henryk Sienkiewicz", Capacity = 2 },
                new Book { Id = 2, Name = "Pan Tadeusz - Adam Mickiewicz", Capacity = 3 },
                new Book { Id = 3, Name = "Zbrodnia i Kara - Fiodor Dostojewski", Capacity = 1 }
            };

            BookListView.ItemsSource = Books;
        }

        private void Wypozycz_Clicked(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(wypozyc.Text);

                var book = Books.FirstOrDefault(b => b.Id == id);

                if (book != null)
                {
                    if (book.Capacity > 0 && book.Capacity < 5)
                    {
                        book.Capacity--;

                        BookListView.ItemsSource = null;
                        BookListView.ItemsSource = Books;

                        DisplayAlert("Dziękujemy", $"Dziękujemy za wypożyczenie książki: {book.Name}", "OK");
                    }
                    else
                    {
                        DisplayAlert("Error", "Wybrana książka jest niedostępna", "OK");
                    }
                }
                else
                {
                    DisplayAlert("Error", "Nie ma książki o takim ID", "OK");
                }
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Wprowadź poprawne ID książki", "OK");
            }
        }

        private void Oddaj_Clicked(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(oddaj.Text);

                var book = Books.FirstOrDefault(b => b.Id == id);

                if (book != null)
                {
                    book.Capacity++;

                    BookListView.ItemsSource = null;
                    BookListView.ItemsSource = Books;

                    DisplayAlert("Dziękujemy", $"Dziękujemy za oddanie książki: {book.Name}", "OK");
                }
                else
                {
                    DisplayAlert("Error", "Nie ma książki o takim ID", "OK");
                }
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Wprowadź poprawne ID książki", "OK");
            }
        }
    }
}
