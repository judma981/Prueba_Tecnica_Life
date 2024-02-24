using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character_animations : MonoBehaviour
{
    public Animator Animator_Dances;
    public int IndexAnimation;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        Animator_Dances = GetComponent<Animator>();
    }

       public void Macarena_Dance()
    {
        IndexAnimation = 1;
        PlayAnimation();
        Debug.Log("index" + IndexAnimation);
    }
    
    public void House_Dance()
    {

        IndexAnimation = 2;
        PlayAnimation();
        Debug.Log("index" + IndexAnimation);

    }
    public void HipHop_Dance()
    {
        IndexAnimation = 3;
        PlayAnimation();
        Debug.Log("index" + IndexAnimation);
    }

    private void PlayAnimation()
    {
        Animator_Dances.SetInteger("IndexAnim", IndexAnimation); 
    
    }

     public void Sceneload()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("LastAnimation",IndexAnimation);
        
    }
    

}
