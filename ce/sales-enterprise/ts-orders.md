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

# Troubleshooting related to the Order entity 
<!--I'm a bit mystified by this article. Can it be integrated into a more general troubleshooting topic? If not, will other issues likely be added to it eventually? The sole issue it addresses isn't really described in the title, so it doesn't seem very discoverable. -->
This article helps you troubleshoot and resolve issues related to the Order entity.

<a name="order_processing_integration"> </a>
## Sales order processing integration is enabled for me. How do I disable it?

Sales order processing integration connects Dynamics 365 Sales with an external back-office order processing application. It allows a sales order created in Dynamics 365 Sales to be submitted, after which the order can be synchronized with an external order processing application, where the lifecycle of the order continues. When the integration is enabled, users don't see the **Create Invoice** button on order records. If the integration is enabled unintentionally, you can disable it.  

**To disable sales order processing integration**

1. In the Sales Hub app, at the bottom of the site map, select **Change area** ![Change area](media/change-area-icon.png "Change area"), and then select **App Settings**.

2. Under **General Settings**, select **Overview**. 

    When sales order processing is already enabled, users with the System Administrator role or equivalent permissions will see the **Back office order processing integration** setting on the **Overview** page.

    > [!div class="mx-imgBorder"]  
    > ![Setting to disable back office order processing integration](media/order-processing-integration-setting.png "Setting to disable back office order processing integration")
 
3. Select **Manage**. 

4. To disable the integration, turn off **Sales order processing**<!--This is how the Style Guide recommends handling a toggle. It's a bit of a conundrum  because the values aren't On and Off. So, I think another option might be to say "In the **Sales order processing** area, select **Yes**, and then select **Save**.-->, and then select **Save**.

    > [!div class="mx-imgBorder"]  
    > ![Sales order processing setting](media/sales-order-processing-setting.png "Sales order processing setting")

    > [!IMPORTANT]
    > - The **Back office order processing integration** setting is visible only when sales order processing is already enabled. 
    > - After the setting is disabled, users will no longer see this setting. 
    > - This setting can be used only to disable sales order processing in case it was turned on unintentionally through some<!--SELF--> solution installations. This setting can't be used to turn _on_ sales order processing.<!--This seems like a good place for a cross-reference to information about how to turn it on.-->

<!--I don't think a "See also" section makes sense for a specific section in a troubleshooting topic. As discussed earlier, I think this topic needs to declare itself as either a one-off troubleshooting issue or an umbrella topic that will be added to over time. In either case, it doesn't make sense to supply people with a link for them to go learn more about a feature when they've come to a troubleshooting topic to solve a problem with that feature. It's different if an umbrella troubleshooting topic gives a "See also" to an FAQ or a related troubleshooting umbrella topic (for example, a user troubleshooting topic might "See also" an admin troubleshooting guide). If the topic below will help the user solve their current problem, can you integrate the cross-reference in the text above?-->
### See also

[Create or edit orders](create-edit-order-sales.md)  