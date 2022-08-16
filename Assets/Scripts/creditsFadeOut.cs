using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditsFadeOut : MonoBehaviour
{
    public void leaveCreditsScene(int index = 0)
    {
        SceneManager.LoadScene(index);
    }
}
