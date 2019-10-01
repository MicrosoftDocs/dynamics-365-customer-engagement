// <snippetfollowupplugin2>

 // The InputParameters collection contains all the data passed in the message request.
 if (context.InputParameters.Contains("Target") &&
       context.InputParameters["Target"] is Entity)
 {
     // Obtain the target entity from the input parameters.
     Entity entity = (Entity)context.InputParameters["Target"];

// </snippetfollowupplugin2>