namespace DAM_Leccion_JOCR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        //protected override window CreateWindow(IActivationState? activationState)
        //{
        //      return new Window(new AppShell());
        //}
    }
}
