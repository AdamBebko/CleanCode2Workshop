using System;
using UnityEngine;

public class FeedbackSystem : MonoBehaviour {
    
    [SerializeField] GameObject yesFeedback;
    [SerializeField] GameObject noFeedback;

    void OnEnable() {
        ParticipantResponse.ResponseReceived += GotResponse;
    }

    void OnDisable() {
        ParticipantResponse.ResponseReceived -= GotResponse;
    }

    void GotResponse(ParticipantResponseType response) {
        if (response == ParticipantResponseType.Yes) {
            YesPressed();
        }

        if (response == ParticipantResponseType.No) {
            NoPressed();
        }
    }

    void YesPressed() {
        yesFeedback.SetActive(true);
        noFeedback.SetActive(false);
    }

    void NoPressed() {
        yesFeedback.SetActive(false);
        noFeedback.SetActive(true);
    }
}