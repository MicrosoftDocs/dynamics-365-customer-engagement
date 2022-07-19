---
title: "Identify customers automatically | MicrosoftDocs"
description: "Learn how to automatically identify customers by using pre-conversation responses in Omnichannel for Customer Service."
ms.date: 07/19/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Identify customers automatically

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

You can assist customers better if you can automatically identify them and view their account and case details on the **Customer summary** page. One of the ways is by setting up pre-conversation questions in the relevant chat widgets. Customer responses can be used to search for details in the records and display the results. For an account or contact, the search is performed on the **Name**, **Email**, or **Phone Number** field. For an account, the **Phone Number** pertains to the **Phone** field of the Account Summary page; for a contact, the **Phone Number** pertains to the **Mobile Number** field of the Contact Summary page. For cases, the search is performed on the **Case Number** field.

For every incoming conversation request that an agent receives, a notification appears that includes contextual information for the request and customer details, if available. After the agent accepts the incoming notification, the **Customer summary** page opens and shows the details of the identified customer and case. If the identified contact or account has one active case linked to it, then case will be automatically linked to the conversation. If the customer has reached out for a different case, the agent can manually change the linked case.

If more than one account, contact, or case is identified, the record won't be linked to the conversation. More information: [View Customer summary for an incoming engagement request](oc-view-customer-summary-incoming-conversation-request.md)

## Set up pre-conversation questions

Use the following question names to create pre-conversation questions. To know how to create pre-conversation questions and use them in a pre-conversation survey, see [Configure a pre-conversation survey](configure-pre-chat-survey.md).

| Entity   |     Mapping    | Answer type |
|---------|----------------|-------------|
| Account |	Question context key: **Name** <br> Attribute Logical Name: **name** <br><br> Question context key: **Email** <br> Attribute logical name: **emailaddress1** <br><br> Question context key: Phone <br> Attribute logical name: **telephone1** (Phone field on the Account Summary page) | Single line |
| Contact | Question context key: **Name** <br> Attribute logical name: **fullname** <br><br> Question context key: Email <br> Attribute logical name: **emailaddress1** <br><br> Question context key: Phone <br> Attribute logical name: **telephone1** (Mobile Phone field on the Contact Summary page) |Single line |
| Incident | Question context key: **CaseNumber** <br> Attribute logical name: **ticketnumber** |Single line |
||||

> [!Note]
> If you'd like other fields to be recognized for phone number lookup, contact [Microsoft Support](https://dynamics.microsoft.com/support/).

## Use the setContextProvider API method

You can automatically identify records using custom context set using the [setContextProvider API](developer/reference/methods/setcontextprovider.md) apart from pre-conversation answers. To programmatically set these values, see [Manage custom context](send-context-starting-chat.md).

### See also

[Create and manage workstreams](create-workstreams.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
