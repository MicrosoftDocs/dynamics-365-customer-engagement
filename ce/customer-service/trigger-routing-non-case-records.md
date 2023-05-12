---
title: "Trigger routing for non-case records using plug-in | MicrosoftDocs"
description: "This page provides sample code for developers to trigger routing for non-case records using the IPlugin interface."
author: gandhamm
ms.author: mgandham
ms.date: 03/04/2022
ms.topic: article

---
# Route non-case records using a plug-in

You can trigger routing for non-case records such as email messages programmatically, using the [IPlugin interface](/dotnet/api/microsoft.xrm.sdk.iplugin?view=dynamics-general-ce-9&preserve-view=true).

You can use the following sample code in your Console App (.NET framework) of Visual Studio. The code checks for the following two conditions and if they're met, it triggers the [msdyn_ApplyRoutingRuleEntityRecord](developer/reference/actions/msdyn_applyroutingruleentityrecord.md) action.
- whether the Web service message is to create a record
- whether the record is an email message.
  
```csharp
public class SamplePlugin : IPlugin 
{ 
    public void Execute(IServiceProvider serviceProvider) 
    { 
          // Obtain the tracing service 
        ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService)); 
        // Obtain the execution context from the service provider 
        IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext)); 
            // Check if create message 
            if (context.MessageName.ToLower().Equals("create")) 
            { 
                // The InputParameters collection contains all the data passed in the message request 
                if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity) 
                { 
                    // Obtain the target entity from the input parameters 
                    Entity entity = (Entity)context.InputParameters["Target"]; 
                    // Target is an email 
                    if (entity.LogicalName.ToLower().Equals("email")) 
                    { 
                        try 
                        {  
                            // Obtain the organization service reference that you'll need for web service calls 
                            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory)); 
                            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId); 
                            // Execute msdyn_ApplyRoutingRuleEntityRecord request 
                            OrganizationRequest request = new OrganizationRequest("msdyn_ApplyRoutingRuleEntityRecord"); 
                            request["Target"] = new EntityReference("email", entity.Id); 
                            service.Execute(request); 
                        } 
                        catch (Exception ex) 
                        { 
                            tracingService.Trace("SamplePlugin: {0}", ex.ToString()); 
                            throw; 
                        } 
                    } 
                } 
            } 
        } 
    } 
}
```

### See also

[Overview of routing](overview-unified-routing.md)  
[Set up routing for records](set-up-record-routing.md)  
[Manually route records](routing-trigger.md)  
[Automatically route records using flow](routing-trigger-automatic.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
