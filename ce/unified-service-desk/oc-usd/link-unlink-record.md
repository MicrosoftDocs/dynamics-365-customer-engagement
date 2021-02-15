---
title: "Link and unlink a record in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn on how to Search for records in Omnichannel for Customer Service and link the record to a conversation."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
monikerRange: '>= dynamics-usd-4.1'
---

# Link and unlink a record to the conversation

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The topic explains how to link and unlink a record to the conversation.

## Link a record to the conversation when doing inline search

During inline search, the search results are displayed, and you can select a record to link the conversation to the selected record. After you link the record, the **Customer summary** form loads with the details.

> [!div class=mx-imgBorder]
> ![Cusomter summary is loaded with details after linking](../../customer-service/media/agent-inline-search-link.PNG "Cusomter summary is loaded with details after linking")

> [!Note]
> You can link only one contact or account in the **Customer profile** section and one case in the **Issue snapshot** section.


## Unlink a record from the conversation

You can unlink a record only when you are interacting with customer using the communication panel. That is, after you accept an incoming conversation request and view the **Customer summary** page, you can unlink the record from the conversation. 

![Select X button next the textbox to unlink](../../customer-service/media/oceh-oc-unlink-customer.PNG "Unlink a record")

To unlink a record, select the **X** button next to the customer name in the **Customer profile** form. After the record is removed, the **Customer profile** form is blank.

> [!Note]
> You can link and unlink only one contact or account in the **Customer profile** section and one case in the **Issue snapshot** section.

> [!div class="nextstepaction"]
> [Understand conversation states](conversation-state.md)


## See also

- [View call scripts, take notes, and search knowledge articles](right-control-panel.md)
- [View customer summary for an incoming conversation request](view-customer-summary-incoming-conversation-request.md)
- [Create a record](create-record.md)
- [Search for records](search-record.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]