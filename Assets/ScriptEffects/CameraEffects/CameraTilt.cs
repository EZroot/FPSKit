using UnityEngine;
using System.Collections;
using CMF;

namespace FPSKit
{
    [RequireComponent(typeof(CameraController))]
    public class CameraTilt : MonoBehaviour
    {
        public Transform cameraTransform;
        CameraController camController;

        //Editor variables, you can customize these
        public float _tiltAmount = 5;
        public KeyCode _leftBtn = KeyCode.A; //A is default
        public KeyCode _rightBtn = KeyCode.D; //D is default
        public KeyCode _upBtn = KeyCode.W; //A is default
        public KeyCode _downBtn = KeyCode.S; //D is default

        Vector3 currentRot;
        int speed = 10;

        private void Start()
        {
            camController = GetComponent<CameraController>();
        }
        // Update is called once per frame
        void Update()
        {
            currentRot = cameraTransform.eulerAngles;

            // If _leftBtn key is hit, rotate Z axis of camera by _tiltAmount
            if (Input.GetKey(_upBtn))
            {
                currentRot = new Vector3(
                 Mathf.LerpAngle(currentRot.x, camController.GetCurrentXAngle() + (_tiltAmount * 0.5f), Time.deltaTime * speed),
                 Mathf.LerpAngle(currentRot.y, currentRot.y, Time.deltaTime * speed),
                 Mathf.LerpAngle(currentRot.z, currentRot.z, Time.deltaTime * speed));
            }
            else if (Input.GetKey(_downBtn))
            {
                currentRot = new Vector3(
                 Mathf.LerpAngle(currentRot.x, camController.GetCurrentXAngle() - (_tiltAmount * 0.5f), Time.deltaTime * speed),
                 Mathf.LerpAngle(currentRot.y, currentRot.y, Time.deltaTime * speed),
                 Mathf.LerpAngle(currentRot.z, currentRot.z, Time.deltaTime * speed));
            }
            else
            {
                currentRot = new Vector3(
                 Mathf.LerpAngle(currentRot.x, camController.GetCurrentXAngle(), Time.deltaTime * speed),
                 Mathf.LerpAngle(currentRot.y, currentRot.y, Time.deltaTime * speed),
                 Mathf.LerpAngle(currentRot.z, 0, Time.deltaTime * speed));
            }

            if (Input.GetKey(_leftBtn))
            {
                currentRot = new Vector3(
                 Mathf.LerpAngle(currentRot.x, currentRot.x, Time.deltaTime * speed),
                 Mathf.LerpAngle(currentRot.y, currentRot.y, Time.deltaTime * speed),
                 Mathf.LerpAngle(currentRot.z, _tiltAmount, Time.deltaTime * speed));
            }
            else if (Input.GetKey(_rightBtn))
            {
                currentRot = new Vector3(
                 Mathf.LerpAngle(currentRot.x, currentRot.x, Time.deltaTime * speed),
                 Mathf.LerpAngle(currentRot.y, currentRot.y, Time.deltaTime * speed),
                 Mathf.LerpAngle(currentRot.z, -_tiltAmount, Time.deltaTime * speed));
            }
            else
            {

                currentRot = new Vector3(
                 Mathf.LerpAngle(currentRot.x, currentRot.x, Time.deltaTime * speed),
                 Mathf.LerpAngle(currentRot.y, currentRot.y, Time.deltaTime * speed),
                 Mathf.LerpAngle(currentRot.z, 0, Time.deltaTime * speed));
            }

            cameraTransform.eulerAngles = currentRot;

        }
    }
}