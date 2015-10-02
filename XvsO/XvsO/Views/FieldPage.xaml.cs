using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XvsO
{
	public partial class FieldPage : ContentPage
	{
		private List<string> ListX = new List<string> ();
		private List<string> ListO = new List<string> ();
		private IGameModel GameModel;
		private FieldViewModel ServiceCheckWinner = new FieldViewModel ();

		public FieldPage ()
		{
			InitializeComponent ();
			Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);

			GameModel = DependencyService.Get<IGameModel> ();
		}

		private void OnButtonClicked (object sender, EventArgs e)
		{
			var btn = sender as Button;

			btn.Text = GameModel.CurrentPlayerStep.ToString ();
			switch (GameModel.CurrentPlayerStep) {
			case EWinner.X:
				{
					ListX.Add (btn.CommandParameter.ToString ());
					ServiceCheckWinner.CheckWinner (ListX);
					break;
				}
			case EWinner.O:
				{
					ListO.Add (btn.CommandParameter.ToString ());
					ServiceCheckWinner.CheckWinner (ListO);
					break;
				}
			}

			btn.IsEnabled = false;
		}
	}
}

