---
title: "Automatically identify customers using pre-chat responses and setContext API method | MicrosoftDocs"
description: "How you can automatically identify customers using pre-chat responses in Omnichannel for Customer Service"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 02/12/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Automatically identify customers

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Identify and assist customers better by showing their details on the **Customer summary** page. To automatically identify and load customer and case details for an incoming conversation, you need to set up pre-chat questions in the relevant chat widgets. Customer responses are used to search for details in the records and display the results. For an Account or Contact, the search is performed on the **Name**, **Email**, or **Phone Number** field. For Cases, the search is performed on the **Case Number** field.

For every incoming conversation request agent receives, a notification appears that includes contextual information for the request and customer details, if available. After the agent accepts the incoming notification, the **Customer summary** page opens, and shows the details of the identified customer and case. 

For more information, see [View Customer summary for an incoming engagement request](oc-view-customer-summary-incoming-conversation-request.md).

> [!NOTE]
> To know how to create pre-chat questions and use them in a pre-chat survey, see [Configure a pre-chat survey](configure-pre-chat-survey.md). 

Use the below question names to create pre-chat questions for an unauthenticated chat.

| Entity   |     Mapping    | Answer type |
|---------|----------------|-------------|
| Account |	Question context key: **Name** <br> Attribute Logical Name: **name** <br><br> Question context key: **Email** <br> Attribute logical name: **emailaddress1** <br><br> Question context key: Phone <br> Attribute logical name: **telephone1** | Single line |
| Contact | Question context key: **Name** <br> Attribute logical name: **fullname** <br><br> Question context key: Email <br> Attribute logical name: **emailaddress1** <br><br> Question context key: Phone <br> Attribute logical name: **telephone1** |Single line |
| Incident | Question context key: **CaseNumber** <br> Attribute logical name: **ticketnumber** |Single line |
||||

For authenticated chat, the logged in user details will be used to search and load contact information in the **Customer summary** page. You can add pre-chat question for **Case Number** to allow identification of the relevant case for the current conversation. The pre-chat questions pertaining to contact or account, such as the name, email, and phone number will not be considered for identification.

|Entity   |     Mapping    | Answer type |
|---------|----------------|-------------|
| Incident | Question context key: **CaseNumber** <br> Attribute logical name: **ticketnumber** |Single line |
|||

## Use the setContextProvider API method

You can automatically identify records using custom context set using setContext API apart from pre-chat answers. To programmatically set these values, see [Manage custom context](send-context-starting-chat.md).

### See also

[Understand and create work streams](work-streams-introduction.md)  
[setContextProvider](developer/reference/methods/setcontextprovider.md)  
