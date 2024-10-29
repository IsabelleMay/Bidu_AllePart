using UnityEngine;

public class Symbol : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Aqui é a lógica para pegar o símbolo ☻
        PlayerInventory.AddSymbol(this);
        gameObject.SetActive(false); // Aqui desativa o símbolo 
    }
}
