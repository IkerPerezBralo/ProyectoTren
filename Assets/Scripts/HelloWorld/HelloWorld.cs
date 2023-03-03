using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Juego
{

    public class HelloWorld : MonoBehaviour
    {
        // const int MaxEnemies = 10;
        // Character[] EnemyCharacters = new Enemy[10];
        // Enemy[] Enemigos;

        private Player player;
        private List<Enemy> enemies;
        private int contadorEnemigos;

        // Start is called before the first frame update
        void Start()
        {
            //  Player player1 = new Player("Player1");

            //  for(int runs = 0; runs < MaxEnemies; runs++)
            //  {
            //      Enemy enemy = new Enemy("Enemy" + runs);
            //      Enemigos[runs] = enemy;
            //  }

            player = new Player("Pascual");

            enemies = new List<Enemy>();
            enemies.Add(new Enemy("Pedro"));
            enemies.Add(new Enemy("Manolo"));
            enemies.Add(new Enemy("Juan"));

        }

        // Update is called once per frame
        void Update()
        {

            foreach (Enemy enemy in enemies)
            {
                if (enemy.Name == "Pedro")
                {
                    Debug.Log("Encontrado! " + enemy.Name);
                }
            }
        }
    }
}