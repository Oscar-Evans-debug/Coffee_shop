using UnityEngine;

public class CoffeeShopTest : MonoBehaviour
{
    public int coffeenum = 0;
    public int coffeesSold = 5;
    public float coffeePrice = 3.50f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void AddCoffee()
    {
        coffeesSold++;
    }
    void Start()
    {
        Debug.Log("coffees sold: " + coffeesSold);
        AddCoffee();
        Debug.Log("coffees sold: " + coffeesSold);
        CustomerFront();
    }

    // Update is called once per frame
    void CustomerFront()
    {
        string[] coffeeType = {"Espresso", "Cappuccino", "Latte", "Americano", "Mocha", "Macchiato", "Affogato", "Cold Brew", "Iced Coffee", "Frappuccino"};
        int coffeenum = Random.Range(0, 10);

        Debug.Log("Hello, I would like to buy a " + coffeeType[coffeenum]);
    }
}
