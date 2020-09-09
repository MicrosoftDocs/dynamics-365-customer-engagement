' <snippetupdateconnectionrole1>


 ' Define some anonymous types to define the range 
 ' of possible connection property values.
 Dim Categories = New With {Key .Business = 1, Key .Family = 2, Key .Social = 3, Key .Sales = 4, Key .Other = 5}

 ' Update the connectionrole instance.
 Dim connectionRole As ConnectionRole = New ConnectionRole With { _
     .ConnectionRoleId = _connectionRoleId, .Name = "Updated Connection Role", _
     .Description = "This is an updated connection role.", .Category = New OptionSetValue(Categories.Other)}

 _serviceProxy.Update(connectionRole)

' </snippetupdateconnectionrole1>