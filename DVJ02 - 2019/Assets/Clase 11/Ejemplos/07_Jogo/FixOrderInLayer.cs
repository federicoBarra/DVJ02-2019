using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase11
{
    public class FixOrderInLayer : MonoBehaviour
    {
        public Transform player;
        public List<SpriteRenderer> enemies;

        public int playerOrderInLayer = 10;

        void FixedUpdate()
        {
            float playerY = player.position.y;

            foreach (SpriteRenderer enemy in enemies)
            {
                if (enemy.transform.position.y > playerY)
                    enemy.sortingOrder = playerOrderInLayer - 1;
                else
                    enemy.sortingOrder = playerOrderInLayer + 1;
            }
        }
    }
}
