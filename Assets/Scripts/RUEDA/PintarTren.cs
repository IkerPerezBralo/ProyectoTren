using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PintarTren : MonoBehaviour
{
    Object[] gameObjects;
    [Serialize]
    public Color color;
    [Serialize]
    public string choosenTag;
    [Serialize]
    public bool searchYag;
    // Start is called before the first frame update
    void Start()
    {
        gameObjects = GameObject.FindGameObjectsWithTag(choosenTag);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var item in gameObjects)
        {
            if (searchYag = true)
            {
                if (item.GetComponent<MeshRenderer>())
                {
                    if (this.tag == choosenTag)
                    {
                        item.GetComponent<MeshRenderer>().material.color = color;
                    }
                    
                }
            }
        }
    }
}
