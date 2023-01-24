using HousingEstate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace HousingEstate02.View
{
    /// <summary>
    /// Interaction logic for BoFCreateView.xaml
    /// </summary>
    public partial class BoFCreateView : UserControl
    {
        public string[] bofnums { get; set; }
        Reference ReferenceHousing { get; set; }
        
        public BoFCreateView()
        {
            InitializeComponent();
            bofnums = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            DataContext = this;
            
            if (SelectButtonBoF.IsPressed) 
            {
                
                //Console.WriteLine("To create a BlockOfFlats, write a number which you want");
                int objectName = int.Parse(bofNumCombo.ToString());
                Housingestate.housing.AddBlockInHousing(new BlockOfFlats(objectName));
                //Console.WriteLine("You successfully created a Block of Flats {0}", objectName);
                System.Threading.Thread.Sleep(3000);

            }
        }
    }
}
