using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public void Start()
    {
        AmountPlaced(32);
    }
    public int coffeeAmountOrdered;
    public float revenue; 
    private float _costOfCoffee = 4f;
    public void AmountPlaced(int coffeeAmountOrdered)
    {
        revenue = _costOfCoffee * coffeeAmountOrdered;
        Debug.Log("The total revenue from the coffee ordered is: $" + revenue);
    }
}
