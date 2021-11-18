using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    public bool pausado;
    public GameObject HUDimage;

    // Start is called before the first frame update
    void Start()
    {
        pausado = true;
    }

    // Update is called once per frame
    void Update()
    {
        if( pausado )
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                pausado = false;
            }
            
            HUDimage.SetActive(true);
            GameMaster.instance.Pausar(true);
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                pausado = true;
            }
            
            HUDimage.SetActive(false);
            GameMaster.instance.Pausar(false);
        }
    }
}
