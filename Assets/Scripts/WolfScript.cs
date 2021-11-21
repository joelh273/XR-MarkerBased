using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfScript : MonoBehaviour
{

    private void OnMouseClick()
    {
        FindObjectOfType<AudioManager>().Play("Wolf");
    }
}
