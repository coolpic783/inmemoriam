using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public GameObject dialogue1;
    public GameObject dialogue2;
    public PrologueEventManager PEM;
    public GameObject PlayerDummy;
    public GameObject RealPlayer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeStuff()
    {
        PEM = GameObject.FindGameObjectWithTag("Manager").GetComponent<PrologueEventManager>();
        StartCoroutine(FadeTextToFullAlpha(1f, dialogue1.GetComponent<Text>()));
        StartCoroutine(FadeTextToZeroAlpha(2f, dialogue1.GetComponent<Text>()));
        PEM.SetActiveCamera(1);
        StartCoroutine(FadeTextToFullAlpha(2f, dialogue2.GetComponent<Text>()));
        StartCoroutine(FadeTextToZeroAlpha(2f, dialogue2.GetComponent<Text>()));
        RealPlayer.SetActive(true);
        return;
    }

    public IEnumerator FadeTextToFullAlpha(float speed, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / speed));
            yield return new WaitForSecondsRealtime(2);
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float speed, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / speed));
            yield return new WaitForSecondsRealtime(2);
        }
    }
}
