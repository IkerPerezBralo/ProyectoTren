using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private bool isGoingUp = true;

    // Start is called before the first frame update
    void Start()
    {
        // Transform posicion = GetComponent<Transform>;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Posicion de {this.name} es de {this.GetComponent<Transform>().position}" +
            $" y el angulo de rotacion: {this.GetComponent<Transform>().localRotation}" +
            $" y la escala: {this.transform.localScale}");

        //Position();
        checkPosition();
        checkRotation();
        //Scale();

        void Position()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.position = transform.position + new Vector3(1, 0, 0) * Time.deltaTime;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.position = transform.position + new Vector3(-1, 0, 0) * Time.deltaTime;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.position = transform.position + new Vector3(0, 0, 1) * Time.deltaTime;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.position = transform.position + new Vector3(0, 0, -1 * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.position = transform.position + new Vector3(0, 1, 0) * Time.deltaTime;
            }
            if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
            {
                transform.position = transform.position + new Vector3(0, -1, 0) * Time.deltaTime;
            }
        }

        void checkPosition()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
            {
                transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
            }
        }

        void Scale()
        {
            Vector3 escala = new Vector3(0, 1, 0);

            while(isGoingUp && transform.localScale.y < 8)
            {
                transform.localScale += escala * Time.deltaTime;
                if(transform.localScale.y >= 8)
                {
                    isGoingUp = false;
                }
            }

            while (!isGoingUp && transform.localScale.y > 0)
            {
                transform.localScale -= escala * Time.deltaTime;
                if (transform.localScale.y <= 0)
                {
                    isGoingUp = true;
                }
            }
        }
        void checkRotation()
        {
            transform.rotation *= Quaternion.Euler(0, 1, 0);
            transform.Rotate(new Vector3(0, 100, 0) * Time.deltaTime);
        }
    }
}
