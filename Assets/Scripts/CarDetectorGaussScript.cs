using UnityEngine;
using System.Collections;
using System.Linq;
using System;

public class CarDetectorGaussScript : CarDetectorScript
{

    public float stdDev = 0.1f;
    public float mean = 0.0f;
    // Get gaussian output value
    public override float GetOutput()
    {
        // if the output is less than 0.1 it means that the Vehicle2a is getting left behind
        // so we make the standard deviation greater in order to make it getting closer
        if (output < 0.1f)
        {
            stdDev = 0.15f;
        }
        // in this case the Vehicle2a is getting too close so we decrease the standard deviation
        else if (output > 0.1f)
        {
            stdDev = 0.1f;
        }

        // calc of Gauss Function (source: Wikipedia)
        float A = (float)(1 / (stdDev * Math.Sqrt(2.0 * Math.PI)));
        float response = (float)(A * Math.Exp(-Math.Pow(output - mean, 2) / (2 * Math.Pow(stdDev, 2))));

        return response;
    }


}
