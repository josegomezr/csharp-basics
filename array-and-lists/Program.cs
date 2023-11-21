// just like in C/C++/Java, <type>[] defines an array
// ("in C is not quite an array mimimim-"- shut up...)
// no pointers in C#... SO FAR!

// arrays in c# are fixed... that means
double[] measurements = {7.6, 9.1, 15.3, 9.32, 3.14, 15.0};

// measurements is immutable until we explicitly resize it.

double avg = 0;

// This is a new construct. A new ephemeral variable will be created here called
// "measure" that will contain the value of each item in "measurement" but *only*
// during the lines covered by the braces.
//
// It can also be read as "for each <item> in <collection> run the following block"
foreach (double measure in measurements) {
  	avg += measure;
}

// now here "measure" doesn't exist! it cleaned itself up.
avg /= measurements.Length;

Console.Write("The average of all measurements is: {0}", avg);

// Now something more interesting is an "array" that can grow!
// (meaning items can be added or removed).
// It's possible to manually resize measurements like:

Array.Resize(ref measurements, measurements.Length + 1);

// And now it can hold one more item:

measurements[measurements.Length-1] = 999;

Console.Write("Measurements: ");

foreach (double measure in measurements) {
	// oxford comma!
	Console.Write("{0}, ", measure);
}
Console.WriteLine();

// but that's quite ugly as we start playing with "ref" that looks oddly similar
// to a pointer, and nothing involving pointers is good for a start... So let's
// use a more complex data-type (ironically it'll be easier to understand)

// 'List<%type%>' reads: List of %type%'s
// below reads: List of doubles.
List<double> growing_measurements = new List<double>();

// this list is empty, but we can add some stuff to it ;)

foreach (double measure in measurements) {
	// look at that beauty, no need to explictly resize!
	growing_measurements.Add(measure);
}

// adding two more items for good measure 🥁
growing_measurements.Add(63);
growing_measurements.Add(9009);

// and iterating it it's exactly the same!
Console.Write("From the List: ");
foreach (double measure in growing_measurements) {
	// oxford comma!
	Console.Write("{0}, ", measure);
}
Console.WriteLine();