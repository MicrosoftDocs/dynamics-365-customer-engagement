---
title: Release history (Unified Service Desk)
description: Find information about all the documentation updates made in various versions of Unified Service Desk.
ms.date: 09/27/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham

search.audienceType: 
  - customizer
  - developer
ms.custom: evergreen
---

# Release history for Unified Service Desk

This is the release history page for the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] Guide.  

::: moniker range="dynamics-usd-4.2"

<a name="Release_4_2"></a>

## Release history for Unified Service Desk 4.2.0.71, September 2024

This release includes an upgrade to the XRM tooling connector package to the 9.1.1.65 version. There are no content-specific changes in this release.

## Release history for Unified Service Desk 4.2.0.57, May 2023

This release includes a CefSharp upgrade from version 103.0.120 to 110.0.300, and EdgeWebView2 SDK Update.
The list provides an overview of documentation updates made in this release of Unified Service Desk.

| Topic | Updates |
|---------------|-------------------|
|[Add parameters using Edge WebView2 Process](edge-webview2-process.md#add-parameters-using-edge-webview2-process) |Added information about how to add parameters using **Edge WebView2 Process**. |
|[Debug Edge WebView2 Process](edge-webview2-process.md#debug-edge-webview2-process) |Added information about how to access and debug all the **Edge WebView2 Process** instances running in a desktop locally and remotely.

## Release history for Unified Service Desk 4.2.0.51, January 2023

This release includes the Newtonsoft.Json version upgrade to 13.0.2, and some accessibility and security fixes. 

## Release history for Unified Service Desk 4.2.0.42, August 2022

This release includes a CefSharp upgrade from version 94.4.50 to 103.0.120, and some bug fixes in Dynamics 365 Channel Integration Framework. There are no content-specific changes in this release.

## Release history for Unified Service Desk 4.2.0.39, June 2022

This release includes an upgrade to the XRM tooling connector package to version 9.1.0.110, CefSharp crash fixes, and other security fixes. There are no content-specific changes in this release.

## Release history for Unified Service Desk 4.2.0.29, June 2021

The list provides an overview of documentation updates made in this release of Unified Service Desk.


| Topic | Updates |
|---------------|-------------------|
|[Create a hosted control with hosting type as Edge WebView2](edge-webview2-process.md#create-a-hosted-control-with-hosting-type-as-edge-webview2) |Added information about creating a hosted control with hosting type as **Edge WebView2**. |
|[Enable Edge WebView2 for Unified Service Desk on client desktop](edge-webview2-process.md#enable-edge-webview2-for-unified-service-desk-on-client-desktop) |Added information about enabling/disabling **Edge WebView2** on client desktops. |
|[Enable Edge WebView2 for an entire organization](edge-webview2-process.md#enable-edge-webview2-for-an-entire-organization) |Added information about enabling **Edge WebView2** for the entire organization using the Global UII option |
| [Edit a PDF in Edge WebView2 Process](edge-webview2-process.md#edit-a-pdf-in-edge-webview2-process) | Added information about editing PDFs. |
| [Enable language support in Edge WebView2 Process](edge-webview2-process.md#enable-language-support-in-edge-webview2-process) | Added information about enabling language support. |
|||

::: moniker-end

::: moniker range="dynamics-usd-4.1"

## Release history for Unified Service Desk 4.1.1.1433, December 2020

This release supports the Dynamics 365 model-driven apps deployed in Switzerland region. There are no content-specific changes in this release.

> [!NOTE]
> - If your organization is using a previously released version of the Unified Service Desk 4.1 client application, you must uninstall the application and then install version 4.1.1.1433, instead of upgrading to version 4.1.1.1433.
> - If your organization is using a previous version other than the Unified Service Desk 4.1 client application, you can upgrade to the version 4.1.1.1433.


<a name="Release_4_1_2"></a>

## Release history for Unified Service Desk 4.1.1.1429, November 2020

The list provides an overview of documentation updates made in Unified Service Desk 4.1.1.1429.

> [!NOTE]
> - If your organization is using a previously released version of the Unified Service Desk 4.1 client application, you must uninstall the application and then install version 4.1.1.1429, instead of upgrading to version 4.1.1.1429.
> - If your organization is using a previous version other than the Unified Service Desk 4.1 client application, you can upgrade to the version 4.1.1.1429.

| Topic | Updates |
|---------------|-------------------|
| [ChromeAccessibilityRenderer](admin/manage-options-unified-service-desk.md) | Added information about enabling the **force-renderer-accessibility** CEF setting when a screen reader is detected . <br><br> Existing option in [Manage options in Unified Service Desk](admin/manage-options-unified-service-desk.md). <br><br> More information: [Accessibility support with Chrome Process](chrome-process.md#accessibility-support-with-chrome-process) |
| [ChromeProcessConfirmationDialog](admin/manage-options-unified-service-desk.md) | Added a new UII option to confirm the exit of a session in the Unified Service Desk client application. <br><br> New option in [Manage options in Unified Service Desk](admin/manage-options-unified-service-desk.md). <br><br> More information: [Enable the confirmation dialog box with Chrome Process](chrome-process.md#enable-the-confirmation-dialog-box-with-chrome-process) |
| [ChromeProcessDownloadPath](admin/manage-options-unified-service-desk.md) | Added a new UII option to set a default folder to download attachments while using Chrome Process webpages. <br><br> New option in [Manage options in Unified Service Desk](admin/manage-options-unified-service-desk.md). <br><br> More information: [Download attachments in Chrome Process](chrome-process.md#download-attachments-in-chrome-process) |
| [ChromeProcessParameters](admin/manage-options-unified-service-desk.md) | Added a new UII option to add Chromium parameters that can be used on Chrome Process webpages in Unified Service Desk. <br><br> New option in [Manage options in Unified Service Desk](admin/manage-options-unified-service-desk.md). <br><br> More information: [Add parameters using Chrome Process](chrome-process.md#add-parameters-using-chrome-process) |
| [EscapeCharacters](admin/manage-options-unified-service-desk.md) | Added information about passing data that includes special characters to the Unified Service Desk client application. <br><br> New section in [Create a Channel Integration Framework hosted control](create-channel-integration-framework-hosted-control.md). <br><br> More information: [Enable the encoding and escaping of special characters](create-channel-integration-framework-hosted-control.md#enable-the-encoding-and-escaping-of-special-characters) |
| [Edit a PDF in Chrome Process](chrome-process.md#edit-a-pdf-in-chrome-process) | Added information about editing PDFs. |
| [Use Chrome Process to host web applications](chrome-process.md) | Added information about upgrading Unified Service Desk support for Chrome Process. |
| [OnBeforeCloseHandler](admin/manage-options-unified-service-desk.md) | Added information about ***onbeforeunload*** event handlers. <br><br> Option in [Manage options in Unified Service Desk](admin/manage-options-unified-service-desk.md). <br><br> More information: [Enable the close confirmation dialog box with Chrome Process](chrome-process.md#enable-the-close-confirmation-dialog-box-with-chrome-process) |
| [Single sign-on for Unified Service Desk](admin/connect-dynamics-365-instance-using-unified-service-desk-client.md#single-sign-on-for-unified-service-desk) | Added information about enabling or disabling SSO. |
| [Navigate](unified-interface-page-hosted-control.md#navigate) | Added information about adding multiple headers. |
| [Navigate](standard-web-application-hosted-control.md#navigate) | Added information about adding multiple headers. |
| [Navigate](crm-page-hosted-control.md#navigate) | Added information about adding multiple headers. |


## Release history for Unified Service Desk 4.1.1.1397, February 2020

The list provides an overview of documentation updates made in Unified Service Desk 4.1.1.1397

> [!NOTE]
> - If your organization is using any version of the Unified Service Desk 4.1 client application, then you need to uninstall that version and install the Unified Service Desk 4.1.1.1397 client application freshly, instead of upgrading to 4.1.1.1397 version.
> - If your organization is using any version other than Unified Service Desk 4.1 client application, you can upgrade to the 4.1.1.1397 version of client application.

| Topic | Updates |
|--------------|----------------|
| [Single sign on for Unified Service Desk](admin/connect-dynamics-365-instance-using-unified-service-desk-client.md#single-sign-on-for-unified-service-desk) | Added a new note under the single sign on support. |
| [BrowserWindowReady](unified-interface-page-hosted-control.md#browserwindowready)| Added a new event in the Unified Interface page hosted control. |
| [PageReady](unified-interface-page-hosted-control.md#pageready) | Added a note for the PageReady event in the Unified Interface page hosted control. |
| [DataReady](unified-interface-page-hosted-control.md#dataready) | Added a note for the DataReady event in the Unified Interface page hosted control. |
| [DataReady](unified-interface-page-hosted-control.md#dataready) | Added a note for the DataReady event in the Unified Interface page hosted control. |
| [Find](unified-interface-page-hosted-control.md#find) | Added new parameters for the Find event in the Unified Interface page hosted control. |
| [CreateSession](global-manager-hosted-control.md#createsession) | Added new parameters for the CreateSession event in the global manager hosted control. |


<a name="Release_4_1_1"></a>

## Release history for Unified Service Desk 4.1.1, July 2019

The list provides an overview of documentation updates made in Unified Service Desk 4.1.1.

| Topic | Updates |
|--------------|----------------|
| [KillUSDIEProcessesOnExit](admin/manage-options-unified-service-desk.md) | Added new UII option to kill the IE Process on exit of Unified Service Desk client application. <br><br> New option in the [Manage Options in Unified Service Desk](admin/manage-options-unified-service-desk.md).|
| [Generate Chrome Process crash report](chrome-process.md#generate-chrome-process-crash-reports) | Added information about generating Chrome Process crash report. <br><br> New section in [Use Chrome process to host web applications in Unified Service Desk](chrome-process.md).  |
| [Use the window.IsUSD property to invoke a Unified Service Desk event](chrome-process.md#use-the-windowisusd-property-to-invoke-a-unified-service-desk-event) | Updated information about window.IsUSD property <br><br> New section in [Use Chrome process to host web applications in Unified Service Desk](chrome-process.md).  |
| [Download attachments in Chrome Process](chrome-process.md#download-attachments-in-chrome-process) | Added information about downloading file attachments in Chrome Process <br><br> New section in [Use Chrome process to host web applications in Unified Service Desk](chrome-process.md).  |
| [Learn the behavior differences in Chrome Process and IE Process](hosting-type-differences.md) | New topic about the behavior differences in IE Process and Chrome Process. <br><br> Topic under [Select a hosting method for your controls in Unified Service Desk](select-hosting-method-controls.md).  |


<a name="Release_4_1"></a>

## Release history for General Availability of [!INCLUDE [pn-unified-service-desk-4-1](../includes/pn-unified-service-desk-4-1.md)], April 2019

The list provides an overview of documentation updates made in [!INCLUDE [pn-unified-service-desk-4-1](../includes/pn-unified-service-desk-4-1.md)].

| Topic | Updates |
|--------------|----------------|
| [Single Sign On for Unified Service Desk](admin/connect-dynamics-365-instance-using-unified-service-desk-client.md#single-sign-on-for-unified-service-desk) | New section about Single Sign On (SSO) for Unified Service Desk. <br><br> Section in [Connect to a model-driven app instance overview](admin/connect-dynamics-365-instance-using-unified-service-desk-client.md).|
| [Unified Service Desk Administrator app](admin/unified-service-desk-administrator-app.md) |  The Unified Service Desk Administrator app brings rich experience to administer and manage your Unified Service Desk client application.<br>The Administrator app, which is built based on the Unified Interface framework, has the same configurational capabilities as the Unified Service Desk administrator in Web Client. <br><br> Topic under [Administer and manage Unified Service Desk](admin/administer-manage-unified-service-desk.md). |
| [Unified Interface Settings](admin/unified-interface-settings.md) | Unified Interface Settings is a new configuration element introduced under Advanced Settings in the Unified Service Desk Administrator app. Unified Interface Settings enables you as an administrator to configure the default Unified Interface app for your agents and transform the Unified Service Desk sign-in experience. <br><br> Topic under [Administer and manage Unified Service Desk](admin/administer-manage-unified-service-desk.md).|
| [Recover a Chrome Process instance](admin/recover-chrome-process-instance.md) | Unified Service Desk can help agents to recover the terminated (crashed) webpages hosted in Chrome Process in Unified Service Desk. <br><br> New topic under [Administer and manage Unified Service Desk](admin/administer-manage-unified-service-desk.md). |
| [Cache specific configuration for agents](admin/set-configuration-cache-version.md) | New topic about caching specific configurations for the agents. <br><br> Topic under [Manage Options for Unified Service Desk](admin/manage-options-unified-service-desk.md) |
| [Pool process instances for Chrome Process](admin/performance-enhancement-crm-entity-page-loads.md#pool-process-instances-for-chrome-process) | New section about pooling of Chrome Process instance. <br><br> New section in [Performance enhancement for loading app pages](admin/performance-enhancement-crm-entity-page-loads.md) |
| [Configure notifications in Unified Service Desk](configure-notifications-unified-service-desk.md) | Updated information about configuring stack notification in Unified Service Desk.|
| [Navigate on the notifications using keyboard shortcuts](configure-notifications-unified-service-desk.md#navigate-on-the-notifications-using-keyboard-shortcuts) | New UII options for navigating on the stack notifications. <br><br> New section in [Configure notifications in Unified Service Desk](configure-notifications-unified-service-desk.md) |
| [Use Chrome process to host web applications in Unified Service Desk](chrome-process.md) | New topic about hosting web applications using Chrome Process in Unified Service Desk <br><br> Topic under [Select a hosting method for your controls in Unified Service Desk](select-hosting-method-controls.md).  |
| [Integrate channel using Channel Integration Framework](integrate-channel-provider-channel-integration-framework.md) | New topic about integrating channel using Channel Integration Framework in Unified Service Desk. <br><br> Topic under [Extend Unified Service Desk](extend-unified-service-desk.md). |
| [Create a Channel Integration Framework hosted control](create-channel-integration-framework-hosted-control.md) | New topic about creating a Channel Integration Framework type of hosted control.<br><br> Topic under [Integrate channel using Channel Integration Framework](integrate-channel-provider-channel-integration-framework.md). |
| [Channel Integration Framework (Hosted Control)](channel-integration-framework-hosted-control.md) | New topic about the predefined UII actions and events of Channel Integration Framework type of hosted control. <br><br> Topic under [Hosted control types and action/event reference](hosted-control-types-action-event-reference.md)  |
| [Popup Notification (Hosted Control)](popup-notification-hosted-control.md) | Updated information about the **Show** action parameters like **stack** and **stackHeight** used for configuring stack notifications.|
| [Session Tabs (Hosted Control)](session-tabs-hosted-control.md) | Updated new action, **SwitchSession** action that is used to switch between local sessions  and switch between local and global sessions.|

## Release history for public preview of [!INCLUDE [pn-unified-service-desk-4-1](../includes/pn-unified-service-desk-4-1.md)], March 2019

The list provides an overview of documentation updates made in [!INCLUDE [pn-unified-service-desk-4-1](../includes/pn-unified-service-desk-4-1.md)].

| Topic | Updates |
|--------------|----------------|
| [Single Sign On for Unified Service Desk](admin/connect-dynamics-365-instance-using-unified-service-desk-client.md#single-sign-on-for-unified-service-desk) | New section about Single Sign On (SSO) for Unified Service Desk. <br><br> New section in [Connect to a model-driven app instance overview](admin/connect-dynamics-365-instance-using-unified-service-desk-client.md). |
| [Cache specific configuration for agents](admin/set-configuration-cache-version.md) | New topic about caching specific configurations for the agents. <br><br> New topic under [Manage Options for Unified Service Desk](admin/manage-options-unified-service-desk.md)|
| [Navigate on the notifications using keyboard shortcuts](configure-notifications-unified-service-desk.md#navigate-on-the-notifications-using-keyboard-shortcuts) | New UII options for navigating on the stack notifications. <br><br> New section under [Configure notifications in Unified Service Desk](configure-notifications-unified-service-desk.md)  |
| [Use Chrome process to host web applications in Unified Service Desk](chrome-process.md) | New topic about hosting web applications using Chrome Process in Unified Service Desk <br><br> New topic under [Select a hosting method for your controls in Unified Service Desk](select-hosting-method-controls.md). |
| [Integrate channel using Channel Integration Framework](integrate-channel-provider-channel-integration-framework.md) | New topic about integrating channel using Channel Integration Framework in Unified Service Desk. <br><br> New topic under [Extend Unified Service Desk](extend-unified-service-desk.md). |
| [Create a Channel Integration Framework hosted control](create-channel-integration-framework-hosted-control.md) | New topic about creating a Channel Integration Framework type of hosted control.<br><br> New topic under [Integrate channel using Channel Integration Framework](integrate-channel-provider-channel-integration-framework.md). |
| [Channel Integration Framework (Hosted Control)](channel-integration-framework-hosted-control.md) | New topic about the predefined UII actions and events of Channel Integration Framework type of hosted control. <br><br> New topic under [Hosted control types and action/event reference](hosted-control-types-action-event-reference.md) |
| [Use Edge process to host web applications in Unified Service Desk](edge-process.md) | New topic about hosting web applications using Edge Process in Unified Service Desk <br><br> New topic under [Select a hosting method for your controls in Unified Service Desk](select-hosting-method-controls.md). <br><br>  |

::: moniker-end

::: moniker range="dynamics-usd-4"

<a name="Release_4_0"></a> 

## Release history for [!INCLUDE [pn-unified-service-desk-4-0](../includes/pn-unified-service-desk-4-0.md)], August 2018

The list provides an overview of documentation updates made in [!INCLUDE [pn-unified-service-desk-4-0](../includes/pn-unified-service-desk-4-0.md)].

|Topic   | Updates |
|--------------|----------------|
| [Download Unified Service Desk](../unified-service-desk/download-unified-service-desk.md) | Download link for [!INCLUDE [pn-unified-service-desk-4-0](../includes/pn-unified-service-desk-4-0.md)]. |
| [Unified Service Desk New Environment sample package](../unified-service-desk/admin/unified-service-desk-new-environment-package.md)  | Updated information about the Customizations for the Unified Interface package.  |
| [Unified Service Desk Unified Interface sample package](../unified-service-desk/admin/unified-service-desk-dynamics-365-unified-interface-package.md)  | Updated information about the Customizations for the Unified Interface package.  |
| [Unified Service Desk Upgrade sample package](../unified-service-desk/admin/unified-service-desk-upgrade-package.md)  | Updated information about the Customizations for the Unified Interface package.  |
| [Support for Unified Interface Apps](admin/support-unified-interfaces-apps-usd.md) | General Availability of the Unified Interface Support in Unified Service Desk. | 
| [Preview feature - Unified Service Desk Administrator app](admin/unified-service-desk-administrator-app.md) |  The Unified Service Desk Administrator app brings rich experience to administer and manage your Unified Service Desk client application.<br>The Administrator app, which is built based on the Unified Interface framework, has the same configurational capabilities as the Unified Service Desk administrator in Web Client. <br><br> New topic under [Administer and manage Unified Service Desk](admin/administer-manage-unified-service-desk.md). |
| [Preview feature - Unified Interface Settings](admin/unified-interface-settings.md) | Unified Interface Settings is a new configuration element introduced under Advanced Settings in the Unified Service Desk Administrator app. Unified Interface Settings enables you as an administrator to configure the default Unified Interface app for your agents and transform the Unified Service Desk sign-in experience. <br><br> New topic under [Administer and manage Unified Service Desk](admin/administer-manage-unified-service-desk.md).|
| [Manage Options for Unified Service Desk](admin/manage-options-unified-service-desk.md) | Updated information about new UII options such as **HideConfirmationDialog** and  **ShowNPSDialog**. |
| [Overview of Web Client - Unified Interface Migration Assistant](admin/overview-migration-assistant.md) | Web Client - Unified Interface Migration Assistant for Unified Service Desk, a tool that helps you to seamlessly migrate your existing Unified Service Desk configurations from the legacy web client to Unified Interface apps.<br><br> New topic under [Administer and manage Unified Service Desk](admin/administer-manage-unified-service-desk.md). |
| [Download the migration assistant](admin/download-migration-assistant.md) |The Web Client - Unified Interface Migration Assistant is an executable file that you can download and save on your machine. After downloading, you can run the executable file to start the migration process. <br><br>New topic under [Overview of Web Client - Unified Interface Migration Assistant](admin/overview-migration-assistant.md).|
| [Migration steps](admin/migration-steps-web-client-unified-interface-configuration.md) |The migration of the Unified Service Desk configurations from the legacy web client to Unified Interface is a three-step process. <br><br>New topic under [Overview of Web Client - Unified Interface Migration Assistant](admin/overview-migration-assistant.md).|
| [Configure close confirmation window](admin/configure-close-confirmation-window.md) |To avoid the accidental closure of Unified Service Desk, the close confirmation window is introduced.<br><br>New topic under [Administer and manage Unified Service Desk](admin/administer-manage-unified-service-desk.md).|
| [Customize themes in Unified Service Desk](customize-themes-in-unified-service-desk.md) | Updated information about the new Unified Blue theme for the Unified Interface app in Unified Service Desk. |
| [Use knowledge for effective customer engagement](use-dynamics-365-knowledge-effective-customer-engagement.md) | Updated information about the [Unified Interface KM Control (Hosted Control)](unified-interface-km-control-hosted-control.md). |
| [Configure Unified Service Desk to use knowledge](configure-unified-service-desk-use-dynamics-365-knowledge.md) | Updated information about the [Unified Interface KM Control (Hosted Control)](unified-interface-km-control-hosted-control.md). |
| [Configure notifications in Unified Service Desk](configure-notifications-unified-service-desk.md) | Updated information about configuring stack notification in Unified Service Desk. <br><br> |
| [Unified Service Desk and Unified Interface configuration walkthroughs](unified-service-desk-unified-interface-configuration-walkthroughs.md) | General Availability of the Unified Interface Support in Unified Service Desk. |
| [Unified Interface KM Control (Hosted Control)](unified-interface-km-control-hosted-control.md) |Use the Unified Interface KM Control type of hosted control to display knowledge base articles in your agent application.<br><br>New topic under [Hosted control types and action/event reference](hosted-control-types-action-event-reference.md). |
| [Popup Notification (Hosted Control)](popup-notification-hosted-control.md) | Updated information about the **Show** action parameters like **stack** and **stackHeight** used for configuring stack notifications. <br><br> |
| [Session Tabs (Hosted Control)](session-tabs-hosted-control.md) | Updated new action, **SwitchSession** action that is used to switch between local sessions  and switch between local and global sessions. <br><br> |
| [Unified Interface Page (Hosted Control)](unified-interface-page-hosted-control.md) | General Availability of Unified Interface Support in Unified Service Desk. |


::: moniker-end



### Related Topics
[What's new for Administrators](../unified-service-desk/admin/whats-new-unified-service-desk-administrators.md)

[What's new for Developers](what-s-new-in-unified-service-desk.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
