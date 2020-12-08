using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    public float Speed;

    // Update is called once per frame
    void Update() {

        var x = Input.GetAxisRaw("Horizontal") * Speed;
        var y = Input.GetAxisRaw("Vertical") * Speed;

        transform.position += new Vector3(x, y);
    }
}
