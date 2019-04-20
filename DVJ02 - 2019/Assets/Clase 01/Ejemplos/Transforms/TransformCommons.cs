using UnityEngine;

namespace DVJ02.Clase01
{
    public class TransformCommons : MonoBehaviour
    {
        private void Start()
        {
            Transform t = this.transform;

            Debug.Log("transform.position: " + transform.position);
            Debug.Log("transform.localPosition: " + transform.localPosition);

            Debug.Log("transform.rotation: " + transform.rotation);
            Debug.Log("transform.localRotation: " + transform.localRotation);

            Debug.Log("transform.lossyScale: " + transform.lossyScale);//global
            Debug.Log("transform.localScale: " + transform.localScale);//relativa al padre

            //etc
        }
    }
}
