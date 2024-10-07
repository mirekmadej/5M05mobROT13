namespace _5M05mobROT13
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void btmROT13clicked(object sender, EventArgs e)
        {
            string litery = "abcdefghijklmnopqrstuvwxyz";
            string w = "";
            string tekst = entText.Text;
            foreach(var c in tekst)
            {
                //pomijamy znaki: spacje, !,. i inne
                if (!litery.Contains(c.ToString()))
                    w = w + c;
                else
                {
                    int poz = (litery.IndexOf(c) + 13) % 26;
                    w = w + litery[poz];
                }
            }
            entText.Text = w;
        }
    }

}
