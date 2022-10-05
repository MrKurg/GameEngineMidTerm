using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class SavePlugin : MonoBehaviour
{
    [DllImport("LabPluginExample")]
    private static extern int GetID();

    [DllImport("LabPluginExample")]
    private static extern void SetID(int id);

    [DllImport("LabPluginExample")]
    private static extern Vector3 GetPosition();

    [DllImport("LabPluginExample")]
    private static extern void SetPosition(float x, float y, float z);

    [DllImport("LabPluginExample")]
    private static extern void SaveToFile(int id, float x, float y, float z);

    [DllImport("LabPluginExample")]
    private static extern void StartWriting(string fileName);

    [DllImport("LabPluginExample")]
    private static extern void EndWriting();

    PlayerAction inputAction;

    string m_Path;
    string fn;

    void Start()
    {
        inputAction = PlayerInputController.controller.inputAction;

        inputAction.Editor.Save.performed += cntxt => SaveItems();

        m_Path = Application.dataPath;
        fn = m_Path + "/save.txt";
        Debug.Log(fn);
    }

    void SaveItems()
    {
        StartWriting(fn);
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("SpikyBall"))
        {
            if (obj.name.Contains("SpikyBall"))
            {
                SaveToFile(1, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z);
            }
            else
            {
                SaveToFile(2, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z);
            }
        }
        EndWriting();
    }
}
