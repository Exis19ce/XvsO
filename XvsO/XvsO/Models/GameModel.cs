using System;
using Xamarin.Forms;
using XvsO;

[assembly:Dependency (typeof(GameModel))]
namespace XvsO
{
	public class GameModel: IGameModel
	{
		public GameModel ()
		{
			_CurrentPlayerStep = EWinner.X;
		}

		private EWinner _CurrentPlayerStep;

		public EWinner CurrentPlayerStep { 
			get { 
				return _CurrentPlayerStep;
			}
			set {
				_CurrentPlayerStep = value;
			} 
		}
	}
}

