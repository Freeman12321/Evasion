using UnityEngine;

public class endtrigger : MonoBehaviour {
    //calls the Complete function from through variable and not through finObjectOfType<gamemanager>.Complete which would have worked fine aswell.
    public gamemanagement gameManager;
    //when triggered (pass through) the end trigger at the end of the level.
    public void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
