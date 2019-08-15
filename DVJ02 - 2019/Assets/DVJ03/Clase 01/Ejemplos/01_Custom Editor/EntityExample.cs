using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ03.Clase01
{
public class EntityExample : MonoBehaviour
{
    public int unInt;
    public string texto;
    public bool unBool;

    public enum Cosas
    {
        UnaCosa,
        OtraCosa,
        OtraMas
    }

    public Cosas cosas;
}
}