using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrologueEventManager : MonoBehaviour
{
    public GameObject[] cameraList; //creates a list of camera gameobjects - that is, the opening cutscene camera and the player camera 
    public GameObject BlackOutSquare;
    public GameObject RealPlayer;
    // Start is called before the first frame update, Awake is called as soon as possible
    void Awake()
    {
        SetActiveCamera(0);
        RealPlayer.SetActive(false);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetActiveCamera(int camNum)
    {
        //switches which camera in the list is active
        for (int i = 0; i < cameraList.Length; i++)
        {
            if (i == camNum)
            {
                cameraList[i].SetActive(true);
            }
            else
                cameraList[i].SetActive(false);
        }
    }
}
