using DAM_Leccion_JOCR.Model;

namespace DAM_Leccion_JOCR
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Ejecutar();
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

        public void Ejecutar() 
        {
            PersonaModel personaModel = new PersonaModel();

            personaModel.Nombre = "kk";

            txtNombre.Text = "kk";
        }

        private void Aceptar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Asistente del sistema", "Se ha guardado el registro en la bd", "Aceptar");
        }
    }

}
