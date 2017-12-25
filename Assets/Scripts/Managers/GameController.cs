using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace IndieLaw.AtLast
{
	public class GameController : MonoBehaviour 
	{
		[SerializeField]
		private GameObject floorBuilder;

		[SerializeField]
		private GameObject playerPrefab;

		private GameObject player;

		void Start()
		{
			placePlayer();
		}

		public void MoveToRight()
		{
			player.transform.position += new Vector3(1,0,0);
		}

		public void MoveToLeft()
		{
			player.transform.position -= new Vector3(1,0,0);
		}
		
		private Cell StartingCell()
		{
			foreach(Cell cell in floorBuilder.GetComponent<FloorBuilder>().Cells)
			{
				if(cell.IsStartingPosition)
				{
					return cell;
				}
			}
			return null;
		}

		private void placePlayer()
		{
			Transform playerPosition = StartingCell().PlayerPosition;
			player = Instantiate(playerPrefab, playerPosition.position, Quaternion.identity);
			player.SetActive(true);
		}
	}
}
