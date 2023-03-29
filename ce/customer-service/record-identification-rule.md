---
title: "Identify customers automatically | MicrosoftDocs"
description: "Learn how to automatically identify customers by using pre-conversation responses in Omnichannel for Customer Service."
ms.date: 02/15/2023
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Identify customers automatically

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

You can assist customers better if you can automatically identify them and view their account and case details on the **Active Conversation**(formerly **Customer summary**) page. One of the ways is by setting up pre-conversation questions in the relevant chat widgets. Customer responses can be used to search for details in the records and display the results. For an account or contact, the search is performed on the **Name**, **Email**, or **Phone Number** fields. For an account, the **Phone Number** pertains to the **Phone** field of the **Account Summary** page; for a contact, the **Phone Number** pertains to the **Mobile Number** field of the **Contact Summary** page. For cases, the search is performed on the **Case Number** field.

> [!NOTE]
> The record search identifies records that have an active status code for contacts or accounts; if you use custom status codes, then record identification won't work.

For every incoming conversation request that an agent receives, a notification appears that includes contextual information for the request and customer details, if available. After the agent accepts the incoming notification, the **Active Conversation** page opens and shows the details of the identified customer and case. If the identified contact or account has one active case linked to it, then case will be automatically linked to the conversation. If the customer has reached out for a different case, the agent can manually change the linked case.

You can identify incoming voice calls out of the box if the incoming phone number matches with the phone number specified for a contact in the mobile phone field or account phone field. If you want to use other phone number fields like home phone for customer identification, then contact Microsoft Support.

If more than one account, contact, or case is identified, the record won't be linked to the conversation. More information: [View Active Conversation for an incoming engagement request](oc-view-customer-summary-incoming-conversation-request.md)

## Set up pre-conversation questions

Use the following question names to create pre-conversation questions. To know how to create pre-conversation questions and use them in a pre-conversation survey, see [Configure a pre-conversation survey](configure-pre-chat-survey.md).

| Entity   |     Mapping    | Answer type |
|---------|----------------|-------------|
| Account |	Question context key: Name <br> Attribute logical name: name <br><br> Question context key: Email <br> Attribute logical name: emailaddress1 <br><br> Question context key: Phone <br> Attribute logical name: telephone1 (**Phone** field on the **Account Summary** page) | Single line |
| Contact | Question context key: Name <br> Attribute logical name: fullname <br><br> Question context key: Email <br> Attribute logical name: emailaddress1 <br><br> Question context key: Phone <br> Attribute logical name: telephone1 (**Mobile Phone** field on the **Contact Summary** page) |Single line |
| Incident | Question context key: CaseNumber <br> Attribute logical name: ticketnumber |Single line |
||||

> [!Note]
> If you'd like other fields to be recognized for phone number lookup, contact [Microsoft Support](https://dynamics.microsoft.com/support/).

## Use the setContextProvider API method

You can automatically identify records using custom context set using the [setContextProvider API](developer/reference/methods/setcontextprovider.md) apart from pre-conversation answers. To programmatically set these values, see [Manage custom context](send-context-starting-chat.md).

## Link customer and case to conversations when bot escalates or ends conversations

When a bot ends a customer conversation, the bot can link the case number to the conversation. The bot can create a new case number or obtain an existing one from the customer based on the customer name, email address, or telephone number.

If the bot needs to escalate the conversation to a human agent, then bot can link the customer and case number to the conversation so that when the human agent accepts the escalation request, all relevant information is available to the agent in the active conversation section. The escalation summary gives the human agent the background information about the escalation and enables quicker resolution of the customer issue.

To link the customer or case, set the values for the associated attributes, such as customer name and phone number. These attributes will be searched in the corresponding entities such as customer and case, and the result will be linked to the conversation if a single matching record is found. The bot will need to set context parameters for the following that are also set when the customer is automatically identified when the conversation is transferred.

| Entity to be linked | Variable name to be set by bot | Attribute for Dynamics 365 entity to match with corresponding variable name in bot |
|------------|----------------|----------------------|
|Account|<ul><li> Name</li><li> Email </li><li> Phone</li></ul> |<ul><li> name</li><li>emailaddress1</li><li>telephone1</li></ul> |
|Contact|<ul><li> Name</li><li> Email </li><li> Phone</li></ul>|<ul><li> name</li><li>emailaddress1</li><li>telephone1</li></ul>|
|Case|CaseNumber|ticketnumber|
||||

For information about creating context variables for Azure and Power Virtual Agents bots, see [Configure context variables for the bot](context-variables-for-bot.md#configure-context-variables-for-power-virtual-agents-bot).


### See also

[Create and manage workstreams](create-workstreams.md)  
[Configure a Power Virtual Agents bot](configure-bot-virtual-agent.md)  
[Configure Azure bot](configure-bot-azure.md)  
[Context variables for bots](context-variables-for-bot.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
