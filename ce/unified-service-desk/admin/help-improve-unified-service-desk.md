---
title: "Help improve Unified Service Desk for Dynamics 365 Customer Engagement | MicrosoftDocs"
description: "Learn how you can make our app better by sending system and application information to Microsoft."
ms.custom: ""
ms.date: 04/24/2018
ms.service: "usd"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 4ca41e5e-d266-4060-8f26-dac57ca2bb29
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
tags: 
 - "MigrationHO"
---
# Improve Unified Service Desk
Improvement program data lets [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] send  application-specific information like product usage, health, and performance data to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)]. We use the information that we collect from the program to analyze and improve the service and product experience for our customers.
  
 The kinds of information that [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sends anonymously includes:  
  
- Operating system version and bit type.  
  
- Web browser application and version.  
  
- [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] version.  
  
- Number of monitors used and screen resolution of the primary monitor.  
  
- Device processor class and random-access memory (RAM) details.

- [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] application-specific information. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Telemetry data](../admin/comply-unified-service-desk-data-gdpr.md#telemetry-data)

By default, the Help Improve [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] feature is enabled and Unified Service Desk sends information to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)].

Configuring and setting the value of the Global Option: `HelpImproveUSD` to `FALSE` disables data collection and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] does not send information to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)].

> [!Note]
>  The checkbox in the Help Improve [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] section on **About** page reflects whether or not [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sends data to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)], and agent cannot select or clear the checkbox. However, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrators can control whether or not send data to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)].

<a name="Disable_ImproveUSD"></a>   
## Disable sending improvement program information to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)] anonymously
  
1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] as a user with the System Administrator or [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator security role.  
  
2. Go to **Settings** > **Unified Service Desk.**  
  
3. Click **Options**.  
  
4. On the Active UII Options page, click **New**.  
  
5. On the New Option page, select **HelpImproveUSD** in the **Global Options** list.  
  
6. In the Value box, type `FALSE`.
  
7. Click **SAVE & CLOSE**.
  
<a name="Enable_ImproveUSD"></a>   
## Enable sending improvement program information to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)] anonymously  

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] as a user with the System Administrator or [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator security role.  
  
2. Go to **Settings** > **Unified Service Desk**.
  
3. Click **Options**.
  
4. On the Active UII Options page,  select **HelpImproveUSD** from the **Global Options** list.
  
5. In the Value box, type `TRUE`.
  
6. Click **SAVE & CLOSE**.

> [!NOTE]
> Alternatively, you can enable the global option for sending improvement program information to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)] by performing the following.
> 1. Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Options**.
> 2. Select **HelpImproveUSD** checkbox.
> 3. Click **Deactivate** in the toolbar.

> [!Note]
> If you delete the **HelpImproveUSD** global option from the UII options page, the data collection is enabled and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sends information to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)]
  
## Privacy notice  
[!INCLUDE[cc_privacy_usd_telemetry](../../includes/cc-privacy-usd-telemetry.md)]
  
## See also
[Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md)

[Provide feedback about Unified Service Desk](../admin/provide-feedback.md)