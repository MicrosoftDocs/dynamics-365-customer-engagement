---
title: "Omnichannel for Customer Service system requirements | MicrosoftDocs"
description: "This article provides information about the prerequisites and system requirements for deploying Omnichannel for Customer Service."
ms.date: 07/13/2023
author: neeranelli
ms.author: nenellim
---

# Omnichannel for Customer Service system requirements

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This article provides information about the prerequisites and system requirements for deploying Omnichannel for Customer Service in your organization.

You can deploy Omnichannel for Customer Service over a Customer Service application and use it in the following ways:

- Omnichannel for Customer Service app - Web experience on the Unified Interface application
- Unified Service Desk client application

## Prerequisites

This section lists the prerequisites for using Omnichannel for Customer Service.

### International availability

Make sure that Omnichannel for Customer Service is available in your region. More information: [International availability](international-availability.md)

### Licensing

- You must have an active subscription to Microsoft Dynamics 365 Customer Service Enterprise or Dynamics 365 Customer Engagement Plan in your tenant for each user of Digital Messaging or Chat for Dynamics 365 Customer Service.
- For each chat channel user, you must have an active subscription to the **Dynamics 365 Customer Service Digital Messaging add-on** for each Digital Messaging user or **Chat for Dynamics 365 Customer Service**.
- For each voice channel user, you must have an active subscription to **Dynamics 365 Customer Service Voice Channel Add-in** or **Dynamics 365 Customer Service Digital Messaging and Voice Add-in**. For information on purchasing add-ins, see [Buy an add-on](/microsoft-365/commerce/buy-or-edit-an-add-on?view=o365-worldwide#buy-an-add-on&preserve-view=true).

For more information about licenses and pricing, see the [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/p/?LinkId=866544). 

## System requirements for Omnichannel for Customer Service

The system requirements to use Omnichannel for Customer Service are as follows.

| Area | Requirements |
|----------|----------|
| Model-driven app | Dynamics 365 Customer Service app 9.2.21034.00160 or later.  |
| Web browsers | Supported browsers:<li> Microsoft Edge ([Chromium based](https://support.microsoft.com/help/4501095/download-the-new-microsoft-edge-based-on-chromium)); version 79.0.309.65 or later is required for the desktop notifications feature. </li> <li> Google Chrome </li> **Important**<br> [!INCLUDE[cc-cookies-in-omnichannel](../includes/cc-cookies-in-omnichannel.md)] |
| Azure Communication Services |Required for 1st party voice and SMS in the voice channel in production environments. |
| Hardware | <ul><li>Microphone and speakers for the voice experience.</li><li>**Minimum:** 4 GB of RAM</li><ul> |
| Internet bandwidth for voice and video |<ul><li>**Minimum:** 4 Mbps upload speed; 8 Mbps download speed</li><li>**Recommended:** 8 Mbps upload speed; 16 Mbps download speed</li></ul> |
|||

For other hardware and software requirements, see [Model-driven app requirements](/power-platform/admin/web-application-requirements).

### Supported web browsers for voice and video in live chat widget<a name="browsers-for-chat"></a>

The following browsers are supported by the customer-facing live chat widget in Omnichannel for Customer Service:

- **Windows:** Chromium-based browser such as Microsoft Edge, Google Chrome, and Mozilla Firefox
- **macOS and iOS:** Safari
- **Android:** Chromium-based browser such as Microsoft Edge and Google Chrome

## Provision Omnichannel for Customer Service

To enable the Omnichannel for Customer Service app in your org, see [Provision Omnichannel for Customer Service](omnichannel-provision-license.md).

To upgrade Omnichannel for Customer Service, see [Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md).

> [!NOTE]
>
> - Omnichannel for Customer Service is not supported with Dynamics 365 Customer Engagement (on-premises).
> - Omnichannel for Customer Service is supported only on desktops, and not on phones and tablets.
> - We recommend that you use browsers in normal mode to optimally experience the Omnichannel for Customer Service app.

## Allow access to websites

If your organization uses a URL filter to block a category of websites or URLs, ensure that you allow the following websites as an exception for your users so they can access the Omnichannel for Customer Service app on the business portal.

- `https://*.communication.azure.com`
- `https://login.microsoft.net`
- `https://login.microsoftonline.com`
- `https://login.windows.net`
- `https://*.teams.microsoft.com`
- `https://ecs.office.com`
- `https://*.skype.com/*`
- `https://*.trouter.skype.com`
- `https://*.edge.skype.com`
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
- `https://*.omnichannelengagementhub.com`
- `https://ocsdk-prod.azureedge.net`
- `https://*.service.signalr.net`


If your customers are using a URL filter to block a category of websites or URLs, you might have to ask your customers to allow a specific website as an exception. Your customers must allow access to the following URLs from their browsers to use the live chat widget in the portal.

- `https://*.communication.azure.com`
- `https://*.teams.microsoft.com`
- `https://ecs.office.com`
- `https://*.skype.com/*`
- `https://browser.pipe.aria.microsoft.com`
- `https://oc-cdn-ocprod.azureedge.net/livechatwidget`
- `https://cdn.botframework.com/botframework-webchat`
- `https://webchatic3.blob.core.windows.net`
- `https://*.omnichannelengagementhub.com`
- `https://ocsdk-prod.azureedge.net`
- `https://*.asm.skype.com`
- `https://*.ng.msg.teams.microsoft.com/*`

### Geo-specific links

Location-specific links that should be made accessible are as follows.

| Geographic location | Links |
|-------------------------------|----------------------------------|
| North America | `oc-cdn-ocprod.azureedge.net/*`|
| Europe | `oc-cdn-public-eur.azureedge.net/*`|
| South America | `oc-cdn-public-sam.azureedge.net/*`|
| United Kingdom | `oc-cdn-public-gbr.azureedge.net/*`|
| Japan | `oc-cdn-public-jpn.azureedge.net/*`|
| Asia Pacific | `oc-apj-public-eur.azureedge.net/*`|
| Canada | `oc-cdn-public.azureedge.net/*`|
| India | `oc-cdn-public-ind.azureedge.net/*`|
| Asia-Pacific and Japan | `oc-cdn-public-apj.azureedge.net/*`|
| Australia | `oc-cdn-public-oce.azureedge.net/*`|
| France | `oc-cdn-public-fra.azureedge.net/*`|
| United Arab Emirates | `oc-cdn-ocuae-uae.azureedge.net/*`|

### Government Community Cloud (GCC)

The Government community cloud links that should be made accessible are as follows.

- `https://*.communication.azure.us`
- `https://ocprodocprodnamgs.blob.core.usgovcloudapi.net`
- `https://*.omnichannelengagementhub.us/*`
- `https://oc-auth.azurewebsites.us`
- `https://swc.cdn.skype.com/*`
- `https://config.edge.skype.com/*`
- `https://*.gcc.teams.microsoft.com`
- `https://api.ams.gcc.teams.microsoft.com/*`
- `https://browser.pipe.aria.microsoft.com/*`

### See also

[Introduction to Omnichannel for Customer Service](introduction-omnichannel.md)  
[Get started with Customer Service admin center](cs-admin-center.md)  
[Agents using Unified Service Desk](../unified-service-desk/oc-usd/omnichannel-agent.md)  
[Agents using Omnichannel for Customer Service](omnichannel-customer-service-app-agent.md)  
[System customizer guide](omnichannel-customizer.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
