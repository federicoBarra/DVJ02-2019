using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase02
{
    public class CollidersExample : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log(name + " OnCollisionEnter " + collision.gameObject.name);
        }

        private void OnCollisionExit(Collision collisionInfo)
        {
            Debug.Log(name + " OnCollisionExit " + collisionInfo.gameObject.name);
        }

        private void OnCollisionStay(Collision collisionInfo)
        {
            Debug.Log(name + " OnCollisionStay " + collisionInfo.gameObject.name);
        }
    }
}