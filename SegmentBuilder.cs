using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentBuilder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Gender gender = gender.Female;
        Analytics.SetUsrGender(gender);
        int birthday = 1998;
        Analytics.SetUserBirthYear(birthYear);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
