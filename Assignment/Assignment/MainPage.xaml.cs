using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assignment
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            userTitle = "Click me";
            colorHex = "#000333";
            this.BindingContext = this;
        }

        private string userTitle;

        public string UserTitle
        {
            get { return userTitle; }
            set { userTitle = value; }
        }

        private string colorHex;

        public string ColorHex
        {
            get { return colorHex; }
            set { colorHex = value; }
        }


    }
}
