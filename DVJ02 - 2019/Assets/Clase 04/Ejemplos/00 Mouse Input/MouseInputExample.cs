using UnityEngine;

namespace DVJ02.Clase04
{
public class MouseInputExample : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        Debug.Log("Axis (x|y) = ( " + x + " | " + y + " )");

        Vector3 mousePos = Input.mousePosition;

        Debug.Log("Position (x|y) = ( " + mousePos.x + " | " + mousePos.y + " )");

        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        Debug.DrawRay(ray.origin, ray.direction * 50, Color.yellow);

    }
}
}
