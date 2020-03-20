---
title: "Troubleshooting related to the Order entity (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how to troubleshoot issues with the Order entity in Dynamics 365 Sales."
ms.date: 03/31/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Troubleshooting order forms 
<!--Would it be possible to have a less formal title, something like this? If not, maybe this could be the title in the TOC. My concern is that this content needs to be easily discovered, so what would be the likeliest title that would help a user find the answers they need?-->
This article helps you troubleshoot and resolve issues related to the Order entity.

<a name="order_processing_integration"> </a>
<!--What do you think of the following heading? The "Issue: xxx" pattern would help these sections stand out in the future, when there might be several of them in this article. I tried to deduce what the problem would be that has driven the user to this page; I might have misunderstood. I don't really see that your original heading expresses a problem though. -->
## Issue: I don't see the Create invoice button on my order forms

<!--Sales order processing integration is enabled for me. How do I disable it?-->

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
    > - This setting can be used only to disable sales order processing in case it was turned on unintentionally through some solution installation. This setting can't be used to turn _on_ sales order processing.<!--Can you give a cross-reference to information about how to turn it on?-->

<!--These "See also" links should relate to the whole article rather than this one issue. Classically for troubleshooting topics, if there are "see also" links they go to a FAQ or related troubleshooting topics. If the topic below will help the user solve their current problem, the cross-reference should be integrated into text above. If it's just truly a "see this article also if you feel like learning more", you don't need it in a troubleshooting topic at all.
### See also

[Create or edit orders](create-edit-order-sales.md)  
-->