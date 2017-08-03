---
title: "Help improve Unified Service Desk for Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: "2016-08-01"
ms.reviewer: ""
ms.service: "usd"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 4ca41e5e-d266-4060-8f26-dac57ca2bb29
caps.latest.revision: 10
author: "Mattp123"
ms.author: "matp"
manager: "amyla"
tags: 
 - "MigrationHO"
---
# Help improve Unified Service Desk
Improvement program data lets [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] transmit computer and [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] application-specific information to [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)]. We use the information that is collected by the program to analyze and improve the service and product experience for   our customers.  
  
 The kinds of information that is transmitted anonymously includes:  
  
-   Operating system version and bit type.  
  
-   Web browser application and version.  
  
- [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] version.  
  
-   Number of monitors used and screen resolution of the primary monitor.  
  
-   Device processor class and random-access memory (RAM) details.  
  
 There are two steps required to enable the send improvement information program.  
  
1.  Set the global option. [Set global option for sending improvement program information to Microsoft](#SetGlobalUsage)  
  
2.  After the global option is set, each service agent can enable. [Enable or disable sending improvement program information to Microsoft anonymously](#Enable_ImproveUSD)  
  
> [!NOTE]
>  -   By default, this feature is globally disabled in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] and must be enabled to use it.  
> -   This feature was first introduced in [!INCLUDE[pn_unified_service_desk_2_1](../includes/pn-unified-service-desk-2-1.md)] and is only available with [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].  
  
<a name="SetGlobalUsage"></a>   
## Set the global option for sending improvement program information to Microsoft  
 Before service agents can enable the send improvement program information to Microsoft option, the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] administrator must enable the global option for the feature.  
  
1.  Sign in to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] as a user with the System Administrator or USD Administrator security role.  
  
2.  Go to **Settings** > **Unified Service Desk.**  
  
3.  Click **Options**.  
  
4.  On the Active UII Options page, click **New**.  
  
5.  On the New Option page, select **HelpImproveUSD** in the **Global Options** list.  
  
6.  In the Value box type `TRUE`.  
  
7.  Click **SAVE & CLOSE**.  
  
> [!NOTE]
>  To disable the global option for sending improvement program information to Microsoft, go to Settings > Unified Service Desk > Options.  Select **HelpImproveUSD**, and then click **Deactivate**.  
  
<a name="Enable_ImproveUSD"></a>   
## Enable or disable sending improvement program information to [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] anonymously  
 After the global option to enable  sending improvement program information to Microsoft is set as described in  [Set global option for sending improvement program information to Microsoft](#SetGlobalUsage), the option becomes  available in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client for service agents to enable.  
  
1.  In the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client click settings, and then click **About**.  
  
2.  In the About Unified Service Desk dialog select the **Send Unified Service Desk improvement program information to Microsoft anonymously** check box to enable, clear the check box to disable.  
  
## Privacy notice  
[!INCLUDE[cc_privacy_usd_telemetry](../includes/cc-privacy-usd-telemetry.md)]
  
### See also  
 [Manage Options for Unified Service Desk](../unified-service-desk/manage-options-unified-service-desk.md)