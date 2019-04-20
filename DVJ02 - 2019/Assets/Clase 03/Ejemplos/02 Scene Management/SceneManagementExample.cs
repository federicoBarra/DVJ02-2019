using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DVJ02.Clase03
{
    public class SceneManagementExample : MonoBehaviour
    {

        // Use this for initialization
        private void Start()
        {

        }

        // Update is called once per frame
        private void Update()
        {

        }

        private void LoadScene()
        {
            //La escena necesita estar agregada a las Build Settings
            SceneManager.LoadScene("SceneManagementExample 02");
        }

    }
}
