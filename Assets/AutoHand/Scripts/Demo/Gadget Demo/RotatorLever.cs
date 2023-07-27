using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Autohand.Demo
{
    public class RotatorLever : PhysicsGadgetHingeAngleReader
    {
        public Transform target;
        public Vector3 rotationAxis;
        public float rotationSpeed = 1.0f;
        public float minAngle = -45.0f; // Minimum angle (in degrees)
        public float maxAngle = 45.0f;  // Maximum angle (in degrees)

        void Update()
        {
            float input = GetValue();
            if (Mathf.Abs(input) > 0.1f)
            {
                float newRotationAngle = Mathf.Clamp(target.localEulerAngles.y + input * rotationSpeed, minAngle, maxAngle);
                Vector3 newRotation = rotationAxis * newRotationAngle;
                target.localEulerAngles = newRotation;
            }
        }

    }
}