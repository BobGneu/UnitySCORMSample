using UnityEngine;

public class TaskManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log("Log Manager Initialized.");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Complete()
    {
        Debug.Log("Quitting!");

        Application.Quit();
    }

    private void Scorm_Initialize_Complete()
    {
        Debug.Log("SCORM Initialized!");
    }

    private void Scorm_Commit_Complete()
    {
        Debug.Log("SCORM Commit Completed!");
        ScormManager.Terminate();
    }
}
