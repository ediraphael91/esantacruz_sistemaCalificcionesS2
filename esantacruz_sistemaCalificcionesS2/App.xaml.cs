﻿namespace esantacruz_sistemaCalificcionesS2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.calificaciones();
        }
    }
}