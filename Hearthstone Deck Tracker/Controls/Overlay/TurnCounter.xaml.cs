using Hearthstone_Deck_Tracker.Utility;
using System.Windows.Controls;

namespace Hearthstone_Deck_Tracker.Controls.Overlay
{
	public partial class TurnCounter : UserControl
	{
		public TurnCounter()
		{
			InitializeComponent();
		}

		internal void UpdateTurn(int turn)
		{
			var turnText = string.Format(LocUtil.Get("Overlay_Battlegrounds_Turn_Counter"), turn);
			var unavailableRacesText = BattlegroundsMinions.UnavailableRacesText;
			TurnText.Text = $"{turnText} {unavailableRacesText}";
		}

	}
}
