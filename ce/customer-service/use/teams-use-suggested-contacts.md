---
title: Use suggested contacts in Teams chats 
description: Learn how to use suggested contacts with Teams chat functionality.
ms.date: 01/17/2025
ms.topic: article
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.collection: bap-ai-copilot
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# Use suggested contacts to collaborate with the right coworkers

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

> [!NOTE]
> Case is applicable to Customer Service only.


The Teams chat embedded in Customer Service Hub, Customer Service workspace, Contact Center workspace, or custom apps can help you more quickly find the right coworkers to collaborate with. This collaboration can help you more quickly resolve customer issues.

To use suggested contacts, your administrator must enable the feature. For the case record type, there are two types of suggestions: AI and rules-based. Other record types enabled for connected chats may only have rules-based suggestions.
-  AI: Suggestions based on cases that were resolved by other customer service representatives (representatives). More information: [Collaborate with AI-suggested contacts in Microsoft Teams](/dynamics365/customer-service/use-ai-suggested-contacts-teams)
-  Rules-based: Suggestions of coworkers who are associated with the connected record or other related records. For example, a representative can see suggestions to collaborate with their supervisor, the account manager for the customer, or a colleague who updated the case timeline with a note or task. More information:

## View suggested contacts

1. Open the collaboration pane, and then select **New connected chat**.
   
   :::image type="content" source="../media/teams-new-linked-chat.png" alt-text="New connected chat option in Teams.":::

2. A dropdown list of suggested contacts is automatically displayed in the **Participants** section. The list has two sections: Suggested contacts who've resolved similar cases, and contacts that are related to the record. Note the following details about the suggestions that are displayed:
  - The rules-based suggestions will show only contacts that have been enabled by your administrator. Additionally, the list is displayed in the order defined by your administrator.
  - A maximum of three suggestions per section are displayed. If you want to see more, select **View more**.

   :::image type="content" source="../media/teams-suggested-contacts.png" alt-text="Suggested contacts view in Teams.":::
   

### Related information

[Configure Teams chat ](../administer/configure-teams-chat.md)<br>
[Use Teams chat ](use-teams-chat.md)<br>

[!INCLUDE[footer-include](../../includes/footer-banner.md)]  
 

