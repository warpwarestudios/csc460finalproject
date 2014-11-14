namespace Cards
{
	using System;
	using System.Collections;

	class Hand
	{
        private ArrayList cards = new ArrayList();

		public void AddCardToHand(PlayingCard cardDealt)
		{
            this.cards.Add(cardDealt);
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