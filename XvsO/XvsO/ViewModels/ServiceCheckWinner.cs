using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Windows.Input;

namespace XvsO
{
	public class FieldViewModel
	{
		private int CountStep = 0;
		private bool BoolWinner = false;
		private IGameModel GameModel;

		public FieldViewModel ()
		{
			GameModel = DependencyService.Get<IGameModel> ();
		}

		public void CheckWinner (List<String> list)
		{
			CountStep++;
			if (list.Contains ("1") && list.Contains ("2") && list.Contains ("3")) {
				BoolWinner = true;
			} else if (list.Contains ("4") && list.Contains ("5") && list.Contains ("6")) {
				BoolWinner = true;
			} else if (list.Contains ("7") && list.Contains ("8") && list.Contains ("9")) {
				BoolWinner = true;
			} else if (list.Contains ("1") && list.Contains ("4") && list.Contains ("7")) {
				BoolWinner = true;
			} else if (list.Contains ("2") && list.Contains ("5") && list.Contains ("8")) {
				BoolWinner = true;
			} else if (list.Contains ("3") && list.Contains ("6") && list.Contains ("9")) {
				BoolWinner = true;
			} else if (list.Contains ("1") && list.Contains ("5") && list.Contains ("9")) {
				BoolWinner = true;
			} else if (list.Contains ("3") && list.Contains ("5") && list.Contains ("7")) {
				BoolWinner = true;
			} else if (CountStep == 9) {
				ShowDisplayAlert (EWinner.Equelly);
			}

			if (BoolWinner) {
				ShowDisplayAlert (GameModel.CurrentPlayerStep);
			}

			GameModel.CurrentPlayerStep = GameModel.CurrentPlayerStep == EWinner.X ? EWinner.O : EWinner.X;
		}

		private async void ShowDisplayAlert (EWinner winner)
		{
			await Application.Current.MainPage.DisplayAlert ("", winner.ToString () + " Winner!", "Reset");
			Application.Current.MainPage = new FieldPage ();
		}


	}
}