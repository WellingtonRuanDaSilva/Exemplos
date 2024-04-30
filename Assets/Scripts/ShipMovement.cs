using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rig;


    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var vector = new Vector3(horizontal, vertical, 0);

        //Controle por Velocidade
        rig.velocity = vector * speed;
        
        
        //Controle por Fisica
        //rig.AddForce(vector * speed * Time.deltaTime);


        //Controle por Vetores

        //transform.position += vector * speed * Time.deltaTime;

    }
}
