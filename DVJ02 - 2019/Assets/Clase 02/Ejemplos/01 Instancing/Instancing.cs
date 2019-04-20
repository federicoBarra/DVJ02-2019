using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase02
{
    public class Instancing : MonoBehaviour
    {

        public Transform prefab;

        private void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(prefab, new Vector3(i*2.0F, 0, 0), Quaternion.identity);
            }
        }
    }
}
