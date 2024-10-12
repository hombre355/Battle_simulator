using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tektonux_Coding_Challenge;

namespace Battle_simulator
{
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
        
        private IRepository<ITransformer> _repository;
        private IBattleSimulator _battleSimulator;

        public MainWindow()
        {

            //Console.WriteLine("media starting");
            InitializeComponent();
            media_Player.Play();
            audio_Player.Play();
            _repository = new Repository<ITransformer>();  
            _battleSimulator = new BattleSimulator();  
            //LoadTransformers();
        }

        private void Media_Ended(object sender, EventArgs e)
        {
            media_Player.Position = TimeSpan.Zero;
            media_Player.Play();
        }

        private void Audio_Ended(object sender, EventArgs e)
        {
            audio_Player.Position = TimeSpan.Zero;
            audio_Player.Play();
        }

        private void Audio_Failed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show("There was an error: " + e.ErrorException.Message);
        }

        void start_click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("test");
        }

        /*
        private void LoadTransformers()
        {
            // Populate ListView and ComboBoxes with transformers from the repository
            var transformers = _repository.GetAll().ToList();
            TransformerListView.ItemsSource = transformers;
            FirstTransformerComboBox.ItemsSource = transformers;
            SecondTransformerComboBox.ItemsSource = transformers;
        }

        private void AddTransformer_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text.Trim();
            string faction = FactionTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(faction))
            {
                MessageBox.Show("Please enter both name and faction.");
                return;
            }

            var transformer = new Transformer(name, faction);
            _repository.Add(transformer);

            // Clear the input fields
            NameTextBox.Clear();
            FactionTextBox.Clear();

            LoadTransformers(); // Reload the list
            MessageBox.Show($"Transformer {name} added.");
        }

        private void RemoveTransformer_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name to remove.");
                return;
            }

            try
            {
                _repository.Remove(name);
                LoadTransformers(); // Reload the list
                MessageBox.Show($"Transformer {name} removed.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SimulateBattle_Click(object sender, RoutedEventArgs e)
        {
            var transformer1 = (ITransformer)FirstTransformerComboBox.SelectedItem;
            var transformer2 = (ITransformer)SecondTransformerComboBox.SelectedItem;

            if (transformer1 == null || transformer2 == null)
            {
                MessageBox.Show("Please select two transformers.");
                return;
            }

            var winner = _battleSimulator.Battle(transformer1, transformer2);

            // Update battle result
            BattleResultTextBlock.Text = $"{winner.Name} wins the battle!";
            LoadTransformers(); // Reload the list to reflect updated stats
        }
        */
    }
}