using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScanesManager : MonoBehaviour
{
    public int Scane2Index;
    


    public void NextScane()
    {
        SceneManager.LoadScene(Scane2Index);
    }
    
   
}
