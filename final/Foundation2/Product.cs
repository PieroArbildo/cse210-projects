public class Product
{
private string _Nombre;
private int _Id;
private double _Price;
private int _Quantity;
public Product(string Nombre, int Id, double Price, int Quantity)
{
    _Nombre= Nombre;
    _Id= Id;
    _Price= Price;
    _Quantity=Quantity;
}
public string GetName()
{
    return _Nombre;
}

public int GetId()
{
    return _Id;
}
public void GetPrice()
{
    Console.WriteLine(_Price);
}
public void GetQuantity()
{
    Console.WriteLine(_Quantity);
}

public double  GetTotalCost()
{
    return _Price * Convert.ToDouble(_Quantity);
} 

}