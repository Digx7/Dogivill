using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetector : MonoBehaviour
{
    public string tagToWatchFor;

    public Collider2DEvent OnTriggerEnter;

    public Collider2DEvent OnTriggerStay;

    public Collider2DEvent OnTriggerExit;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == tagToWatchFor)
        {
            OnTriggerEnter.Invoke(collision);
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == tagToWatchFor)
        {
            OnTriggerStay.Invoke(collision);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == tagToWatchFor)
        {
            OnTriggerExit.Invoke(collision);
        }
    }
}
