---
title: "Create custom cards in Dynamics 365 Sales | MicrosoftDocs"
description: "Create custom cards in Dynamics 365 Sales using Assistant"
ms.date: 10/31/2018
ms.service: crm-online
ms.custom: 
ms.topic: article
ms.assetid: 1b7a3dda-59c9-4b5d-b4b2-7fbc039a3f22
author: udaykirang
ms.author: udag
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
---

# Create custom cards in Assistant 

Action cards provides you up to date information on email, meeting, and much more in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. These cards reminds you of upcoming activities; it evaluates your communications, and suggests when it might be time to reach out to a contact that’s been inactive for a while; it identifies email messages that may be waiting for a reply from you; it alerts you when an opportunity is nearing its close date; and much more. These cards are displayed on forms, dashboards, and throughout the application to provide relevant information for the context you are working in at the moment.
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Action cards reference](action-cards-reference.md) 

The action cards contain the following basic elements:

> [!div class="mx-imgBorder"]
> ![Action cards basic elements](media/card-type-dev.png "Action cards basic elements") 

1.	**Generics actions:** The more options consist of the following actionable buttons:
    - **Snooze button:** Hides card temporarily. Snooze time varies by card type. Once the snooze time expires the card will again be visible.
    - **Dismiss button:** Dismisses card permanently, regardless of whether you have completed the action.
2. **Actions area:** Provides convenient links that will help you complete whatever type of action the card is recommending. The number (up to two) and types of links provided here vary by card type.
3. **Main content area:** Shows the title of the record the card refers to, its summary, the card type, and other basic information. Click anywhere in this area (except for on the two buttons) to open the related item, which might be a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] record or an email message.

You can generate these custom cards in two ways:

- As a sales manager or administrator, you can generate custom insight cards (known as action cards) by using the **Assistant** which is based on Microsoft Flow. This provides you a graphical user interface to generate custom cards. To learn more, see [Preview: Manage insight cards](manage-custom-cards-flow.md)
    >[!NOTE]
    > We recommend you to use the **Assistant** to generate the custom insight cards.  

- As a developer, you can create card types according to your organizational requirements and make them available for users. To learn more, see [Sample: Create custom insight cards type](sample-extend-relationship-assistant-card-type.md)

    >[!NOTE]
    >To use this feature, you must purchase a **Dynamics 365 Sales Insights** license, or start a trial to use Sales Insights features.

### See also

[Manage insight cards](manage-custom-cards-flow.md)

[Sample: Extend assistant card type (custom card)](sample-extend-relationship-assistant-card-type.md)

[Configure Assistant](configure-assistant.md)

[Guide customer communications with assistant](assistant.md)
