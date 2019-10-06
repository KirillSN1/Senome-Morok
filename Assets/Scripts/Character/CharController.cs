using System.Collections.Generic;
using UnityEngine;

namespace Character
{
    public class CharController : MonoBehaviour
    {
        public string diseaseName;
        public bool onDisease;
        public float degree;

        public float degreeSpeed;

        void Start()
        {
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

        public void Disease(Disease.Disease disease)
        {
            if (Random.Range(0f, 1f) < 0.2f)
            {
                onDisease = true;
                degree += disease.DegreeStep * 0.005f;
                degreeSpeed = disease.DegreeSpeed;
                diseaseName = disease.Name;
            }
        }

        public void Dead()
        {
            //todo
            //Сделать смерть
        }
    }
}