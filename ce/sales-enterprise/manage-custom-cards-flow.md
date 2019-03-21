---
title: "Manage custom insight cards using Microsoft Flow Dynamics 365 for Customer Engagement | MicrosoftDocs"
description: "Create custom insight cards using Microsoft and optimize ranking for cards in assistant"
keywords: "AI for sales, , "
ms.date: 03/21/2019
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 2c2a2739-a7ab-4de1-9dd9-8d6a423dc090
author: udaykirang
ms.author: udag
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 01
topic-status: Drafting
---

# Preview: Manage custom insight cards using Microsoft Flow

Applies to [!INCLUDE[pn-crm-online](../includes/pn-crm-online.md)] version 9.1.0.

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]  

The relationship assistant displays actionable insight cards (formerly called action cards) for users in [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]. The relationship assistant is evolving and we're introducing new preview capabilities such as customized insight cards to your team. To learn more about predefined insight cards, see [Action cards](../sales-enterprise/action-cards-reference.md).

With the new redesigned assistant administration, you can perform tasks that were previously available such as such as turn on and off the insight cards and set thresholds for certain cards. Additionally, you can use preview capabilities to create customized insight cards and optimize card ranking for your Dynamics 365 for Sales organization. The preview features include:

- Creating custom insight cards
- Prioritizing individual cards
- Optimizing card ranking
- Assigning cards to users by roles
- Editing custom cards

## Prerequisites

Verify the following prerequisites before you start working on insight card creation.

- You must have administrative privileges.
- You must purchase **Dynamics 365 AI for Sales** license. However, in preview you need not acquire the **Dynamics 365 AI for Sales** license.
- Embedded intelligence is enabled. To learn more, see [How to enable Embedded intelligence](../sales-enterprise/configure-enable-embedded-intelligence.md#how-to-enable-embedded-intelligence).
- Enabled preview features for Assistant.
    1. Sign into **Dynamics 365 for Sales** and go to **Settings** > **Sales AI**.
    2. Select **Configure** on **Assistant** section.
        <Add image>
        The **Assistant** tab opens.
    3. On the **Assistant** tab, select **Enable preview features**.
        <Add image>
        The feature is enabled, and you can start using it.

## Understand Assistant tab

After enabling Embedded intelligence, select **Configuration** on the **Assistant** section to go to **Assistant** tab (configuration page). The assistant displays two tabs – **Manage insight cards** and **Optimize ranking** tabs.

### Manage insight cards 

The **Manage insight cards** tab allows you to: 
- Create custom insight cards;
- View the information on the cards that are available for your organization in a tabular format;
- Filter and/or sort cards;
- Enable preview features for the assistant feature. 
The following is an example of **Manage insights cards** tab:
<Add image>

1. **Preview enable button**: This allows you to turn on or off the preview features for customizing the assistant in your organization, giving you the opportunity to try the feature. If the preview is not enabled, you cannot create custom cards or perform other action on cards such as edit, set priorities, assign to roles and so on.
2. **Create cards with Microsoft Flow**: This allows you to create cards that are custom made for your organization.
To learn more, see Create custom cards.
3. **Table with card details**: This displays the cards that are available in your organization. On the cards, you can perform actions such as edit the settings, disable, assign to security roles, and prioritize.
To learn more, see [How to prioritize cards](), [Assign cards to different roles](), and [Edit custom cards]().
4. **Filters**: This allows you to filter the cards displayed in the table based on the security roles. For example, if you want to view only the cards that are available to salesperson, select Salesperson from the filter drop down and the table is refreshed to display the cards that are assigned only to salesperson role.

### Optimize ranking tabs
The **Optimize ranking** tab provides information on the rules that are created to prioritize cards to appear in the application. The following is an example of **Optimize ranking** tab:
<Add image>

To learn more, see [How to prioritize cards](). 

## Create custom insight cards

As an administrator or sales manager, you can create your own suggested actions that are more relevant to your organization through the assistant management feature. By using events and conditions you can customize the circumstances on when to create suggestions and push information into the seller’s workflow. This helps the sellers to close deals faster. In this procedure, we will consider an example to create an insight to act when a property is updated. Let’s create the When property is updated, create an insight to act card.

1. Sign into **[!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]** and go to **Settings** > **Sales AI**.
2. Select **Configure** on **Assistant** section or select the **Assistant** tab.
    <Add image>
    
    A template selection page opens. 
    
    > [!NOTE]
    > We recommend you use templates to create insights cards.

3. Select a template to create the card.

    > [!NOTE]
    > If you want to create insights cards from an empty flow select **Create from blank**. To learn more, see [Create a flow in Microsoft Flow]().
    
    In this example, we selected **Due date is coming up** template to create the custom card.
    
    <Add image>
    
    A new tab opens with the flow selections options.
    
    <Add image>
    
    The flow validates your accounts of the applications that the flow is going to connect. In this example, the flow is connecting to Dynamics 365 and Dynamics 365 AI for Sales. Once you are successfully signed in you can continue creating the card.

    If any of the account is not valid, the **Continue** button is grayed out and you cannot proceed further. Select the **More options** icon (…) and choose the options **+ add new connection** or **Update** accordingly to login.

4. Select **Continue**.

    The predefined flow is displayed. In this example, we are creating an insight when a due date is coming up for an opportunity. There are three steps associated with the predefined flow with the prepopulated data. You can edit the steps according to your requirements.










 