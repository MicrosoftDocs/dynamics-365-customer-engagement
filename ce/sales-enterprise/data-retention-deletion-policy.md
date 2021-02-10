---
title: "Data retention and deletion policy for conversation intelligence | MicrosoftDocs"
description: "Data retention and deletion policy for conversation intelligence"
ms.date: 11/06/2020
ms.service: crm-online
ms.custom: 
ms.topic: article
ms.assetid: c85b26ab-0150-454f-8767-6aed448529bc
author: udaykirang
ms.author: udag
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 01
topic-status: Drafting
---

# Data retention and access through Privacy

>[!IMPORTANT]
>This feature is intended to help sales managers or supervisors enhance their team’s performance. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with sales persons may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their sales persons that their communications with end users may be monitored, recorded, or stored.

When you configure conversation intelligence, sales call recordings of sales reps are processed and analyzed to provide necessary insights such as overall customer sentiments, sentiment trends, and identify keywords that customers have used during calls. Conversation intelligence provides the following options to configure:  
-	[Provide read-only access to your data for Microsoft](#provide-read-only-access-to-your-data-for-microsoft)
-	[Retention policy](#retention-policy)  

## Open privacy settings page

> [!NOTE]
> Review the prerequisites. To learn more, see [Prerequisites to configure conversation intelligence](prereq-sales-insights-app.md).

### In conversation intelligence app

1.	Open the **Conversation intelligence** application.  
2.	Select the **Settings** icon on the top-right of the page and then select **Settings**.  
    > [!div class="mx-imgBorder"]
    > ![Select settings option](media/si-app-admin-select-settings.png "Select settings option")  
3.	On the **Settings** page, select **Privacy**.  
    Privacy page opens and you can perform the following tasks:  
        - [Provide read-only access to your data for Microsoft](#provide-read-only-access-to-your-data-for-microsoft)  
        - [Retention policy](#retention-policy)  

### In Sales Hub app  

1.	Go to **Change area** in the lower-left corner of the page and select **Sales Insights settings**.  
    > [!div class="mx-imgBorder"]
    > ![Select Sales Insights settings](media/si-admin-change-area-sales-insights-settings.png "Select Sales Insights settings")  
2.	In the configuration page, under **Productivity**, select **Conversation intelligence**.  
    > [!div class="mx-imgBorder"]
    > ![Conversation intelligence configuration page](media/ci-admin-config-page.png "Conversation intelligence configuration page")
3.	Select **Privacy**.  
    Privacy page opens and you can perform the following tasks:  
        - [Provide read-only access to your data for Microsoft](#provide-read-only-access-to-your-data-for-microsoft)  
        - [Retention policy](#retention-policy)  

## Provide read-only access to your data for Microsoft

You can allow to Microsoft to improve the quality of insights through manual (human) read-only access to your organization’s data in conversation intelligence. This is optional.  
1. Under the **Read-only access to data** section, select the option to allow Microsoft with read-only access to your data.  
> [!div class="mx-imgBorder"]
> ![Enable privacy](media/ci-admin-enable-privacy-ci-app.png "Enable privacy")  
2. Save the settings.

## Retention Policy

Retention policy allows you to determine how long you want to keep the analyzed call recording data in conversation intelligence by specifying a time limit. When you specify a retention time limit, the application retains the call recording data for the specified time limit. The application deletes the data when the time limit is reached. 

For example, retention time limit is set 30 days. At any given time, application retains the call data from the time it is analyzed to 30 days. On the 31st day, the application deletes the analyzed call data.  
1.	In the **Retention policy** section, select the drop-down and choose how many days you want to retain the analyzed data. You have the following options to choose: **Always**, **30 days**, **1 year**, or **90 Days**.  
    > [!div class="mx-imgBorder"]
    > ![Select data retention time](media/si-app-admin-select-retention-policy.png "Select data retention time")   
2.	Select **Save**.  
    Retention policy configuration is saved, and the analyzed call recording data will be retained until the selected option.

To learn more on Microsoft Dynamics 365 and GDPR, see [Microsoft Dynamics 365 and GDPR](https://docs.microsoft.com/dynamics365/get-started/gdpr/index).

### See also

[Introduction to administer conversation intelligence](intro-admin-guide-sales-insights.md#administer-conversation-intelligence)

[Prerequisites to use conversation intelligence](prereq-sales-insights-app.md)