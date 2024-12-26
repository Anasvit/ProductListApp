using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppLists;

namespace WpfAppLists
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Тушь",
                    Description = "Термотушь с эффектом натуральных ресниц",
                    Manufacturer = "Darling",
                    Price = 1000,
                    Stock = 153,
                    ImagePath = "https://images.app.goo.gl/LU1n9CBMN6CPnG886"
                },
                new Product
                {
                    Name = "Консилер",
                    Description = "Стойкий консилер для лица",
                    Manufacturer = "Influence beauty",
                    Price = 500,
                    Stock = 365,
                    ImagePath = "https://images.app.goo.gl/qDXbG4MuTjiPUPUg8"
                },
                new Product
                {
                    Name = "Тканевая маска",
                    Description = "Освежающая тканевая маска для лица",
                    Manufacturer = "Darling",
                    Price = 300,
                    Stock = 412,
                    ImagePath = "https://images.app.goo.gl/B9KpBKfR5HK6gaC76"
                }
            };

        }
        public class Product
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Manufacturer { get; set; }
            public double Price { get; set; }
            public int Stock { get; set; }
            public string ImagePath { get; set; }
        }
    }
}
