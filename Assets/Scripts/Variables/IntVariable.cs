using UnityEngine;

namespace IndieLaw.AtLast
{
	[CreateAssetMenu]
	public class IntVariable : ScriptableObject 
	{
#if UNITY_EDITOR
		[Multiline]
		public string DeveloperDescription;
#endif

		public int Value;

		public void SetValue(int value)
		{
			Value = value;
		}

		public void ApplyChange(int amount)
		{
			Value += amount;
		}

		public void ApplyChange(IntVariable amount)
		{
			Value += amount.Value;
		}	
	}
}
