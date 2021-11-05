using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    int totalDeads = 5;
    int totalSores = 100;
    int totalTimes = 120;
    string Level = "Level5";
    Analytics.CutomEvent("Gameplay", new Dictionary<string, object>
        {
            {"Deads", totalDeads },
            { "Scores", totalScores },
            { "Times", totalTimes },
            { "Level", Level }
        });
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
