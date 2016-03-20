using UnityEngine;
using FATEC.ArcadeSpaceBattle.Abstractions;
using FATEC.ArcadeSpaceBattle.Controllers;
using FATEC.ArcadeSpaceBattle.Joysticks;
using FATEC.ArcadeSpaceBattle.Managers;
using FATEC.ArcadeSpaceBattle.Objects;
using FATEC.ArcadeSpaceBattle.Behaviours;

namespace FATEC.ArcadeSpaceBattle {
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
        public int maxProjectileInScene;
        public int maxBarrierInScene;
        public int maxTowerInScene;
        //prefab
        public GameObject player1Ship;
        public GameObject player2Ship;
        //public GameObject _laser;
        //public GameObject _laser2;

        public void Awake() {
            ///Instantiate a model to get all componentes reference for create e ship
            //GameObject player1Ship = (GameObject)Instantiate(_player1Ship.gameObject, _player1Ship.transform.position, _player1Ship.transform.rotation);
            //GameObject player2Ship = (GameObject)Instantiate(_player2Ship.gameObject, _player2Ship.transform.position, _player2Ship.transform.rotation);

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
            /*
            laser = new Projectile(
                _laser.gameObject,
                _laser.GetComponent<Transform>(),
                _laser.GetComponent<TransformMoviment>(),
                _laser.tag);
                */
            MI = new ManagerInstantiate(maxProjectileInScene, maxBarrierInScene, maxTowerInScene);

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
