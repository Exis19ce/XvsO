using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Windows.Input;

namespace XvsO
{
	public class FieldViewModel
	{

		private List<string> ListX = new List<string> ();
		private List<string> ListO = new List<string> ();
		private bool BoolForStep = true;


		public FieldViewModel ()
		{
			CommandButtonClicked = new Command<string> (ButtonClicked);
		}

		public ICommand CommandButtonClicked { get; private set; }

		private void ButtonClicked (string value)
		{
			if (BoolForStep) {
				BoolForStep = false;
				ListX.Add (value);
				CheckWinner (ListX);
			} else {
				BoolForStep = true;
				ListO.Add (value);
				CheckWinner (ListO);
			}
		}

		private void CheckWinner (List<String> list)
		{
			if (list.Contains ("1") || list.Contains ("2") || list.Contains ("3")) {
			} else if (list.Contains ("4") || list.Contains ("5") || list.Contains ("6")) {
				
			} else if (list.Contains ("7") || list.Contains ("8") || list.Contains ("9")) {
				
			} else if (list.Contains ("1") || list.Contains ("4") || list.Contains ("7")) {
				
			} else if (list.Contains ("2") || list.Contains ("5") || list.Contains ("8")) {
								
			} else if (list.Contains ("3") || list.Contains ("6") || list.Contains ("9")) {
				
			} else if (list.Contains ("1") || list.Contains ("5") || list.Contains ("9")) {
					
			} else if (list.Contains ("3") || list.Contains ("5") || list.Contains ("7")) {
						
			} else {
				var asdas = 33;
			}
		}

	}
}


