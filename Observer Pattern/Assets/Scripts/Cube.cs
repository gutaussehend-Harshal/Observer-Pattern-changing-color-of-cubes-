using UnityEngine;

public class Cube : MonoBehaviour
{
    private Material _mesh;

    private void OnEnable()
    {
        _mesh = GetComponent<MeshRenderer>().material;
        PlayerObserver.onTurnRed += Player_onTurnRed;
    }

    private void Player_onTurnRed()
    {
        _mesh.color = new Color(Random.value, Random.value, Random.value);
    }

    private void OnDisable()
    {
        PlayerObserver.onTurnRed -= Player_onTurnRed;
    }
}
