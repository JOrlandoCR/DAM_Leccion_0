﻿using DAM_Leccion_JOCR.View;

namespace DAM_Leccion_JOCR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();

            MainPage = new PersonasView();
        }
    }
}
