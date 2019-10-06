using System.Linq;
using Disease;
using UnityEngine;
using UnityEngine.Events;

namespace NPC
{
    public class NpcController : MonoBehaviour
    {
        private bool _collisionBool;

        public KeyCode collectButton;

        private Disease.Disease Disease { get; set; }

        public NpcEvent onNpcActive;

        void Start()
        {
            _collisionBool = false;
            var diseaseList = GetComponentInChildren<DiseaseList>().List();
            //todo
            //генерация болезней, надо сделать
            Disease = new Disease.Disease();
            var id = Random.Range(1, 3);
            Disease = diseaseList.Single(x => x.Id == id);
        }


        void Update()
        {
            if (_collisionBool)
            {
                if (Input.GetKeyDown(collectButton))
                {
                    onNpcActive.Invoke(Disease);
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
    public class NpcEvent : UnityEvent<Disease.Disease>
    {
    }
}