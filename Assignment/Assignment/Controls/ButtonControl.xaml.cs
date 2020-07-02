using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            myLayout.BackgroundColor = Color.FromHex("#009688");
        }

        private void Entrytxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            Title = e.NewTextValue;
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            btnLabel.Text = entrytxt.Text;
            btnIcon.Source = $"{imgPicker.SelectedItem.ToString()}.png";
            if (myLayout.BackgroundColor.Equals(Color.FromHex("009688")))
            {
                myLayout.BackgroundColor = Color.FromHex("#219e62");
            }
            else
            {
                myLayout.BackgroundColor = Color.FromHex("#009688");
            }
        }

        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title),
                                                                                        typeof(string),
                                                                                        typeof(ButtonControl),
                                                                                        default(string),
                                                                                        BindingMode.TwoWay);

        //public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text),
        //                                                                              typeof(string),
        //                                                                              typeof(Image),
        //                                                                              default(string),
        //                                                                              BindingMode.TwoWay);

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

        //public string Text
        //{
        //    get { return (string)GetValue(TextProperty); }
        //    set { SetValue(TextProperty, value); }
        //}

        public string ColorHex
        {
            get { return (string)GetValue(ColorHexProperty); }
            set { SetValue(ColorHexProperty, value); }
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TitleProperty.PropertyName)
            {
                btnLabel.Text = Title;
            }

            if(propertyName == ColorHexProperty.PropertyName)
            {
                myLayout.BackgroundColor = Color.FromHex(ColorHex);
            }
        }

    }
}