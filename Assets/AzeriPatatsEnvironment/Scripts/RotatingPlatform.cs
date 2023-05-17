using UnityEngine;

namespace Azeripatates.Environment
{
    public class RotatingPlatform : MonoBehaviour
    {
       [field:SerializeField] private int rotationSpeed { get; set; }
       [SerializeField] private Vector3 rotationAngle;
        private Rigidbody _rigidbody;
        private float angle;
        private void Start() {
            _rigidbody = GetComponent<Rigidbody>();
       }
        private void FixedUpdate() {
             angle += rotationSpeed * Time.deltaTime;
             var rotation = Quaternion.Euler((rotationAngle+ rotationAngle)*rotationSpeed*Time.deltaTime);
            _rigidbody.MoveRotation(rotation);
        }
        //public void FixedUpdate() {
        //    var t = -0.5f * (Mathf.Cos(Mathf.PI * Mathf.PingPong(Time.time, _moveTime) / _moveTime) - 1.0f);
        //    var p = Vector3.Lerp(_startPosition, _targetPosition, t);
        //    _rigidbody.MovePosition(p);
        //}

    }
}
