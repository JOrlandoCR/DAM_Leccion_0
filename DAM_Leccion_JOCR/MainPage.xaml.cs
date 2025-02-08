using DAM_Leccion_JOCR.Model;

namespace DAM_Leccion_JOCR
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        //Aqui se declara global, en este caso una propiedad del perona model
        private PersonaModel personaModel { get; set; }

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
            //PersonaModel personaModel = new PersonaModel();
            //personaModel.Nombre = "Holaa";
            //txtNombre.Text = personaModel.Nombre; 

            personaModel = new PersonaModel()
            {
                Nombre = "kkkkkk", 
            };

            BindingContext = personaModel;

            //txtNombre.Text = personaModel.Nombre;

            //Binding personaBinding = new Binding(); 

            //personaBinding.Source = personaModel;   //Origen
            //personaBinding.Path = "Nombre";//Ruta
            //txtNombre.SetBinding(Entry.TextProperty, personaBinding);//Destinofinal
           
        }

        private void Aceptar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Asistente del sistema", "Se ha guardado el registro en la bd", "Aceptar");
        }
    }

}
