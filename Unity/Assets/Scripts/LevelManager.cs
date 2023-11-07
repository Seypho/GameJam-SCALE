using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public bool playingStage0 = true;
    GameObject camera0;
    [SerializeField] GameObject player0;
    [SerializeField] GameObject camera1;
    [SerializeField] GameObject player1;
    S0PlayerMovement playerMovement0;
    S1PlayerMovement playerMovement1;

    void Awake()
    {
        camera0 = Camera.main.gameObject;
        playerMovement0 = player0.GetComponent<S0PlayerMovement>();
        playerMovement1 = player1.GetComponent<S1PlayerMovement>();
    }

    void Update()
    {
        ChangeStage();
    }

    void ChangeStage()
    {
        if (playingStage0)
        {
            camera0.SetActive(true);
            playerMovement0.enabled = true;
            camera1.SetActive(false);
            playerMovement1.enabled = false;
        }
        else
        {
            camera0.SetActive(false);
            playerMovement0.enabled = false;
            camera1.SetActive(true);
            playerMovement1.enabled = true;
        }
    }
}
