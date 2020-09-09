' <snippetfollowupplugin2>


 ' The InputParameters collection contains all the data passed in the message request.
 If context.InputParameters.Contains("Target") AndAlso
     TypeOf context.InputParameters("Target") Is Entity Then

     ' Obtain the target entity from the input parameters.
     Dim entity As Entity = CType(context.InputParameters("Target"), Entity)

' </snippetfollowupplugin2>