---
title: "What's new in Unified Service Desk for administrators | MicrosoftDocs"
description: "Learn about new features available for system administrators in the latest version of Unified Service Desk."
ms.date: 02/06/2023
ms.topic: article
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - admin
ms.custom: 
  - dyn365-USD
  - dyn365-admin
---

# What's new in Unified Service Desk for administrators



::: moniker range="dynamics-usd-4.2"

## What's new in Unified Service Desk 4.2

This topic contains information about changes in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] for system administrators available in this version.

### Use Edge WebView2 Process to host web applications in Unified Service Desk

The Edge WebView2 Process browser control hosts your controls in individual Edge WebView2 process instances and displays them in tabs in the Unified Service Desk client application. It facilitates predictable and secure page rendering by making sure that if your web application works in Microsoft Edge, it'll work in Unified Service Desk.

The advantages of using the Edge WebView2 Process hosting method are:

- Available on supported versions of the Windows operating system.
- Highly reliable.
- Easy to configure to host applications in Unified Service Desk.
- Switch seamlessly from one browser to another for your entire organization.
- Enhanced performance and memory optimization.

Also, administrators will be able to perform the following:

- Select Edge WebView2 Process as the hosting type for the organization.
- Select Edge WebView2 Process as the hosting type for select web applications, alongside Chrome process.

More information: [Use EdgeWebView2 Process to host web applications in Unified Service Desk](../edge-webview2-process.md)

### Recover an Edge WebView2 process instance

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can help agents to recover the terminated (crashed) webpages hosted in Edge WebView2 Process in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

By default, Edge WebView2 Process instance recovery is enabled.

More information: [Recover an Edge WebView2 process instance](recover-edge-webview2-process-instance.md)

### Pool process instances for Edge WebView2 Process

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] always maintains a pool of Edge WebView2 process instances for hosted controls to use. Opening a hosted control using a pooled Edge WebView2 process instance enhances the performance of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

By default, the Edge WebView2 process instance pooling is enabled.

With the Edge WebView2 process instance pooling, every entity page navigation happens inline after the first entity page navigation.

::: moniker-end

::: moniker range="dynamics-usd-4.1"

## What's new in Unified Service Desk 4.1.1.1433

This topic contains information about changes in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] for system administrators available in this version.

This release supports the Dynamics 365 model-driven apps deployed in Switzerland region.

## What's new in Unified Service Desk 4.1.1.1429

This topic contains information about changes in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] for system administrators available in this version.

- Enhancements to the Chrome process hosting type include the following:

  * Unified Service Desk support for Chrome process upgraded to Chromium version 84. More information: [Use Chrome Process to host web application](../chrome-process.md)
  * Support for editing PDFs (if the PDF has editable fields) with Chrome Process webpages. More information: [Edit PDF in chrome process](../chrome-process.md#edit-a-pdf-in-chrome-process)
  * Accessibility support for the Chrome process web pages enhanced. More information: [Accessibility support with Chrome Process](../chrome-process.md#accessibility-support-with-chrome-process).
  * Confirmation messages displayed on close and save sessions. More information: [Enable the close confirmation dialog box with Chrome Process](../chrome-process.md#enable-the-close-confirmation-dialog-box-with-chrome-process) and [Enable the confirmation dialog box with Chrome Process](../chrome-process.md#enable-the-confirmation-dialog-box-with-chrome-process)
  * Open source parameters supported to enhance the performance of Chrome process&ndash;based webpages. More information: [Add parameters using Chrome Process](../chrome-process.md#add-parameters-using-chrome-process).
  * Default folder enabled to download attachments. More information: [Download attachments in Chrome Process](../chrome-process.md#download-attachments-in-chrome-process).

- Multiple headers supported during the Navigate action of a Unified Service Desk POST event. More information: [Unified interface page hosted control](../unified-interface-page-hosted-control.md#navigate), [Standard Web Application hosted control](../standard-web-application-hosted-control.md#navigate), and [CRM Page hosted control](../crm-page-hosted-control.md#navigate).

- Single sign-on feature enabled by default. More information: [Single sign on for Unified Service Desk](connect-dynamics-365-instance-using-unified-service-desk-client.md#single-sign-on-for-unified-service-desk).

- Special characters supported in Unified Service Desk. More information: [Enable the encoding and escaping of special characters](../create-channel-integration-framework-hosted-control.md#enable-the-encoding-and-escaping-of-special-characters).

## What's new in Unified Service Desk 4.1

This topic contains information about changes in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] for system administrators available in this version. 

### Use Chrome Process hosting type to host web applications in Unified Service Desk

Use Chrome Process to host web applications in Unified Service Desk client application. The Chrome Process is based on **CefSharp**, an open source framework, which uses the chromium core that powers many modern browsers.

The advantages of using the Chrome process hosting method are as follows:

- Chrome Process is available on different Windows OS versions.
- Chrome Process is highly reliable.
- Easy configurations to host the applications in Unified Service Desk.
- Switch easily from one browser to another for your entire organization.
- Chrome Process pooling feature that reuses the chrome processes and mimics inline navigation provides enhanced performance and memory optimizations.

More information: [Use Chrome Process to host web applications in Unified Service Desk](../chrome-process.md)

### Recover a Chrome Process instance

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can help agents to recover the terminated (crashed) webpages hosted in Chrome Process in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] 

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can help agents to recover the webpages in the following scenarios:

- When Chrome Process closes abruptly.
- When you manually end an unresponsive Chrome Process instance from Task Manager.
- When you manually end an unresponsive Chrome Process instance using a keyboard shortcut.

Chrome Process recovery enables you to recover any Chrome Process instance (which may have more than one webpage) that is unresponsive in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] application.

By default, Chrome Process instance recovery is enabled. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Recover Chrome Process instance](../../unified-service-desk/admin/recover-chrome-process-instance.md).

### Integrate channel using Channel Integration Framework

Bring your channel providers and integrate them with Unified Service Desk client application using the Channel Integration Framework.

If your organization wants to use the cloud-based channel that you have developed using the [Channel Integration Framework](/dynamics365/customer-engagement/developer/channel-integration-framework/channel-integration-framework), you can integrate the same channel in Unified Service Desk with minimal configuration experience. In turn, this eliminates the need for developing multiple channels. 

The User Interface Integration (UII) framework provides a hosted control - **Channel Integration Framework** - for you to host the channel provider within the Unified Service Desk client application.

More information: [Integrate channel using Channel Integration Framework](../integrate-channel-provider-channel-integration-framework.md)

### Cache-specific configuration for agents

The Configuration Cache Version option causes the client caching feature to retrieve the configuration that has undergone change from the server to the agent’s desktop and avoid retrieving all configurations.

Your organization may have several departments, each with a configuration and agents added to those configurations. Whenever you make a change to one of those configurations, the **Configuration Cache Version** feature helps to download only that specific configuration for which you've made a change. Also, when the agents assigned to other configurations sign in to the client application, the feature doesn't download the configurations, thus improving the startup time of Unified Service Desk. This is also helpful in better application lifecycle management for Unified Service Desk in cases where your organization wants to make changes in your pilot or developer configurations without impacting the production users.

More information: [Cache specific configuration for agents](../admin/set-configuration-cache-version.md)

### Single sign-on for Unified Service Desk

Single sign-on (SSO) for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] provides an improved startup performance and user experience by authenticating users to access the model-driven apps without the need for entering the credentials multiple times. This eliminates the need for entering the same password again and minimizes the possibility of login errors and ensures a seamless experience.

More information: [Single sign-on (SSO) for Unified Service Desk](../admin/connect-dynamics-365-instance-using-unified-service-desk-client.md#single-sign-on-for-unified-service-desk)

### Unified Service Desk Administrator App

Use the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator App built on the Unified Interface framework to administer and manage the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application.

The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator app is built on the Unified Interface framework, which has a new user experience - **Unified Interface** - that uses responsive web design principles to provide an optimal viewing and interaction experience for any screen size, device, or orientation.

The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator app brings rich experience to administer and manage your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application.

The Administrator app, built based on the Unified Interface framework, has the same configurational capabilities as the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] administrator in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Web Client.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Unified Service Desk Administrator App](../admin/unified-service-desk-administrator-app.md)

### Unified Interface Settings

Unified Interface Settings is a new configuration element introduced under the **Advanced Settings** in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator app. Unified Interface Settings enables you as an administrator to configure the default Unified Interface app for your agents and transform the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sign-in experience.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Unified Interface Settings](../admin/unified-interface-settings.md)

### Show feedback window to agents
A feedback window is introduced in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to help an agent to provide feedback while closing the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application. Agents can provide feedback comments with the score and submit it to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)]. The comments are assessed and considered for improving the products and services.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage options for Unified Service Desk](../admin/manage-options-unified-service-desk.md)

::: moniker-end

::: moniker range="dynamics-usd-4"

## What's new in [!INCLUDE[pn-unified-service-desk-4-0](../../includes/pn-unified-service-desk-4-0.md)]

This topic contains information about changes in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] for system administrators available in this version.

### Web Client - Unified Interface Migration Assistant
The Web Client - Unified Interface Migration Assistant for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] helps you migrate your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configurations from [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Web Client to a [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Unified Interface app.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Web Client - Unified Interface Migration Assistant](../admin/overview-migration-assistant.md)

### Prevent Accidental Closure of Unified Service Desk Unified Service Desk

While working on [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], accidentally if you select the **x** Close button, you may lose all the unsaved work. The Close Confirmation Window is introduced to prevent the accidental closure of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure close confirmation window for Unified Service Desk](../admin/configure-close-confirmation-window.md)

### Unified Interface KM Control

The **Unified Interface KM Control** hosted control is introduced for your knowledge base search experience with [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. You must configure the Unified Interface KM Control when you are using a Unified Interface app in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. 

Your service agents can use the **Unified Interface KM Control** hosted control to search and view the knowledge base in Unified Interface from within the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. Also, you can position your search control in the main panel, left panel, or right panel of the Unified Interface Desk application. Also, you can configure the contextual actions for the search results.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Unified Interface KM Control (hosted control)](../unified-interface-km-control-hosted-control.md)

### Unified Blue theme for Unified Service Desk

The Unified Blue theme is the predefined theme for Unified Service Desk when you are using a Unified Interface app.

### Unified Service Desk Administrator App

With [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] 4.0, you can use the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator App built on the Unified Interface framework to administer and manage the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application.

The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator app is built on the Unified Interface framework, which has a new user experience - **Unified Interface** - that uses responsive web design principles to provide an optimal viewing and interaction experience for any screen size, device, or orientation.

The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator app brings rich experience to administer and manage your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application.

The Administrator app, built based on the Unified Interface framework has the same configurational capabilities as the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] administrator in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Web Client. 

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Unified Service Desk Administrator App](../admin/unified-service-desk-administrator-app.md)

### Unified Interface Settings

Unified Interface Settings is a new configuration element introduced under the **Advanced Settings** in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator app. Unified Interface Settings enables you as an administrator to configure the default Unified Interface App for your agents and transform the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sign-in experience.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Unified Interface Settings](../admin/unified-interface-settings.md)

### Show feedback window to agents
A feedback window is introduced in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to help an agent to provide feedback while closing the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application. Agents can provide feedback comments with the score and submit it to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)]. The comments are assessed and considered for improving the products and services.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage options for Unified Service Desk](../admin/manage-options-unified-service-desk.md)

::: moniker-end

### See also
 [What’s New in Unified Service Desk for developers](../../unified-service-desk/what-s-new-in-unified-service-desk.md)  

 [Overview of Unified Service Desk](../../unified-service-desk/admin/overview-unified-service-desk.md)  

 [Install and Deploy Unified Service Desk](../../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
