using UnityEngine;

public class CoffeeShopTest : MonoBehaviour
{
    public int food = 0;
    public int foodnum = 0;
    public int coffeenum = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CustomerFront();
    }

    //customerFront simulates a customer ordering a random type of coffee from the coffee shop. It creates an array of coffee types, generates a random index to select one of the coffee types, and then logs a message indicating the customer's order.
    void CustomerFront()
    {
        food=Random.Range(0, 2);
        string[] coffeeType = {"Espresso", "Cappuccino", "Latte", "Americano", "Mocha", "Macchiato", "Affogato", "Cold Brew", "Iced Coffee", "Frappuccino"};
        int coffeenum = Random.Range(0, 10);
        string[] foodtype = {"Croissant", "Muffin", "Bagel", "Scone", "Danish", "Cookie", "Brownie", "Cupcake", "Donut", "Toast"};
        int foodnum = Random.Range(0, 10);
        Debug.Log("Hello, I would like to buy a " + coffeeType[coffeenum]);
        if (food == 1)
        {
            Debug.Log("I would also like to buy a " + foodtype[foodnum]);
        }
    else
        {
            Debug.Log("I would not like to buy any food.");
        }
    }
}
