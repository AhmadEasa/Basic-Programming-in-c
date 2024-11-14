using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    struct Position
    {
        public float X ,Y ,Z; 

        public Position(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void PrintPosition()
        {
            Debug.Log($"Position Coordinates -> X: {X}, Y: {Y}, Z: {Z}");
        }
    }
}
