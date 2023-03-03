using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Object[] gameObjects;
    [Serialize]
    public string objectName;
    [Serialize]
    public Color color;
    public Object objeto;
    [Serialize]
    public string choosenTag;
    [Serialize]
    public bool yesTag = true;
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
            if (yesTag = true)
            {
                if (item.GetComponent<MeshRenderer>())
                {
                    if (this.tag == "Azul")
                    {
                        item.GetComponent<MeshRenderer>().material.color = color;
                    }
                    if (this.tag == "Verde")
                    {
                        item.GetComponent<MeshRenderer>().material.color = color;
                    }
                }
            }
        }
    }
}
