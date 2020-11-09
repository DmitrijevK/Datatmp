using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace kirillDm
{
    public partial class MainPage : ContentPage
    {
        Picker puker;
        Image bok1;
        Editor Edit;
        Entry buka;
        public MainPage()
        {
            Grid abs = new Grid {

                RowDefinitions =
                {
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},

                }

                
            };


            bok1 = new Image { Source = "mm.png" };
            abs.Children.Add(bok1, 0, 0);
            puker = new Picker
            {
                Title = "Ваш Город"
            };
            puker.Items.Add("Таллинн");
            puker.Items.Add("Нарва");
            puker.Items.Add("Пярну");
            puker.Items.Add("Тарту");
            puker.SelectedIndexChanged += Puker_SelectedIndexChanged;

            //   DatePicker datePicker = new DatePicker
            //   {
            //  Format = "M",
            //  MinimumDate = DateTime.Now,
            //   MaximumDate = DateTime.Now.AddDays(+20)
            //   };
            //   datePicker.DateSelected += DatePicker_DateSelected;


            Edit = new Editor { Placeholder = "Задать вопрос" };
            abs.Children.Add(Edit, 0, 3);
      
            abs.Children.Add(puker, 0,1);

            // abs.Children.Add(datePicker, 0, 2);

            TimePicker tp = new TimePicker()
            {
                Time=new TimeSpan(Now)
            };
            abs.Children.Add(tp, 0, 3);

            Entry buka = new Entry
            {
                Text = "Своя дата"
            };
            abs.Children.Add(buka, 0, 4);

            Content = abs;
        }

       
        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            buka.Text = "Своя дата " + e.NewDate.ToString("M");
        }

        private void Puker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Edit.Text = "Добрый вечер, контора " + puker.Items[puker.SelectedIndex];
        }
    }
}
