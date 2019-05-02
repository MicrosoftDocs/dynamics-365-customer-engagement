---
title: "View customer summary for an incoming conversation request | MicrosoftDocs"
description: "Learn about the Customer Summary and its behavior when the agent gets and incoming conversation request."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 05/03/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 2E22E0FD-F220-404E-B1F8-4F1BF3C487B0
ms.custom: 
---

# View customer summary for an incoming conversation request

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

## Scenario 1: An incoming engagement request for an existing customer record with a case already in the Omni-channel Engagement Hub 

When you get an incoming conversation request, you see a notification (screen pop) with contextual information for an incoming request. When you accept or select the incoming notification, the application displays the Customer summary page with details about the customer. 

## Scenario 2: An incoming conversation request where you find several customer records in the Omni-channel Engagement Hub 

When you get an incoming conversation request, you see a notification (screen pop) with contextual information about the incoming request. The Omni-channel Engagement Hub displays a message: **One or more records found. Select a record or create new**.

### Select a record

If you select a record, the Customer summary page displays details by pre-populating the fields.

If you select a case, contact, or account, the Customer summary page refreshes and updates the **Case** section with the current case details.

If you choose a case that is different than the one you are assigned, you will see a warning message that needs your action to link the conversation to the record. More information: [Search for records](#search-for-records)  

### Create a record

You can create a record using the quick create (+) option. After you create the record, it is automatically linked to the conversation. More information: [Create a record](#create-a-record)

## Scenario 3: An incoming conversation request where you find no customer records in the Omni-channel Engagement Hub

When you get an incoming conversation request, you will see a notification (screen pop) with contextual information for an incoming request. However, if no records are linked to a conversation in the Omni-channel Engagement Hub, you will see this message: **No records found. Search for an existing customer record or create a new one to link to this conversation**.

### Create a record

When no records are linked to a conversation in the Omni-channel Engagement Hub, you can create one using the quick create (**+**) option. After you create the record, it is automatically linked to the conversation. More information: [Create a record](#create-a-record)

### Search for records

When you choose to Search for records, the application launches the **Omni-channel search** tab. Specify the details according to the field and then search. Once the search is complete, you can see the results in the form of a list. You can link the record to the conversation. Also, if you select a record, you can see it in the application management toolbar.

> [!div class="nextstepaction"]
> [Next topic: Create a record](oceh-create-record.md)

## See also

- [View customer summary](oceh-customer-360-overview-of-the-existing-challenges.md)
- [View conversation and session activity types in the Customer Engagement apps](oceh-view-conversations-sessions-dynamics-365-apps.md)]
- [Search, link, and unlink a record](oceh-search-link-unlink-record.md)
