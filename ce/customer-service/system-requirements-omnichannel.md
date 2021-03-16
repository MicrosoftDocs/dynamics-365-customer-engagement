---
title: "Omnichannel for Customer Service system requirements | MicrosoftDocs"
description: "Learn about the system requirements of Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 03/12/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Omnichannel for Customer Service system requirements

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This topic provides information about the prerequisites and system requirements for deploying Omnichannel for Customer Service in your organization.

You can deploy Omnichannel for Customer Service over a Customer Service application and experience it in the following ways:

- Unified Service Desk client application

- Omnichannel for Customer Service app - Web experience on the Unified Interface application

## Prerequisites

This section lists the prerequisites for using Omnichannel for Customer Service.

### International availability

Make sure that Omnichannel for Customer Service is available in your region. For more information, see [International availability](international-availability.md).

### Licensing

- You must have an active subscription to Microsoft Dynamics 365 Customer Service Enterprise or Dynamics 365 Customer Engagement Plan in your tenant for each user of Digital Messaging or Chat for Dynamics 365 Customer Service.
- You must have an active subscription to the Dynamics 365 Customer Service Digital Messaging add-on for each Digital Messaging user or Chat for Dynamics 365 Customer Service for each Chat user.
- Use of historical Supervisor reporting through **Omnichannel Intraday Insights**, **Omnichannel Chat Insights**, and **Omnichannel Sentiment Insights Dashboards** also requires Power BI Pro license or higher for each individual in a Supervisor role.

## System requirements of Omnichannel for Customer Service

The system requirements to use Omnichannel for Customer Service are as follows.

| Area | Requirements |
|----------|----------|
| Model-driven app | Dynamics 365 Customer Service app version 9.1.0000.3653 or later  |
| Web browsers | Supported browsers:<li> Microsoft Edge ([Chromium based](https://support.microsoft.com/help/4501095/download-the-new-microsoft-edge-based-on-chromium) is recommended); version 79.0.309.65 or later is required for the desktop notifications feature </li> <li> Google Chrome </li> **Important**<br> [!INCLUDE[cc-cookies-in-omnichannel](../includes/cc-cookies-in-omnichannel.md)] |

For hardware and other requirements, see [Model-driven app requirements](../admin/online-requirements.md).

### Supported browsers for live chat widget<a name="browsers-for-chat"></a>

The following browsers are supported by the live chat widget in Omnichannel for Customer Service:

- **Windows:** Chromium-based Microsoft Edge, Google Chrome, Mozilla Firefox, and Internet Explorer 11
- **macOS and iOS:** Safari
- **Android:** Chromium-based Microsoft Edge and Google Chrome

> [!NOTE]
>
> - Only Chromium-based Microsoft Edge and Google Chrome are supported for voice and video in live chat.
> - Support for Internet Explorer 11 is deprecated. We recommend that you use Microsoft Edge. More information: [Deprecation announcement](deprecations-customer-service.md#internetexplorer11).

## Provision Omnichannel

See [Provision Omnichannel for Customer Service](omnichannel-provision-license.md) to know how to enable the Omnichannel for Customer Service app in your org.

To upgrade Omnichannel, see [Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md).

> [!NOTE]
>
> - Omnichannel for Customer Service is not supported with Dynamics 365 Customer Engagement (on-premises).
> - Omnichannel for Customer Service is supported only on desktops, and not on phones and tablets.
> - Microsoft recommends that you use browsers for Omnichannel for Customer Service in normal mode for optimal experience.

## Allow access to websites

If your organization is using a URL filter to block a category of websites, you need to allow specific websites as an exception for your users to access the Omnichannel for Customer Service app and live chat widget in the business portal:

- `https://login.microsoft.net`
- `https://login.microsoftonline.com`
- `https://login.windows.net`
- `https://*.teams.microsoft.com`
- `https://ecs.office.com`
- `https://*.skype.com`
- `https://browser.pipe.aria.microsoft.com`
- `https://plat.teams.microsoft.com`
- `https://aad.skypetoken.skype.com`
- `https://authsvc.teams.microsoft.com`
- `https://swc.cdn.skype.com/*`
- `https://config.edge.skype.com/*`
- `https://edge.skype.com/* `
- `https://api.aps.skype.com/*`
- `https://*.asm.skype.com`
- `https://*.ng.msg.teams.microsoft.com/* `
- `https://*.notifications.teams.microsoft.com/*`
- `https://*.omnichannelengagementhub.com/*`
- `https://cdn.botframework.com/botframework-webchat`
- `https://webchatic3.blob.core.windows.net`
- `https://comms.omnichannelengagementhub.com`
- `https://ocsdk-prod.azureedge.net`
- `https://*.service.signalr.net`

If your customers are using a URL filter to block a category of websites or URLs, you might have to ask your customers to allow a specific website as an exception.

Customers must be able to access the following URLs from their browsers to use the live chat widget in the portal:

- `https://*.teams.microsoft.com`
- `https://ecs.office.com`
- `https://*.skype.com`
- `https://browser.pipe.aria.microsoft.com`
- `https://oc-cdn-ocprod.azureedge.net/livechatwidget`
- `https://cdn.botframework.com/botframework-webchat`
- `https://webchatic3.blob.core.windows.net`
- `https://comms.omnichannelengagementhub.com`
- `https://ocsdk-prod.azureedge.net`
- `https://*.asm.skype.com`
- `https://*.ng.msg.teams.microsoft.com/*`

### Geo-specific links

Geographic specific links that should be accessible are as follows.

| Geographic location | Links |
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

### Government Community Cloud (GCC)

The Government community cloud links that should be accessible are as follows.

- `https://ocprodocprodnamgs.blob.core.usgovcloudapi.net`
- `https://*.omnichannelengagementhub.us/*`
- `https://oc-auth.azurewebsites.us`
- `https://swc.cdn.skype.com/*`
- `https://config.edge.skype.com/*`
- `https://*.gcc.teams.microsoft.com`
- `https://api.ams.gcc.teams.microsoft.com/*`
- `https://browser.pipe.aria.microsoft.com/*`

### See also

[Introduction](introduction-omnichannel.md)  
[Administrator guide](omnichannel-administrator.md)  
[Agents using Unified Service Desk](../unified-service-desk/oc-usd/omnichannel-agent.md)  
[Agents using Omnichannel for Customer Service app](omnichannel-customer-service-app-agent.md)  
[System customizers guide](omnichannel-customizer.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
