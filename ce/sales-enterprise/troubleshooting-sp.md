---
title: "Troubleshooting the Sales Insights features | MicrosoftDocs"
description: "Know about the issues that are related to the Sales Insights features, and how to troubleshoot them."
ms.date: 03/22/2021
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Troubleshooting Sales Insights 

This article helps you troubleshoot and resolve issues related to the Sales Insights features.

<a name="unable-install-features-not-working-sales-premium"> </a>
## I'm unable to install or Sales Insights features aren't working as defined 

**Reason**   
This could happen when some of the processes that are related Sales Insights are disabled in your organization and a warning is displayed in the Sales Insights settings page as shown below:    
> [!div class="mx-imgBorder"]  
> ![Sales insights processes are disabled warning message](media/ts-sp-process-disabled-warning-message.png "Sales insights processes are disabled warning message")

**Resolution**    
To resolve this issue, enable the Sales Insights processes that are disabled. Follow these steps:   
1.  In your app, select the **Settings** icon, and then select **Advanced Settings**.   
    > [!div class="mx-imgBorder"]    
    > ![Advanced Settings option on the Settings menu](media/advanced-settings-option.png "Advanced Settings option on the Settings menu")    
    The **Business Management** page opens.    
2.  On the navigation bar, select **Settings**, and then under **Process Center**, select **Processes**.    
3. On the **Processes** page, choose the **All Processes** view and the search for sale insights.    
    A list of Sales Insights processes is displayed.    
4. Verify that the statuses of all Sales Insights processes are in **Activated** state. In this example, you can see that the **Sales Insights ActionCard stat aggregator**, **Sales Insights CES API Handler**, and **Sales Insights create similar opportunity prediction model** processes are in draft state.  
    > [!div class="mx-imgBorder"]    
    > ![View all Sales Insights processes](media/ts-sp-process-view-sales-insights-processes.png "View all Sales Insights processes")    
5. Select the processes that are in **Draft** state and activate.


[!INCLUDE[footer-include](../includes/footer-banner.md)]
