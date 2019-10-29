' <snippetuselinqquery1>


 ' Retrieve records with Skip/Take record paging. Setting a page size
 ' can help you manage your Skip and Take calls, since Skip must be
 ' passed a multiple of Take's parameter value.
 Dim pageSize As Integer = 5

 Dim accountsByPage = ( _
     From a In svcContext.CreateQuery(Of Account)() _
     Select New Account With {.Name = a.Name})
 Console.WriteLine("Skip 10 accounts, then Take 5 accounts")
 Console.WriteLine("======================================")
 For Each a In accountsByPage.Skip(2 * pageSize).Take(pageSize)
     Console.WriteLine(a.Name)
 Next a
 Console.WriteLine()
 Console.WriteLine("<End of Listing>")
 Console.WriteLine()

' </snippetuselinqquery1>