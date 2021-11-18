using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float movementSpeed = 0.06f;
    Vector3 moveDirection;
    private float rotationSpeed = 70f;

    Rigidbody rb;


    void Start()
    {
        moveDirection = new Vector3(-1, 0, 0);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Locomotion();
    }
    void Locomotion()
    {
        //rb.MovePosition(transform.position + (moveDirection * movementSpeed * Time.deltaTime));
        //transform.position = transform.position + (moveDirection * movementSpeed * Time.timeScale * Time.deltaTime);
        transform.Translate(Vector3.left* Time.deltaTime *movementSpeed);
        
    }
    public void girarDerecha()
    {
        //transform.rotation = transform.rotation * Quaternion.Euler(0,rotationSpeed * Time.deltaTime, 0);
        //moveDirection = transform.rotation * Vector3.left;
        transform.Rotate(Vector3.down * Time.deltaTime * rotationSpeed);

    }
    public void girarIzquierda()
    {
        //transform.rotation = transform.rotation * Quaternion.Euler(0, -rotationSpeed * Time.deltaTime, 0);
        //moveDirection = transform.rotation * Vector3.left;
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
    }
    public void noGirar()
    {
        moveDirection =  Vector3.left;
    }
}
