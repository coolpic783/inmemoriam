using System.Collections;
using System.Collections.Generic;
using VIDE_Data;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject container_NPC;
    public GameObject container_PLAYER;
    public Text text_NPC;
    public Text[] text_Choices;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!VD.isActive)
            {
                Begin();
            }
        }
    }

    void Begin()
    {
    
    }
}
