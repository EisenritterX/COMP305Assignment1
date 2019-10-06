﻿/*******************************************/
/*       Created By: George Zhou           */
/*       Student ID: 300613283             */
/*******************************************/
// This utility script control the speed component
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Util {
    [System.Serializable]
    public class Speed
    {
        public float minSpeed;
        public float maxSpeed;

        public Speed(float min = 0.0f, float max = 0.0f)
        {
            minSpeed = min;
            maxSpeed = max;
        }
           

    }
}
