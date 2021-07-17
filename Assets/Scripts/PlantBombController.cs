using UnityEngine;

public class PlantBombController : MonoBehaviour
{
    private PlayerInput _playerInput;
    [SerializeField] private GameObject bomb;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
    }
    
    void Update()
    {
        if (_playerInput.GetPlantTheBombInput())
            PlantTheBomb();

    }

    public void PlantTheBomb()
    {
        Instantiate(bomb, _playerInput.transform.position, Quaternion.identity);
    }
}
