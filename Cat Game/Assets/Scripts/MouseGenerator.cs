using UnityEngine;
public class MouseGenerator : MonoBehaviour
{
    public float timer;
    public int randomPicker;
    void Start()
    {
        RandomTimePicker();
    }
    public void RandomTimePicker()
    { 
        GenerateMouse();
      randomPicker = Random.Range(0, 3);
      if (randomPicker == 0)
      {
          timer = Random.Range(3, 5);
      }
      if (randomPicker == 1)
      {
          timer = Random.Range(5, 8);
      }
      if (randomPicker == 2)
      {
          timer = Random.Range(6, 9);
      }
    }
    public void GenerateMouse()
    {
        print("NewMouse");
    }
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            RandomTimePicker();
        }
    }
}
