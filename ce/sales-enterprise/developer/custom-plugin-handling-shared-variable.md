---
title: "Custom plug-in handling through a shared variable (Dynamics 365 Sales) | MicrosoftDocs"
description: "Use a shared variable in your custom plug-in to prevent triggering operations on parent entities"
ms.date: 07/09/2020
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
# Custom plug-in handling by using a shared variable

## Issue

- Create and update operations on Opportunity, Quote, Order, and Invoice entities are triggering updates on their parent entities.
- Retrieving details about Opportunity, Quote, Order, and Invoice entities internally triggers the Price Calculation service, which subsequently triggers custom plug-ins created by customers. 

## Resolution

Custom plug-ins execute create, update, and save operations on Opportunity, Quote, Order, and Invoice entities. Create and update operations on these entities internally trigger the Price Calculation service, which subsequently updates associated price-related fields or attributes of their parent entities.

You can identify or differentiate any updates in Opportunity, Quote, Order, or Invoice entities or parent Opportunity, Quote, Order, or Invoice entities by using the internal Price Calculation service or by using your own custom plug-in. The Boolean shared variable `InternalSystemPriceCalculationEvent`, which is accessible through `IPluginExecutionContext`, is available within the plug-in code. Any create or update event processed by using the Price Calculation service will set the value of the variable `InternalSystemPriceCalculationEvent` to `true`. The default value of `InternalSystemPriceCalculationEvent` is `false`. You can access this variable from your custom plug-in code to control the flow of your existing business logic.

> [!NOTE]
> To perform custom plug-in operations by using a shared variable, make sure that the out-of-the-box Price Calculation service is disabled.

### Sample code

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

### See also

[Developer guide for Dynamics 365 Sales overview](developer-guide.md)<br />
[Organization entity reference](../../customerengagement/on-premises/developer/entities/organization.md)<br />
[System user entity reference](../../customerengagement/on-premises/developer/entities/systemuser.md)<br />
[Quote, order, and invoice entities](../../customerengagement/on-premises/developer/quote-order-invoice-entities.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]