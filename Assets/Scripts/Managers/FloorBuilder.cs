using UnityEngine;
using System.Collections.Generic;

namespace IndieLaw.AtLast
{
	public class FloorBuilder : MonoBehaviour 
	{
		public List<Cell> Cells
		{
			get { return cells; }
		}

		[SerializeField]
		private GameObject cellPrefab;

		[SerializeField]
		private IntReference widthNumber; 

		[SerializeField]
		private IntReference widthInitialPosition;

		[SerializeField]
		private FloatReference heightBetweenFloors;

		[SerializeField]
		private FloatReference heightInitialPosition;

		[SerializeField]
		private IntReference floorsInScreen;

		private List<Cell> cells;

		void Awake()
		{
			cells = new List<Cell>();
			for(int j = 0; j < floorsInScreen; j++)
			{
				for(int i = 0; i < widthNumber; ++i)
				{
					InstantiateCell(i, j);
				}
			}
		}

		private void InstantiateCell(int row, int column)
		{
			GameObject cell = Instantiate(cellPrefab, 
										  new Vector3(widthInitialPosition + row, heightInitialPosition - heightBetweenFloors * column,0), 
										  Quaternion.identity) as GameObject;
			cell.name = "Cell" + column + "_" + row;
			cell.SetActive(true);

			Cell cellComponent = cell.GetComponent<Cell>();
			cells.Add(cellComponent);

			if(row == 0 && column == 0)
			{
				cellComponent.SetStartingPosition(true);
			}
		}
	}
}
