using UnityEngine;
public class MouseGenerator : MonoBehaviour
{
    public float timer;
    public int randomPicker;
    public GameObject mouseOne, mouseTwo, mouseThree;
    public AudioSource newMouseSqueak;
    public int sideSpawner;
    public float xAxisValue;
    public float yAxisValue;
    public static float mouseRotation;
    public int mousePicker;
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
          timer = Random.Range(1, 2);
      }
      if (randomPicker == 1)
      {
          timer = Random.Range(2, 4);
      }
      if (randomPicker == 2)
      {
          timer = Random.Range(3, 5);
      }
    }
    public void GenerateMouse()
    {
        if (mousePicker == 0)
        {
            newMouseSqueak.Play();
            MouseSpeed.mouseSpeedValue = Random.Range(11f, 20f);
            Instantiate(mouseOne,new Vector3(xAxisValue, yAxisValue), Quaternion.Euler(0,0,0));
        }
        if (mousePicker == 1)
        {
            newMouseSqueak.Play();
            MouseSpeed.mouseSpeedValue = Random.Range(11f, 20f);
            Instantiate(mouseTwo,new Vector3(xAxisValue, yAxisValue), Quaternion.Euler(0,0,0));
        }
        if (mousePicker == 2)
        {
            newMouseSqueak.Play();
            MouseSpeed.mouseSpeedValue = Random.Range(11f, 20f);
            Instantiate(mouseThree,new Vector3(xAxisValue, yAxisValue), Quaternion.Euler(0,0,0)); 
        }
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
        mousePicker = Random.Range(0, 3);
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
