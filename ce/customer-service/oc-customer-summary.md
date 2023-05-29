---
title: "View Active Conversation in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about Active Conversation, its sections, and how you can view customer information in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to 
ms.date: 05/04/2023
ms.custom: bap-template
---

# View customer information on Active Conversation form

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> The **Customer Summary** form is renamed as **Active Conversation** form.

One of the major challenges that customers face when contacting customer support is repeatedly giving the same information about the issue to each support agent they talk to. And if they want to review the status of their request later, they have to share the same information with another support agent to explain the context of the engagement. To avoid this situation, support agents need access to all the information the customer has provided, including details about the product or service, issue, case history, related cases, and location.

Having this information ready can help support agents reduce the hold time that they spend retrieving customer information, reduce average handling time, and increase customer satisfaction by resolving issues faster.

## What is Active Conversation?

**Active Conversation** (formerly **Customer Summary**) is a page that appears when you accept an incoming request from any channel and gives you complete information about a customer. The  **Active Conversation** view provides the following sections:

- Customer (Contact or Account)
- Conversation summary
- Case
- Recent cases
- Timeline
   
Depending on the settings enabled for you, you'll see one of the following layouts:

  ### [Enhanced Active Conversation page](#tab/enhancedcustomersummarypage)

  If your administrator has enabled the **Enhanced Active conversation form**  in Customer Service admin center, you see the enhanced **Active Conversation** page. 
  
  If your administrator has enabled the **Customise active conversation form**  in Customer Service admin center, you see the following options on the **Active Conversation** page:  
  - The **Save** and **Refresh** options are available on **Active Conversation** form. 
  - **Queue:** The queue through which the conversation has been assigned to you.
  - **Start time:** The time when you started the conversation.

  You can also use **Related** to select and navigate to the required entities.

   :::image type="content" source="media/enh-custsummary-overall-mini.png" alt-text="Enhanced quick case form" lightbox="media/enh-custsummary-overall.png":::
    
  > [!NOTE] 
  > - The form selector to switch between **Active Conversation** and **Closed Conversation** is hidden. However, you can switch between active and closed conversations if your administrator has enabled this control.
  > - You can't switch to closed conversation form from the **Active Conversation** form while the conversation is still active. Similarly, once the conversation and the session has ended, you can't switch from  the Closed Conversation form to the Active Conversation form.

  ### [Default Active Conversation page](#tab/customersummarypage)
    
  If your administrator hasn't enabled the **Enhanced Active conversation form** in **Customer Service admin center**, you see the default Active Conversation view.

  :::image type="content" source="media/customer-summary.png" alt-text="View the Active Conversation page" :::

---


## View customer details

This section provides details such as the contact name or account name. For a contact, you can view the location, email, and other details. For an account, you can view location, telephone number, and primary contact person for the account.

Use the customer section to search for an existing contact or account record, and select the record to link it to the conversation. If the record doesn't exist, you can create a new contact or account record by using the **Add Contact** or **Add Account** button, respectively. After you create it, search for the record and then select it to link it to the conversation.

Depending on the settings enabled for you, you'll see one of the following layouts:
 
  ### [Enhanced Active Conversation&mdash;Customer Details](#tab/enhancedcustomer)

   Displays the customer or account details configured by your administrator. You can edit the customer or account details inline, without navigating to another tab. However, if you see the default **Customer(Contact or Account)** card, your administrator has disabled the enhanced **Customer Details** experience for the **Active Conversation** form.
 
   :::image type="content" source="media/enh-custsummary-conv.png" alt-text="View enhanced CustomerContact or Account" :::

   ### [Default Active Conversation&mdash;Customer(Contact or Account)](#tab/customer)
    
   View customer details on the default Customer(Contact or Account) layout.

   :::image type="content" source="media/customer-summary-customer-form.png" alt-text="View enhanced CustomerContact or Account" :::

--- 

## View Case details

Use the **Case** section to search for an existing case, and select the case to link it to the conversation. If the record doesn't exist, you can create a new case by using the **Add Case** button. After you create it, search for the record and then select it to link it to the conversation. More information: [Case management in multisession apps](enh-casemgmt-csw.md)

Depending on the settings enabled for you, you'll see one of the following layouts:


   ### [Enhanced Active Conversation &mdash; Case Details](#tab/enhancedcase)

  Displays the details, configured by the  of the case linked to the conversation. You can edit case details inline, without navigating to another tab. However, if you see the default **Issue Snapshot** card, your administrator has disabled the enhanced **Case Details** experience for the **Active Conversation** form.

   :::image type="content" source="media/enh-custsummary-casedetails.png" alt-text="enh Case details section of the active conversation page" :::  
   
   ### [Default Active Conversation &mdash; Case](#tab/case)
    
   You'll see the details of the case linked to the conversation on the default **Case** card.

   :::image type="content" source="media/cs-recent-cases.png" alt-text="default Case details section of the active conversation page"::: 

---

## View recent cases

This section displays recent cases related to the customer.

Depending on the settings enabled for you, you'll see one of the following layouts:

   ### [Enhanced Active Conversation&mdash;Recent Case](#tab/enhancedrecentcases)

   Displays the recent cases raised by the customer. However, if you see the default **Recent Cases** card, your administrator has disabled the enhanced **Recent Case** experience for the **Active Conversation** form.

   :::image type="content" source="media/enh-custsummary-recent.png" alt-text="enh Case details section of the active conversation page"::: 
    
   ### [Default Active Conversation&mdash;Recent case](#tab/recentcase)
    
   View the default Recent cases experience.

   :::image type="content" source="media/customer-summary-recent-cases.png" alt-text="enh Case details section of the active conversation page"::: 
  
 ---
## View Conversation summary

The **Conversation summary** section provides detailed information about the conversation between the agent and customer. The information shown in the **Conversation details** area includes the following:

- **Engagement channel:** The channel, such as live chat or custom channel, through which the conversation is taking place.
- **Waiting time:** The time the customer had to wait before the conversation was assigned to the agent.
- **Skills:** The skills that had been attached for routing the conversation. If your administrator has enabled the setting for agents to update skills, you can add or remove skills.
- **Queue:** The queue through which the conversation has been assigned to you.
- **Start time:** The time when you started the conversation.

  > [!div class='mx-imgBorder']
  > ![Conversation details.](media/conversation-details.png "Conversation-details")
 
In addition, the **Conversation summary** section includes several tabs:

- Pre-chat survey
- Self service
- Visitor details
- Additional details, if they've been configured and other context variables are available

These tabs are described in the following sections.

### View Pre-chat survey

The **Pre-chat survey** tab displays the customer's answers to the survey questions that were posed by your organization, which helps your interaction with the customer.

### View Self service

The **Self service** tab displays information about the activities that the customer performed before starting a conversation with an agent. This information helps you understand why the customer reached out and helps you provide a personalized service for enhanced customer satisfaction. The activity information, which is categorized into the following action types, appears in reverse chronological order.

| Action type | Description |
|-------------|-----------------------------------|
| Page visited | The page visited on the portal, with time stamp.|
| Phrase searched | The keyword or phrase that was searched for, with time stamp. |
| Knowledge article viewed | The knowledge article viewed, with time stamp. |
| Custom action performed | Any other custom action that's tracked by your organization, with time stamp. |

To configure the appearance of the **Self service** tab, see [Enable self-service settings for customer actions in a conversation summary](enable-self-service-settings.md).

### View Visitor details

The **Visitor details** tab provides information such as whether the customer is authenticated, the browser the customer used to contact support, the operating system used by the customer, the customer's location, and the language used during the interaction.

If the customer has signed in to the portal to initiate the chat with a support agent, the **Authenticated** field value is **Yes**; otherwise, the **Authenticated** field value is **No**.

![Authenticated chat shown as Yes on the Visitor details tab](media/conversation-summary-authenticated-chat.PNG "Authenticated chat shown as Yes on the Visitor details tab") ![Unauthenticated chat shown as No on the Visitor details tab](media/conversation-summary-unauthenticated-chat.PNG "Unauthenticated chat shown as No on the Visitor details tab")

To learn more, see [Create chat authentication settings](create-chat-auth-settings.md).

### View Additional details

If your administrator or developer has configured the **Additional details** tab and if any other context variables exist, they're displayed on the **Additional details** tab.

To learn more, see [setContextProvider](developer/reference/methods/setContextProvider.md).

## View Timeline

This section displays case-related and customer-related activities in the form of a timeline. You can create quick notes based on your discussion with the customer. Use the **Linked records** field to switch the timeline based on the case, contact, or account record linked to the conversation.

The **Linked records** field shows the record that's linked to the conversation. For example, if you link a contact and case to the conversation, the **Linked records** dropdown list shows **Contact** and **Case**, respectively.

> [!div class='mx-imgBorder']
> ![View only the linked records in the drop-down.](media/customer-summary-linked-records.PNG "View only the linked records in the drop-down list")

### See also


[Search for and share knowledge articles](oc-search-knowledge-articles.md)  
[View communication panel](oc-conversation-control.md)  
[Monitor real-time customer sentiment](oc-monitor-real-time-customer-sentiment-sessions.md)  
[View active conversation for an incoming conversation request](oc-view-customer-summary-incoming-conversation-request.md)  
[setContextProvider](developer/reference/methods/setContextProvider.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
