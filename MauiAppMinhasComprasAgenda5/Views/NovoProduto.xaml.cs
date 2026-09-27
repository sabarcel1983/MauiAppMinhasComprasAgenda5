using MauiAppMinhasComprasAgenda5.Models;
using SQLite;

namespace MauiAppMinhasComprasAgenda5.Views;

public partial class NovoProduto : ContentPage
{
    public NovoProduto()
    {
        InitializeComponent();
    }

    private async void  Salvar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Produto p = new Produto
            {
                Descricao = txt_descricao.Text,
                Quantidade = Convert.ToDouble(txt_quantidade.Text),
                Preco = Convert.ToDouble(txt_Preco.Text)
            };
            await App.Db.Insert(p);
            await DisplayAlert("Sucesso", "Produto salvo com sucesso!", "OK");

        }
        catch (Exception ex)
        {
           

        }

}
}