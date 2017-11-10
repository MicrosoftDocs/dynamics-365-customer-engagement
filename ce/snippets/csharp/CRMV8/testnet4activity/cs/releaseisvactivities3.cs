// <snippetreleaseisvactivities3>


 public sealed partial class ReleaseScenario_MessageName : CodeActivity
 {
     protected override void Execute(CodeActivityContext executionContext)
     {
         IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();

         //Set the variable
         MessageName.Set(executionContext, context.MessageName);
     }

     //Define the properties
     [Output("Message Name")]
     public OutArgument<string> MessageName { get; set; }
 }

// </snippetreleaseisvactivities3>