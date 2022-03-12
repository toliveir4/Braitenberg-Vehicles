using UnityEngine;
using System.Collections;
using System.Linq;
using System;

public class LightDetectorLinearScript : LightDetectorScript {

	public override float GetOutput()
	{
		if (ApplyLimits)
		{
			if (ApplyThresholds)
			{
				if (output > MaxX)
					return MinY;

				if (output < MinY || output < MinX)
					return MinY;

				if (output > MaxY)
					return MaxY;
			}
			else
			{
				if (output < MinX || output > MaxX)
					return 0.0f;
			}
		}
		else
		{
			if (ApplyThresholds)
			{
				if (output < MinY)
					return MinY;

				if (output > MaxY)
					return MaxY;
			}
		}

		return output;
	}
}
