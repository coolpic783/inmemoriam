using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUpAnimationComplete : StateMachineBehaviour
{
    public PrologueEventManager PEM;

    void Start()
    {
        PEM = GameObject.FindGameObjectWithTag("Manager").GetComponent<PrologueEventManager>();
    }
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
   public void ContinueCutscene()
    {
        PEM = GameObject.FindGameObjectWithTag("Manager").GetComponent<PrologueEventManager>();
        PEM.FadeBlackOutSquare(true, 5);
    }
