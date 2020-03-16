---
title: "Disable back office order processing integration (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how to disable the back office order processing integration to stop the order from synching with external systems."
ms.date: 02/03/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Sales order processing integration is enabled for me. How do I disable it?

Sales order processing integration connects Dynamics 365 Sales with an external back-office order processing application. It allows a sales order created in Dynamics 365 Sales to be submitted, after which the order can be synchronized with an external order processing application, where the lifecycle of the order continues. When the integration is enabled, users don't see the **Create Invoice** button on the Order records. If the integration is enabled unintentionally, you can disable it.  

To disable:

1. In the Sales Hub app, at the bottom of the site map, select **Change area** ![Change area](media/change-area-icon.png "Change area") and then select **App Settings**.

2. Under **General Settings**, select **Overview**. Select 

    When Sales order processing is already enabled, users with the System Administrator role or equivalent permissions will see the **Back office order processing integration** setting on the **Overview** page.

    ![Setting to disable back office order processing integration](media/order-processing-integration-setting.png "Setting to disable back office order processing integration")
 
3. Select **Manage**. 

4. To disable the integration, change the **Sales order processing** setting to **No**, and select **Save**.

    ![Sales order processing setting](media/sales-order-processing-setting.png "Sales order processing setting")

    > [!IMPORTANT]
    > - Back office order processing integration setting is visible only when Sales order processing is already enabled. 
    > - After the setting is disabled, users will no longer see this setting. 
    > - This setting can be used only to disable the sales order processing incase it was turned on unintentionally through some solution installations. This setting can't be used to turn ON the Sales order processing.


### See also

[Create or edit orders](create-edit-order-sales.md)  