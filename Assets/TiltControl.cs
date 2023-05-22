using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltControl : MonoBehaviour
{
    private Touch touch;
    private Vector2 touchPosition;
    private Quaternion initialRotation;

    private float tiltSpeedModifier = 0.1f;

    void Start()
    {
        initialRotation = transform.rotation;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Moved:
                    float rotationX = -touch.deltaPosition.x * tiltSpeedModifier;
                    float rotationZ = -touch.deltaPosition.y * tiltSpeedModifier;

                    Quaternion rotationDeltaX = Quaternion.Euler(rotationX, 0f, 0f);
                    Quaternion rotationDeltaZ = Quaternion.Euler(0f, 0f, rotationZ);

                    Quaternion newRotation = initialRotation * rotationDeltaX * rotationDeltaZ;
                    transform.rotation = newRotation;

                    break;
            }
        }
    }
}
