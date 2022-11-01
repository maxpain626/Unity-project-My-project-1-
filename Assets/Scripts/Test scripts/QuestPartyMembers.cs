using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestPartyMembers : MonoBehaviour
{
    void Start()
    {
        List<string> questPartyMembers = new List<string>()
        {
            "Grim the Barbarian", "Merlin the Wise", "Sterling the Knight"
        };

        for (int i = 0; i < questPartyMembers.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, questPartyMembers[i]);

            if (questPartyMembers[i] == "Merlin the Wise")
            {
                Debug.Log("Glad you're here Merlin!");
            }
        }

        foreach(string partyMember in questPartyMembers)
        {
            Debug.LogFormat("{0} - Here!", partyMember);
        }

    }

    void Update()
    {
        
    }
}
