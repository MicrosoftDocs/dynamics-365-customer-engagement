// <snippetlinqexamples18>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var methodResults = svcContext.ContactSet
   .Where(a => a.LastName == "Smith");
  var methodResults2 = svcContext.ContactSet
   .Where(a => a.LastName.StartsWith("Smi"));
  Console.WriteLine();
  Console.WriteLine("Method query using Lambda expression");
  Console.WriteLine("---------------------------------------");
  foreach (var a in methodResults)
  {
   Console.WriteLine("Name: " + a.FirstName + " " + a.LastName);
  }
  Console.WriteLine("---------------------------------------");
  Console.WriteLine("Method query 2 using Lambda expression");
  Console.WriteLine("---------------------------------------");
  foreach (var a in methodResults2)
  {
   Console.WriteLine("Name: " + a.Attributes["firstname"] +
    " " + a.Attributes["lastname"]);
  }
 }

// </snippetlinqexamples18>