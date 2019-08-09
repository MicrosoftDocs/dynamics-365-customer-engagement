---
title: "Troubleshoot and FAQs | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 08/08/2019
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Troubleshoot and FAQs for Field Service

## Can I customize out of the box web resources, option sets, or security roles? 

This is not supported. Organizations that customize these components may not immediately cause the environment to break, but eventually, as Microsoft ships changes to the components you customized via new versions, the changes will not be applied to the top layer of that component. The organizations' specific customized layer will override all future changes. This will almost certainly eventually cause the instances which have customized these components to experience unpredictable errors and behavior.

## Why are there work orders with duplicate work order numbers?

This is a known issue that was fixed in Field Service version **8.6.0.274+** that lets you apply the Dynamics 365 auto numbering system to the work order entity. To do this you must 1) Opt-in to Auto Numbering function in Field Service Settings and 2) manage it in **Dynamics Settings > Administration > Auto-Numbering**.   

## Cascade crew changes can't be disabled for a booking scheduled to a crew or group 

This happens when a booking is assigned from a resource (not crew or group) to a crew or group and the value of "msdyn_CascadeCrewChanges" in the booking is set to false. In order to overcome this first open the booking and set the value of "msdyn_CascadeCrewChanges" to Yes and then re-perform the booking assignment to a crew. This will fix the error the user is getting when assigning the booking to a crew.

### See also

[Resource Scheduling Optimization FAQs](rso-faq.md)









