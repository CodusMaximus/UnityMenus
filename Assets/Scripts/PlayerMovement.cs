using Photon.Pun;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    float Speed;

    private PhotonView photonView;
    private void Start() {
        photonView = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update() {
        if (!photonView.IsMine && PhotonNetwork.IsConnected) {
            return;
        }

        var x = Input.GetAxisRaw("Horizontal") * Speed;
        var y = Input.GetAxisRaw("Vertical") * Speed;

        transform.position += new Vector3(x, y);
    }
}
