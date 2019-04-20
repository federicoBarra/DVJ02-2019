using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase02
{
    public class RigidbodiesExample : MonoBehaviour
    {
        private Rigidbody rig;
        public float force = 10;

        private void Start()
        {
            rig = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                rig.AddForce(Vector3.up*force);
        }
    }
}
