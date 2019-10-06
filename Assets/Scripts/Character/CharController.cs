using System.Collections.Generic;
using Disease;
using UnityEngine;

namespace Character
{
    public class CharController : MonoBehaviour
    {
        public DiseaseType diseaseList;
        public bool onDisease;
        public float degree;
        
        public float degreeSpeed;
        public float degreeStep;
        
        void Start()
        {
            degree = 0;
            onDisease = false;
        }

        void Update()
        {
            if (onDisease)
            {
                degree += degreeSpeed * 0.005f * Time.deltaTime;
            }

            if (degree >= 100f)
            {
                Dead();
            }
        }

        public void Disease(DiseaseType diseaseType)
        {
            if (Random.Range(0f, 1f) < 0.2f)
            {
                onDisease = true;
                degree += degreeStep;
                diseaseList = diseaseType;
            }
        }

        public void Dead()
        {
            //todo
            //Сделать смерть
        }
    }
}