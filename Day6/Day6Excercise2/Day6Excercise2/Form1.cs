namespace Day6Excercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deck deck = new Deck();
            textBox1.Text = "";
            for (int i = 0; i < deck.DeckCards.Count; i++)
            {
                textBox1.Text += deck.DeckCards[i].rank + " of " + deck.DeckCards[i].suit + ", ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deck deck = new Deck();
            deck.DeckCards.ShuffleList();
            textBox1.Text = "";
            for (int i = 0; i < deck.DeckCards.Count; i++)
            {
                textBox1.Text += deck.DeckCards[i].rank + " of " + deck.DeckCards[i].suit + ", ";
            }
        }
    }


    public class Deck
    {
        public List<Card> DeckCards = new List<Card>();

        readonly string[] suits = { "Club", "Diamond", "Heart", "Spade" };
        readonly string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        public Deck()
        {
            for (int r = 0; r < 12; r++)
            {
                for (int s = 0; s < 4; s++)
                {
                    Card currentCard = new Card(suits[s], ranks[r]);
                    DeckCards.Add(currentCard);
                }
            }
        }       

    }

    public static class Extensions
    {
        private static Random rng = new Random();
        public static void ShuffleList<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

    public class Card
    {
        public string suit;
        public string rank;

        public Card(string suit, string rank)
        {
            this.suit = suit;
            this.rank = rank;
        }
    }
}