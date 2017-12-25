using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndieLaw.AtLast
{
	public class Cell : MonoBehaviour 
	{
		public bool IsStartingPosition { get { return isStartingPosition; } }

		public Transform PlayerPosition { get { return playerPosition; } }

		private bool isStartingPosition;

		[SerializeField]
		private Transform playerPosition;

		public void SetStartingPosition(bool isStarting)
		{
			isStartingPosition = isStarting;
		}
	}
}