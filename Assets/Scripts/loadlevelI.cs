using UnityEngine;
using UnityEngine.SceneManagement;
public class loadlevelI : MonoBehaviour {

    // loads level 1
    public void LoadFirstLevel () {
        SceneManager.LoadScene("Level-01");
    }
}
