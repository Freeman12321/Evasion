using UnityEngine;
//imperative for scene changes
using UnityEngine.SceneManagement;

public class levelcomplete : MonoBehaviour {
    //loads the next scene in the build index
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
