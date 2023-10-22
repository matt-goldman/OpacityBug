namespace OpacityBug
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        double opacity = 0.5;

        public double MainOpacity
        {
            get => opacity;
            set
            {
                opacity = value;
                Overlay.Opacity = opacity;
                OnPropertyChanged();
            }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
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
