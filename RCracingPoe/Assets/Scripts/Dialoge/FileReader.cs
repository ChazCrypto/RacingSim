using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileReader : MonoBehaviour
{
    public TextAsset jsonFile;
    // Start is called before the first frame update
    void Start()
    {
        RacesTypes RaceTypeFromJSON = JsonUtility.FromJson<RacesTypes>(jsonFile.text);
        foreach (Races Race in RaceTypeFromJSON.Races)
        {
            Debug.Log("Chosen race: " + Race.RaceName + "'" + Race.dialogue + "'");
        }
    }

}