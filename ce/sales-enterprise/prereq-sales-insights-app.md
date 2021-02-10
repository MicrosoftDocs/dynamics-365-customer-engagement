---
title: "Prerequisites to administer conversation intelligence | MicrosoftDocs"
description: "Prerequisites on how to administer conversation intelligence"
ms.date: 06/01/2020
ms.service: crm-online
ms.custom: 
ms.topic: article
ms.assetid: 6ee1a5cf-bb4a-46d5-b835-c0ac6644dec5
author: udaykirang
ms.author: udag
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 01
topic-status: Drafting
---

# Prerequisites to configure conversation intelligence

>[!IMPORTANT]
>This feature is intended to help sales managers or supervisors enhance their team's performance. This feature isn't intended for use in making&mdash;and shouldn't be used to make&mdash;decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with sales persons may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their sales persons that their communications with end users may be monitored, recorded, or stored.

Verify the following requirements before setting up conversation intelligence for your organization:   
-	You must have an administrator or similar role.   
-	You must have a Dynamics 365 Sales organization.   
-	You must purchase a [Dynamics 365 Sales Insights](https://portal.office.com/Signup/MainSignUp.aspx?OfferId=5be85c9f-df71-4bcf-ac2f-b2a05b4a1f99) or Sales Premium license.         
    >[!NOTE]
    >The Sales Insights license provides you access to the conversation intelligence feature with 3 hours of call processing capacity for all licensed users from your organization.<br> 
    >To extend the capacity of processing hours for your organization, you must purchase the conversation intelligence add-on for Sales Insights.<br>
    >To learn more, see **Add-on Capacities** section in **Appendix F: Dynamics 365 Capacity Add-ons** from [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).         
-	You must get access to conversation intelligence. If you don't have access, follow these steps:       
    1.	To access the app, go to [Conversation intelligence](https://sales.ai.dynamics.com/).       
    2.	Enter your work email address.       
    3.	When the application recognizes the email, you must sign in using Azure Active Directory. To learn more, see [Azure AD Connect user sign-in options](https://docs.microsoft.com/azure/active-directory/hybrid/plan-connect-user-signin).   
-	You must create a v2 storage account with an Azure subscription to create blob container to configure call data. To learn more, see [Create a storage account](https://docs.microsoft.com/azure/storage/common/storage-quickstart-create-account?tabs=portal#create-a-storage-account-1).

### See also

[Introduction to administer conversation intelligence](intro-admin-guide-sales-insights.md#administer-conversation-intelligence)   
[Overview of conversation intelligence](dynamics365-sales-insights-app.md) 
