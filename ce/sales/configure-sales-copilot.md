---
title: Configure copilot capabilities
description: 
ms.date: 06/20/2023
ms.custom: bap-template
ms.topic: how-to
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
---

# Configure copilot capabilities

You can configure copilot capabilities to specify the fields that copilot should use to generate summaries and catch up information. 

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Configure record summary and catch up fields

By default, Copilot uses the first seven fields in the default lead and opportunity view to generate summaries and first 10 fields to generate catch up. You can configure a view with fields that are most relevant to your business and have Copilot use it for generating summaries and catch ups. You can configure different lead and opportunity views for summary and catch up.

1. In the Sales Hub app, [create a system view](/power-apps/maker/model-driven-apps/create-or-edit-model-driven-app-view) with the fields you want to use for generating summaries and catch up information.


1. Go to the Change area and select **App Settings**.
1. Under **General Settings**, select **Copilot (preview)**.
1. Select **Record summary**, and then select the view you'd like to use for generating summaries for leads and opportunities.
    You'll see the first seven fields listed under **Fields available in the view**. These fields will be used to generate summaries.  
1. Select **Record catch up**, and then select **Turn audit on**.
    As catch up summaries are generated from the audit history, you must turn on auditing to use this feature. Ensure to enable user access to the audit history and audit summary. For more information, see [Grant copilot access to users](enable-setup-copilot.md#grant-copilot-access-to-users).
  
1. Select the view you'd like to use for generating catch up information for leads and opportunities.
    You'll see the first 10 fields listed under **Fields available in the view**. Changes to these fields are only reported in the catch up summary. If you select the **Default system view**, then only changes to the following fields are reported:
    - Close date
    - Business process flow stage
    - Budget or revenue
    - Decision maker, primary contact, or contact information
    - Product information
    
1. Save the changes.

> [!IMPORTANT]
> If you update or remove fields in any of the selected views, open the **Copilot (preview)** settings page, select a different view, save the changes, and then select the updated view. Ensure that you see the updated fields listed under **Fields available in the view**. 