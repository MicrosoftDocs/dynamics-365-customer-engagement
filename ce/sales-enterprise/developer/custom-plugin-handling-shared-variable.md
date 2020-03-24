---
title: "Custom plugin handling using shared variable (Dynamics 365 Sales) | MicrosoftDocs"
description: 
ms.date: 03/24/2020
ms.service: 
  - dynamics-365-sales
ms.custom: 
  - dyn365-sales
ms.topic: get-started-article
author: susikka
ms.author: susikka
manager: shujoshi
ms.reviewer: susikka
---
# Custom plugin handling using shared variable

Custom plugins execute on create/update/save operation of Opportunity, Quote, Order, Invoice entities. Create and update operations on OQOI entities internally trigger the Price Calculation service, which subsequently updates associated price related fields or attributes of the parent OQOI entities. 

<!--
As customers are unaware of internal working/implementation of Price Calculation Service, they assume changes are getting triggered due to their custom plug-in implementation. Few issues reported by customer are – 
-	Create/Update of OQOI details, triggering updates on Parent OQOI entities.
-	Retrieval of OQOI details, internally triggers Price Calculation service, which subsequently triggers Custom Plug-ins created by customers. 
Solution 


As Price calculation service is internal to system by design, We wanted to provide a mechanism through which customer should be able to  
In the similar direction, we introduced a boolean shared variable named as “InternalSystemPriceCalculationEvent”, which will be accessible via IPluginExecutionContext inside the plugin code. 
Any Create/Update event processed via Price Calculation service, will set this variable value to “True”. By-default the value will be “false” for this variable.
Customer can access this variable inside their custom plug-in code and control the flow of their existing business logic. 
-->

You can identity or differentiate any updates in OQOI entities or parent OQOI entities using the internal price calculation service or using your own custom plugin. In the similar direction, we introduced a boolean shared variable named as “InternalSystemPriceCalculationEvent”, which will be accessible via IPluginExecutionContext inside the plugin code. Any create or update event processed using the price calculation service will set the value of variable `InternalSystemPriceCalculationEvent` to `true`. The default value of `InternalSystemPriceCalculationEvent` variable is `false` and it is accessible via `IPluginExecutionContext` inside the plugin code. You can access this variable from your custom plugin code to control the flow of your existing business logic. 

## Sample code

```csharp
public void Execute(IServiceProvider serviceProvider)
{
   // Obtain the tracing service
   ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));

   // Obtain the execution context from the service provider.  
    IPluginExecutionContext executionContext = (IPluginExecutionContext)
    serviceProvider.GetService(typeof(IPluginExecutionContext))
    bool isInternalSystemPriceCalculationEvent = false;

    //Check existence of shared variable and fetch the value from executionContext
    if (executionContext.ParentContext != null && executionContext.ParentContext.SharedVariables.ContainsKey("InternalSystemPriceCalculationEvent"))
                    
    {
        isInternalSystemPriceCalculationEvent = (bool)executionContext.ParentContext.SharedVariables["InternalSystemPriceCalculationEvent"];
    }   

    if (isInternalSystemPriceCalculationEvent)
    {
            //TO DO - Add/skip custom business logic
    }

}
```

## See also

[Developer guide for Dynamics 365 Sales overview](developer-guide.md)