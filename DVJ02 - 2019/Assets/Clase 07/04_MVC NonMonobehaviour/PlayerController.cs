using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase06
{
public class PlayerController : MonoBehaviour
{
    public PlayerStats stats;
    // Use this for initialization
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            LevelUp();
    }

    private void LevelUp()
    {
        stats.AddToAllStats();
    }
}
}