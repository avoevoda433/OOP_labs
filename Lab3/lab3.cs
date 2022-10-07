using System;
				
public class MyClassA {
    // FIELDS
	int a, b;
	
	// CONSTRUCTOR
	public MyClassA(int a, int b) {
		this.a = a;
		this.b = b;
	}
	
	// PROPERTIES FOR FIELDS
	public int A {
		get { return a; }
	}
	public int B {
		get { return b; }
	}
	
	// PROPERTIES
	public int C1 {
		get { return a*b; }
	}
	public int C2 {
		get { return ++a; }
	}
	public float C3 {
		get { return a/b; }
	}
}


public class MyClassB: MyClassA {
    // FIELDS (also MyClassA fields)
	float d;
	float[] arr;
	
	// CUNSTRUCTORS
	// Constructor inherits MyClassA constructor
	public MyClassB(int a, int b, float d): base(a, b) {
		this.d = d;
	}
	// It's own MyClassB constructor
	public MyClassB(): this(15, 32, 6.32F) {
		this.d = 6.32F;
	}
	// Constructor for array initialization
	public MyClassB(int a): this(a, 4, 9.32F) {
	    this.d = 6.32F;
	    arr = new float[A];
	    for(int i = 0; i < A; i++){
			arr[i] = C4 * i;
		}
	}
	
	// PROPERTIES FOR FIELDS
	public float D {
		get { return d; }
	}
	
	public float[] Arr{
		get { return arr; }
	}
	
	// PROPERTIE
	public float C4 {
		get {
		    float i = 0F; 
		    do i += d/(A-B); while(i < 50);
			return i;
		}
	}
}


public class Program {
	public static void Main() {
	    MyClassB object_B = new MyClassB(10);
	    foreach(float element in object_B.Arr) Console.WriteLine(element);
	}
}
