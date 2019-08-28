---
title: "Frequently asked questions for Dynamics 365 for Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 08/28/2019
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

# Frequently asked questions for Field Service - General

> [!Note]
> If you're looking for help with **errors**, **unexpected behavior**, **crashes**, and **bugs**, create a [Dynamics 365 support ticket](https://dynamics.microsoft.com/contact-us/). 

## Can I customize out-of-the-box web resources, option sets, or security roles? 

No, this is not supported. Organizations that customize these components may not immediately cause the environment to break, but eventually, as Microsoft releases changes to the customized components, the changes will not be applied to the top layer of that component. The specific customized layer will override all future changes. This will almost certainly eventually cause the instances that have customized these components to experience unpredictable errors and behavior.

## Why are there work orders with duplicate work order numbers?

This is a known issue that was fixed in Field Service version **8.6.0.274+** that lets you apply the Dynamics 365 auto numbering system to the work order entity. To do this you must: 

1.  Opt-in to the **Auto Numbering** function in **Field Service Settings**.
2.  Manage it in **Dynamics Settings** > **Administration** > **Auto-Numbering**.   

## Why can't cascade crew changes be disabled for a booking scheduled to a crew or group 

This happens when a booking is assigned from a resource (not crew or group) to a crew or group and the value of **msdyn_CascadeCrewChanges** in the booking is set to false. To overcome this, open the booking and set the value of **msdyn_CascadeCrewChanges** to **Yes**. Then, re-perform the booking assignment to a crew. This will fix the error the user sees when assigning the booking to a crew.

## Can we modify, edit, or delete Field Service date fields or statuses?

No. Modifying, editing, or deleting date fields and statuses can effect business logic and may disrupt solution upgrades. Examples of work order date fields include date window start, date window end, time from promised and time to promised. Examples of status fields include work order system status and Agreement system status.

## Why do I get the error message "This form can only be used on service-maintenance based records. Record is read only"

Field Service makes the Opportunity, Lead, Quote, and Invoice forms read-only once it detects the record is not a service-maintenance based record. This means FS forms or the forms copied from FS forms do not support Opportunity, Lead, Quote, and Invoice records other than Field Service Opportunity, Lead, Quote, and Invoice. If you want to use an Opportunity form for non-Field Service related Opportunities then you should use the OOB Opportunity ("Opportunity: Opportunity") form shipped by Dynamics 365 for Sales or copy this form for further customization. The same is true for Lead, Quote, and Invoice.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/faq-opportunity-read-only.png)

## See also

- [Resource Scheduling Optimization FAQs](rso-faq.md)
- [Field Service Mobile FAQs](activate-fs-mobile-app-license.md)
- [Get help for Field Service Mobile](mobile-get-help.md)









