using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public int GasInput;
        public int BreakInput;




        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }

        public void GasPressed()
        {
            GasInput = 1;
        }
        public void GasReleased()
        {
            GasInput = 0;
        }

        public void BreakPressed()
        {
            GasInput = 1;
        }
        public void BreakReleased()
        {
            GasInput = 0;
        }


        private void FixedUpdate()
        {
            float h = SimpleInput.GetAxis("Horizontal");
            float v = GasInput;

            // pass the input to the car!
            // float h = CrossPlatformInputManager.GetAxis("Horizontal");
            //float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = BreakInput;
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
