---
title: "Custom plug-in handling through shared variable (Dynamics 365 Sales) | MicrosoftDocs"
description: "Use a shared variable in your custom plug-in to prevent triggering operations on parent entities"
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
# Custom plug-in handling by using shared variable

## Issue

- Create and update operations on Opportunity, Quote, Order, and Invoice entities are triggering updates on their parent entities.
- Retrieving details about Opportunity, Quote, Order, and Invoice entities internally triggers the Price Calculation service<!--caps are okay for service names.-->, which subsequently triggers custom plug-ins<!--note from editor: I know that it's used extensively in Dynamics documentation, but are you sure that "plug-in" is the right term? Microsoft Writing Style Guide says it's "noun to describe a component that permits a specific browser to recognize and support the file format of an object embedded in an HTML document. Don't use as a synonym for add-in or add-on." It goes on to describe an add-in as "software that adds functionality to a larger program[...] Add-in can also refer to a driver or to a customer-written program that adds functionality to a larger program, such as a wizard."--> created by customers. 

## Resolution

Custom plug-ins execute create, update, and save operations on Opportunity, Quote, Order, and Invoice entities. Create and update operations on these entities internally trigger the Price Calculation service, which subsequently updates associated price-related fields or attributes of their parent entities.<!--Is it necessary to re-state the issue here?-->

You can identify or differentiate any updates in Opportunity, Quote, Order, or Invoice entities&mdash;or parent Opportunity, Quote, Order, or Invoice entities&mdash;by using the internal Price Calculation service or by using your own custom plug-in. The Boolean<!--always capped, via Style Guide--> shared variable `InternalSystemPriceCalculationEvent`, which is accessible through `IPluginExecutionContext`, is available within the plug-in code. Any create or update event processed by using the Price Calculation service will set the value of the variable `InternalSystemPriceCalculationEvent` to `true`. The default value of `InternalSystemPriceCalculationEvent` is `false`. You can access this variable from your custom plug-in code to control the flow of your existing business logic.<!--Will the reader be able to take over from here? I see the sample code says "TO DO - Add or skip custom business logic." Is that going to suffice, or can you give a bit more advice?-->

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