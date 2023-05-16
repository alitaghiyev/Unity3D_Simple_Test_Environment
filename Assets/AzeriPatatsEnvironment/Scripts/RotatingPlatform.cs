using UnityEngine;

namespace Azeripatates.Environment
{
    public class RotatingPlatform : MonoBehaviour
    {
       [field:SerializeField] private int RotationSpeed { get; set; }
        private Rigidbody _rigidbody;
        private float angle;
        private void Start() {
            _rigidbody = GetComponent<Rigidbody>();
       }
        private void FixedUpdate() {
             angle += RotationSpeed * Time.deltaTime;
             var rotation = Quaternion.Euler(0.0f, angle, 0.0f);
            _rigidbody.MoveRotation(rotation);
        }
    }
}
