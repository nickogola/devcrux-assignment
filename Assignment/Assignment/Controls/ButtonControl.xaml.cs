using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonControl : ContentView
    {
        public ButtonControl()
        {
            InitializeComponent();
            customBtn.Text = "Proceed";
            customBtn.TextColor = Color.White;
            customBtn.BackgroundColor = Color.ForestGreen;

            customBtn.Pressed += Button_Pressed;
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            var customBtn = sender as Button;
            if (customBtn.Text.Equals("Testing")) {
                customBtn.Text = "Proceed";
                customBtn.BackgroundColor = Color.ForestGreen;
                customBtn.ImageSource = "play.png";
            }
            else
            {
                customBtn.Text = "Testing";
                customBtn.BackgroundColor = Color.SteelBlue;
                customBtn.ImageSource = "next.png";
            }
        }

        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title),
                                                                                        typeof(string),
                                                                                        typeof(ButtonControl),
                                                                                        default(string),
                                                                                        BindingMode.OneWay);

        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text),
                                                                                      typeof(string),
                                                                                      typeof(ButtonControl),
                                                                                      default(string),
                                                                                      BindingMode.TwoWay);

        public static readonly BindableProperty ColorHexProperty = BindableProperty.Create(nameof(ColorHex),
                                                                                  typeof(string),
                                                                                  typeof(ButtonControl),
                                                                                  default(string),
                                                                                  BindingMode.TwoWay);

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public string ColorHex
        {
            get { return (string)GetValue(ColorHexProperty); }
            set { SetValue(ColorHexProperty, value); }
        }
    }
}