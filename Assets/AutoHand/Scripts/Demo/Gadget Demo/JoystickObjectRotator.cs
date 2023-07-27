using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Autohand.Demo
{
    public class JoystickObjectRotator : PhysicsGadgetJoystick
    {
        public Transform target;
        public float rotationSpeed = 2.0f;

        void Update()
        {
            var axis = GetValue();
            var rotationAxis = new Vector3(0, axis.x, 0);
            target.Rotate(rotationAxis * Time.deltaTime * -rotationSpeed);
        }
    }
}