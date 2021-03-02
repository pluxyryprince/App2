﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            StackLayout stackLayout = new StackLayout();

            Button button_red = new Button
            {
                Text = "Red",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                TextColor = Color.Red,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            };
            
            button_red.Clicked += OnButtonClicked_Red;
            stackLayout.Children.Add(button_red);
            this.Content = stackLayout;


            Button button_yellow = new Button
            {
                Text = "Yellow",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                TextColor = Color.Yellow,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            };

            button_yellow.Clicked += OnButtonClicked_Yellow ;
            stackLayout.Children.Add(button_yellow);
            this.Content = stackLayout;


            Button button_green = new Button
            {
                Text = "Green",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                TextColor = Color.Green,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            };

            button_green.Clicked += OnButtonClicked_Green;
            stackLayout.Children.Add(button_green);
            this.Content = stackLayout;
        }

        private void OnButtonClicked_Red(object sender, System.EventArgs e)
        {
            Button button_red = (Button)sender;
            //button.Text = "Нажато!";
            BackgroundColor = Color.Red;
        }

        private void OnButtonClicked_Yellow(object sender, System.EventArgs e)
        {
            Button button_yellow = (Button)sender;
            //button.Text = "Нажато!";
            BackgroundColor = Color.LightYellow;
        }


        private void OnButtonClicked_Green(object sender, System.EventArgs e)
        {
            Button button_green = (Button)sender;
            //button.Text = "Нажато!";
            BackgroundColor = Color.Green;
        }

    } 
    
}



