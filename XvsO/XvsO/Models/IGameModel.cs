using System;
using System.Dynamic;
using Xamarin.Forms;

namespace XvsO
{
	public interface IGameModel
	{
		EWinner CurrentPlayerStep{ get; set; }
	}
}

