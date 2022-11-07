using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravestonetriggermanager : MonoBehaviour
{

    public static GameObject gravestone;
    public static GameObject playerKneel;
    public static GameObject player;

    BoxCollider2D gravebc = gravestone.GetComponent<BoxCollider2D>();
    BoxCollider2D playerbc = player.GetComponent<BoxCollider2D>();

    void OnTriggerEnter2D(BoxCollider2D playerbc)
{
    Debug.Log("gravestone cutscene triggered.");

}
}
