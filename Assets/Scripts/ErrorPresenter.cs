using UnityEngine;
 
 public class ErrorPresenter : MonoBehaviour
 {
     private static ErrorPresenter _instance;
     private string _message;
 
     private static ErrorPresenter Instance
     {
         get
         {
             if(_instance == null)
             {
                 _instance = new GameObject(nameof(ErrorPresenter)).AddComponent<ErrorPresenter>();
             }
 
             return _instance;
         }
     }
 
     public static void Show(string message)
     {
         Instance._message = message;
     }
 
     private void OnGUI()
     {
         if(!string.IsNullOrWhiteSpace(_message))
         {
             Rect container = new Rect(Screen.width * 0.3f, Screen.height * 0.3f, Screen.width * 0.4f, Screen.height * 0.4f);
             GUI.Box(container, (string) null);
             GUILayout.BeginArea(new RectOffset(20, 20, 20, 20).Remove(container));
 
             DrawLabel();
             DrawButton();
 
             GUILayout.EndArea();
         }
     }
 
     private void DrawLabel()
     {
        GUIStyle myStyle = new GUIStyle();
        myStyle.normal.textColor = Color.white;
        myStyle.fontSize = 54;


         GUILayout.FlexibleSpace();
         GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));
         GUILayout.FlexibleSpace();
         GUILayout.Label(_message, myStyle);
         GUILayout.FlexibleSpace();
         GUILayout.EndHorizontal();
         GUILayout.FlexibleSpace();
     }
 
     private static void DrawButton()
     {
         GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));
         GUILayout.FlexibleSpace();
        GUIStyle customButton = new GUIStyle("button");
        customButton.fontSize = 48;

        if (GUILayout.Button("Ok", customButton))
        {
            ErrorPresenter.Destroy(_instance);
        }
         GUILayout.FlexibleSpace();
         GUILayout.EndHorizontal();
     }
 }