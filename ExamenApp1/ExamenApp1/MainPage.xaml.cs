using Microsoft.Maui.Controls;

namespace ExamenApp1
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Función para calcular el área del círculo
        private void CalculateCircleArea_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(radiusEntry.Text))
            {
                if (double.TryParse(radiusEntry.Text, out double radius))
                {
                    double area = Math.PI * radius * radius;
                    circleResultLabel.Text = area.ToString();
                }
                else
                {
                    DisplayAlert("Error", "El radio debe ser un número válido", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Por favor, ingrese el radio", "OK");
            }
        }

        // Función para limpiar los campos del círculo
        private void ClearCircleFields_Clicked(object sender, EventArgs e)
        {
            radiusEntry.Text = string.Empty;
            circleResultLabel.Text = string.Empty;
        }

        // Función para calcular el área del rectángulo
        private void CalculateRectangleArea_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(widthEntry.Text) && !string.IsNullOrWhiteSpace(heightEntry.Text))
            {
                if (double.TryParse(widthEntry.Text, out double width) && double.TryParse(heightEntry.Text, out double height))
                {
                    double area = width * height;
                    rectangleResultLabel.Text = area.ToString();
                }
                else
                {
                    DisplayAlert("Error", "El ancho y la altura deben ser números válidos", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Por favor, ingrese el ancho y la altura", "OK");
            }
        }

        // Función para limpiar los campos del rectángulo
        private void ClearRectangleFields_Clicked(object sender, EventArgs e)
        {
            widthEntry.Text = string.Empty;
            heightEntry.Text = string.Empty;
            rectangleResultLabel.Text = string.Empty;
        }
    }
}
