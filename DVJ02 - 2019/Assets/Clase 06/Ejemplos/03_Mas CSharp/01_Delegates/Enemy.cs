using System;
using UnityEngine;

namespace DVJ02.Clase06
{
public class Enemy : MonoBehaviour
{
    //Un delegate es basicamente un puntero a funcion.
    public delegate void EnemyKilledAction(Enemy enemy); //define el signature del delegate (delegate type)
    public EnemyKilledAction OnEnemyKilled; //(delegate instance)
    
    private void OnMouseDown()
    {
        EnemyDied();
    }

    void EnemyDied()
    {
        DieAsADispatcher();
        //DieAsADispatcherAsStatic();
    }

    private void DieAsADispatcher()
    {
        if (OnEnemyKilled != null)
            OnEnemyKilled(this);
    }







    public static EnemyKilledAction OnEnemyKilledAsStatic; //(delegate instance)

    private void DieAsADispatcherAsStatic()
    {
        if (OnEnemyKilledAsStatic != null)
            OnEnemyKilledAsStatic(this);
    }

}
}
