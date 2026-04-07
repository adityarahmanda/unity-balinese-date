using UnityEditor;
using UnityEngine;

namespace BalineseCalendar
{   
    [CustomEditor(typeof(DewasaDatabase))]
    public class DewasaDatabaseEditor : Editor
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