using UnityEditor;
using UnityEngine;

namespace BalineseCalendar.Editor
{   
    [CustomEditor(typeof(SasihDatabase))]
    public class SasihDatabaseEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            SasihDatabase db = (SasihDatabase)target;
            if (GUILayout.Button("Read Data From JSON"))
            {
                db.ReadDataFromJson();
                EditorUtility.SetDirty(db);
            }
        }
    }
}