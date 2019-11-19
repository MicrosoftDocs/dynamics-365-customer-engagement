---
title: "Link and unlink a record in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn on how to Search for records in Omnichannel for Customer Service and link the record to a conversation."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 07/01/2019
ms.service: 
  - dynamics-365-customerservice
ms.topic: article
---

# Link and unlink a record to the conversation

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

The topic explains how to link and unlink a record to the conversation.

## Link a record to the conversation when doing inline search

<!--
> [!div class=mx-imgBorder]
> ![Customer profile and Issue snapshot are blank when there are no records](../../media/agent-inline-search-no-record.PNG "Customer profile and Issue snapshot are blank when there are no records") -->

During inline search, the search results are displayed, and you can select a record to link the conversation to the selected record. After you link the record, the **Customer summary** form loads with the details.

> [!div class=mx-imgBorder]
> ![Cusomter summary is loaded with details after linking](../../media/agent-inline-search-link.PNG "Cusomter summary is loaded with details after linking")

> [!Note]
> You can link only one contact or account in the **Customer profile** section and one case in the **Issue snapshot** section.


<!-- ## Link a record by doing advanced search

You can link a record in the list of search results to a conversation. You can link only one record to a conversation.

1. Select the ![Omnichannel select icon](../../media/select-icon.png "Omnichannel select icon") icon to view the selection list.

 > [!div class=mx-imgBorder]
 > ![Omnichannel select records](../../media/agent-select-records-link.png "Omnichannel select records")

2. Select the check box next to the record you want to link.

 > [!div class=mx-imgBorder]
 > ![Omnichannel select checbox](../../media/agent-select-record-checkbox.png "Omnichannel select checkbox")

3. Select the link button at the top.

 > [!div class=mx-imgBorder]
 > ![Omnichannel send link](../../media/agent-select-link-button.png "Omnichannel send link")

After you link the record to the conversation, the Customer summary form is refreshed and reflects the details. Similarly, you can link other record types.

> [!Note]
> You can link only one contact or account in the **Customer profile** section and one case in the **Issue snapshot** section. -->

## Unlink a record from the conversation

You can unlink a record only when you are interacting with customer using the communication panel. That is, after you accept an incoming conversation request and view the **Customer summary** page, you can unlink the record from the conversation. 

![Select X button next the textbox to unlink](../../media/oceh-oc-unlink-customer.PNG "Unlink a record")

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
