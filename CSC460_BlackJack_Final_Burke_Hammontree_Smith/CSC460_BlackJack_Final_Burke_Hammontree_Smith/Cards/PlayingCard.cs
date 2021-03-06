using System;
using System.Resources;

namespace Cards
{
    using System.Drawing;
	class PlayingCard
	{
        public static ResourceManager resources = 
            new ResourceManager("CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources",
                               typeof(CSC460_BlackJack_Final_Burke_Hammontree_Smith.Properties.Resources).Assembly);

        private readonly Suit suit;
        private readonly Value value;
        private readonly Image image;
        private readonly Image backImage;

        // Assigns card suit and value
		public PlayingCard(Suit s, Value v)
		{
			this.suit = s;
			this.value = v;
            this.image = resources.GetObject("" + suit + "_" +  value) as Image;
            this.backImage = resources.GetObject("Back"+ "_" + "Vertical") as Image;
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

        public Image HiddenCardImage()
        {
            return this.backImage;
        }
        
	}
}