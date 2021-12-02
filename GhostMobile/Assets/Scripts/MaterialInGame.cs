using UnityEngine;
public class MaterialInGame : MonoBehaviour
{
    public GameObject ghost;
    public int materialNum;
    public Material[] colors;
    public Material chosenMat;
    public void Awake()
    {
        materialNum = TitleCanvas.EquipedColorNum;
        chosenMat = colors[materialNum];
        ghost.GetComponent<Renderer>().material = chosenMat;
    }
}
