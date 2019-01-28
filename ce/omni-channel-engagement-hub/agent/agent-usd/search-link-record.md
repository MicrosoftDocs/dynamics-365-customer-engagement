---
title: "Search for and link a record in Omni-channel Engagement Hub | MicrosoftDocs"
description: "Learn on how to search a record in Omni-channel Engagement Hub and link the record to a conversation."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 1/29/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 9DE991EA-5B54-4D31-89EE-9CE05E73AF3C
ms.custom: 
---

# Search for and link a record in Omni-channel Engagement Hub

[!INCLUDE[cc-applies-to-update-9-0-0](../../../includes/cc_applies_to_update_9_0_0.md)]

The topic explains how to search for a record in Omni-channel Engagement Hub and link it to a conversation.

## Search for a record
You can search for the records in two ways.

### Search for a record using inline search option

You accept an incoming conversation request and there is no customer record identified in the Omni-channel Engagement Hub. In this case, use the inline search option in the **Customer profile** form and **Issue snapshot** form to search for a contact or account and case respectively.

The inline search is based on the Lookup view. You can search the fields (attributes) that is based on the lookup view.

| Entity | Searchable fields (attributes) | Status |
|--------|--------------------------------|--------|
| Accounts | Email |  |
|  | Phone |  |
|  | Name |  |
|  | Address |  |
|  | City |  |
|  | Pin code |  |
| Incident | Case number |  |
|  | Title |  |

Only active lookup views are displayed for the search results. Also, you can customize the lookup views to change the searchable fields as per your business requirements.

> [!div class=mx-imgBorder]
> ![Customer profile and Issue snapshot are blank when there are no records](../../media/agent-inline-search-no-record.PNG "Customer profile and Issue snapshot are blank when there are no records")

After the search results, selecting a record links the conversation to the selected record and loads the **Customer summary** form with the details.

> [!div class=mx-imgBorder]
> ![Cusomter summary is loaded with details after linking](../../media/agent-inline-search-link.PNG "Cusomter summary is loaded with details after linking")


### Search for a record using the search option

You can search for omni-channel records by using the search functionality. When you select the **Search** button, the **Search** page appears on the application management toolbar. Specify the details, and then select **Search**. The results appear in the form of a list.

![omni-channel search lists](../../media/agent-search-lists.png "omni-channel search lists")

1. Select the search icon ![omni-channel search icon](../../media/agent-search-icon.png "omni-channel search icon"), and select **Omni-channel Search**.

2. Specify any of the following values as per your search requirements:

 - Account Name
 - Address 1: State/Province
 - Main Phone
 - Email
 - Address 1: ZIP/Post Code
 - First Name
 - Last Name
 - Address 1: State/Province
 - Business Phone
 - Email
 - Address 1: ZIP/Post Code
 - Case Number

3. Select **Search**. The list of search results appear.

## Link a record

You can link a record in the list of search results to a conversation. You can link only one record to a conversation.

1. Select the ![omni-channel select icon](../../media/select-icon.png "omni-channel select icon") icon to view the selection list.

 > [!div class=mx-imgBorder]
 > ![omni-channel select records](../../media/agent-select-records-link.png "omni-channel select records")

2. Select the check box next to the record you want to link.

 > [!div class=mx-imgBorder]
 > ![omni-channel select checbox](../../media/agent-select-record-checkbox.png "omni-channel select checkbox")

3. Select the link button at the top.

 > [!div class=mx-imgBorder]
 > ![omni-channel send link](../../media/agent-select-link-button.png "omni-channel send link")

After you link the record to the conversation, the Customer summary form is refreshed and reflects the details. Similarly, you can link other record types.

## See also

- [Sign in to Unified Service Desk – Omni-channel Engagement Hub](signin-unified-service-desk-omni-channel-engagement-hub.md)
- [Introduction to the agent interface in Omni-channel Engagement Hub](introduction-agent-interface-omni-channel-engagement-hub.md)
- [View agent dashboard and agent work items](introduction-agent-dashboard.md)
- [View notifications and screen pops](notifications-screen-pop.md)
- [View customer summary and know everything about customers](customer360-overview-existing-challenges.md)
- [View conversation control](left-control-panel.md)
- [View call scripts, take notes, and search knowledge articles](right-control-panel.md)
- [View conversation and session forms in Dynamics 365 for Customer Engagement apps](view-omni-channel-conversation-omni-channel-session-dynamics365-apps.md)
- [View customer summary for an incoming conversation request](view-customer360-incoming-conversation-request.md)
- [Create a record](create-record.md)
