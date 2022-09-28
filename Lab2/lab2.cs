using System;
				
public class MyClassA {
	float a, b;
	
	public MyClassA(float a, float b) {
		this.a = a;
		this.b = b;
	}
	
	public float A {
		get { return a; }
	}
	
	public float B {
		get { return b; }
	}
	
	public float C1 {
		get { a *= b; return a; }
	}
	
	public float C2 {
		get { return ++a; }
	}
	
	public float C3 {
		get { return a/b; }
	}
}


public class MyClassB: MyClassA {
	float d;
	public MyClassB(float a, float b, float d): base(a, b) {
		this.d = d;
	}
	public MyClassB(): this(1.42F, 32.23F, 6.32F) {
		this.d = 6.32F;
	}
	public float D {
		get { return d; }
	}
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
		MyClassA MyObject = new MyClassA(5.43F, 34.22F);
		
		MyClassB ObjectB1 = new MyClassB();
		MyClassB ObjectB2 = new MyClassB(1.1F, 2.2F, 3.3F);
		Console.WriteLine("Object   |\ta\t|\tb\t|\td");
		Console.WriteLine("----------------------------------------------------");
		Console.WriteLine(string.Format("ObjectB1 |\t{0}    |\t{1}   |\t{2}", 
										ObjectB1.A, ObjectB1.B, ObjectB1.D));
		Console.WriteLine("----------------------------------------------------");
		Console.WriteLine(string.Format("ObjectB2 |\t{0}     |\t{1}     |\t{2}\n", 
										ObjectB2.A, ObjectB2.B, ObjectB2.D));
		
		Console.WriteLine(string.Format("MyObject:\nC1 result: {0}\nC2 result: {1}\nC3 result: {2}\n", 
										MyObject.C1, MyObject.C2, MyObject.C3));
		
		Console.WriteLine(string.Format("ObjectB1:\nC1 result: {0}\nC2 result: {1}\nC3 result: {2}\nC4 result: {3}\n", 
										ObjectB1.C1, ObjectB1.C2, ObjectB1.C3, ObjectB1.C4));
		
		Console.WriteLine(string.Format("ObjectB2:\nC1 result: {0}\nC2 result: {1}\nC3 result: {2}\nC4 result: {3}\n", 
										ObjectB2.C1, ObjectB2.C2, ObjectB2.C3, ObjectB2.C4));
	}
}
