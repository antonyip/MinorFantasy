using UnityEngine;
using System.Collections;
using TouchScript.Gestures;

namespace TouchScript.Examples.CameraControl
{
    public class CameraControls : MonoBehaviour
    {
        public ScreenTransformGesture TwoFingerMoveGesture;
        public ScreenTransformGesture ManipulationGesture;
        public float PanSpeed = 200f;
        public float RotationSpeed = 200f;
        public float ZoomSpeed = 10f;

        private Transform cam;

        private void Awake()
        {
            cam = GameObject.Find("Main Camera").transform;
        }

        private void OnEnable()
        {
            TwoFingerMoveGesture.Transformed += twoFingerTransformHandler;
            ManipulationGesture.Transformed += manipulationTransformedHandler;

        }

        private void OnDisable()
        {
            TwoFingerMoveGesture.Transformed -= twoFingerTransformHandler;
            ManipulationGesture.Transformed -= manipulationTransformedHandler;
        }

        private void manipulationTransformedHandler(object sender, System.EventArgs e)
        {
            float x = ManipulationGesture.DeltaPosition.x * PanSpeed;
            float z = ManipulationGesture.DeltaPosition.y * PanSpeed;
            cam.localPosition += new Vector3(-x, 0, -z);
        }

        private void twoFingerTransformHandler(object sender, System.EventArgs e)
        {
            //Vector2 diff = scaleGesture.NormalizedScreenPosition - scaleGesture.PreviousNormalizedScreenPosition;
            float d = TwoFingerMoveGesture.DeltaScale;
            Debug.Log(d);
            float y = d * ZoomSpeed;
            cam.localPosition += new Vector3(0, 1.0f-y, 0);
        }
    }
}