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
[!INCLUDE[cc-applies-to-psa-app-2-5x-9-0-platform](../includes/cc-applies-to-psa-app-2-5x-9-0-platform.md)]
[!INCLUDE[cc-applies-to-psa-app-2-4x-9-0-platform](../includes/cc-applies-to-psa-app-2-4x-9-0-platform.md)]
[!INCLUDE[cc-applies-to-psa-app-1x-8-2-platform](../includes/cc-applies-to-psa-app-1x-8-2-platform.md)]

The way you customize the Project Stages business process flow depends on the version of the Project Service app and the version of Dynamics 365 (online). In addition, there is a known limitation that the names of the stages must exactly match the expected English names (New, Quote, Plan, Deliver, Complete, Close).

This article explains the reasons for this limitation and provides suggested workarounds.

## Business logic built into the project entity requires an exact match with English stage names

The Project Stages business process flow includes business logic that drives the following behaviors in the app:
- When the project is associated with a quote, the code sets the business process flow to the **Quote** stage.
- When the project is associated with a contract, the code sets the business process flow to the **Plan** stage.
- When the business process flow is advanced to the **Close** stage, the project record is deactivated. When the project is deactivated, the project form and work breakdown structure (WBS) are set to read-only, the named resource bookings are released, and any associated price lists are deactivated.

This business logic relies on the English names for the project stages. This dependency on the English stage names is the main reason why customization of the Project Stages business process flow isn't encouraged, as well as why you don’t see the common business process flow actions like **Switch Process** or **Edit Process** on the project entity.

## What happens if the stage names don't match the English names?

In Project Service app version 1.x on the 8.2 platform, when the stage names within the BPF don’t match the English stage names exactly, the business logic that sets the right stage for quotes or contracts or closes the project is skipped. No error messages are displayed. This behavior explains why it appears that you can customize the Project Stages business process flow. However, you won’t see any of the automatic processes working for quotes, contracts, and project close.

In Project Service app version 2.4.4.30 or earlier on the 9.0 platform, there was a significant architectural change to business process flows, which required a re-write of the business process flow business logic. As a result, if the process stage names don’t match the expected English names, you will see an error displayed. 

Therefore, if you want to customize the Project Stages business process flow for the Project entity, you can only add new stages to the default BPF for the project entity, keeping the Quote, Plan, and Close stages. This restriction ensures that you don’t get errors from the business logic that expects the English stage names to be in the BPF.

## Version 2.5.x.x or later

In version 2.5.x.x or later, the business logic described above has been removed from the default BPF for the project entity. Upgrading to that version or later lets you customize or replace the default BPF with one of your own. If upgrading is not an option, you can customize the project entity BPF by either:

1. Adding additional stages to the default configuration, retaining the English stage names for Quote, Plan, and Close.

> [!div class="mx-imgBorder"] 
> ![Screenshot of adding stages to default configuration](media/FAQ-Customize-BPF-1.png)
 
2. Creating your own BPF and making it the primary BPF for the project entity, which lets you have any stage names you wish. However, if you want the same standard project stages such as Quote, Plan, and Close, you need to do some customizations that are driven off your custom stage names. The more complex logic is in the closing of the project, which you can still trigger by just deactivating the project record.

> [!div class="mx-imgBorder"] 
> ![Screenshot of BPF customization](media/FAQ-Customize-BPF-2.png)

## Version 2.4.4.30 or earlier on platform 9.0

In Project Service 2.4.4.30 or earlier on platform 9.0 with a custom BPF, the Stage Name field on the project entity that is used in the Project By Stage chart and project list views won’t update since it’s coupled to the default Project Stages BPF. You can address this issue with the following steps:

- Adding a custom field to capture the current BPF stage that is updated as the user advances through the custom BPF.
- Modifying the project By stage to work with your custom field instead of the default configuration.

To create your own BPF for the project entity do the following:

1. Go to Settings and then Process Center. Don’t copy the Project Stages BPF as that also copies the Project Service-specific business logic.

> [!div class="mx-imgBorder"] 
> ![Screenshot of Process Center](media/FAQ-Customize-BPF-3.png)

2. Use Process Designer to create the stage names you want. If you want to have the same functionality as the default stages for Quote, Plan, and Close, you’ll have to create that based on your custom BPF’s stage names.

> [!div class="mx-imgBorder"] 
> ![Screenshot of Process Designer used to customize BPF](media/FAQ-Customize-BPF-4.png) 

3. In the Process Designer, click on Order Process Flow to make the custom BPF the primary BPF for the project entity by moving it above the Project Stages BPF to the top of the list.

> [!div class="mx-imgBorder"] 
> ![Screenshot of using Order Process Flow](media/FAQ-Customize-BPF-5.png)

## Version 2.4.4.30 or earlier on platform 9.0

Add a new custom field to the project entity to capture the custom stages in your custom BPF. You’ll need to add business logic (plugin/workflow) to update this field when the stage on the custom BPF is updated.

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

