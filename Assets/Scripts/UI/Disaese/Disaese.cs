using Character;
using Disease;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Disaese
{
    public class Disaese : MonoBehaviour
    {
        private GameObject player;

        private float _degree;
        private CharController _charController;
        public Transform degreeBar;
        public Text diseaseType;

        // Start is called before the first frame update
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
            _charController = player.GetComponent<CharController>();
        }

        // Update is called once per frame
        void Update()
        {
            if (_charController.onDisease)
            {
                degreeBar.localScale = new Vector3(_charController.degree,1f);
                diseaseType.text = _charController.diseaseList.ToString();
            }
        }
    }
}