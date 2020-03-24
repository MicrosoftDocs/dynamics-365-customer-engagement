---
title: "Custom plugin handling through shared variable (Dynamics 365 Sales) | MicrosoftDocs"
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
# Custom plugin handling through shared variable

Custom plugins execute on create, update and save operations of Opportunity, Quote, Order, Invoice(OQOI) entities. Create and update operations on OQOI entities internally trigger the Price Calculation service, which subsequently update associated price related fields or attributes of the parent OQOI entities. 

You can identity or differentiate any updates in OQOI entities or parent OQOI entities using the internal price calculation service or using your own custom plugin. The boolean shared variable called `InternalSystemPriceCalculationEvent`, which is accessible via `IPluginExecutionContext` is available within the plugin code. Any create or update event processed using the price calculation service will set the value of variable `InternalSystemPriceCalculationEvent` to `true`. The default value of `InternalSystemPriceCalculationEvent` variable is `false`. You can access this variable from your custom plugin code to control the flow of your existing business logic. 

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
            //TO DO - Add or skip custom business logic
    }

}
```

## See also

[Developer guide for Dynamics 365 Sales overview](developer-guide.md)<br />
[Organization entity reference](../../customerengagement/on-premises/developer/entities/organization.md)<br />
[System user entity reference](../../customerengagement/on-premises/developer/entities/systemuser.md)<br />
[Quote, order, and invoice entities](../../customerengagement/on-premises/developer/quote-order-invoice-entities.md)