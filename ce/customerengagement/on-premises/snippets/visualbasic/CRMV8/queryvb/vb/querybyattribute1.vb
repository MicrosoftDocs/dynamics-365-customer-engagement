' <snippetquerybyattribute1>


 '  Create query using QueryByAttribute.
 Dim querybyattribute As New QueryByAttribute("account")
 querybyattribute.ColumnSet = New ColumnSet("name", "address1_city", "emailaddress1")

 '  Attribute to query.
 querybyattribute.Attributes.AddRange("address1_city")

 '  Value of queried attribute to return.
 querybyattribute.Values.AddRange("Redmond")

 '  Query passed to service proxy.
 Dim retrieved As EntityCollection = _service.RetrieveMultiple(querybyattribute)

 Console.WriteLine("Query Using QueryByAttribute")
 Console.WriteLine("===============================")

 '  Iterate through returned collection.
 For Each c In retrieved.Entities
     Console.WriteLine("Name: " &amp; c.Attributes("name").ToString())

     If c.Attributes.Contains("address1_city") Then
         Console.WriteLine("Address: " &amp; c.Attributes("address1_city").ToString())
     End If

     If c.Attributes.Contains("emailaddress1") Then
         Console.WriteLine("E-mail: " &amp; c.Attributes("emailaddress1").ToString())
     End If
 Next c
 Console.WriteLine("===============================")

' </snippetquerybyattribute1>