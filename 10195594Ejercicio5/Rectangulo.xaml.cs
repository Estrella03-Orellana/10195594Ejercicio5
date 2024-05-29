namespace _10195594Ejercicio5;

public partial class Rectangulo : ContentPage
{
	public Rectangulo()
	{
		InitializeComponent();
	}
    /// <summary>
    /// En el evento clicked del bot�n lo que se realiza es un c�lculo, donde se solicitan dos cantidades, luego se almacenan 
    /// en las variables DatoA y DatoB,  y en un Entry se muestra el resultado de dicho c�lculo.
    /// En  un If validamos los campos para que solo se puedan solicitar n�meros, de lo contrarario muestra una ventana de alerta
    /// donde le indica que ingrese n�meros y no letras ni otro tipo de car�cter.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {
		double DatoA, DatoB, Perimetro, Superficie;
        if (!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Base.Text))
        {
            if (double.TryParse(Altura.Text, out DatoA) && double.TryParse(Base.Text, out DatoB))
            {
                DatoA = Convert.ToDouble(Altura.Text);
		        DatoB = Convert.ToDouble(Base.Text);

		        Perimetro = DatoB + DatoA + DatoB + DatoA;
		        Superficie = DatoB * DatoA;
		        EntryR.Text = "El perimetro es de : " + Perimetro + "cm" + " y la superficie es de : " + Superficie + "cm";
            }
            else
            {
                DisplayAlert("ERROR", "Introduce N�mero, no letras ni otro tipo de car�cteres", "OK");
            }
        }


    }
}