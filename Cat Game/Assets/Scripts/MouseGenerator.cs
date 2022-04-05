using UnityEngine;
public class MouseGenerator : MonoBehaviour
{
    public float timer;
    public int randomPicker;
    public GameObject mouse;
    public AudioSource newMouseSqueak;
    public int sideSpawner;
    public float mouseSpeed;
    public Vector3 newMousePosition;
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
        Instantiate(mouse, new Vector3());
        mouse.transform.position = newMousePosition;
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
        mouseSpeed = Random.Range(1, 9);
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
        GenerateMouse();
    }
    public void TopWallSpawn()
    {
        
    }public void RightWallSpawn()
    {
        
    }public void BottomWallSpawn()
    {
        
    }
}
