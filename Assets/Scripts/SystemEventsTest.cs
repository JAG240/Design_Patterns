using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemEventsTest : MonoBehaviour
{
    [SerializeField] string testString;
    GetDestination getDestination;

    private void Start()
    {
        getDestination = GetComponent<GetDestination>();

        getDestination.OnClick += SayHello;
    }

    void SayHello(GetDestination getDestination)
    {
        Debug.Log(testString);
    }
}
