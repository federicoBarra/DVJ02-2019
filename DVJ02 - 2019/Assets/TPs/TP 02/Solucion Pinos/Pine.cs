using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase05
{
    public class Pine : MonoBehaviour
    {

        public float localRotX;
        public float localRotY;
        public float localRotZ;

        public Vector3 up;

        public Material common;
        public Material dropped;
        private Renderer rend;

        private void Start()
        {
            rend = GetComponent<Renderer>();
        }

        private void Update()
        {
            localRotX = (transform.localEulerAngles.x + 360)%360;
            localRotY = (transform.localEulerAngles.y + 360)%360;
            localRotZ = (transform.localEulerAngles.z + 360)%360;

            up = transform.up;

            bool drop = false;

            if (localRotZ > 60 && localRotZ < 330 || (localRotX > 60 && localRotX < 330))
                drop = true;

            if (drop)
                rend.sharedMaterial = dropped;
            else
                rend.sharedMaterial = common;
        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Pine Triggered with: " + other.name);
        }
    }

}