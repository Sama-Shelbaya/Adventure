using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource levelupSoundEffect;
    private bool levelCompletted = false;
    // Start is called before the first frame update
   private void Start()
    {
        levelupSoundEffect = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name=="player" && !levelCompletted)
        {
            levelupSoundEffect.Play ();
            levelCompletted = true;
            Invoke("completeLevel", 2f);
            
        }
    }

    private void completeLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
