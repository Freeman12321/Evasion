using UnityEngine;

public class bounce : MonoBehaviour {
    //record start position
    float startY;
    void Start() {
        startY = transform.position.y;
    }

    Vector3 upDir = Vector3.up;

    public float maxHeight = 3f;
    //move an obsticle up until it reaches the the variable in line 12 or the one set in unity
    //then move it back down (* -1) until it reaches the start position (StartY) repeat because its updating.
    void Update() {
        transform.Translate(upDir * Time.deltaTime);
        Vector3 pos = transform.position;
        if (pos.y > maxHeight) {
            transform.position = new Vector3(pos.x, maxHeight, pos.z);
            upDir = upDir * -1f;
        }
        else if (pos.y < startY) {
            transform.position = new Vector3(pos.x, startY, pos.z);
            upDir = upDir * -1f;
        }
    }
}
