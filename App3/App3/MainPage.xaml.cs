using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MyItemsListView.ItemsSource = new List<Employees>()
            {
                new Employees()
                {
                    Id = 213,
                    Name = "John",
                    IsFirstOrLast = true,
                    IsFirstOrLastRadius = true,

                },
                new Employees()
                {
                    Id = 213,
                    Name = "John"
                },
                new Employees()
                {
                    Id = 213,
                    Name = "John"
                },
                new Employees()
                {
                    Id = 213,
                    Name = "John"
                },
                new Employees()
                {
                    Id = 213,
                    Name = "John"
                },
                new Employees()
                {
                    Id = 213,
                    Name = "John"
                },
                new Employees()
                {
                    Id = 213,
                    Name = "John"
                },
                new Employees()
                {
                    Id = 213,
                    Name = "John"
                },
                new Employees()
                {
                    Id = 213,
                    Name = "John",
                    IsFirstOrLast = true,
                },
            };
        }
    }
}
