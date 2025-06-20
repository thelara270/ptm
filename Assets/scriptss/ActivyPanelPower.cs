using UnityEngine;

public class ActivyPanelPower : MonoBehaviour
{
    [Header("Paneles UI")]
    [SerializeField] GameObject panelPowerUps;
    [SerializeField] GameObject panelPowerM;
    [SerializeField] GameObject panelPowerF;
    [SerializeField] GameObject panelPowerD;
    [SerializeField] GameObject panelGame;
    [SerializeField] GameObject joystick;

    [Header("Prefabs de jugador")]
    [SerializeField] GameObject jugadorNormal;
    [SerializeField] GameObject jugadorDobleShot;
    [SerializeField] GameObject jugadorFastShot;
    [SerializeField] GameObject jugadorMegaShot;

    [Header("Sistema de puntos")]
    [SerializeField] punta scoreSystem;
    [SerializeField] float puntosCadaPowerUp = 100f;

    [SerializeField] private int siguientePowerUp = 500;
    private GameObject jugadorActivo;

    private void Start()
    {
        panelPowerUps.SetActive(false);
        jugadorActivo = jugadorNormal;
        ActivarJugador(jugadorNormal);
    }

    private void Update()
    {
        if (scoreSystem != null && scoreSystem.ScoreActual() >= siguientePowerUp)
        {
            if (jugadorActivo.activeSelf)
            {
                AbrirPanelPowerUp();
            }
            if (jugadorMegaShot.activeSelf)
            {
                AbrirPanelPowerUpM();
            }
            if (jugadorFastShot.activeSelf)
            {
                AbrirPanelPowerUpF();
            }
            if (jugadorDobleShot.activeSelf)
            {
                AbrirPanelPowerUpD();
            }



        }
    }

    void AbrirPanelPowerUp()
    {

        Time.timeScale = 0f;
        panelPowerUps.SetActive(true);
        panelGame.SetActive(false);
        joystick.SetActive(false);

    }

    void AbrirPanelPowerUpM()
    {

        Time.timeScale = 0f;
        panelPowerM.SetActive(true);
        panelPowerUps.SetActive(false );
        panelGame.SetActive(false);
        joystick.SetActive(false);
    }

    void AbrirPanelPowerUpF()
    {

        Time.timeScale = 0f;
        panelPowerF.SetActive(true);
        panelPowerUps.SetActive(false);
        panelGame.SetActive(false);
        joystick.SetActive(false);

    }
    void AbrirPanelPowerUpD()
    {

        Time.timeScale = 0f;
        panelPowerD.SetActive(true);
        panelPowerUps.SetActive(false);
        panelGame.SetActive(false);
        joystick.SetActive(false);
    }

    void CerrarPanel()
    {
        Time.timeScale = 1f;
        panelPowerUps.SetActive(false);
        panelPowerM.SetActive(false);
        panelPowerD.SetActive(false);
        panelPowerF.SetActive(false);

        panelGame.SetActive(true);
        joystick.SetActive(true);
        siguientePowerUp += (int)puntosCadaPowerUp;
    }

    void ActivarJugador(GameObject nuevoJugador)
    {
        if (jugadorActivo != null && jugadorActivo != nuevoJugador)
        {
            // Detener el disparo del jugador anterior
            instanciador anteriorDisparo = jugadorActivo.GetComponent<instanciador>();
            if (anteriorDisparo != null)
            {
                anteriorDisparo.CancelInvoke(nameof(anteriorDisparo.Disparar));
            }

            jugadorActivo.SetActive(false);
        }

        nuevoJugador.SetActive(true);
        jugadorActivo = nuevoJugador;

        // Forzar reinicio del disparo en el nuevo prefab
        instanciador nuevoDisparo = nuevoJugador.GetComponent<instanciador>();
        if (nuevoDisparo != null)
        {
            nuevoDisparo.CancelInvoke(nameof(nuevoDisparo.Disparar)); // por si acaso
            nuevoDisparo.Disparar();
        }
    }

    public void ElegirDisparoDoble()
    {
        ActivarJugador(jugadorDobleShot);
        CerrarPanel();
    }

    public void ElegirMisilGrande()
    {
        ActivarJugador(jugadorMegaShot);
        CerrarPanel();
    }

    public void ElegirMisilRapido()
    {
        ActivarJugador(jugadorFastShot);
        CerrarPanel();
    }
}