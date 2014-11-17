namespace Cards
{
    using System.Drawing;
	class PlayingCard
	{
        private readonly Suit suit;
        private readonly Value value;
        private readonly Image image;

        // Assigns card suit and value
		public PlayingCard(Suit s, Value v)
		{
			this.suit = s;
			this.value = v;
            //this.image = Image.FromFile("Resources/" + suit + "-" + value);
		}

        public override string ToString()
		{
            string result = string.Format("{0} of {1}", this.value, this.suit);
			return result;
		}

        public Suit CardSuit()
        {
            return this.suit;
        }

        public Value CardValue()
        {
            return this.value;
        }
        public Image CardImage()
        {
            return this.image;
        }
        
	}
}