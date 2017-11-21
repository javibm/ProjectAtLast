using UnityEngine;

namespace IndieLaw.AtLast
{
	public class AspectRatioEnforcer : MonoBehaviour 
	{
		public FloatReference targetRatio;

		void Awake()
		{
			Camera.main.aspect = targetRatio.value;
		} 
	}
}
