---
title: "What's new in Unified Service Desk for developers and customizers | MicrosoftDocs"
description: "Learn about the new features available for developers and customizers in the latest version of Unified Service Desk."
ms.date: 06/21/2021
ms.topic: article
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - customizer
  - developer
ms.custom: 
  - dyn365-USD
---

# What's new in Unified Service Desk for developers and customizers

::: moniker range="dynamics-usd-4.2"

## What's new in Unified Service Desk 4.2

This topic contains information about changes in [!INCLUDE[pn-unified-service-desk-4-2](../includes/pn-unified-service-desk-4-2.md)] for developers and customizers available in this version.

### Use Edge WebView2 Process to host web applications in Unified Service Desk

The Edge WebView2 Process browser control hosts your controls in individual Edge WebView2 process instances and displays them in tabs in the Unified Service Desk client application. It facilitates predictable and secure page rendering by making sure that if your web application works in Microsoft Edge, it'll work in Unified Service Desk.

The advantages of using the Edge WebView2 Process hosting method are:

- Available on supported versions of the Windows operating system.
- Highly reliable.
- Easy to configure to host applications in Unified Service Desk.
- Switch seamlessly from one browser to another for your entire organization.
- Enhanced performance and memory optimization.

More information: [Use EdgeWebView2 Process to host web applications in Unified Service Desk](edge-webview2-process.md)

::: moniker-end

::: moniker range="dynamics-usd-4.1"

## What's new in Unified Service Desk 4.1.1.1433

This release supports the Dynamics 365 model-driven apps deployed in Switzerland region.

## What's new in [!INCLUDE[pn-unified-service-desk-4-1](../includes/pn-unified-service-desk-4-1.md)]

### Use Chrome Process hosting type to host web applications in Unified Service Desk

Use Chrome Process to host web applications in Unified Service Desk client application. The Chrome Process is based on **CefSharp**, an open source framework, which uses the chromium core that powers many modern browsers.

The advantages of using the Chrome process hosting method are as follows:

- Chrome Process is available on different Windows OS versions.
- Chrome Process is highly reliable.
- Easy configurations to host the applications in Unified Service Desk.
- Switch easily from one browser to another for your entire organization.
- Chrome Process pooling feature that reuses the chrome processes and mimics inline navigation provides enhanced performance and memory optimizations.

More information: [Use Chrome Process to host web applications in Unified Service Desk](chrome-process.md)

### Integrate channel using Channel Integration Framework

Bring your channel providers and integrate them with Unified Service Desk client application using Channel Integration Framework.

If your organization wants to use the cloud-based channel that you have developed using the [Channel Integration Framework](../customer-service/channel-integration-framework/channel-integration-framework.md), you can integrate the same channel in Unified Service Desk with minimal configuration experience. In turn, this eliminates the need for developing multiple channels. 

The User Interface Integration (UII) framework provides a hosted control - **Channel Integration Framework** - for you to host the channel provider within Unified Service Desk client application.

More information: [Integrate channel using Channel Integration Framework](integrate-channel-provider-channel-integration-framework.md)

### Stack notification in Unified Service Desk

You can configure stack notifications in Unified Service Desk to display popup notification messages to your customer service agents that contains general information, customer or process-related information that the agent can act on.
This facilitates simultaneous toast notifications in a multi-session environment. 

Two new parameters are introduced: **stack** and **stackHeight**, for which you can set the values to show the notifications in a stack with a certain height.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Stack Notifications](configure-notifications-unified-service-desk.md#stack-notifications) and [Popup Notification Hosted Control](popup-notification-hosted-control.md)

### Switch between local sessions, and between local and global sessions

When you are working on a case (local session) and want to review your Dashboard (global session) or another case (local session), you can easily switch from the case to Dashboard or another case, without affecting your session timer. That is, when you switch from local session, your session timer doesn't count until you switch back to the session. This helps in efficiently measure the agents' productivity.

Using **SwitchSession** action, you can now switch between local sessions. Also, you can switch sessions between local and global by passing the global session ID retrieved from the context using the replacement parameter.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [SwitchSession Action](session-tabs-hosted-control.md#switchsession)

::: moniker-end

::: moniker range="dynamics-usd-4"

## What's new in [!INCLUDE[pn-unified-service-desk-4-0](../includes/pn-unified-service-desk-4-0.md)]

This topic contains information about changes in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] for developers and system customizers. 

### General Availability: Support for Unified Interface apps in Unified Service Desk

With the release of [!include[pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)], we've introduced a new user experience -[Unified Interface](/dynamics365/customer-engagement/admin/about-unified-interface), which uses responsive web design principles to provide an optimal viewing and interaction experience for any screen size, device, or orientation.  [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] supports the apps built using Unified Interface framework. That is, you can load a URL or page from model-driven app, which is built based on the Unified Interface framework.

A new hosted control type called **Unified Interface Page** is introduced, which you need to set as **USD Component Type** while creating a hosted control to use a URL or page from the model-driven apps.

The experience of the supportability is that the Unified Interface Page hosted control type exposes number of predefined UII actions and events that are unique to handling of model-driven app windows built using Unified Interface framework including list manipulation actions, and a find action for displaying a quick search or advanced search page.

### Stack notification in Unified Service Desk

You can configure stack notifications in Unified Service Desk to display popup notification messages to your customer service agents that contains general information or some customer or process-related information that the agent can act on.
This facilitates simultaneous toast notifications in a multi-session environment. 

Two new parameters are introduced: **stack** and **stackHeight**, for which you can set the values to show the notifications in a stack with a certain height.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Stack Notifications](configure-notifications-unified-service-desk.md#stack-notifications) and [Popup Notification Hosted Control](popup-notification-hosted-control.md)

### Switch between local sessions, and between local and global sessions

When you are working on a case (local session) and want to review your Dashboard (global session) or another case (local session), you can easily switch from the case to Dashboard or another case, without affecting your session timer. That is, when you switch from local session, your session timer will not be counted until you switch back to the session. This helps in efficiently measure the agents' productivity.

Using **SwitchSession** action, you can now switch between local sessions. Also, you can switch sessions between local and global by passing the global session ID retrieved from the context using the replacement parameter.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [SwitchSession Action](session-tabs-hosted-control.md#switchsession)

::: moniker-end


### See also  
 [What’s New in Unified Service Desk for administrators](admin/whats-new-unified-service-desk-administrators.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]

