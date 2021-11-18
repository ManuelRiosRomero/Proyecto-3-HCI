using System.Collections;
using System.IO.Ports;
using System.Collections.Generic;
using UnityEngine;

public class PuertoController : MonoBehaviour
{
    SerialPort dataStream = new SerialPort("COM4", 9600);
    public string datos;

    // Start is called before the first frame update
    void Start()
    {
        dataStream.Open();
    }

    // Update is called once per frame
    void Update()
    {
        datos = dataStream.ReadLine();        
    }
}
