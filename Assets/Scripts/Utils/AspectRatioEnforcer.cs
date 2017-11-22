using UnityEngine;

namespace IndieLaw.AtLast
{
	public class AspectRatioEnforcer : MonoBehaviour 
	{
		[SerializeField]
		private FloatReference targetRatio;

		void Awake()
		{
			Camera.main.aspect = targetRatio.value;
		} 
	}
}
