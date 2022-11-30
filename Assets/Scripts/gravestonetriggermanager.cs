using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravestonetriggermanager : MonoBehaviour
{

    public GameObject gravestone;
    public GameObject playerKneel;
    public GameObject player;

    void Start()
    {
        BoxCollider2D gravebc = gravestone.GetComponent<BoxCollider2D>();
        BoxCollider2D playerbc = player.GetComponent<BoxCollider2D>();
    }
    void OnTriggerEnter2D(BoxCollider2D playerbc)
    {


        Debug.Log("gravestone cutscene triggered.");
    }

}
