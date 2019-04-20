using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase04
{
public class QuaternionsExample : MonoBehaviour
{
    public Transform pingPongTransform;

    public Transform SetLookRotation;

    [Header("Angle")]
    public Transform AngleBetween01;
    public Transform AngleBetween02;
    public float angle;

    [Header("RotateTowards")]
    public Transform RotateTowards;
    public Transform RotateTowardsDestiny;
    public float RotateTowardsSpeed = 2;

    [Header("Slerp")]
    public Transform SlerpTarget;
    public Transform SlerpFrom;
    public Transform SlerpTo;

    private void Start()
    {
    }

    private void Update()
    {
        pingPongTransform.transform.position = new Vector3(Mathf.PingPong(Time.time, 2), Mathf.PingPong(Time.time, 5), Mathf.PingPong(Time.time, 10));

        
        Quaternion q01 = Quaternion.identity;
        q01.SetLookRotation(pingPongTransform.position - SetLookRotation.position, Vector3.up); // similar to LookRotation
        SetLookRotation.rotation = q01;


        angle = Quaternion.Angle(AngleBetween01.rotation, AngleBetween02.rotation);


        RotateTowards.rotation = Quaternion.RotateTowards(RotateTowards.rotation, RotateTowardsDestiny.rotation, RotateTowardsSpeed * Time.deltaTime);


        SlerpTarget.rotation = Quaternion.Slerp(SlerpFrom.rotation, SlerpTo.rotation, Mathf.PingPong(Time.time, 2)/2);

    }
}
}
