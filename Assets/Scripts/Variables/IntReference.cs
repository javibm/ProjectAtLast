using System;

namespace IndieLaw.AtLast
{
	[Serializable]
	public class IntReference 
	{
		public bool UseConstant = true;
		public int ConstantValue;
		public IntVariable Variable;

		public IntReference()
		{

		} 
		public IntReference(int value)
		{
			UseConstant = true;
			ConstantValue = value;
		}
		public int value
		{
			get { return UseConstant ? ConstantValue : Variable.Value; }
		}
		public static implicit operator int(IntReference reference)
		{
			return reference.value;
		}
	}
}
