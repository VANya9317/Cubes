using UnityEngine;

namespace Scripts
{
    public class DestroyObjectComponent : MonoBehaviour
    {
        [SerializeField] private EnterTriggerComponent _objectDestroy;

        public void DestroyObject()
        {
            Destroy(_objectDestroy);
        }
    }
}