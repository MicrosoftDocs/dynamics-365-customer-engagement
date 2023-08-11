---
title: Delete or deactivate an assignment rule
description: Permanently delete an assignment rule that is no longer required in your organization, or deactivate to retain the rule in the application in inactive mode.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 08/11/2023
ms.custom: bap-template 
---

# Delete or deactivate an assignment rule 

You can deactivate or delete an assignment rule that's no longer required in your organization. Deactivation keeps the rule, but it won't be used to assign leads to any sellers in the future. Deleting the rule removes it from the application, but leads that were already assigned to sellers through the rule won't be affected. 

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator, Sequence Manager, or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## To delete or deactivate an assignment rule   

>[!NOTE]
>In this procedure, we are using lead as an example to delete or deactivate an assignment rule. Similarly, you can use this procedure to delete or deactivate opportunity or insight assignment rule. 

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.
1. Under **Sales accelerator**, select **Work assignment**. 
1. Choose the record type as **Leads**.
1. Open the segment and then under the **Assignment rules** tab, select the rule and then one of the following:  
    - **Deactivate**: Turn off the toggle in the **Active** column and on the confirmation message, select **Deactivate**.  
    - **Delete**: Select **Delete** and on the confirmation message, select **Delete permanently**.  

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Create and activate assignment rules](wa-create-and-activate-assignment-rule.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
