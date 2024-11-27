using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generadorenemigos : MonoBehaviour
{
    public GameObject enemigo;
    public float contador;
    public float limite;
    public float min;
    public float max;
    public float ubicacion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contador = contador + Time.deltaTime;
        if(contador > limite)
        {

            ubicacion = Random.Range(min, max);
            Instantiate(enemigo, new Vector2(ubicacion, transform.position.y), transform.rotation);
            contador = 0;
        }
    }
}
