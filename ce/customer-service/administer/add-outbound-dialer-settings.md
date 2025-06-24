---
title: Configure outbound dialer settings
description: Enable administrators to configure outbound dialer settings.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to
ms.collection: 
ms.date: 06/13/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-seo-date:03/19/2024
  - ai-gen-desc
---

# Configure outbound dialer settings


[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

Customer service representatives (service representatives or representatives) can place a call to a customer using the outbound dialer.

This article describes how you can configure various settings for the outbound dialer in the Copilot Service admin center. 

## Enable service representatives to search for contacts and open records from outbound dialer

In the outbound dialer, service representatives can search for customers by name. They can also select and open a customer's record from the recently dialed number list. When the representative initiates a call, a widget appears on the dialer pane and shows the status of the call.

### Prerequisites

- Enable [Dataverse search](/power-platform/admin/configure-relevance-search-organization) for your environment in Power Platform admin center. 
- Configure the minimum number of characters that should trigger the search. Learn more in [Lookup behavior](/power-platform/admin/settings-behavior#settings).

### Configure search by name, open records

Perform the following steps:

1. In [Power Apps](https://make.powerapps.com/), select the required solution.
1.  Select and [edit the following setting definitions](/power-apps/maker/data-platform/create-edit-configure-settings#updating-a-setting-definition):
   - **Enhanced outbound dialer April 2024 improvements**: Enables representatives to select and open customers records from the recently dialed number list in the outbound dialer.
   - **Enhanced outbound dialer contact search experience**: Enables representatives to search for contacts and accounts by name.
3. Select the setting definitions, and set the **Setting environment value** option to **Yes**. Learn more in [Update a setting definition](/power-apps/maker/data-platform/create-edit-configure-settings#updating-a-setting-definition).
4. Save and publish the changes.

## Enable the enhanced dialer experience

When the service representative selects **Call** in the outbound dialer, a widget appears on the dialer pane and shows the status of the call. Representatives can also initiate multiple calls from the dialer. Learn more in [Make a call using the outbound dialer](../use/voice-channel-call-customer.md#make-a-call-using-the-outbound-dialer)

Perform the following steps to enable the widget:

1. In Copilot Service admin center, select **Miscellaneous** in **Operations**.
1. Select **Manage** for **New and upcoming features**. The **New and upcoming features** page appears.
1. Select  **Enable voice controls in dialer**.

