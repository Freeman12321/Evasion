using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {
    
    public void LoadLevelI() {
        Debug.Log("Level 1");
        SceneManager.LoadScene("Level-01");
	}
}
