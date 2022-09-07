using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] public int _cubeScore = 0;
    
    public void UpdateCubeScore(int score)
    {
        _cubeScore = score;
    }
}
