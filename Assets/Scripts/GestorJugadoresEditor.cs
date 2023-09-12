using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GestorJugadores))]
public class GestorJugadoresEditor : Editor
{
    public override void OnInspectorGUI()
    {
        GestorJugadores gestor = (GestorJugadores)target;

        // Muestra la lista de jugadores
        GUILayout.Label("Lista de Jugadores:");

        for (int i = 0; i < gestor.jugadores.Count; i++)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label("Jugador " + i.ToString(), GUILayout.Width(100));
            gestor.jugadores[i].Nombre = EditorGUILayout.TextField(gestor.jugadores[i].Nombre);
            gestor.jugadores[i].Nickname = EditorGUILayout.TextField(gestor.jugadores[i].Nickname);
            gestor.jugadores[i].NumeroApostador = EditorGUILayout.IntField(gestor.jugadores[i].NumeroApostador);
            GUILayout.EndHorizontal();
        }

        // Botón para agregar un nuevo jugador
        if (GUILayout.Button("Agregar Nuevo Jugador"))
        {
            gestor.jugadores.Add(new Jugador("Nuevo Jugador", "Nickname", 0));
        }

        // Actualiza el Inspector
        if (GUI.changed)
        {
            EditorUtility.SetDirty(target);
        }
    }
}