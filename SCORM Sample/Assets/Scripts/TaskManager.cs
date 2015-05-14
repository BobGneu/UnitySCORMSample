using Scorm2004;
using UnityEngine;

public class TaskManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        UnityEngine.Application.ExternalEval("console.log(\"Log Manager Initialized.\");");
        // ScormManager.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Complete()
    {
        UnityEngine.Application.ExternalEval("console.log(\"Quitting.\");");

        Application.Quit();
    }

    public void Success()
    {
        UnityEngine.Application.ExternalEval("console.log(\"Success.\");");
        
        ScormManager.SetCompletionStatus(completionStatusType.completed);
        ScormManager.SetScore(100, 1.0f, 0, 100);
        ScormManager.SetSatisfaction(successStatusType.passed);

        ScormManager.Commit();
    }

    private void Scorm_Initialize_Complete()
    {
        UnityEngine.Application.ExternalEval("console.log(\"SCORM Initialized.\");");
    }

    private void Scorm_Commit_Complete()
    {
        UnityEngine.Application.ExternalEval("console.log(\"SCORM Commit Completed.\");");

        ScormManager.Terminate();
    }
}
