using System.Collections;
using UnityEngine;
using Vuforia;

public class VirtualButtonControl : MonoBehaviour, IVirtualButtonEventHandler {
    public GameObject VirtuButton;
    public GameManager GM;
    // Use this for initialization
    void Start()
    {
        VirtuButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Pressed!!!!!!!!!");
        GM.Player.GetComponent<Animator>().SetTrigger("Dance");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //throw new System.NotImplementedException();
        Debug.Log("Released");
    }

   
}
