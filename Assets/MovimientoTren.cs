using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTren : MonoBehaviour
{

    int drops = 0;
    GameObject[] vagones;
    // Start is called before the first frame update
    void Start()
    {
        vagones = GameObject.FindGameObjectsWithTag("VagonDejable");
    }

    // Update is called once per frame
    void Update()
    {
        checkPosition();
        checkWagon();
    }

    void checkPosition()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 0, -3) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 0, +3) * Time.deltaTime);
        }
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime);
        //}
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        }
    }

    void checkWagon()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (drops < vagones.Length)
            {
                vagones[drops].GetComponent<Transform>().parent = null;
                drops++;
            }

        }
    }

}
