
using System.Collections.Generic;
using System.Windows.Forms;

public class Sandwich
{
    public SortedList<string, double> meatPrice { get; set; }
    public SortedList<string, double> cheesePrice { get; set; }
    public SortedList<string, double> toppingPrice { get; set; }
    public SortedList<string, double> extraPrice { get; set; }
    public SortedList<string, double> BreadPrice { get; set; }
    public SortedList<string, double> saucePrice { get; set; }
    public SortedList<string, double> breadSize { get; set; }


    public Sandwich()
    {
        breadSize = new SortedList<string, double>();
        breadSize.Add("Half", 1.99);
        breadSize.Add("Small", 2.99);
        breadSize.Add("Medium", 2.99);
        breadSize.Add("Large", 3.99);
        breadSize.Add("Extra Large",4.99);
        breadSize.Add("Party Size",6.99);

        meatPrice = new SortedList<string, double>();
        // Add items and their prices to the SortedList
        meatPrice.Add("Turky", 0.99);
        meatPrice.Add("Harm",1.99);
        meatPrice.Add("Bologna", 2.99);
        meatPrice.Add("Pepperoni", 1.99);
        meatPrice.Add("Prosciutto", 2.99);
        meatPrice.Add("Roast Beef", 1.99);
        meatPrice.Add("Chicken", .99);
        meatPrice.Add("Pastrami", 1.99);
        meatPrice.Add("Comed Beef", 1.99);
        meatPrice.Add("Sausage", 1.29);


        cheesePrice = new SortedList<string, double>();
        cheesePrice.Add("Chedder", .99);
        cheesePrice.Add("Swiss", .78);
        cheesePrice.Add("Provolone",.68);
        cheesePrice.Add("American", .97);
        cheesePrice.Add("PapperJack", .99);
        cheesePrice.Add("Mozarella", .67);
        cheesePrice.Add("Bire", .89);
        cheesePrice.Add("Blue Cheese", .67);
        cheesePrice.Add("Gouda",.76);
        cheesePrice.Add("Colby", .88);

        toppingPrice = new SortedList<string, double>();
        toppingPrice.Add("Lettuce",67);
        toppingPrice.Add("Onion", .89);
        toppingPrice.Add("Pickles",.87);
        toppingPrice.Add("Jalapenos",.87);
        toppingPrice.Add("Avacado", .99);
        toppingPrice.Add("Bell Pepper", .39);
        toppingPrice.Add("Cucumber", .87);
        toppingPrice.Add("Spinach", .56);
        toppingPrice.Add("Sprouts", .98);

        extraPrice = new SortedList<string, double>();
        extraPrice.Add("Extra Cheese", .99);
        extraPrice.Add("Extra Meat", .50);
        extraPrice.Add("Premium Avacado", .99);
        extraPrice.Add("Truffle", .79);
        extraPrice.Add("Grilled Onions", .80);
        extraPrice.Add("Fresh Herbs", .79);
        extraPrice.Add("Roasted Red Peppers", .69);
        extraPrice.Add("Sun-Dried Tomatoes", .95);
        extraPrice.Add("Truffle Mushrooms", .79);

        BreadPrice = new SortedList<string, double>();
        BreadPrice.Add("White Bread", 1.99);
        BreadPrice.Add("Baguetta ", 3.49);
        BreadPrice.Add("Ciabatta", 4.99);
        BreadPrice.Add("Sourdough",3.99);
        BreadPrice.Add("Pandesal", 2.99);

        saucePrice = new SortedList<string, double>();
        saucePrice.Add("Anchovy essence", .91);
        saucePrice.Add("Avgolemono ", .99);
        saucePrice.Add("Avocado sauce", .79);
        saucePrice.Add("Barbecue sauce", .78);
        saucePrice.Add("Bread sauce", .58);
        saucePrice.Add("Ravigote sauce", .83);
        saucePrice.Add("Wine sauce", .85);
        saucePrice.Add("Satsebeli", .89);


    }


}


