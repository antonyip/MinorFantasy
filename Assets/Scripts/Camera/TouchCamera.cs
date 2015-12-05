// Just add this script to your camera. It doesn't need any configuration.

using UnityEngine;

public class TouchCamera : MonoBehaviour
{
    Vector2?[] oldTouchPositions = {
        null,
        null
    };
    Vector2 oldTouchVector;
    float oldTouchDistance;
    bool dragging = false;

    void Update()
    {
        if (Input.GetMouseButtonUp(1))
        {
            dragging = false;
        }
        else if (Input.touchCount == 1 || Input.GetMouseButtonDown(1) || dragging)
        {
            dragging = true;
            Vector2 currentPosition = Input.touchCount == 1 ? Input.GetTouch(0).position : (Vector2)Input.mousePosition;
            if (oldTouchPositions[0] == null || oldTouchPositions[1] != null)
            {
                oldTouchPositions[0] = currentPosition;
                oldTouchPositions[1] = null;
            }
            else {
                Vector2 newTouchPosition = currentPosition;
                Vector2 movement = (Vector2)oldTouchPositions[0] - newTouchPosition;
                //Ensure the camera is within the boundary of the game scene
                if (!(transform.position.x <= GameManager.instance.bottomLeft.x && movement.x < 0) && 
                        !(transform.position.x >= GameManager.instance.topRight.x && movement.x > 0) && 
                        !(transform.position.y <= GameManager.instance.bottomLeft.y && movement.y < 0) && 
                        !(transform.position.y >= GameManager.instance.topRight.y && movement.y > 0))
                {
                    transform.position += transform.TransformDirection((Vector3)((oldTouchPositions[0] - newTouchPosition) * GetComponent<Camera>().orthographicSize / GetComponent<Camera>().pixelHeight * 2f));
                }
                oldTouchPositions[0] = newTouchPosition;
            }
        }
        //For mouse zooming (Scrolling)
        else if (Input.GetAxis("Mouse ScrollWheel") > 0) // Zoom out
        {
            Camera.main.orthographicSize--;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0) // Zoom in
        {
            Camera.main.orthographicSize++;
            Debug.Log(Camera.main.orthographicSize);
        }
        else if (Input.touchCount == 0)
        {
            oldTouchPositions[0] = null;
            oldTouchPositions[1] = null;
        }
        //For input touch zooming
        else
        {
            if (oldTouchPositions[1] == null)
            {
                oldTouchPositions[0] = Input.GetTouch(0).position;
                oldTouchPositions[1] = Input.GetTouch(1).position;
                oldTouchVector = (Vector2)(oldTouchPositions[0] - oldTouchPositions[1]);
                oldTouchDistance = oldTouchVector.magnitude;
            }
            else {
                Vector2 screen = new Vector2(GetComponent<Camera>().pixelWidth, GetComponent<Camera>().pixelHeight);

                Vector2[] newTouchPositions = {
                    Input.GetTouch(0).position,
                    Input.GetTouch(1).position
                };
                Vector2 newTouchVector = newTouchPositions[0] - newTouchPositions[1];
                float newTouchDistance = newTouchVector.magnitude;

                transform.position += transform.TransformDirection((Vector3)((oldTouchPositions[0] + oldTouchPositions[1] - screen) * GetComponent<Camera>().orthographicSize / screen.y));
                //transform.localRotation *= Quaternion.Euler(new Vector3(0, 0, Mathf.Asin(Mathf.Clamp((oldTouchVector.y * newTouchVector.x - oldTouchVector.x * newTouchVector.y) / oldTouchDistance / newTouchDistance, -1f, 1f)) / 0.0174532924f));
                GetComponent<Camera>().orthographicSize *= oldTouchDistance / newTouchDistance;
                transform.position -= transform.TransformDirection((newTouchPositions[0] + newTouchPositions[1] - screen) * GetComponent<Camera>().orthographicSize / screen.y);

                oldTouchPositions[0] = newTouchPositions[0];
                oldTouchPositions[1] = newTouchPositions[1];
                oldTouchVector = newTouchVector;
                oldTouchDistance = newTouchDistance;
            }
        }
    }
}
