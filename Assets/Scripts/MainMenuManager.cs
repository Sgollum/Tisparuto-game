using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject characterSelectPanel;
    public GameObject playButton;

    private string selectedCharacter = "";

    public void Start()
    {
        mainMenuPanel.SetActive(true);
        characterSelectPanel.SetActive(false);
        playButton.SetActive(false);
    }

    public void OnPlayButtonPressed()
    {
        mainMenuPanel.SetActive(false);
        characterSelectPanel.SetActive(true);
    }

    public void OnCharacterSelected(string characterName)
    {
        selectedCharacter = characterName;
        playButton.SetActive(true);
    }

    public void OnStartGame()
    {
        // Aquí puedes guardar el personaje seleccionado si lo necesitas
        // PlayerPrefs.SetString("SelectedCharacter", selectedCharacter);

        // Cargar la escena del juego (asegúrate de agregarla en Build Settings)
        characterSelectPanel.SetActive(false);
        SceneManager.LoadScene("GameScene");
    }
}