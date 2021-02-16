---
title: "Help improve Unified Service Desk  | MicrosoftDocs"
description: "Learn how you can make our app better by sending system and application information to Microsoft."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 11/06/2020
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
  - dyn365-admin
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
tags: MigrationHO
---
# Improve Unified Service Desk

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

Improvement program data lets [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] send application-specific information like product usage, health, and performance data to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)]. We use the information that we collect from the program to analyze and improve the service and product experience for our customers.
  
The information that [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sends anonymously includes:  
  
- Operating system version and bit type.  
  
- Web browser application and version.  
  
- [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] version.  
  
- Number of monitors used and screen resolution of the primary monitor.  
  
- Device processor class and random-access memory (RAM) details.

- [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] application-specific information. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Telemetry data](../admin/comply-unified-service-desk-data-gdpr.md#telemetry-data)

## Help improve Unified Service Desk enabled by default

With the release of [!INCLUDE[pn-unified-service-desk-3-3](../../includes/pn-unified-service-desk-3-3.md)], by default the **Help improve [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** feature is enabled for Microsoft Dataverse, and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] will send information to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)].

> [!Note]
> If you're using [!INCLUDE[pn-unified-service-desk-3-2](../../includes/pn-unified-service-desk-3-2.md)] or earlier with Dataverse instance, you must enable **Help improve [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** by configuring the **HelpImproveUSD** global option and setting the option to **True**. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Enable sending improvement program information to Microsoft anonymously](#enable-sending-improvement-program-information-to-microsoft-anonymously)

During installation or upgrade, a notice about transmitting product usage and performance information to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)] appears as shown in the following image. This information helps  us to improve the product experience.

![Transmitting usage and performance information](../media/helpimprove-usd-install.PNG "Transmitting usage and performance information")


Configuring and setting the value of the **HelpImproveUSD** global option to **FALSE** disables data collection, and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] won't send information to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)].

> [!Note]
>  The check box in the **Help improve [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** section on the **About** page reflects whether [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] will send data to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)]; an agent can't select or clear the check box. However, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] administrators can control whether to send data to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)].

<a name="Disable_ImproveUSD"></a>   
## Disable sending improvement program information to Microsoft anonymously
  
1. Sign in to the Unified Service Desk Administrator app.

2. In the site map under **Advanced Settings**, select **Options**.

3. On the **Active UII Options** page, select **New**.
  
4. On the **New Option** page in the **Global Options** list, select **HelpImproveUSD**.
  
5. In the **Value** box, enter **FALSE**.
  
6. Select **Save**.
  
> [!Note]
> Disable sending this information to Microsoft if you experience low performance with Unified Service Desk 4.1.1.1319 or an earlier version.

<a name="Enable_ImproveUSD"></a>   
## Enable sending improvement program information to Microsoft anonymously

1. Sign in to the Unified Service Desk Administrator app. 

2. In the site map under **Advanced Settings**, select **Options**.

3. On the **Active UII Options** page, select **New**.  
  
4. On the **New Option** page in the **Global Options** list, select **HelpImproveUSD**.
  
5. In the **Value** box, enter **TRUE**.
  
6. Select **Save**.

> [!NOTE]
> Alternatively, you can enable the global option for sending improvement program information to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)] by performing the following.
> 1. Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Options**.
> 2. Select the **HelpImproveUSD** check box.
> 3. In the toolbar, select **Deactivate**.

> [!Note]
> If you delete the **HelpImproveUSD** global option from the **Active UII Options** page, data collection is enabled and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sends information to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)]
  
## Privacy notice

[!INCLUDE[cc_privacy_usd_telemetry](../../includes/cc-privacy-usd-telemetry.md)]
  
### See also

[Manage options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md)  
[Provide feedback about Unified Service Desk](../admin/provide-feedback.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]