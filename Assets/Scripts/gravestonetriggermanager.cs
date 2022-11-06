using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravestonetriggermanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        public GameObject gravestone;
        public GameObject playerKneel;
        public GameObject player;
        
        BoxCollider2d gravebc = gravestone.GetComponent<BoxCollider2d>();
        BoxCollider2d playerbc = player.GetComponent<BoxCollider2d>();
    }

    void OnTriggerEnter2D(playerbc)
    {
        Debug.Log("gravestone cutscene triggered.");
        
    }
}
