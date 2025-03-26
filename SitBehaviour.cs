using UnityEngine;
using Valve.VR;

public class SitBehaviour : MonoBehaviour
{
    public bool isSitting;
    public GameObject playerStanding, playerSitting, text;

    void Start()
    {
        isSitting = false;
        playerSitting.SetActive(false);
    }

    void Update()
    {
 
        if (isSitting)
        {
            text.SetActive(false);
        }


        if (Input.GetKeyDown(KeyCode.B))
        {
            if (isSitting)
            {
                playerSitting.SetActive(false);
                playerStanding.SetActive(true);
                isSitting = false;
            }
            else if(!isSitting && text.activeInHierarchy)
            {
                playerSitting.SetActive(true);
                playerStanding.SetActive(false);

                isSitting = true;
            }
        }
    }
}
