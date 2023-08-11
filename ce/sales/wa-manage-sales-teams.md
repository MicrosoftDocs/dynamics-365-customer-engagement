---
title: Configure security roles to assign records
description: Configure security roles to sellers to grant permissions to automatically assign the records.  
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 08/11/2023
ms.custom: bap-template 
---

# Configure security roles to assign records 

Configure security roles for sellers to allow automatic record assignments by granting permissions.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator, Sequence Manager, or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Select security roles

Select security roles to grant permissions to automatically assign records. 

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.
1. Under **Sales accelerator**, select **Work assignment**.
1. On the **Work assignment** page, select **Settings**.
1. On the **Work assignment settings** page, select **Define team access**.

    :::image type="content" source="media/wa-sales-team-select-define-team-access.png" alt-text="Screenshot of work assignment settings page.":::

1. On the **Team settings** dialog box, choose one of the following options to grant permissions:

    | Security roles | Description |
    |----------------|-------------|
    | All security roles | Select this option to give access to view the Sales Hub app to all the security roles in your organization. |
    | Specific security roles | Select this option to specify security roles to give access to view the Sales Hub app to just a few users. Use the lookup box to add the security roles. |    

1. Select **Save**.

The chosen security roles are given access to assign records, and you can review the permissions on the **Eligible Security Roles** card in the **Work Assignment Settings** page.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Manage seller attributes](manage-seller-attributes.md)  
[Manage seller availability](manage-seller-availability.md)
