' <snippetuselinqquery2>


 ' Use orderBy to order items retrieved.
 Dim orderedAccounts = From a In svcContext.CreateQuery(Of Account)() _
                       Order By a.Name _
                       Select New Account With {.Name = a.Name}
 Console.WriteLine("Display accounts ordered by name")
 Console.WriteLine("================================")
 For Each a In orderedAccounts
     Console.WriteLine(a.Name)
 Next a
 Console.WriteLine()
 Console.WriteLine("<End of Listing>")
 Console.WriteLine()

' </snippetuselinqquery2>