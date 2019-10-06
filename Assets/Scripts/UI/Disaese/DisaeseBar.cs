using Character;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Disaese
{
    public class DisaeseBar : MonoBehaviour
    {
        private GameObject player;

        private float _degree;
        private CharController _charController;
        public Transform degreeBar;
        public Text diseaseType;
        
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
            _charController = player.GetComponent<CharController>();
        }

        void Update()
        {
            if (_charController.onDisease)
            {
                degreeBar.localScale = new Vector3(_charController.degree,1f);
                diseaseType.text = _charController.diseaseName;
            }
        }
    }
}