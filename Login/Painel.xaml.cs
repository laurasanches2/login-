using System.IO.Packaging;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Login;

public partial class Painel : Window
{
    public Painel()
    {
        InitializeComponent();
    }


    private void BotaoBuscarImagem(object sender, RoutedEventArgs e)
    {
        string nomeEstudante = tbEstudanteNome.Text;
         
        // Estrutura Switch-case
        switch (nomeEstudante.ToLower())
        {
            case "rebeca spinola":
                imagemAluna.Source =
                    CriarImagem(
                        " https://vestibulares.estrategia.com/portal/wp-content/uploads/2023/02/sid-balachandran-_9a-3NO5KJE-unsplash-960x540.jpg");
                break;
            case "sarah":
                imagemAluna.Source =
                    CriarImagem(
                        "https://recantoalvorada.com.br/wp-content/uploads/2022/01/bem-estar-animal-980x408.jpeg");
                break;
            case "yatra":
                imagemAluna.Source =
                    CriarImagem(
                        "https://admin.cnnbrasil.com.br/wp-content/uploads/sites/12/2025/05/gato-laranja-e1748043537291.jpg?w=1200&h=900&crop=0");
                break;
            case "maria":
                imagemAluna.Source =
                    CriarImagem(
                        "https://cdn.midiamax.com.br/wp-content/uploads/2025/12/Novo-Projeto-2025-12-15T161000.332.webp");
                break;
            case "laura":
                imagemAluna.Source = CriarImagem(
                    "https://s2-vidadebicho.glbimg.com/h8x30Fy23-Q4mnbB6wHUrUxDnSY=/0x0:1500x1083/1000x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_fb623579cd474803aedbbbbae014af68/internal_photos/bs/2022/2/R/dpaaFZTea3KLAvmRfrQw/panteras-conheca-as-especies-de-felinos-que-sao-chamadas-assim00002.jpg");
                break;
            case "isabella":
                imagemAluna.Source =
                    CriarImagem(
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dc/Vulpes_lagopus_in_Iceland_%28cropped_3%29.jpg/330px-Vulpes_lagopus_in_Iceland_%28cropped_3%29.jpg");
                break;
            case "joyce":
                imagemAluna.Source =
                    CriarImagem(
                        "https://img.odcdn.com.br/wp-content/uploads/2025/03/meme-que-Xou-da-Xuxa-1920x1080.jpg");
                break;
            case "rebeca":
                imagemAluna.Source =
                    CriarImagem(
                        "https://pt.quizur.com/_image?href=https://img.quizur.com/f/img5fcabf9df1ed78.93013431.jpg?lastEdited=1607428683&w=1024&h");
                break;
            case "adrielle":
                imagemAluna.Source =
                    CriarImagem(
                        "https://revistaamazonia.com.br/wp-content/uploads/2025/04/A-capivara-e-perigosa-Entenda-os-riscos-e-como-conviver-em-seguranca-2-1.webp");
                break;
            default:
                imagemAluna.Source = CriarImagem("pack://application:,,,/images/background.jpg");
                break;
        }
    }

    private BitmapImage CriarImagem(string url)
    {
        var imagemBitmap = new BitmapImage();
        imagemBitmap.BeginInit();
        imagemBitmap.UriSource = new Uri(url);
        imagemBitmap.EndInit();
        return imagemBitmap;
    }
}