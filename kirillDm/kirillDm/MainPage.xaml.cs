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
        Picker puker, puker1;
        Image bok1;
        Editor Edit;
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

            DatePicker datePicker = new DatePicker
            {
                MinimumDate = new DateTime(2020, 11, 1),
                MaximumDate = new DateTime(2020, 11, 30),
                Date = new DateTime(2020, 11, 1)
            };


            Edit = new Editor { Placeholder = "Задать вопрос" };
            abs.Children.Add(Edit, 0, 3);
      
            abs.Children.Add(puker, 0,1);

            abs.Children.Add(datePicker, 0, 2);

            Content = abs;
        }

        private void Puker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Edit.Text = "Добрый вечер, контора " + puker.Items[puker.SelectedIndex];
        }
    }
}
