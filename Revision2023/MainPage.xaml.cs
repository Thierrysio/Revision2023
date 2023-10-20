using Revision2023.Modeles;

namespace Revision2023
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Ville VI1 = new Ville("Lannion");
            Ville VI2 = new Ville("Morlaix");
            Ville VI3 = new Ville("Brest");

            Parking P1 = new Parking(2.222f, 3.2f, VI1);
            Parking P2 = new Parking(5.222f, 4.2f, VI2);
            Parking P3 = new Parking(4.222f, 8.2f, VI3);

            Voiture V1 = new Voiture("sdfghj");

            V1.LesParkings.Add(P1);
            V1.LesParkings.Add(P3);

            int nbPark = V1.LesParkings.Count;

            string toto = V1.Immatriculation;
            V1.Immatriculation = "oiuy";
            toto = V1.Immatriculation;
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
    }
}