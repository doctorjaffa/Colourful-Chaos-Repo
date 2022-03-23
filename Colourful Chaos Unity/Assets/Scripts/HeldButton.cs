using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

//This line means this script can only be attached to a game object that has a button component on it.
[RequireComponent(typeof(Button))]

//The additional items in this list allows response to mouse/touch events.
public class HeldButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{

    //Store button for use.
    private Button button;

    //Used to track whether button is pressed or not.
    private bool buttonPressed = false;

    //This function gets called by Unity when the user first clicks the button.
    public void OnPointerDown(PointerEventData eventData)
    {
        //Ignore if the button is not interactible.
        if (!button.interactable) return;

        //Record that button is being pressed.
        buttonPressed = true;
    }

    //Called by Unity when the user releases the button.
    public void OnPointerUp(PointerEventData eventData)
    {
        //Record that the button is no longer being pressed.
        buttonPressed = false;
    }

    //Called by Unity when the user moves their mouse/finger off the button, while it was still held down.
    public void OnPointerExit(PointerEventData eventData)
    {
        //Record that the button is no longer being pressed.
        buttonPressed = false;
    }

    // Awake is called before anything else in the script.
    void Awake()
    {
        button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        //If button is currently pressed...
        if (buttonPressed)
        {
            //Call the onClick function set up in Unity for this button.
            button.onClick?.Invoke();
        }
    }
}
