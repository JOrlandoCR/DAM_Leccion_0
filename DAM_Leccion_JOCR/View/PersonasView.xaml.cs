using DAM_Leccion_JOCR.ViewModel;

namespace DAM_Leccion_JOCR.View;

public partial class PersonasView : ContentPage
{
	public PersonasView()
	{
        InitializeComponent();

		BindingContext = new PersonasViewModel();
	}
}