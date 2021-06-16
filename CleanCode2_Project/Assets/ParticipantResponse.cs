using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticipantResponse : MonoBehaviour {

    public delegate void ResponseEvent(ParticipantResponseType response);

    public static event ResponseEvent ResponseReceived;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("startup");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y)) {
            Debug.Log("Participant said Yes");
            ResponseReceived?.Invoke(ParticipantResponseType.Yes);
        }
        if (Input.GetKeyDown(KeyCode.N)) {
            Debug.Log("Participant said No");
            ResponseReceived?.Invoke(ParticipantResponseType.No);
        }
    }
}



public enum ParticipantResponseType {
    Yes,
    No
}