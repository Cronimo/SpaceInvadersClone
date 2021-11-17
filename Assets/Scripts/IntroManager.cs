using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManager : MonoBehaviour
{
    public GameObject invaders1;
    public GameObject invaders2;
    public GameObject invaders3;

    public GameObject tankPlayer;


    float time = -54f;
    float time2 = -30f;
    float time3 = -9f;
    float destroyTimer = 0f;

    private void Start()
    {
        tankPlayer.GetComponent<TankMovement>().IntroPlaying();
    }

    private void Update()
    {
        time += 20f * Time.deltaTime;
        time2 += 20f * Time.deltaTime;
        time3 += 20f * Time.deltaTime;
        destroyTimer += 1f * Time.deltaTime;

        Debug.Log(time3);
        //Invaders3 Spawn
        for (int i = 0; i < 22; i++)
        {
            if (Mathf.Round(time3) == i)
            {
                invaders3.gameObject.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        if (time3 > 21f)
        {
            //Invaders2 Spawn
            for (int i = 0; i < 22; i++)
            {

                if (Mathf.Round(time2) == i)
                {
                    invaders2.gameObject.transform.GetChild(i).gameObject.SetActive(true);
                }

            }
            if (time2 > 21f)
            {
                //Invaders1 Spawn
                for (int i = 0; i < 11; i++)
                {
                    if (Mathf.Round(time) == i)
                    {
                        invaders1.gameObject.transform.GetChild(i).gameObject.SetActive(true);
                    }
                    Debug.Log(time);
                }
                if (time > 10f)
                {

                    time = 0;
                }
                if (destroyTimer > 3.2f)
                {
                    tankPlayer.GetComponent<TankMovement>().IntroPlaying();
                    Destroy(this.gameObject);
                }
                
            }

        }
    }
}
