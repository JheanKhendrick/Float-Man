using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class hasShrunk : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float shrinkDuration;
    private float elapsedTime;
    public GameObject countdown;
    public Text time;
    public AudioSource growSound;
    private bool hasGrown = false;
    void Update()
    {
        if (player != null)
        {

            if (player.transform.localScale == new Vector3(0.3653499f, 0.3761048f, 1f))
            {
                if(time.text != "-1")
                countdown.SetActive(true);
                elapsedTime += 1 * (Time.deltaTime * 1);
                float countdwn = shrinkDuration - elapsedTime;
                time.text = Mathf.FloorToInt(countdwn).ToString();
                if (elapsedTime >= shrinkDuration)
                {
                    player.transform.localScale = new Vector3(0.8498486f, 0.8686022f, 1f);
                    elapsedTime = 0f;
                    hasGrown = true;
                }
            }
            else
            {
                if (hasGrown)
                {
                    growSound.Play();
                    hasGrown = false;
                }
                countdown.SetActive(false);
            }
        }
        else
        {
            countdown.SetActive(false);
        }
        
    }
}
