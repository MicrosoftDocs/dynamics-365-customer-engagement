---
title: "Configure rules-based suggested contacts when starting a Microsoft Teams chat in Dynamics 365 Customer Service | Microsoft Docs"
description: "Learn how to configure the ability to use rules-based suggested contacts."
ms.date: 01/05/2023
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
---

# Configure rules-based suggestions for contacts in Microsoft Teams

Agents can collaborate with other contacts directly through Microsoft Teams to quickly resolve customer issues. As an administrator, you can enable rules-based suggested contacts to be displayed when an agent starts a new connected chat. This feature can help agents in your organization to quickly find the right coworkers to collaborate with. 

## Turn on the suggested contacts for a record type

> [!NOTE]
> For the case record type, there are two types of contact suggestions: AI and rules-based. Most record types enabled for connected chats only have rules-based suggestions. For more information about configuring AI-suggested contacts in Teams, see [Configure AI suggestions for contacts in Microsoft Teams](configure-teams-collaboration.md)

**To enable collaboration with Microsoft Teams and chat**

1. In Dynamics 365, go to one of the apps and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, in **Agent experience**, select **Collaboration**.
    
    1. In **Embedded chat using Teams**, select **Manage**.
   
   ### [Customer Service Hub](#tab/customerservicehub) 

    1. In the site map, select **Service Management**.
    2. In **Collaboration**, select **Embedded chat using Teams**.

1. On the **Microsoft Teams collaboration and chat** page, set the toggle for **Turn on the linking of Dynamics 365 records to Microsoft Teams channels** to **Yes**.

1. To get suggested contacts for active cases or supported conversations, perform the following steps:
   
   1. In **Connect chat to Dynamics 365 records**, select record type for which you want to enable rules-based suggested contacts. Based on your selection, the relative settings pane appears on the right.

   2. In **Suggest contacts**, turn on the toggle for **Rules-based suggested contacts**.

    :::image type="content" source="media/configure-suggest-contact.png" alt-text="Settings page to turn on or off the rules-based suggested contacts feature.":::

5. In the **Update rules for suggesting contacts** section, reorder or disable the rules for suggesting contacts. Users will see the suggestions in the order you choose.

    - To reorder the rules, hover over a rule, and then select the up or down arrow to move the rules up or down, respectively.
    - To disable a rule, hover over a rule, and then select :::image type="icon" source="media/suggested-contacts-rule-disable.png" border="false":::. When the rule is disabled, :::image type="icon" source="media/suggested-contacts-rule-disabled.png" border="false"::: is displayed when you hover over the disabled rule.

    :::image type="content" source="media/c.png" alt-text="Reorder or disable the rules for suggested contacts.":::
    - To delete a rule, hover over the rule, and then select :::image type="icon" source="media/suggested-contacts-rule-delete.png" border="false":::.

6. Select **Save**.

## Add a rule



### See also

[Configure Microsoft Teams chat in Customer Service](configure-teams-chat.md)   
[Use Teams chat in Customer Service](use-teams-chat.md)
