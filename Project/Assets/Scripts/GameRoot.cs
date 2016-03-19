using UnityEngine;
using FATEC.OOTest.Abstractions;
using FATEC.OOTest.Controllers;
using FATEC.OOTest.Joysticks;
using FATEC.OOTest.Managers;
using FATEC.OOTest.Objects;
using FATEC.OOTest.Behaviours;

namespace FATEC.OOTest {
    /// <summary>
    /// Game root.
    /// </summary>
    public class GameRoot : MonoBehaviour {

        public Ship player1;
        public Ship player2;
        public Projectile laser;
        public IJoystick joystickPlayer1;
        public IJoystick joystickPlayer2;
        public MovimentController MCP1;
        public MovimentController MCP2;
        public GunController GCP1;
        public GunController GCP2;

        public ManagerInstantiate MI;

        //configs
        public float speedPlayer1 = 0.5f;
        public float speedPlayer2 = 0.5f;
        public float fireRatePlayer1 = 0.5f;
        public float fireRatePlayer2 = 0.5f;
        //prefab
        public GameObject _Player1Ship;
        public GameObject _Player2Ship;
        public GameObject _laser;

        public void Awake() {
            ///Instantiate a model to get all componentes reference for create e ship
            GameObject player1Ship = (GameObject)Instantiate(_Player1Ship.gameObject, _Player1Ship.transform.position, _Player1Ship.transform.rotation);
            GameObject player2Ship = (GameObject)Instantiate(_Player2Ship.gameObject, _Player2Ship.transform.position, _Player2Ship.transform.rotation);

            ///Set all references to work with this
            player1 = new Ship(
                player1Ship.gameObject,
                player1Ship.GetComponent<Transform>(),
                player1Ship.GetComponent<TransformMoviment>(),
                player1Ship.GetComponents<ProjectileGun>(),
                player1Ship.tag);
            player2 = new Ship(
                player2Ship.gameObject,
                player2Ship.GetComponent<Transform>(),
                player2Ship.GetComponent<TransformMoviment>(),
                player2Ship.GetComponents<ProjectileGun>(),
                player2Ship.tag);

            laser = new Projectile(
                _laser.gameObject,
                _laser.GetComponent<Transform>(),
                _laser.GetComponent<TransformMoviment>(),
                _laser.tag);

            MI = new ManagerInstantiate();

            this.joystickPlayer1 = new JoystickPlayer1();
            joystickPlayer2 = new JoystickPlayer2();

            MCP1 = new MovimentController(player1.mover, joystickPlayer1, speedPlayer1);
            MCP2 = new MovimentController(player2.mover, joystickPlayer2, speedPlayer2);

            GCP1 = new GunController(player1.guns, joystickPlayer1, fireRatePlayer1, MI);
            GCP2 = new GunController(player2.guns, joystickPlayer2, fireRatePlayer2, MI);

            StartCoroutine(MCP1.Update());
            StartCoroutine(MCP2.Update());
            StartCoroutine(GCP1.Update());
            StartCoroutine(GCP2.Update());
            StartCoroutine(MI.Update());

        }
    }
}
