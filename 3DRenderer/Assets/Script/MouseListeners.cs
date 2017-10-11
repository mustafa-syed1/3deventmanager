using UnityEngine;
using System.Collections;

public class MouseListeners : MonoBehaviour {
         //
        // VARIABLES
        //

        public float turnSpeed = 4.0f;      // Speed of camera turning when mouse moves in along an axis
        public float zoomSpeed = 4.0f;      // Speed of the camera going back and forth

        private Vector3 mouseOrigin;    // Position of cursor when mouse dragging starts
        private bool isRotating;    // Is the camera being rotated?
        private bool isZooming;     // Is the camera zooming?
        
        //
        // UPDATE
        //

        void Update()
        {
            // Get the left mouse button
            if (Input.GetMouseButtonDown(0))
            {
                // Get mouse origin
                mouseOrigin = Input.mousePosition;
                isRotating = true;
            }
            // Get the middle mouse button
            
            if (Input.GetMouseButtonDown(2))
            {
                // Get mouse origin
                mouseOrigin = Input.mousePosition;
                isZooming = true;
            }

            // Disable movements on button release
            if (!Input.GetMouseButton(0)) isRotating = false;
            if (!Input.GetMouseButton(2)) isZooming = false;

            // Rotate camera along X and Y axis
            if (isRotating)
            {
                Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

                transform.RotateAround(transform.position, transform.right, -pos.y * turnSpeed);
                transform.RotateAround(transform.position, Vector3.up, pos.x * turnSpeed);
            }
            
            // Move the camera linearly along Z axis
            if (isZooming)
            {
                Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

                Vector3 move = pos.y * zoomSpeed * transform.forward;
                transform.Translate(move, Space.World);
            }
        }
    }