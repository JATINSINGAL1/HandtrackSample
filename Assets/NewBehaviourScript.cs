using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
 public GameObject cubePrefab; // Prefab of the cube

    void Start()
    {
        string jsonData = "{\"0\": {\"x\": 87, \"y\": 338, \"z\": -0.0002570005744928494}, \"1\": {\"x\": 146, \"y\": 348, \"z\": -19.631216526031494}, \"2\": {\"x\": 215, \"y\": 342, \"z\": -28.94139051437378}, \"3\": {\"x\": 241, \"y\": 305, \"z\": -37.0969557762146}, \"4\": {\"x\": 208, \"y\": 278, \"z\": -40.114378929138184}, \"5\": {\"x\": 221, \"y\": 270, \"z\": -7.895422577857971}, \"6\": {\"x\": 255, \"y\": 254, \"z\": -31.248395442962646}, \"7\": {\"x\": 221, \"y\": 290, \"z\": -41.93594932556152}, \"8\": {\"x\": 205, \"y\": 294, \"z\": -47.24599361419678}, \"9\": {\"x\": 191, \"y\": 249, \"z\": -10.502922534942627}, \"10\": {\"x\": 223, \"y\": 233, \"z\": -37.583956718444824}, \"11\": {\"x\": 189, \"y\": 279, \"z\": -43.49341869354248}, \"12\": {\"x\": 175, \"y\": 278, \"z\": -41.807618141174316}, \"13\": {\"x\": 157, \"y\": 234, \"z\": -16.42936110496521}, \"14\": {\"x\": 186, \"y\": 219, \"z\": -45.18742084503174}, \"15\": {\"x\": 159, \"y\": 267, \"z\": -35.86630582809448}, \"16\": {\"x\": 147, \"y\": 269, \"z\": -22.875747680664062}, \"17\": {\"x\": 119, \"y\": 222, \"z\": -23.559436798095703}, \"18\": {\"x\": 147, \"y\": 217, \"z\": -38.64102602005005}, \"19\": {\"x\": 133, \"y\": 254, \"z\": -26.035845279693604}, \"20\": {\"x\": 122, \"y\": 258, \"z\": -12.974909543991089}}";

        // Parse JSON data
        Dictionary<string, Dictionary<string, float>> handData = JsonUtility.FromJson<Dictionary<string, Dictionary<string, float>>>(jsonData);

        // Instantiate cubes based on coordinates
        foreach (var entry in handData)
        {
            Vector3 position = new Vector3(entry.Value["x"], entry.Value["y"], entry.Value["z"]);
            Instantiate(cubePrefab, position, Quaternion.identity);
        }
    }
}
