using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public string Name { get; private set; }
    

    public  Character(string name)
    {
        Name = name;

        Debug.Log($"Hola, soy {Name}");
    }
    ~Character()
    {
        Debug.Log("Destruido");
    }
}

public class Player : Character
{
    public Player(string name) : base(name)
    {

    }
}

public class Enemy : Character
{
    public Enemy(string name) : base(name)
    {

    }

}
