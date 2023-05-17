using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace AzeriPatates {
    public class MovablePlatform : MonoBehaviour {
        [SerializeField] private float _moveTime = 3.0f;
        [SerializeField] private Vector3 offset;
        private Rigidbody _rigidbody;
        private Vector3 _startPosition;
        private Vector3 _targetPosition;



        public void Awake() {
            _rigidbody = GetComponent<Rigidbody>();
            _startPosition = transform.position;
            _targetPosition = _startPosition + offset;
        }
        public void FixedUpdate() {
            var t = -0.5f * (Mathf.Cos(Mathf.PI * Mathf.PingPong(Time.time, _moveTime) / _moveTime) - 1.0f);
            var p = Vector3.Lerp(_startPosition, _targetPosition, t);
            _rigidbody.MovePosition(p);
        }
    }
}
