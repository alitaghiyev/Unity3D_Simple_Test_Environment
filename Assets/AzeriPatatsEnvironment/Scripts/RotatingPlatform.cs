using UnityEngine;

namespace Azeripatates.Environment {
    public class RotatingPlatform : MonoBehaviour {
        [field: SerializeField] private Vector3 rotateSpeed { get; set; }

        private Rigidbody _rigidbody;
        private Vector3 rotateAngle;

        private void Start() {
            _rigidbody = GetComponent<Rigidbody>();
            rotateAngle = gameObject.transform.eulerAngles;
        }
        private void FixedUpdate() {
            rotateAngle += rotateSpeed * Time.deltaTime;
            var rotation = Quaternion.Euler(rotateAngle);
            _rigidbody.MoveRotation(rotation);
        }
    }
}
