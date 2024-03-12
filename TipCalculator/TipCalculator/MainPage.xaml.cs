namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        private void ButtonRoundUp_Clicked(object sender, EventArgs e)
        {
            double result = CalculateTip();
            double roundedResult = Math.Ceiling(result);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double totalValue = roundedResult + amount;
            LabelTipValue.Text = roundedResult.ToString();
            LabelTipValue.Text = amount.ToString();

        }

        private void ButtonRoundDown_Clicked(object sender, EventArgs e)
        {
            double ressult = CalculateTip();
            double roundedResult = Math.Floor(ressult);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double totalValue = roundedResult + amount;
            LabelTipValue.Text = roundedResult.ToString();
            LabelTipValue.Text = amount.ToString();
        }

        private void Button20percent_Clicked(object sender, EventArgs e)
        {

        }

        private void Button15percent_Clicked(object sender, EventArgs e)
        {

        }

        private double CalculateTip()
        {
            //Programar uma função que calcule
            //Preciso receber o valor do pedido digitado pelo usuário
            //Receber o valor da porcentagem´para calcular a gorjeta
            //Realizar o cálculo da gorjeta considerando o tipo de arrendondamento]
            //Exibir o calor na label Totaltip

            double amount =Convert.ToDouble(ValueEntry.Text.ToString());
            double percent = SliderTipPercent.Value;

            double result = amount * (percent/100);
            return result;

            LabelTipValue.Text = result.ToString();
        }
    }

}
