﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Rigidbody))]
public class ControllerInstructor : MonoBehaviour
{
    private CharacterController ControladorDelPersonaje;
    private Vector3 MovimientoEnDireccion = Vector3.zero;
    private Vector2 Entrada;
    private CollisionFlags BanderasDeColision;
    public float FuerzaAlTocarElSuelo;
    public float MultiplicarGravedad;
    // Start is called before the first frame update
    void Start()
    {
        ControladorDelPersonaje = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 MovimientoDeseado = transform.forward * Entrada.y + transform.right * Entrada.x;
        RaycastHit hitInfo;
        Physics.SphereCast(transform.position, ControladorDelPersonaje.radius, Vector3.down, out hitInfo, ControladorDelPersonaje.height / 2f, Physics.AllLayers, QueryTriggerInteraction.Ignore);
        MovimientoDeseado = Vector3.ProjectOnPlane(MovimientoDeseado, hitInfo.normal).normalized;
        if (ControladorDelPersonaje.isGrounded)
        {
            MovimientoEnDireccion.y = -FuerzaAlTocarElSuelo;
        }
        else
        {
            MovimientoEnDireccion += Physics.gravity * MultiplicarGravedad * Time.fixedDeltaTime;
        }
        BanderasDeColision = ControladorDelPersonaje.Move(MovimientoEnDireccion * Time.fixedDeltaTime);
    }
}