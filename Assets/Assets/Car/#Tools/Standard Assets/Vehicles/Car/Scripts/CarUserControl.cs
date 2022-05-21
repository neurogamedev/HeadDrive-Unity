using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        private HeadTilt m_HeadTilt;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
            m_HeadTilt = GameObject.FindWithTag("Player").GetComponent<HeadTilt>();
        }


        private void FixedUpdate()
        {
            // pass the key/xbox controller input to the car
            //float h = CrossPlatformInputManager.GetAxis("Horizontal");
            //float v = CrossPlatformInputManager.GetAxis("Vertical");

            float h = m_HeadTilt.headYaw;
            float v = m_HeadTilt.headPitch;

#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
