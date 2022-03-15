using UnityEngine;
using System.Collections;
using System.Linq;
using System;

public class LightDetectorGaussScript : LightDetectorScript {
	public float stdDev = 1.0f; 
	public float mean = 0.0f; 
	public float min_y;
	public bool inverse = false;

	// Get gaussian output value
	public override float GetOutput()
	{
		// calc of Gauss Function (source: Wikipedia)
        float A = (float) (1 / (stdDev * Math.Sqrt(2.0 * Math.PI)));
        output = (float) (A * Math.Exp(-Math.Pow(output - mean, 2) / (2 * Math.Pow(stdDev, 2))));

		if (ApplyThresholds)
		{
			if (output < MinX || output > MaxX)
				return 0.0f;
		}
		if (ApplyLimits)
		{
			if (output < MinY)
				return MinY;

			if (output > MaxY)
				return MaxY;
		}

		if (inverse)
			return 1 - output;
		else
			return output;
	}
}
