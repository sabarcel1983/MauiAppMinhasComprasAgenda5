namespace MauiAppMinhasComprasAgenda5.Views;

public partial class ListaProduto : ContentPage
{
	public ListaProduto()
	{
		InitializeComponent();
	}

    private void Adicionar_Clicked(object sender, EventArgs e)
    {

        try
        {
            Navigation.PushAsync(new Views.NovoProduto());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops..Ocorreu um erro para adicionar o produto.", ex.Message, "OK");

        }

    }





}