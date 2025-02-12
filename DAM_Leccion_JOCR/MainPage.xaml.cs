using DAM_Leccion_JOCR.Model;
using DAM_Leccion_JOCR.ViewModel;

namespace DAM_Leccion_JOCR
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        MainPageViewModel mainPageViewModel = new MainPageViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }


        private void Aceptar_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Asistente del sistema", "Se ha guardado el registro en la bd", "Aceptar");
            //personasModel.Nombre = "Orlando";
            //personasModel.Apellido = "castro";
            //personasModel.Edad = "21";
        }
    }

}
