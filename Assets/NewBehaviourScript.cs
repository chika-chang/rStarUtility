#if UNITY_EDITOR
     using UnityEditor;
#endif
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
#region Unity events

    // Start is called before the first frame update
    void Start()
    {
    #if UNITY_EDITOR
             EditorApplication.Beep();
    #endif
    }

#endregion
}
