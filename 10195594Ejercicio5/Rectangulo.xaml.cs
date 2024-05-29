namespace _10195594Ejercicio5;

public partial class Rectangulo : ContentPage
{
	public Rectangulo()
	{
		InitializeComponent();
	}
    /// <summary>
    /// En el evento clicked del botón lo que se realiza es un cálculo, donde se solicitan dos cantidades, luego se almacenan 
    /// en las variables DatoA y DatoB,  y en un Entry se muestra el resultado de dicho cálculo.
    /// En  un If validamos los campos para que solo se puedan solicitar números, de lo contrarario muestra una ventana de alerta
    /// donde le indica que ingrese números y no letras ni otro tipo de carácter.
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
                DisplayAlert("ERROR", "Introduce Número, no letras ni otro tipo de carácteres", "OK");
            }
        }


    }
}