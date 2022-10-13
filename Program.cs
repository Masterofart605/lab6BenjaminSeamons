int selection;
int a;
int b;
int c;
string d;
bool freeMe = false;
while (freeMe == false){
while (true){
try{
    Console.WriteLine("Which Program do you want to run?");
    Console.WriteLine("1:StackNoParams");
    Console.WriteLine("2:StackWithParams");
    Console.WriteLine("3:StackWithHeap");
    Console.WriteLine("4:StackOver");
    selection = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input value of Int a");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input value of Int b");
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input value of Int c");
    c = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input value of Strig d");
    d = Console.ReadLine();
    break;
}catch{
    Console.WriteLine("Please input a number");
}
}
switch(selection){
    case 1:
    StackNoParams();
    break;
    case 2:
    StackWithParams(a,b,c);
    break;
    case 3:
    StackWithHeap(a,b,c,d);
    break;
    case 4:
    StackOver();
    break;
    default:
    freeMe = true;
    break;
}
}









void StackNoParams() {
int intager1 = 2;
int anotherInt = 57;
double twins = 1935719835099.5;
long bigNumber = 3482095642;
int over9000 = 9001;
Console.WriteLine($"{intager1}{anotherInt}{twins}{bigNumber}{over9000}");
}

void StackWithParams(int a, int b, int c){
Console.WriteLine($"Ah yes, a = {a}, b = {b}, c = {c}.");
}

void StackWithHeap(int a, int b, int c, string d){
int e = 2245145;
int f = 4747474;
string theEnd = "... and then Mr.Grizz Blasted off on the spaceship, and all seemed lost, But then Deep cut showed up. Fry summond her eals to make an ink tornado, shiver let the main charecter ride master mega the shark, and Big Man gave the main charecter a space helmate. Now with the power of the Shark nado the main charecter is able to chase Mr.Grizz into space. Soon the main charecter catched up to the spaceship, and the final battle begins. The main charecter must collect Golden eggs to power up Lil' buddy in order to clear out the fuzzy ooze to aproch Mr.Grizz. Once close enogh the main charcter muct ink Mr.Grizz in order to show his weak spots at which point Lil' buddy would atack them. This happend three times, Mr Grizz tryes to stop the main charecter by detaching the lower half of the ship sending them flying into space. But at the last Momment DJ Octavio came out of no where with a spaceship and with the help of the Main charecter finally destroyed Mr. Grizz and samde the world."; 
Console.WriteLine(theEnd);
}

void StackOver(){
    int ohNo = 1;
StackOver();
}