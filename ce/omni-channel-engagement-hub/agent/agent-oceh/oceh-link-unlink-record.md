---
title: "Link and unlink a record in Omni-channel Engagement Hub | MicrosoftDocs"
description: "Learn how to search for records in Omni-channel Engagement Hub and link the record to a conversation."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 48AB4878-B062-4126-93F8-26FF8A726121
ms.custom: 
---

# Link and unlink a record to the conversation

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

The topic explains how to link and unlink a record to the conversation.

## Link a record to the conversation when doing inline search

> [!div class=mx-imgBorder]
> ![Customer profile and Issue snapshot are blank when there are no records](../../media/agent-inline-search-no-record.PNG "Customer profile and Issue snapshot are blank when there are no records")

During inline search, the search results are displayed and you can select a record to link the conversation to the selected record. After you link the record, the **Customer summary** form loads with the details.

> [!div class=mx-imgBorder]
> ![Customer summary is loaded with details after linking](../../media/agent-inline-search-link.PNG "Customer summary is loaded with details after linking")

> [!Note]
> You can link only one contact or account in the **Customer profile** section and one case in the **Issue snapshot** section.


## Link a record to the conversation

After you search a record using Advanced Search, you can link the record to the conversation from the communication panel. To link a record to the conversation when using Advanced Search, select the record from the list, the record opens in the Application tab. Now, go to the communication panel and select the more options (**...**) and select Link to conversation.

> [!Note]
> You can link only one record to a conversation.

1. Select the record to open it using the Application tab.

2. Select the more options (**...**) in the communication panel, and select **Link to conversation**. The record is linked to the conversation.

> [!div class=mx-imgBorder]
> ![Select record to link](../../media/oceh-oc-select-record-link.png "Select record to link")

Now, the Customer summary page refreshes and reflects the details. Similarly, you can link other record types.

> [!Note]
> You can link only one contact or account in the **Customer profile** section and one case in the **Issue snapshot** section.

## Unlink a record from the conversation

You can unlink a record only when you are interacting with a customer using the communication panel. That is, after you accept an incoming conversation request and view the **Customer summary** page, you can unlink the record from the conversation. 

> [!div class=mx-imgBorder]
> ![Select the X button next to the textbox to unlink](../../media/oceh-oc-unlink-customer.PNG "Unlink a record")

To unlink a record, select the **X** button next to the customer name in the **Customer profile** form. After the record is removed, the **Customer profile** form is blank. 

> [!div class=mx-imgBorder]
> ![Blank customer profile form after unlinking the record](../../media/oceh-oc-unlinked-form.PNG "Blank customer profile form after unlinking the record")

> [!Note]
> You can link and unlink only one contact or account in the **Customer profile** section and one case in the **Issue snapshot** section.

## See also

- [View customer summary and know everything about customers](oceh-customer-360-overview-of-the-existing-challenges.md)
- [Search for and share knowledge articles](oceh-search-knowledge-articles.md)
- [Take notes specific to conversation](oceh-take-notes.md)
- [View conversations and sessions in Dynamics 365 for Customer Engagement apps](oceh-view-conversations-sessions-dynamics-365-apps.md)
- [View customer summary for an incoming conversation request](oceh-view-customer-360-incoming-conversation-request.md)
- [Create a record](oceh-create-record.md)
