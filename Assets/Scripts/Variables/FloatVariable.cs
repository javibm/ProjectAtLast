using UnityEngine;

namespace IndieLaw.AtLast
{
	[CreateAssetMenu]
	public class FloatVariable : ScriptableObject 
	{
#if UNITY_EDITOR
		[Multiline]
		public string DeveloperDescription;
#endif

		public float Value;

		public void SetValue(float value)
		{
			Value = value;
		}

		public void ApplyChange(float amount)
		{
			Value += amount;
		}

		public void ApplyChange(FloatVariable amount)
		{
			Value += amount.Value;
		}	
	}
}
