---
title: Enable agents to search for contacts, open records from outbound dialer #Required; page title displayed in search results. 
description: Enable agents to search for customer contacts or accounts by name, open records from Recents tab in the outbound dialer. 
author: gandhamm
ms.author: mgandham
ms.reviewer: 
ms.topic: 
ms.collection: how-to
ms.date: 03/19/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-seo-date:03/19/2024
  - ai-gen-desc
---

# Enable agents to search for contacts, open records from outbound dialer

In the outbound dialer, agents can search for customer contacts or accounts by name. Agents can also select and open a customer's record from the recently dialled number list. This allows agents to quickly find and open records for the customer they are speaking with.

## Prerequisites

- [Dataverse search](/power-platform/admin/configure-relevance-search-organization) must be enabled for your environment in Power Platform admin center. 
- Configure the minimum number of characters that trigger the search. More information: [Lookup behavior](/power-platform/admin/settings-behavior#settings).

## Configure search by name, open records

Perform the following steps:

1. In [Power Apps](https://make.powerapps.com/), select the required solution.
1.  Select and [add the following setting definitions](/power-apps/maker/data-platform/create-edit-configure-settings#adding-an-existing-setting-definition):

 - **Enhanced outbound dialer April 2024 improvements**: Enables agents to select and open customers records from the recently dialled number list in the outbound dialer.
 - **Enhanced outbound dialer contact search experience**: Agents can search for contacts and accounts by name.

1. Select the setting definitions, and set the **Setting environment value** option to **Yes**. More information: [Update a setting definition](/power-apps/maker/data-platform/create-edit-configure-settings#updating-a-setting-definition).
1. Save and publish the changes.

## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
