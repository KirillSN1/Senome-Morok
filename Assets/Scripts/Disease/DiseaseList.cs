using System.Collections.Generic;
using UnityEngine;

namespace Disease
{
    public class DiseaseList : MonoBehaviour
    {
        public ICollection<Disease> List()
        {
            return  new List<Disease>
            {
                new Disease {Id = 1, Name = "cholera", DegreeSpeed = 2, DegreeStep = 5},
                new Disease {Id = 2, Name = "AIDS", DegreeSpeed = 1, DegreeStep = 5},
                new Disease {Id = 3, Name = "plague", DegreeSpeed = 3, DegreeStep = 6}
            };
        }
    }
}