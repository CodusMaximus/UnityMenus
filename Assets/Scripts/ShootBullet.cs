using Photon.Pun;
using UnityEngine;

public class ShootBullet : MonoBehaviour {

    [SerializeField]
    GameObject bulletPrefab;

    PhotonView photonView;
    void Start() {
        photonView = GetComponent<PhotonView>();
    }
    void Update() {
        if (!photonView.IsMine && PhotonNetwork.IsConnected) {
            return;
        }

        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }

    void Shoot() {
        if (PhotonNetwork.IsConnected) {
            PhotonNetwork.Instantiate("Bullet", transform.position, transform.rotation);
        }
        else {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}
