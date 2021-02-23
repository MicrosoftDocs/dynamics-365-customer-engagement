---
title: "Troubleshooting the Order entity (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how to troubleshoot issues with the Order entity in Dynamics 365 Sales."
ms.date: 03/24/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Troubleshooting the Order entity 

This article helps you troubleshoot and resolve issues related to the Order entity.

<a name="no_create_invoice_button"> </a>
## Issue: I don't see the Create invoice button on my order forms

Sales order processing integration connects Dynamics 365 Sales with an external, back-office order-processing application. When enabled, it allows a sales order created in Dynamics 365 Sales to be submitted and then synchronized with an external order processing application, where the lifecycle of the order continues. When the integration is enabled, users don't see the **Create Invoice** button on order records. If the integration is enabled unintentionally, you can disable it.  

**To disable sales order processing integration**

1. In the Sales Hub app, at the bottom of the site map, select **Change area** ![Change area](media/change-area-icon.png "Change area"), and then select **App Settings**.

2. Under **General Settings**, select **Overview**. 

    When sales order processing is already enabled, users with the System Administrator role or equivalent permissions will see the **Back office order processing integration** setting on the **Overview** page.

    > [!div class="mx-imgBorder"]  
    > ![Setting to disable back-office order-processing integration](media/order-processing-integration-setting.png "Setting to disable back-office order-processing integration")
 
3. Select **Manage**. 

4. To disable the integration, switch **Sales order processing** to **Off**, and then select **Save**.

    > [!div class="mx-imgBorder"]  
    > ![Sales order processing setting](media/sales-order-processing-setting.png "Sales order processing setting")

    > [!IMPORTANT]
    > - The **Back office order processing integration** setting is visible only when sales order processing is already enabled. 
    > - After the setting is disabled, users will no longer see this setting. 
    > - This setting can be used only to disable sales order processing in case it was turned on unintentionally through some solution installation. This setting can't be used to turn _on_ sales order processing. To learn about turning on sales order processing, see [Enable sales order processing integration](developer/enable-sales-order-processing-integration.md).


### See also

[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]