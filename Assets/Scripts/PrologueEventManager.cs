using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrologueEventManager : MonoBehaviour
{
    public GameObject[] cameraList; //creates a list of camera gameobjects - that is, the opening cutscene camera and the player camera 
    public GameObject BlackOutSquare;
    public GameObject UnFade;
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

    public IEnumerator FadeBlackOutSquare(bool fadeToBlack, int fadeSpeed)
    {
        Color objectColor = BlackOutSquare.GetComponent<Image>().color;
        float fadeAmount;

        if (fadeToBlack)
        {
            while (BlackOutSquare.GetComponent<Image>().color.a < 1)
            {
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                BlackOutSquare.GetComponent<Image>().color = objectColor;
                yield return new WaitForSecondsRealtime(2);
            }
        }
        else
        {
            while (BlackOutSquare.GetComponent<Image>().color.a > 0)
            {
                fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.b, fadeAmount);
                BlackOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
            }
        }
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
