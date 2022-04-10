using UnityEngine;
public class MouseGenerator : MonoBehaviour
{
    public float timer;
    public int randomPicker;
    public GameObject mouse;
    public AudioSource newMouseSqueak;
    public int sideSpawner;
    public float xAxisValue;
    public float yAxisValue;
    public static float mouseRotation;
    void Start()
    {
        RandomTimePicker();
    }
    public void RandomTimePicker()
    {
        MouseLocation();
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
        newMouseSqueak.Play();
        MouseSpeed.mouseSpeedValue = Random.Range(11f, 20f);
        Instantiate(mouse,new Vector3(xAxisValue, yAxisValue), Quaternion.Euler(0,0,0));
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
    public void MouseLocation()
    {
        
        sideSpawner = Random.Range(0, 4);
        if (sideSpawner == 0)
        {
            LeftWallSpawn();
        }
        if (sideSpawner == 1)
        {
            TopWallSpawn();
        }
        if (sideSpawner == 2)
        {
            RightWallSpawn();
        }
        if (sideSpawner == 3)
        {
            BottomWallSpawn();
        }
    }
    public void LeftWallSpawn()
    {
        xAxisValue = -12f;
        yAxisValue = Random.Range(-5f, 5.51f);
       mouseRotation = 270f;
        GenerateMouse();
    }
    public void TopWallSpawn()
    {
        xAxisValue = Random.Range(-9f, 9f);
        yAxisValue = 8f;
        mouseRotation = 180f;
        GenerateMouse();
    }
    public void RightWallSpawn()
    {
        xAxisValue = 12f;
        yAxisValue = Random.Range(-5, 5.51f);
        mouseRotation = 90f;
        GenerateMouse();
    }
    public void BottomWallSpawn()
    {
        xAxisValue = Random.Range(-9f, 9f);
        yAxisValue = -8f;
        mouseRotation = 0f;
        GenerateMouse();
    }
}
