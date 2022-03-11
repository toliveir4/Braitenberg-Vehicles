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
		// YOUR CODE HERE

		return 0.0f;
	}


}
