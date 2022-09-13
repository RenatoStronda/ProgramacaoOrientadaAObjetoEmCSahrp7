// See https://aka.ms/new-console-template for more information
namespace calcSE{
    class Program {
    public static void Main (string[] args) {
    calcula ca = new calcula("Verde");
    calcula ca2 = new calcula("Azul");
    calcSE calc = new calcSE();
    //ESSA É DA CALCSE
    Console.WriteLine(ca.getCor());
    Console.WriteLine("ESSA É DA CALCSE: ");
    Console.WriteLine(ca.somar(2,3));
    Console.WriteLine(ca.multiplicar(2,3));
    Console.WriteLine(ca.dividir(5,5));
    Console.WriteLine(ca.subtrair(5,2));
    //ESSA É DA CALCULA
    Console.WriteLine(ca2.getCor());
    Console.WriteLine("ESSA É DA CALCULA: ");
    Console.WriteLine(calc.somar(2,3));
    Console.WriteLine(calc.multiplicar(2,3));
    Console.WriteLine(calc.dividir(5,5));
    Console.WriteLine(calc.subtrair(5,2));
  }
}
public class calcSE{
public float somar(float v, float v2){
    return v + v2;
    }
public float multiplicar(float v, float v2){
    return v * v2;
    }
public float dividir(float v, float v2){
    return v / v2;
    }
public float subtrair(float v, float v2){
    return v - v2;
    }
}
public class calcula{
    private float v1;
    private float v2;
    private string cor;

public calcula(string cor){
    this.cor = cor;
    }
public string getCor(){
    return this.cor;
    }
public float somar(float v1, float v2){
    this.v1 = v1;
    this.v2 = v2;
    return this.v1 + this.v2;
    }
public float multiplicar(float v1, float v2){
    this.v1 = v1;
    this.v2 = v2;
    return this.v1 * this.v2;
    }
public float dividir(float v1, float v2){
    this.v1 = v1;
    this.v2 = v2;
    return this.v1 / this.v2;
    }
public float subtrair(float v1, float v2){
    this.v1 = v1;
    this.v2 = v2;
    return this.v1 - this.v2;
    }
 }
}