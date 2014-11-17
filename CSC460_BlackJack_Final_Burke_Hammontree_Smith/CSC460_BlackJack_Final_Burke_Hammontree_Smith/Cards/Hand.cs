namespace Cards
{
	using System;
	using System.Collections;

	class Hand
	{
        private ArrayList cards = new ArrayList();

        public ArrayList CardsInHand()
        {
            return cards;
        }

        // Recieves card and places into container array
		public void AddCardToHand(PlayingCard cardDealt)
		{
            this.cards.Add(cardDealt);
		}
        
        // Clears hand of all cards
        public void ClearHand()
        {
            this.cards.Clear();
        }

		public override string ToString()
		{
			string result = "";
			foreach (PlayingCard card in this.cards)
			{
				result += card.ToString() + "\n";
			}

			return result;
		}
	}
}