using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    private void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Shawn_Level");
            Debug.Log("FUN");
        }
    }
}
