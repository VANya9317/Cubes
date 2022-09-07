using UnityEngine;

namespace Scripts
{
    public class SpawnCube : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] public Cube[] _cube;
        private float x, y, z;

        [ContextMenu("SpawnCube")]
        public void Spawn()
        {
            SpawnInstance();
        }

        private void SpawnInstance()
        {
            for (var i = 0; i < _cube.Length; i++)
            {
                _cube[i].transform.position = Vector3.Lerp(_cube[i].transform.position, _target.position, 1f);
                VariationCube(_cube[i]);
            }
        }

        private void VariationCube(Cube cubes)
        {
            float varianceX = Random.Range(-180f, 180f);
            x = varianceX;
            float varianceY = Random.Range(-180f, 180f);
            y = varianceY;
            float varianceZ = Random.Range(-180f, 180f);
            z = varianceZ;

            cubes.transform.rotation = Quaternion.Euler(x, y, z);
        }
    }
}

