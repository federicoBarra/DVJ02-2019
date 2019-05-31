using UnityEditor;
using UnityEngine;

namespace DVJ02.Clase08
{
public class PlayerControllerTest : MonoBehaviour
{
    protected Camera cam;
    private bool moving;
    private Vector3 movingTo;
    protected Rigidbody rig;

    public int groundLayer = 0;
    public float speed = 10;
    public float distanceToStop = 1;
    void Start()
    {
        cam = Camera.main;
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        GameObject goHit;

        if (Input.GetMouseButtonUp(1))
        {
            if (Physics.Raycast(ray, out hit, 50))
            {
                goHit = hit.transform.gameObject;
                if (goHit)
                {
                    if (goHit.layer == groundLayer)
                        SetDestination(hit.point);
                }
            }
        }

        if (moving)
        {
            Move();
        }

        if (Vector3.Distance(transform.position, movingTo) < distanceToStop)
        {
            Stop();
        }
    }

    private void SetDestination(Vector3 _movingTo)
    {
        movingTo = _movingTo;
        moving = true;
    }

    private void Move()
    {
        Vector3 currentPos = transform.position;
        Vector3 direction = movingTo - currentPos;

        Vector3 wantedVelocity = direction.normalized * speed * Time.deltaTime;

        RaycastHit hitInfo;
        Vector3 m_GroundNormal;
        if (Physics.Raycast(transform.position + (Vector3.up * 0.1f), Vector3.down, out hitInfo, 5))
        {
            m_GroundNormal = hitInfo.normal;
            wantedVelocity = Vector3.ProjectOnPlane(wantedVelocity, m_GroundNormal);
        }

        rig.velocity = wantedVelocity;
    }

    private void Stop()
    {
        moving = false;
        rig.velocity = Vector3.zero;
    }
}
}
