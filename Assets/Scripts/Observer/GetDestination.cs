using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDestination : MonoBehaviour
{
    [SerializeField] private GameEvent gameEvent;

    public event Action<GetDestination> OnClick;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit) && hit.transform.tag == "Ground")
            {
                gameEvent.Walk(hit.point);
            }

            Debug.Log("Hello from get destination");
            OnClick?.Invoke(this);
        }
    }
}