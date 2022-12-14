using System;
				
public class MyClassA{
	public int a, b;
	public MyClassA(int a, int b){
		this.a = a;
		this.b = b;
	}
	public int A{
		get { return a; }
	}
	public int B{
		get { return b; }
	}
	public float C0{
		get { a *= b; return a; }
	}
	public float C1{
		get { return ++a; }
	}
	public float C2{
		get { return a/b; }
	}
}


public class MyClassB: MyClassA{
	public int d;
	private int[] array;
	int[] array2 = new int[] {1, 2, 3, 4, 5};
	
	public MyClassB(int a, int b, int d): base(a, b){
		this.d = d;
	}
	public MyClassB(): this(3, 4, 5){
		this.d = 5;
	}
	public MyClassB(int a): this(a, 2, -7){
		this.d = -7;
		array = new int[a];
		for(int i = 0; i < a; i++){
			array[i] = C3 * i;
		}
	}
	public int D{
		get { return d; }
	}
	public int C3{
		get {
			for(int i=0; i < 3; i++)
			{
				d -= A + B;
			}
			return d;
		}
	}
	public int[] Array{
		get { return array; }
	}
	public int[] Array2{
		get { return array2; }
	}
	
	public int this[int index]{
	    get{return array[(int)index];}
	    set{array[(int)index] = value;}
	}
	public int this[float index]{
	    get{return array2[(int)index];}
	    set{array2[(int)index] = value;}
	}
}

public class MyClassC<T>{
    public static string message = "This is static";
    private T[] arr = new T[3];
    public T this[int index]{
	   get{return arr[(int)index];}
	    set{arr[(int)index] = value;}
	}
}


public class Program{
	public static void Main(){
		MyClassB ObjectB = new MyClassB(5);
		Console.WriteLine("Массив 1:");
		for (int i=0; i < ObjectB.Array.Length; i++){
		    Console.WriteLine(ObjectB[i]);
		}
		Console.WriteLine("Массив 2:");
		for (float i=0; i < ObjectB.Array2.Length; i++){
		    Console.WriteLine(ObjectB[i]);
		}
		MyClassC<string> str_obj = new MyClassC<string>();
		MyClassC<int> int_obj = new MyClassC<int>();
		
		for (int i=0; i<3; i++){
		    str_obj[i] = Convert.ToString(i) + " number";
		}
		for (int i=0; i<3; i++){
		    int_obj[i] = i;
		}
		Console.WriteLine(MyClassC<int>.message);
		Console.WriteLine("\nStrings array");
		for (int i=0; i<3; i++){
		    Console.WriteLine(str_obj[i]);
		}
		Console.WriteLine("\nNumbers array");
		for (int i=0; i<3; i++){
		    Console.WriteLine(int_obj[i]);
		}
	}
}
