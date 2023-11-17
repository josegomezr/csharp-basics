Console.Write("What's your favourite fruit? (apple, banana or orange): ");

// Here's an interesting bit.
// Console.ReadLine() returns either a string with the full line or null
// C# does not like this ambiguity, you'll see a warning of CS8600: [... yadda yadda...]
//
// to get rid of this warning (being realistic, Console.ReadLine() will likely not fail in your console)
// we need to ensure the compiler that we've handled the null-returning case so it can be sure that always
// a value of type `string` is handled at all times.
//
// TL;DR: (expr) ?? "default value"
//        keeps compiler happy about possible-null results.
string fruit = Console.ReadLine() ?? "";

// and just for being rigurous, let's catch that.
if(fruit == ""){
    Console.WriteLine();
    Console.WriteLine("You could not say anything :o!");
    return; // nifty feature here, we can exit early from top-level!
}

// Now here we know something was written, so back to business as usual.
//
// Console.ReadLine will give you a full line of the input, that also includes
// what would be the equivalent of the <enter> key, the before-mentioned LF/\n/0x0A character.
fruit = fruit.Trim();

Console.Write("You said: '{0}'", fruit);

if(fruit == "apple" || fruit == "banana" || fruit == "orange"){
    Console.WriteLine(" - JUST LIKE I DID!!");
} else {
    Console.WriteLine(" - what's that??? o.o !!");
}