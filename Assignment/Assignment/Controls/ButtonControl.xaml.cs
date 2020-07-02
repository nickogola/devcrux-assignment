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

            switch (colorPicker.SelectedItem.ToString())
            {
                case "Blue":
                    myLayout.BackgroundColor = Color.FromHex("#0a528b");
                    break;
                case "Purple":
                    myLayout.BackgroundColor = Color.FromHex("#80189e");
                    break;
                case "Green":
                    myLayout.BackgroundColor = Color.FromHex("#12650f");
                    break;
                case "Yellow":
                    myLayout.BackgroundColor = Color.FromHex("#ffc220");
                    break;
                case "Gray":
                    myLayout.BackgroundColor = Color.FromHex("#ccc");
                    break;
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