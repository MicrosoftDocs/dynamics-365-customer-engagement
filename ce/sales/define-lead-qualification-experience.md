---
title: "Define lead qualification experience in Dynamics 365 Sales"
description: "Give your salespeople the flexibility to choose which records to create—account, contact, or opportunity—when a lead is qualified."
ms.date: 05/10/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-lead
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---
# Define the lead qualification experience  

Give your salespeople the flexibility to choose which records to create—account, contact, or opportunity—when a lead is qualified. 

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Define the experience  

1.  In your app, select the **Settings** icon, and then select **Advanced Settings**.

    > [!div class="mx-imgBorder"]
    > ![Advanced Settings option on the Settings menu.](media/advanced-settings-option.png "Advanced Settings option on the Settings menu")

    The **Business Management** page opens.

2.    Select **Settings**, then **Administration**, and then **System Settings**.

3.    Select the **Sales** tab.

4.    Under **Qualify lead experience**, set **Create Account, Contact, and Opportunity records by default upon qualifying a lead** to **No**.

This prompts salespeople to select which record types to be created once a lead is qualified. 

If you set **Create Account, Contact, and Opportunity records by default upon qualifying a lead** to **Yes**, Account, Contact, and Opportunity records are created by default. 

This behavior is applicable on all the leads that are qualified after this setting is updated.

With the April 2020 release, this setting is also available in the **App Settings** area of the Sales Hub app itself. 

To go to this setting:

1. At the bottom of the site map, select **Change area** ![Icon to change the work area.](media/change-area-icon.png "Icon to change the work area") and then select **App Settings**. 

2. In the site map, select **Overview**, and on the **Overview** page, select **Manage** for **Auto-create records for newly qualified leads**.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also
[Qualify or convert leads](qualify-lead-convert-opportunity-sales.md)  
[Create or edit leads](create-edit-lead-sales.md)  
[Troubleshoot issues with lead qualification](/troubleshoot/dynamics-365/sales/troubleshoot-lead-qualification-issues-for-system-admin)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
