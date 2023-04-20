---
title: "Use suggested contacts in Teams chats in Customer Service | Microsoft Docs"
description: "Learn how to use suggested contacts with Teams chat functionality in Dynamics 365 Customer Service and Dynamics 365 Customer Service workspace."
ms.date: 10/03/2022
ms.topic: article
author: lalexms
ms.author: laalexan
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# Use suggested contacts to collaborate with the right coworkers

The Teams chat embedded in Dynamics 365 Customer Service Hub, Customer Service workspace, or custom apps can help you more quickly find the right coworkers to collaborate with. This collaboration can help you more quickly resolve customer issues.

To use suggested contacts, your administrator must enable the feature. For the case record type, there are two types of suggestions: AI and rules-based. Other record types enabled for connected chats may only have rules-based suggestions.
-  AI: Suggestions based on cases that were resolved by other agents. More information: [Collaborate with AI-suggested contacts in Microsoft Teams](/dynamics365/customer-service/use-ai-suggested-contacts-teams)
-  Rules-based: Suggestions of coworkers who are associated with the connected record or other related records. For example, an agent can see suggestions to collaborate with their supervisor, the account manager for the customer, or a colleague who updated the case timeline with a note or task. More information:

## View suggested contacts

1. Open the collaboration pane, and then select **New connected chat**.
   
   :::image type="content" source="media/teams-new-linked-chat.png" alt-text="New connected chat option in Teams.":::

2. A dropdown list of suggested contacts is automatically displayed in the **Participants** section. The list has two sections: Suggested contacts who've resolved similar cases, and contacts that are related to the record. Note the following details about the suggestions that are displayed:
  - The rules-based suggestions will show only contacts that have been enabled by your administrator. Additionally, the list is displayed in the order defined by your administrator.
  - A maximum of three suggestions per section are displayed. If you want to see more, select **View more**.

   :::image type="content" source="media/teams-suggested-contacts.png" alt-text="Suggested contacts view in Teams.":::
   

### See also

[Configure Teams chat in Customer Service](configure-teams-chat.md)<br>
[Use Teams chat in Customer Service](use-teams-chat.md)<br>

[!INCLUDE[footer-include](../includes/footer-banner.md)]  
 

