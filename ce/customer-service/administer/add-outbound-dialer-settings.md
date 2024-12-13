---
title: Enable service representatives to search for contacts and open records from outbound dialer
description: Enable agents to search for customer contacts or accounts by name, open records from Recents tab in the outbound dialer. 
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to
ms.collection: 
ms.date: 07/01/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-seo-date:03/19/2024
  - ai-gen-desc
---

# Enable service representatives to search for contacts and open records from outbound dialer 

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

In the outbound dialer, customer service representatives (service representatives or representatives) can search for customers by name. Representativess can also select and open a customer's record from the recently dialed number list.

## Prerequisites

-  Enable [Dataverse search](/power-platform/admin/configure-relevance-search-organization) for your environment in Power Platform admin center. 
- Configure the minimum number of characters that should trigger the search. More information: [Lookup behavior](/power-platform/admin/settings-behavior#settings).

## Configure search by name, open records

Perform the following steps:

1. In [Power Apps](https://make.powerapps.com/), select the required solution.
1.  Select and [edit the following setting definitions](/power-apps/maker/data-platform/create-edit-configure-settings#updating-a-setting-definition):
   - **Enhanced outbound dialer April 2024 improvements**: Enables representatives to select and open customers records from the recently dialed number list in the outbound dialer.
   - **Enhanced outbound dialer contact search experience**: Enables representatives to search for contacts and accounts by name.
3. Select the setting definitions, and set the **Setting environment value** option to **Yes**. More information: [Update a setting definition](/power-apps/maker/data-platform/create-edit-configure-settings#updating-a-setting-definition).
4. Save and publish the changes.


