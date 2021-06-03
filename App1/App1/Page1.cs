using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            Entry Entry1 = new Entry()
            {
                Placeholder = "Write",
                TextColor = Color.Blue
            };
            Button Button1 = new Button()
            {
                Text = "Tap"
            };

            Content = new StackLayout
            {
                Children = {
                    Entry1,
                    Button1
                }
            };
        }
    }
}         