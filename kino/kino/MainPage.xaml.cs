﻿namespace kino
{
    public partial class MainPage : ContentPage
    {
        int cena = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            cena += 10;
            Koszyk.Text = "Koszyk: " + cena + " zł";



        }

        private void OnCounterClicked2(object sender, EventArgs e)
        {
            cena -= 10;
            Koszyk.Text = "Koszyk: " + cena + " zł";



        }
    }

}
