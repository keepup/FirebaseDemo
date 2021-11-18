using System.Collections;
using System.Collections.Generic;
using Firebase;
using UnityEngine;

public class SampleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("------ Start CheckAndFixDependenciesAsync");
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {
            Debug.Log($"------ CheckAndFixDependenciesAsync with result: {task.Result.ToString()}");
        });
    }

}
