using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCredits : MonoBehaviour
{
    public GameObject FadeSquare;
    public GameObject CreditsSceneEnter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ViewCredits()
    {
        Instantiate(FadeSquare);
        Instantiate(CreditsSceneEnter);
    }

    public void EnterCreditsScene()
    {

    }
}
