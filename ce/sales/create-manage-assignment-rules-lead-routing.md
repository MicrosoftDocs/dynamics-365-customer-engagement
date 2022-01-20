---
title: "Manage assignment rules for lead routing (Sales Insights) | MicrosoftDocs"
description: "Create, activate, edit, delete assignment rules, manage sales teams, and seller attributes for lead routing."
ms.date: 05/14/2021
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Preview: Manage assignment rules for lead routing

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Create, activate, edit, delete assignment rules, manage sales teams, and seller attributes for lead routing.

## Requirements
| &nbsp; | &nbsp; |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | System Administrator or Sequence Manager <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## What are assignment rules

Assignment rules enable new leads to be automatically assigned to sellers or sales teams. This helps reduce the amount of time and effort required to manually assign leads, prevent the loss of unassigned leads, and balance lead assignments among sellers.

As an administrator or sequence manager, you can create rules that match lead attributes (such as location and language) with seller or team attributes (such as location and language). When a lead is created and satisfies the conditions of a specific rule, the lead is automatically assigned to a seller.

You can use the assignment rules designer to:

- [Create and activate an assignment rule](create-and-activate-assignment-rule.md).
- [Edit an assignment rule](edit-assignment-rule.md).
- [Delete or deactivate an assignment rule](delete-deactivate-assignment-rule.md). 
- [Manage sales teams](manage-sales-teams.md).
- [Manage seller attributes](manage-seller-attributes.md).

## Review the prerequisites

Before you start, be sure you've met the following prerequisites:   
-	The sales accelerator has been configured in your organization. More information: [Configure the sales accelerator](enable-configure-sales-accelerator.md)   
-	You've enabled the **Assignment rules for lead routing** feature preview:    
    1.	Sign in to your Dynamics 365 Sales Hub app.  
    2.	Go to the **Change area** ![change area](media/change-area-icon.png) in the lower-left corner of the page, and select **Sales Insights settings**.   
    3.	Under **Sales accelerator**, select **Assignment rules (preview)**.   
    4.	Read and accept the preview terms and conditions.   
    5.	Select **Get started**.  

<table>
<tr><td>

> [!div class="nextstepaction"] 
> [Next step: Create and activate an assignment rule](create-and-activate-assignment-rule.md)
</td></tr>
</table>   

### See also

[Configure the sales accelerator](enable-configure-sales-accelerator.md)  
[Prioritize your sales pipeline by using the work list](prioritize-sales-pipeline-through-work-list.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
