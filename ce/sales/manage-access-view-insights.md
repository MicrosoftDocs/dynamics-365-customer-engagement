---
title: Manage access to view insights
description: Restrict the access to seller insights to a specific security group within your organization.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 06/09/2023
ms.custom: bap-template 
---

# Manage access permissions to view insights (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

By default, all security roles in your organization have permission to view seller insights. You can restrict the access to seller insights to a specific security group within your organization.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Grant permissions to use seller insights

1.	Sign into your sales app. In the lower-left corner of the page, go to **Change area** > **Sales Insights settings**.
1.	Under **Productivity**, select **Insights (preview)**.
1.	On the **Insights (preview)** page, under the **Configure access** section, select **Configure**.
1.	On the **Configuration access** page, choose one of the following options to grant permissions. 

    | Security roles | Description |
    |----------------|-------------|
    | All security roles | Select this option to allow all the security roles in your organization to view seller insights. |
    | Specific security roles | Select this option to allow only users from specific security roles to view the insights. |

5.	Select **Publish**.

### See also

[Enable seller insights](enable-seller-insights.md)  
[Get intelligent insights to improve sales](seller-insights-intro.md)
