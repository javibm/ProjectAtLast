using UnityEngine;

namespace IndieLaw.AtLast
{
	public class FloorBuilder : MonoBehaviour 
	{
		[SerializeField]
		private GameObject cell;

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

		void Start()
		{

			for(int j = 0; j < floorsInScreen; j++)
			{
				for(int i = 0; i < widthNumber; ++i)
				{
					Instantiate(cell, new Vector3(widthInitialPosition + i, heightInitialPosition + heightBetweenFloors * j,0), Quaternion.identity).SetActive(true);
				}
			}
		}
	}
}
