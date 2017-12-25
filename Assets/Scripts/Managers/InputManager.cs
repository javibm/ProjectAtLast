using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace IndieLaw.AtLast
{
	public class InputManager : MonoBehaviour 
	{
		[SerializeField]
		private GameEvent OnRightMove;

		[SerializeField]
		private GameEvent OnLeftMove;

		void Update () 
		{
			if(Input.GetKeyDown(KeyCode.RightArrow))
			{
				OnRightMove.Raise();
			}
			
			if(Input.GetKeyDown(KeyCode.LeftArrow))
			{
				OnLeftMove.Raise();
			}
		}
	}
}
