---
title: Change priority of an assignment rule
description: Change the priority of an assignment rule to assign records to sellers.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 08/11/2023
ms.custom: bap-template 
---

# Change priority of an assignment rule 

The priority of the rule is determined by its position in the list. When a record matches the conditions of multiple rules, the rule with the highest priority is applied. You can view the priority of the rule in the **Priority** column.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator, Sequence Manager, or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## To change priority of an assignment rule

>[!NOTE]
>In this procedure, we are using lead as an example to edit an assignment rule. Similarly, you can use this procedure to edit opportunity or insight assignment rule. 

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.
1. Under **Sales accelerator**, select **work assignment**. 
1. Choose the record type as **Leads**, **Opportunities**, or **Insights**.
1. Open the segment and then under the **Assignment rules** tab, select the rule and then select **Change rule priority**.  
    The **Change rule priority** dialog opens.
1. Change the priority as required and then select **Save**.

The priority is updated for the rule and records are assigned to sellers based on the new priority.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Create and activate assignment rules](wa-create-and-activate-assignment-rule.md)
