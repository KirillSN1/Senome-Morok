using Disease;
using UnityEngine;
using UnityEngine.Events;

namespace NPC
{
    public class NpcController : MonoBehaviour
    {
        private bool _collisionBool;

        public KeyCode collectButton;

        public DiseaseType disease;

        public NpcEvent onNpcActive;

        void Start()
        {
            _collisionBool = false;
            //todo
            //генерация болезней, надо сделать
            disease = (DiseaseType) Random.Range(1, 3);
        }

        void Update()
        {
            if (_collisionBool)
            {
                if (Input.GetKeyDown(collectButton))
                {
                    onNpcActive.Invoke(disease);
                }
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                _collisionBool = true;
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                _collisionBool = false;
            }
        }
    }

    [System.Serializable]
    public class NpcEvent : UnityEvent<DiseaseType>
    {
    }
}