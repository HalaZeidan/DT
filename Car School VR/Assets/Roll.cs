using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SimpleInputNamespace
{
    public class Roll : MonoBehaviour
    {
        SteeringWheel st;
        public GameObject roll;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float ang = roll.GetComponent<SteeringWheel>().wheelAngle;
            Debug.Log(ang);
            transform.localRotation = Quaternion.Euler(0f,0f,-ang);


        }
    }
}