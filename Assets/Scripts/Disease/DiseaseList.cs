using System.Collections.Generic;
using UnityEngine;

namespace Disease
{
    public class DiseaseList : MonoBehaviour
    {
        public ICollection<DiseaseModel> List()
        {
            return new List<DiseaseModel>
            {
                new DiseaseModel {Id = 1, Name = "cholera", DegreeSpeed = 2, DegreeStep = 5},
                new DiseaseModel {Id = 2, Name = "AIDS", DegreeSpeed = 1, DegreeStep = 5},
                new DiseaseModel {Id = 3, Name = "plague", DegreeSpeed = 3, DegreeStep = 6},
                new DiseaseModel {Id = 4, Name = "diarrhea", DegreeSpeed = 3, DegreeStep = 6}
            };
        }
    }
}
 