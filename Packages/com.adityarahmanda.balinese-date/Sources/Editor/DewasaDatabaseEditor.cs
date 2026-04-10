using UnityEditor;
using UnityEngine;

namespace BalineseCalendar.Editor
{   
    [CustomEditor(typeof(DewasaDatabase))]
    public class DewasaDatabaseEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            DewasaDatabase db = (DewasaDatabase)target;
            if (GUILayout.Button("Read Data From JSON"))
            {
                db.ReadDataFromJson();
                EditorUtility.SetDirty(db);
            }
        }
    }
}