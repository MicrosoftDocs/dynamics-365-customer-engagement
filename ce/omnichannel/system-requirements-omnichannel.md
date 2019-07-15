---
title: "Pre-requisites and system requirements of Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about the system requirements of Omnichannel for Customer Service."
keywords: ""
ms.date: 07/12/2019
ms.service:
  - "dynamics-365-customerservice"
ms.custom:
  - ""
ms.topic: article
applies_to:
  - ""
ms.assetid: 94FFAD86-B4BF-48C1-90A5-81FDE7A8D13E
author: kabala123
ms.author: kabala
manager: shujoshi
---

# Pre-requisites and system requirements of Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This topic provides information about the pre-requisites and system requirements for deploying Omnichannel for Customer Service on a Dynamics 365 for Customer Engagement organization.

You can deploy Omnichannel for Customer Service solution over a Customer Engagement application and experience it through the following ways:

- Unified Service Desk client application

- Omnichannel for Customer Service app - Web experience on Dynamics 365 Unified Interface application.

## Prerequisites

This section explains the pre-requisites for using Omnichannel for Customer Service.

### Licensing

- You must have an active subscription of Microsoft Dynamics 365 for Customer Service Enterprise or Customer Engagement Plan in your tenant for each Chat user.

- Use of historical Supervisor reporting through **Omnichannel Intraday Insights**, **Omnichannel Chat Insights**, and **Omnichannel Sentiment Insights Dashboards** also requires Power BI Pro license or higher for each individual in a Supervisor role.

## System and hardware requirements of Omnichannel for Customer Service with web experience

| Area | Requirements | 
|----------|----------|
| Dynamics 365 | Dynamics 365 for Customer Engagement apps version 9.1.0000.3653 and a higher version |
| Web browsers | Supported browsers are: <li>Microsoft Edge</li><li>Google Chrome</li> |

For hardware and other requirements, see [Microsoft Dynamics 365 for Customer Engagement apps requirements](../admin/online-requirements.md)

## System and hardware requirements of Omnichannel for Customer Service with Unified Service Desk

You require the following to use Omnichannel for Customer Service with Unified Service Desk:

| Area | Requirements | 
|----------|----------|
| Desktop application | Unified Service Desk 4.1.1.1253 and higher version <br><br>More information: [Download Unified Service Desk](administrator/omnichannel-customer-service-unified-service-desk.md#download-unified-service-desk-client-application)|
| Dynamics 365 |Dynamics 365 for Customer Engagement apps version 9.1.0000.3653 and a higher version<br><br> **Note:** We recommend you to use a new production Dynamics 365 for Customer Engagement instance to use Omnichannel for Customer Service on Unified Service Desk. |
| Hosting Types | Supported hosting types are: <li>Chrome Process</li> <li>IE Process</li> <br> To learn more about the hosting types, see [Configure recommended settings for Unified Service Desk](administrator/configure-settings-unified-service-desk.md). |
| Operating system |<li>For Microsoft Edge - Windows 10 (October 2018 release and a higher version)</li><li>For Internet Explorer - Windows 10, Windows 8.1, Windows 8, or Windows 7 Service Pack 1 (SP1)</li>|
| Memory (Hardware) | ^8-GB RAM or more |

^The memory requirement is for out-of-the-box solution. Evaluate the requirements when creating complex configurations to the Unified Service Desk - Omnichannel for Customer Service solution or when using other line-of-business applications with Unified Service Desk.

For other hardware requirements of Unified Service Desk client application, see [Unified Service Desk system requirements](/dynamics365/customer-engagement/unified-service-desk/admin/unified-service-desk-system-requirements)

## International availability

The Chat for Dynamics 365 service is available in the following regions currently:

- North America 
- Europe
- Canada
- United Kingdom
- Government Cloud Computing (GCC)

For the service to work, your tenant and organization have to be co-located in one of these regions.

## Provision Omnichannel in Dynamics 365

See [Provision Omnichannel for Customer Service](administrator/omnichannel-provision-license.md) to know how to enable the Omnichannel for Customer Service app in your Dynamics 365 org.

To upgrade Omnichannel, see [Upgrade Omnichannel for Customer Service](administrator/upgrade-omnichannel.md).

> [!NOTE]
> - Omnichannel for Customer Service is not supported on Dynamics 365 for Customer Engagement apps (on-premises).
>
> - Omnichannel for Customer Service is supported only on Desktops, and not on mobiles and tablets.
>
> - Omnichannel for Customer Service for other regions will be available in the future.

## See also

- [Introduction](introduction-omnichannel.md)
- [Administrator guide](administrator/omnichannel-administrator.md)
- [Agents using Unified Service Desk](agent/agent-usd/omnichannel-agent.md)
- [Agents using Omnichannel for Customer Service app](agent/agent-oc/omnichannel-customer-service-app-agent.md)
- [System customizers guide](customizer/omnichannel-customizer.md)

<!-- - [Supervisors](supervisor/omni-channel-engagement-hub-supervisor.md) -->
