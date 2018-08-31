---

title: How do I customize the Project Stages business process flow? (Dynamics 365 for Project Service) | MicrosoftDocs
description: An overview of how to customize the Project Stages business process flow (BPF) in Dynamics 365 for Project Service.
author: NeilWOrint 
manager: ShellyHa
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 8/27/2018
ms.topic: article
ms.prod: 
ms.service: business-applications
ms.technology: Dynamics 365 for Project Service 3.x
ms.author: john.burrows
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
  
---

# How do I customize the Project Stages business process flow?
[!INCLUDE[cc-applies-to-psa-app-2-4x-9-0-platform](../includes/cc-applies-to-psa-app-2-4x-9-0-platform.md)]
[!INCLUDE[cc-applies-to-psa-app-1x-8-2-platform](../includes/cc-applies-to-psa-app-1x-8-2-platform.md)]

There's a known limitation in earlier versions of the Project Service application that the names of the stages in the Project Stages business process flow must exactly match the expected English names (**Quote**, **Plan**, **Close**). Otherwise, the business logic, which relies on the English stage names, doesn't work as expected. That's why you don't see familiar actions such as **Switch Process** or **Edit Process** available on the project form, and customizing the business process flow isn't encouraged. 

This limitation has been corrected in Project Service app version 2.5.x.x or later. If updating isn't an option, this article provides suggested workarounds if you have an earlier version and you do need to customize the default business process flow. 

[screenshot]

## Business logic built into the project entity requires an exact match with English stage names

The Project Stages business process flow includes business logic that drives the following behaviors in the app:
- When the project is associated with a quote, the code sets the business process flow to the **Quote** stage.
- When the project is associated with a contract, the code sets the business process flow to the **Plan** stage.
- When the business process flow is advanced to the **Close** stage, the project record is deactivated. When the project is deactivated, the project form and work breakdown structure (WBS) are set to read-only, the named resource bookings are released, and any associated price lists are deactivated.

This business logic relies on the English names for the project stages. This dependency on the English stage names is the main reason why customization of the Project Stages business process flow isn't encouraged, as well as why you don’t see the common business process flow actions like **Switch Process** or **Edit Process** on the project entity.

## What happens if the stage names don't match the English names?

In the Project Service app version 1.x on the 8.2 platform, when the stage names in the business process flow don’t match the English stage names exactly, the business logic that sets the right stage for quotes or contracts, or that closes the project, is skipped. No error messages are displayed. Therefore it appears that you are able to customize the Project Stages business process flow. However, you won’t see any of the automatic processes working for quotes, contracts, and project close.

In the Project Service app version 2.4.4.30 or earlier on the 9.0 platform, there was a significant architectural change to business process flows, which required a re-write of the business process flow business logic. As a result, if the process stage names don’t match the expected English names, you do see an error displayed. 

Therefore, if you want to customize the Project Stages business process flow for the Project entity, you can only add new stages to the default BPF for the project entity, keeping the **Quote**, **Plan**, and **Close** stages. This restriction ensures that you don’t get errors from the business logic that expects the English stage names in the business process flow.

## Upgrade to version 2.5.x.x or later

In version 2.5.x.x or later, the business logic described in this article has been removed from the default business process flow for the project entity. Upgrading to that version or later lets you customize or replace the default business process flow with one of your own. 

## Workarounds for earlier versions

If upgrading isn't an option, you can customize the Project Stages business process flow for the project entity in one of these two ways:

1. Add additional stages to the default configuration, retaining the English stage names for **Quote**, **Plan**, and **Close**.

> [!div class="mx-imgBorder"] 
> ![Screenshot of adding stages to default configuration](media/FAQ-Customize-BPF-1.png)
 
2. Create your own business process flow and make it the primary business process flow for the project entity, which lets you have any stage names you want. However, if you want to use the same standard project stages such as Quote, Plan, and Close, you need to do some customizations that are driven off your custom stage names. The more complex logic is in the closing of the project, which you can still trigger by just deactivating the project record.

> [!div class="mx-imgBorder"] 
> ![Screenshot of BPF customization](media/FAQ-Customize-BPF-2.png)

## Additional considerations for Project Service app version 2.4.4.30 or earlier on platform 9.0

In Project Service 2.4.4.30 or earlier on platform 9.0 with a custom business process flow, the **Stage Name** field on the project entity that is used in the **Project By Stage** chart and project list views won’t update, because it’s coupled to the default Project Stages business process flow. You can address this issue with the following steps:

- Adding a custom field to capture the current business process flow stage that is updated as the user advances through the custom business process flow.

- Modifying the **Project By Stage** chart to work with your custom field instead of the default configuration.

To create your own business process flow for the project entity do the following:

1. Go to **Settings** > **Process Center**. Don’t copy the Project Stages business process flow because that also copies the Project Service business logic.

> [!div class="mx-imgBorder"] 
> ![Screenshot of Process Center](media/FAQ-Customize-BPF-3.png)

2. Use the Process Designer to create the stage names you want. If you want to have the same functionality as the default stages for **Quote**, **Plan**, and **Close**, you’ll have to create that based on your custom business process flow’s stage names.

> [!div class="mx-imgBorder"] 
> ![Screenshot of Process Designer used to customize BPF](media/FAQ-Customize-BPF-4.png) 

3. In the Process Designer, click **Order Process Flow** to make the custom BPF the primary business process flow for the project entity by moving it above the Project Stages business process flow to the top of the list.

> [!div class="mx-imgBorder"] 
> ![Screenshot of using Order Process Flow](media/FAQ-Customize-BPF-5.png)

## Version 2.4.4.30 or earlier on platform 9.0

Add a new custom field to the project entity to capture the custom stages in your custom business process flow. You’ll need to add business logic (plugin/workflow) to update this field when the stage on the custom business process flow is updated.

> [!div class="mx-imgBorder"] 
> ![Screenshot of customizing Project entity](media/FAQ-Customize-BPF-6.png)

## Version 2.4.4.30 or earlier on the 9.0 platform

Modify the Project By Stage chart to use your new custom field for stages.

> [!div class="mx-imgBorder"] 
> ![Screenshot of using the Project By Stage chart](media/FAQ-Customize-BPF-7.png)

## Version 2.4.4.30 or earlier on the 9.0 platform

Modify views on the Project entity to include your new custom field for stages.

> [!div class="mx-imgBorder"] 
> ![Screenshot of modifying views on the Project entity](media/FAQ-Customize-BPF-8.png)

