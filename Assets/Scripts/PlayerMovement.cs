using Photon.Pun;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    public float Speed;

    private PhotonView myView;
    private void Start() {
        myView = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update() {
        if (!myView.IsMine && PhotonNetwork.IsConnected) {
            return;
        }

        var x = Input.GetAxisRaw("Horizontal") * Speed;
        var y = Input.GetAxisRaw("Vertical") * Speed;

        transform.position += new Vector3(x, y);
    }
}
