using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Correios.NET;

namespace RastreadorDePacotes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btnBuscar_Clicked(object sender, EventArgs e)
        {
            var pacote = "JN709355478BR";//etInsert.Text;
            _ = RastrearPacoteAsync(pacote);
        }
        public async Task RastrearPacoteAsync(string pacote)
        {
            var result = await new CorreiosService().GetPackageTrackingAsync(pacote);

            foreach (var track in result.TrackingHistory)
            {
                //lblHora.Text = $"Etregue em {Convert.ToString(track.Date)}";

                lblPostado.Text = "Postado em:";
                lblRPostado.Text = $"{track.Source} {Convert.ToString(track.Date)}";
                //lblDestino.Text = $"{track.Destination}";
                lblStatus.Text = $"{track.Status}";
            }
        }
    }
}
