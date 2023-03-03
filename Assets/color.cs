using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Buenas tardes, me llamo {this.name}");
          Material m_Material = GetComponent<Renderer>().material;
        m_Material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
