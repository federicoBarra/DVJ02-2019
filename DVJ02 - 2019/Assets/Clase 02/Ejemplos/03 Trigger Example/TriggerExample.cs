using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase02
{
    public class TriggerExample : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log(name + " OnCollisionEnter " + other.gameObject.name);
        }

        private void OnTriggerExit(Collider other)
        {
            Debug.Log(name + " OnCollisionExit " + other.gameObject.name);
        }

        private void OnTriggerStay(Collider other)
        {
            Debug.Log(name + " OnCollisionStay " + other.gameObject.name);
        }
    }
}
