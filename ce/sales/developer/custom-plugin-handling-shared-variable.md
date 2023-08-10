---
title: Handle Custom plug-in by using shared variable
description: Use a shared variable in your custom plug-in to prevent it from triggering operations on parent tables.
ms.date: 10/26/2021
ms.topic: conceptual
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - dyn365-sales
ms.reviewer: susikka
---
# Custom plug-in handling by using a shared variable 

## Issue

- Create and update operations on Opportunity, Quote, Order, and Invoice tables are triggering updates on their parent tables.
- Retrieving details about Opportunity, Quote, Order, and Invoice tables internally trigger the Price Calculation service, which subsequently triggers custom plug-ins created by customers. 

## Resolution

Custom plug-ins execute create, update, and save operations on Opportunity, Quote, Order, and Invoice tables. Create and update operations on these tables internally trigger the Price Calculation service, which then updates associated price-related fields or attributes of their parent tables.

You can identify or differentiate any updates in Opportunity, Quote, Order, or Invoice tables or parent Opportunity, Quote, Order, or Invoice tables by using the internal Price Calculation service or by using your own custom plug-in. The Boolean shared variable `InternalSystemPriceCalculationEvent`, which is accessible through `IPluginExecutionContext`, is available within the plug-in code. Any create or update event processed by using the Price Calculation service will set the value of the variable `InternalSystemPriceCalculationEvent` to `true`. The default value of `InternalSystemPriceCalculationEvent` is `false`. You can access this variable from your custom plug-in code to control the flow of your existing business logic.

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
[Organization table reference](/power-apps/developer/data-platform/reference/entities/organization)<br />
[System user table reference](/power-apps/developer/data-platform/reference/entities/systemuser)<br />
[Quote, order, and invoice tables](quote-order-invoice-entities.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
