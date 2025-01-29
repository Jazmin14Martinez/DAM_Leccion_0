using DAM_Leccion_LMG.Model;

namespace DAM_Leccion_LMG
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
            PersonaModel personaModel = new PersonaModel()
            {
                Nombre = "Hola aqui estoy"
            };

            BindingContext = personaModel.Nombre;
        
            //txtNombre.Text = personaModel.Nombre;

            //Binding personaBinding = new Binding();


            //personaBinding.Source = personaModel; //origen
            //personaBinding.Path = "Nombre"; //ruta
            //txtNombre.SetBinding(Entry.TextProperty, personaBinding); //Destino
        }

        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Asistente del sitema", "se ha guardado el registro en la BD", "Aceptar");
        }
    }

}
