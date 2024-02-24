using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadAnim : MonoBehaviour
{
    public Animator animator;
    public RenderTexture renderTexture;
    public RawImage Animation_capture;
    public GameObject gameObjects;

    private void Awake()
    {
       
    }
    public void Start()
    {
        gameObjects = GameObject.FindGameObjectWithTag("Rawimage");
        //Animation_capture = GetComponent<RawImage>();

        renderTexture = new RenderTexture(256, 256, -1);
        Animation_capture.texture = renderTexture;

        
        int LastAnimationIndex = PlayerPrefs.GetInt("LastAnimation");
        animator.SetInteger("LastAnimation", LastAnimationIndex);
    }

    public void Update()
    {
         //animator.SetInteger("IndexAnim", 1);
         Camera.main.targetTexture = renderTexture;
           
       
    }


}
