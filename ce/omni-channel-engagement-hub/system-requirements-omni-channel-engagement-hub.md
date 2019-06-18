---
title: "Pre-requisites and system requirements of Omni-channel Engagement Hub | MicrosoftDocs"
description: "Learn about the system requirements of Omni-channel Engagement Hub."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 05/03/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 94FFAD86-B4BF-48C1-90A5-81FDE7A8D13E
ms.custom: 
---

# Pre-requisites and system requirements of Omni-channel Engagement Hub - Preview

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

This topic provides information about the pre-requisites and system requirements for deploying Omni-channel Engagement Hub - Preview on a Dynamics 365 for Customer Engagement organization.

You can deploy Omni-channel Engagement Hub - Preview solution over a Customer Engagement application and experience it through the following ways:

- Unified Service Desk client application

- Omni-channel Engagement Hub app - Web experience on Dynamics 365 Unified Interface application.

## Pre-requisites

This section explains the pre-requisites for using Omni-channel Engagement Hub.

### Licensing requirement of Office 365

Your organization needs the following Office 365 license:

- Office 365 Enterprise E1 plan or a higher plan. To learn more, see [Office 365 Business Plans](https://products.office.com/en-US/business/compare-more-office-365-for-business-plans).

> [!NOTE]
> - You must assign the Office 365 Enterprise E1 plan or a higher plan licenses to the Omni-channel users.
>
> - To assign the licenses, you must have the **Global Tenant Admin** access. 

## System and hardware requirements of Omni-channel Engagement Hub - Preview with web experience

| Area | Requirements | 
|----------|----------|
| Dynamics 365 | Dynamics 365 for Customer Engagement apps version 9.1.0000.3653 and a higher version |
| Web browsers | Supported browsers are: <li>Microsoft Edge</li><li>Google Chrome</li> |

For hardware and other requirements, see [Microsoft Dynamics 365 for Customer Engagement apps requirements](../admin/online-requirements.md)

## System and hardware requirements of Omni-channel Engagement Hub - Preview with Unified Service Desk

You require the following to use Omni-channel Engagement Hub - Preview with Unified Service Desk:

| Area | Requirements | 
|----------|----------|
| Desktop application | Unified Service Desk 4.1.1.1253 and higher version <br><br>More information: [Download Unified Service Desk](administrator/omni-channel-engagement-hub-unified-service-desk.md#download-unified-service-desk-client-application)|
| Dynamics 365 |Dynamics 365 for Customer Engagement apps version 9.1.0000.3653 and a higher version<br><br> **Note:** We recommend you to use a new production Dynamics 365 for Customer Engagement instance to use Omni-channel Engagement Hub on Unified Service Desk. |
| Hosting Types | Supported hosting types are: <li>Chrome Process</li> <li>IE Process</li> <br> To learn more about the hosting types, see [Configure recommended settings for Unified Service Desk](administrator/configure-settings-unified-service-desk.md). |
| Operating system |<li>For Microsoft Edge - Windows 10 (October 2018 release and a higher version)</li><li>For Internet Explorer - Windows 10, Windows 8.1, Windows 8, or Windows 7 Service Pack 1 (SP1)</li>|
| Memory (Hardware) | ^8-GB RAM or more |

^The memory requirement is for out-of-the-box solution. Evaluate the requirements when creating complex configurations to the Unified Service Desk - Omni-channel Engagement Hub - Preview solution or when using other line-of-business applications with Unified Service Desk.

For other hardware requirements of Unified Service Desk client application, see [Unified Service Desk system requirements](/dynamics365/customer-engagement/unified-service-desk/admin/unified-service-desk-system-requirements)

## International availability

The Omni-channel Engagement Hub - Preview is available in the following regions: 

- North America Region (NAM)

> [!NOTE]
> Since Omni-channel Engagement Hub is in preview in the NAM region, your organization and tenant must be in the NAM region.

## Provision Omni-channel in Dynamics 365

See [Provision Omni-channel Engagement Hub](administrator/omni-channel-provision-license.md) to know how to enable the Omni-channel Engagement Hub app in your Dynamics 365 org.

To upgrade Omni-channel, see [Upgrade Omni-channel Engagement Hub](administrator/upgrade-omni-channel.md).

> [!NOTE]
> - Omni-channel Engagement Hub - Preview is not supported on Dynamics 365 for Customer Engagement apps (on-premises).
>
> - Omni-channel Engagement Hub - Preview is supported only on Desktops, and not on mobiles and tablets.
>
> - Omni-channel Engagement Hub - Preview for other regions will be available in the future. 

## See also

- [Introduction](introduction-omni-channel.md)
- [Administrators](administrator/omni-channel-engagement-hub-administrator.md)
- [Agents using Unified Service Desk](agent/agent-usd/omni-channel-engagement-hub-agent.md)
- [Agents using Omni-channel Engagement Hub app](agent/agent-oceh/oceh-omni-channel-engagement-hub-agent.md)
- [System customizers](customizer/omni-channel-engagement-hub-customizer.md)

<!-- - [Supervisors](supervisor/omni-channel-engagement-hub-supervisor.md) -->
