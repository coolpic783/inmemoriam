using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravestonetriggermanager : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject gravestone;
    public GameObject playerKneel;
    public GameObject player;
    public bool CutsceneNotTriggered = true;

    void Start()
    {
        BoxCollider2D gravebc = gravestone.GetComponent<BoxCollider2D>();
        BoxCollider2D playerbc = player.GetComponent<BoxCollider2D>();
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    void OnTriggerStay2D(Collider2D playerbc)
    {
        if (CutsceneNotTriggered)
        {
            if (Input.GetKeyDown("E"))
            {
                Debug.Log("gravestone cutscene triggered.");

                TriggerDialogue();
                CutsceneNotTriggered = false;
            }
        }
    }

}
