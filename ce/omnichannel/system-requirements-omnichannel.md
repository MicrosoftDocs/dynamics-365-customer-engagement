---
title: "Prerequisites and system requirements of Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about the system requirements of Omnichannel for Customer Service."
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
  - ""
ms.date: 01/30/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
ms.custom: 
  - ""
---

# Prerequisites and system requirements of Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This topic provides information about the prerequisites and system requirements for deploying Omnichannel for Customer Service in your organization.

You can deploy Omnichannel for Customer Service over a Customer Service application and experience it in the following ways:

- Unified Service Desk client application

- Omnichannel for Customer Service app - Web experience on Unified Interface application

## Prerequisites

This section explains the prerequisites for using Omnichannel for Customer Service.

### Licensing

- You must have an active subscription to Microsoft Dynamics 365 Customer Service Enterprise in your tenant for each Chat user.

- You must have an active subscription to Chat for Dynamics 365 Customer Service.

- Use of historical Supervisor reporting through **Omnichannel Intraday Insights**, **Omnichannel Chat Insights**, and **Omnichannel Sentiment Insights Dashboards** also requires Power BI Pro license or higher for each individual in a Supervisor role.

## System and hardware requirements of Omnichannel for Customer Service with web experience

| Area | Requirements | 
|----------|----------|
| Model-driven app | Dynamics 365 Customer Service app version 9.1.0000.3653 or higher  |
| Web browsers | Supported browsers are: <li>Microsoft Edge</li><li>Google Chrome</li> |

For hardware and other requirements, see [Model-driven app requirements](../admin/online-requirements.md).

## System and hardware requirements of Omnichannel for Customer Service with Unified Service Desk

You will need the following to use Omnichannel for Customer Service with Unified Service Desk:

| Area | Requirements | 
|----------|----------|
| Desktop application | Unified Service Desk 4.1.1.1253 and higher version <br><br>More information: [Download Unified Service Desk](administrator/omnichannel-customer-service-unified-service-desk.md#download-unified-service-desk-client-application)|
| Model-driven app |Dynamics 365 Customer Service app version 9.1.0000.3653 and a higher version<br><br> **Note:** We recommend you use a new production Dynamics 365 Customer Service instance to use Omnichannel for Customer Service on Unified Service Desk. |
| Hosting Types | Supported hosting types are: <li>Chrome Process</li> <li>IE Process</li> <br> To learn more about the hosting types, see [Configure recommended settings for Unified Service Desk](administrator/configure-settings-unified-service-desk.md). |
| Operating system |<li>For Microsoft Edge - Windows 10 (October 2018 release and a higher version)</li><li>For Internet Explorer - Windows 10, Windows 8.1, Windows 8, or Windows 7 Service Pack 1 (SP1)</li>|
| Memory (Hardware) | ^8-GB RAM or more |

^The memory requirement is for out-of-the-box solutions. Evaluate the requirements when creating complex configurations to the Unified Service Desk - Omnichannel for Customer Service solution or when using other line-of-business applications with Unified Service Desk.

For other hardware requirements of Unified Service Desk client application, see [Unified Service Desk system requirements](/dynamics365/unified-service-desk/admin/unified-service-desk-system-requirements).

## International availability

Currently, **Chat for Dynamics 365 Customer Service** and **Dynamics 365 for Digital Messaging** are available in the following countries or regions:

- North America 
- Europe
- Canada
- United Kingdom
- Government Cloud Computing (GCC)
- Australia
- Asia Pacific
- South America
- Japan

For the service to work, your tenant and organization have to be co-located in one of these countries or regions.

## Provision Omnichannel

See [Provision Omnichannel for Customer Service](administrator/omnichannel-provision-license.md) to know how to enable the Omnichannel for Customer Service app in your org.

To upgrade Omnichannel, see [Upgrade Omnichannel for Customer Service](administrator/upgrade-omnichannel.md).

> [!NOTE]
> - Omnichannel for Customer Service is not supported with Dynamics 365 Customer Engagement (on-premises).
>
> - Omnichannel for Customer Service is supported only on desktops, and not on phones and tablets.
>
> - Omnichannel for Customer Service for other regions will be available in the future.

## Allow access to websites or URLs

If your organization is using a URL filter to block a category of websites or URLs, you might have to allow a specific website as an exception.

Add the following URLs for your users to access the Omnichannel for Customer Service app and live chat widget in the portal:

- `https://plat.teams.microsoft.com`
- `https://aad.skypetoken.skype.com`
- `https://authsvc.teams.microsoft.com`
- `https://swc.cdn.skype.com/*`
- `https://config.edge.skype.com/*`
- `https://edge.skype.com/* `
- `https://api.aps.skype.com/*` 
- `https://*.ng.msg.teams.microsoft.com/* `
- `https://*.notifications.teams.microsoft.com/* ` 
- `https://*.omnichannelengagementhub.com/*`

**Geo-specific URLs**

| Geographic location | URL |
|-------------------------------|----------------------------------|
| North America | `oc-cdn-ocprod.azureedge.net/*`|
| Europe | `oc-cdn-public-eur.azureedge.net/*`|
| South America | `oc-cdn-public-sam.azureedge.net/*`|
| United Kingdom | `oc-cdn-public-gbr.azureedge.net/*`|
| Japan | `oc-cdn-public-jpn.azureedge.net/*`|
| Asia Pacific | `oc-cdn-public-eur.azureedge.net/*`|
| Canada | `oc-cdn-public.azureedge.net/*`|
| India | `oc-cdn-public-ind.azureedge.net/*`|
| Asia-Pacific and Japan | `oc-cdn-public-apj.azureedge.net/*`|
| Australia | `oc-cdn-public-oce.azureedge.net/*`|
| France | `oc-cdn-public-fra.azureedge.net/*`|

**Government Community Cloud (GCC)**

- `https://ocprodocprodnamgs.blob.core.usgovcloudapi.net`
- `https://*.omnichannelengagementhub.us/*`
- `https://oc-auth.azurewebsites.us`
- `https://swc.cdn.skype.com/*`
- `https://config.edge.skype.com/*`
- `https://*.gcc.teams.microsoft.com`
- `https://api.ams.gcc.teams.microsoft.com/*`
- `https://browser.pipe.aria.microsoft.com/*`


## See also

- [Introduction](introduction-omnichannel.md)
- [Administrator guide](administrator/omnichannel-administrator.md)
- [Agents using Unified Service Desk](agent/agent-usd/omnichannel-agent.md)
- [Agents using Omnichannel for Customer Service app](agent/agent-oc/omnichannel-customer-service-app-agent.md)
- [System customizers guide](customizer/omnichannel-customizer.md)
