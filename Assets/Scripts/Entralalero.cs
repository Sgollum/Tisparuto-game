using UnityEngine;

public class Entralalero : MonoBehaviour
{
    public Vector3 offsetDesdePosicionFinal = new Vector3(0, 10, 0);
    public float delay = 1f;
    public float tiempoCaida = 1f;

    private Vector3 posFinal;
    private Vector3 posInicial;
    private float tiempoPasado;
    private bool cayendo = false;

    void Start()
    {
        posFinal = transform.position;
        posInicial = posFinal + offsetDesdePosicionFinal;
        transform.position = posInicial;

        Invoke(nameof(IniciarCaida), delay);
    }

    void IniciarCaida()
    {
        cayendo = true;
        tiempoPasado = 0;
    }

    void Update()
    {
        if (cayendo)
        {
            tiempoPasado += Time.deltaTime;
            float t = tiempoPasado / tiempoCaida;

            // Lerp suave (ease out)
            float curva = Mathf.SmoothStep(0, 1, t);
            transform.position = Vector3.Lerp(posInicial, posFinal, curva);

            if (t >= 1f)
            {
                cayendo = false;
            }
        }
    }
}
