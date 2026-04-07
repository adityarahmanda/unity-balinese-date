using UnityEditor;
using UnityEngine;

namespace BalineseCalendar
{   
    [CustomEditor(typeof(SasihDatabase))]
    public class SasihDatabaseEditor : Editor
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