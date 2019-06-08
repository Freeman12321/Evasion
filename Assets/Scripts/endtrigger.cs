using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endtrigger : MonoBehaviour {

    public gamemanagement gameManager;
    public void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
