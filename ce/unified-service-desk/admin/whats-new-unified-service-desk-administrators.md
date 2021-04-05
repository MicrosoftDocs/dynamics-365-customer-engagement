---
title: "What's new in Unified Service Desk for administrators | MicrosoftDocs"
description: "Learn about new Unified Service Desk features"
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 04/05/2021
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
---

# What's new in Unified Service Desk for administrators

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]


::: moniker range="dynamics-usd-4.2"

## What's new in Unified Service Desk 4.2

This topic contains information about changes in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] for system administrators available in this version. 


### Use Edge WebView2 Process to host web applications in Unified Service Desk

The Edge WebView2 Process browser control hosts your controls in individual Edge WebView2 process instances and displays them in tabs in the Unified Service Desk client application. It facilitates predictable and secure page rendering by making sure that if your web application works in Microsoft Edge, it will work in Unified Service Desk.

The advantages of using the Edge WebView2 Process hosting method are:

- Available on supported versions of the Windows operating system.
- Highly reliable.
- Easy to configure to host applications in Unified Service Desk.
- Switch seamlessly from one browser to another for your entire organization.
- Enhanced performance and memory optimization.

Also, administrators will be able to perform the following:

- Select Edge process as the hosting type for the organization.
- Select Edge process as the hosting type for select web applications, alongside Chrome process.

More information: [Use EdgeWebView2 Process to host web applications in Unified Service Desk](../edge-webview2-process.md)


### Recover an Edge WebView2 Process instance

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can help agents to recover the terminated (crashed) webpages hosted in Edge WebView2 Process in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

By default, Edge WebView2 Process instance recovery is enabled.

More information: [Recover an Edge WebView2 process instance](recover-edge-webview2-process-instance.md)

### Pool process instances for Edge WebView2 Process

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] always maintains a pool of Edge WebView2 Process instances for hosted controls to use. Opening a hosted control using a pooled Edge WebView2 Process instance enhances the performance of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

By default, the Edge WebView2 Process instance pooling is enabled.

With the Edge WebView2 Process instance pooling, every entity page navigation happens inline after the first entity page navigation.

::: moniker-end 

::: moniker range="dynamics-usd-4.1"

## What's new in Unified Service Desk 4.1.1.1433

This topic contains information about changes in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] for system administrators available in this version.

This release supports the Dynamics 365 model-driven apps deployed in Switzerland region.

## What's new in Unified Service Desk 4.1.1.1429

This topic contains information about changes in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] for system administrators available in this version.

- Enhancements for the Chrome Process hosting type include the following:

  * Unified Service Desk support for Chrome Process upgraded to Chromium version 84. More information: [Use Chrome Process to host web application](../chrome-process.md)
  * Support for editing PDFs (if the PDF has editable fields) with Chrome Process webpages. More information: [Edit PDF in chrome process](../chrome-process.md#edit-a-pdf-in-chrome-process)
  * Accessibility support for the Chrome Process web pages enhanced. More information: [Accessibility support with Chrome Process](../chrome-process.md#accessibility-support-with-chrome-process).
  * Confirmation messages displayed on close and save sessions. More information: [Enable the close confirmation dialog box with Chrome Process](../chrome-process.md#enable-the-close-confirmation-dialog-box-with-chrome-process) and [Enable the confirmation dialog box with Chrome Process](../chrome-process.md#enable-the-confirmation-dialog-box-with-chrome-process)
  * Open source parameters supported to enhance the performance of Chrome Process&ndash;based webpages. More information: [Add parameters using Chrome Process](../chrome-process.md#add-parameters-using-chrome-process).
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

The Administrator app, built based on the Unified Interface framework has the same configurational capabilities as the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] administrator in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Web Client. 

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Unified Service Desk Administrator App](../admin/unified-service-desk-administrator-app.md)

### Unified Interface Settings

Unified Interface Settings is a new configuration element introduced under the **Advanced Settings** in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Administrator app. Unified Interface Settings enables you as an administrator to configure the default Unified Interface App for your agents and transform the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sign-in experience.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Unified Interface Settings](../admin/unified-interface-settings.md)

### Show feedback window to agents
A feedback window is introduced in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to help an agent to provide feedback while closing the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application. Agents can provide feedback comments with the score and submit it to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)]. The comments are assessed and considered for improving the products and services.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage options for Unified Service Desk](../admin/manage-options-unified-service-desk.md)

::: moniker-end

::: moniker range="dynamics-usd-4"

## What's new in [!INCLUDE[pn-unified-service-desk-4-0](../../includes/pn-unified-service-desk-4-0.md)]

This topic contains information about changes in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] for system administrators available in this version. 

### Web Client - Unified Interface Migration Assistant
The Web Client - Unified Interface Migration Assistant for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] helps you migrate your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configurations from [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Web Client to a [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Unified Interface App.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Web Client - Unified Interface Migration Assistant](../admin/overview-migration-assistant.md)

### Prevent Accidental Closure of Unified Service Desk Unified Service Desk

While working on [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], accidentally if you select the **x** Close button, you may lose all the unsaved work. The Close Confirmation Window is introduced to prevent the accidental closure of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure close confirmation window for Unified Service Desk](../admin/configure-close-confirmation-window.md)

### Unified Interface KM Control

The **Unified Interface KM Control** hosted control is introduced for your knowledge base search experience with [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. You must configure the Unified Interface KM Control when you are using a Unified Interface App in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. 

Your service agents can use the **Unified Interface KM Control** hosted control to search and view knowledge base in Unified Interface from within the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. Also, you can position your search control in the main panel, left panel, or right panel of the Unified Interface Desk application. Also, you can configure the contextual actions for the search results.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Unified Interface KM Control (hosted control)](../unified-interface-km-control-hosted-control.md)

### Unified Blue theme for Unified Service Desk

The Unified Blue theme is the predefined theme for Unified Service Desk when you are using a Unified Interface App.

## Preview features

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

::: moniker range="dynamics-usd-3"

## What's new in [!INCLUDE[pn-unified-service-desk-3-3](../../includes/pn-unified-service-desk-3-3.md)]

This topic contains information about changes in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] for system administrators available in this version. 

#### Videos

See the video to know [What's New in Unified Service Desk 3.3](https://go.microsoft.com/fwlink/?linkid=2008774).

### Analyze best practices in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]

Best practices are the guidelines about System Configurations, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], Internet Explorer settings, and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configurations. Consider these guidelines as our recommended way to use [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and serve your customers.

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] analyzes the compliance of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] with best practice rules in certain categories. The [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] displays the results of analysis in the form of a report with severity levels, description of the parameter, and mitigation for the non-compliant / problematic areas.

The categories against which [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] analyzes the compliance of best practice rules are as follows:

- [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Configurations
- System configurations
- Internet Explorer settings

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] is available for the following [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] versions.


|                                                                                                                                          [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] version                                                                                                                                          |                                                                                                                                                      Availability                                                                                                                                                      |
|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                                                                                                                                          [!INCLUDE[pn-unified-service-desk-3-3](../../includes/pn-unified-service-desk-3-3.md)]                                                                                                                                          |                                                                                                  Available in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Web client demo package.                                                                                                  |
| [!INCLUDE[pn-unified-service-desk-3-2](../../includes/pn-unified-service-desk-3-2.md)]<br>[!INCLUDE[pn-unified-service-desk-3-1](../../includes/pn-unified-service-desk-3-1.md)]<br>[!INCLUDE[pn-unified-service-desk-3-0](../../includes/pn-unified-service-desk-3-0.md)]<br>[!INCLUDE[pn-unified-service-desk-2-2](../../includes/pn-unified-service-desk-2-2.md)]<br> | Available as a separate zip file for download, which you must copy and paste in your **PkgConfigs** folder and extract the package. Then execute the **Package Deployer** and configure the [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] hosted control and necessary actions. |

After the analysis, [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] displays a report that recommends mitigation steps in case of a warning or an error and help you determine your next steps. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when you handle the warning and error as recommended—this helps you to serve your customers without interruption.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Analyze best practices in Unified Service Desk](../admin/analyze-best-practices-unified-service-desk.md)

### Improve [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]

From this release, by default, the Help Improve [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] feature is enabled.

Improvement program data lets [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] send  application-specific information like product usage, health, and performance data to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)]. We use the information that we collect from the program to analyze and improve the service and product experience for our customers.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Improve Unified Service Desk](../admin/help-improve-unified-service-desk.md)

### Provide feedback about [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]

Have a comment or suggestion about [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]? We need your feedback to help us deliver a reliable product. Good or bad, the quickest route to get your comments to our team is right from within [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

In this release, you can configure a button in the toolbar and associate an action call to display the **Provide Feedback** window through which you can provide your suggestion, comments, or feedback.

The feedback window has smiley icons – Good, Normal, and Bad. You can select any one and type your feedback in the textbox and submit.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Provide feedback about Unified Service Desk](../admin/provide-feedback.md)

### Comply with the General Data Protection Regulation (GDPR)

The General Data Protection Regulation (GDPR) imposes new rules on organizations in the European Union (EU) and those that offer goods and services to people in the EU, or those that collect and analyze data tied to EU residents, regardless of where they are located.

As per the data definitions and stages are outlined in the GDPR, the data contained in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] are as follows: 

- **Audit log files.** The audit data log files are present in your local computer, or you can configure a path to store the file in your local computer or another computer in the network. In this case, you hold the responsibility to delete the Audit log files. 

- **Diagnostic log files.** The diagnostic logging records operational events and errors in the client application. UTF-8 encoded text files that are named **UnifiedServiceDesk-.log** are maintained at the following location on the client computer: 

`c:\Users\<UserName>\AppData\Roaming\Microsoft\Microsoft Dynamics 365 Unified Service Desk\<Version>`

In this case, you hold the responsibility to delete the Diagnostic log files. 

- **Telemetry data.** [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application collects telemetry data that is maintained in Microsoft Dataverse. In these cases, the natural or legal person, public authority, agency, or other body which, alone or jointly with others, becomes the controller, and the processor is [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)], which processes the data on behalf of the controller.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Comply with General Data Protection Regulation (GDPR)](../admin/comply-gdpr.md) and [Unified Service Desk data compliance under GDPR](../admin/comply-unified-service-desk-data-gdpr.md)

## What's new in [!INCLUDE[pn-unified-service-desk-3-2](../../includes/pn-unified-service-desk-3-2.md)]


### Performance enhancement for CRM page loads

With [!INCLUDE[pn-unified-service-desk-3-2](../../includes/pn-unified-service-desk-3-2.md)], you can experience enhanced performance of CRM entity page loading in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] with the Internet Explorer Pooling feature.

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] always maintains a pool of Internet Explorer instances for hosted controls to use. Opening a hosted control using a pooled Internet Explorer instance enhances the performance of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

By default, Internet Explorer pooling is disabled. To enable pooling, a System Administrator must configure the **InternetExplorerPooling** option on the **Active UII Options** page and set it to **true**. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Performance enhancement for CRM entity page loads](../../unified-service-desk/admin/performance-enhancement-CRM-entity-page-loads.md).

### [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] helps to recover an Internet Explorer process instance

With [!INCLUDE [pn-unified-service-desk-3-2](../../includes/pn-unified-service-desk-3-2.md)], [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can help agents to recover the terminated (crashed) webpages hosted in Internet Explorer process in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] 

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can help agents to recover the webpages in the following scenarios:

- When Internet Explorer closes abruptly.

- When you manually end an unresponsive Internet Explorer process instance from Task Manager.

- When a script on the hosted control that uses an `IE process` browser control takes time more than the timeout period ([IEWebPageInactivityTimeOut](../admin/recover-internet-explorer-process-instance.md#change-iewebpageinactivitytimeout-option)) for page navigation.

Internet Explorer process recovery enables you to recover any Internet Explorer process instance (which may have more than one webpage) that is unresponsive in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] application.

By default, Internet Explorer process instance recovery is enabled. To disable recovery, a System Administrator must configure the **IEWebPageRecovery** option on the **Active UII Options** page and set it to **false**. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Recover Internet Explorer process instance](../../unified-service-desk/admin/recover-internet-explorer-process-instance.md).

### Performance data collection using keyboard shortcuts and application configuration file

#### Collect performance data using keyboard shortcut 

Using keyboard shortcuts, agents can start and stop collecting data about operational events in a [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application. You can collect data in log files, which can be used to identify and troubleshoot performance issues. If you encounter performance issues, customer support may ask you to collect the performance data and send the log file to help troubleshoot the issue.

When agents start collecting the performance data using keyboard shortcut, the log files are generated with a unique performance session ID (GUID) on the client computer.

Agents working on the client computer can use **Ctrl+Alt+Q** to start and **Ctrl+Alt+P** to stop collecting the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] performance data. To change the default keyboard shortcut, a System Administrator must configure the new keyboard shortcut to start and stop collecting performance data. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Performance data collection](../../unified-service-desk/admin/performance-data-collection-using-keyboard-shortcut.md).

#### Collect startup performance data using application configuration file 

If you experience performance issues when starting [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], you can manually modify the application configuration file (UnifiedServiceDesk.exe.config) to start collecting the performance data to log files. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Performance data collection](../../unified-service-desk/admin/performance-data-collection-using-keyboard-shortcut.md).

### System administrator configurable UII options

With [!INCLUDE [pn-unified-service-desk-3-2](../../includes/pn-unified-service-desk-3-2.md)], new UII options are introduced that a system administrator can configure on the **Active UII Options** page. 

New UII options introduced in [!INCLUDE [pn-unified-service-desk-3-2](../../includes/pn-unified-service-desk-3-2.md)]:

1. IEWebPageRecovery
2. IEWebPageInactivityTimeOut
3. On-DemandIETerminationShortcut
4. InternetExplorerPooling
5. TotalRecordCountLimit

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage Options for Unified Service Desk](../admin/manage-options-unified-service-desk.md)

## What's new in [!INCLUDE[pn-unified-service-desk-3-1](../../includes/pn-unified-service-desk-3-1.md)]

### Support for the latest

[!INCLUDE [pn-unified-service-desk-3-1](../../includes/pn-unified-service-desk-3-1.md)] is compatible with the [!INCLUDE [pn-crm-9-0-0-online](../../includes/pn-crm-9-0-0-online.md)].

However, certain features in [!INCLUDE [pn-crm-9-0-0-online](../../includes/pn-crm-9-0-0-online.md)] are not fully supported in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. More information: [Unified Service Desk limitations](#limitations)

### Security enhancements: User session and access management

When agents host one or more [!INCLUDE [pn-dynamics-365](../../includes/pn-dynamics-365.md)] pages inside the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client using a hosted control of hosting type [IE Process](../ie-process.md), an inactivity or session timeout warning may appear. These warnings are based on the configured inactivity and session timeouts, and agents are signed out after the expiry period. This behavior is similar with that of the web client and after the expiry period agents must sign in to the application again to resume working. System administrators can change the default warning and session timeout values from the System Settings page in Dataverse. More information: [Security enhancements: User session and access management](/dynamics365/customer-engagement/admin/user-session-management)

The inactivity timeout setting does not apply to hosted controls of hosting type [Internal WPF](../internal-wpf.md) and the agent will not be signed out due to inactivity. However, the session timeout is still applicable and there will be no warning displayed before automatic sign out occurs due to session expiry. We recommend that you use hosted controls of type IE Process if session timeout is desired. 

> [!NOTE]
> We recommend you keep the session timeout default of 24 hours to avoid frequent agent sign outs when hosted controls of type Internal WPF are used. 

### Security enhancements: TLS requirements

Unified Service Desk clients connecting to the [!INCLUDE [pn-crm-9-0-0-online](../../includes/pn-crm-9-0-0-online.md)] instances will require Transport Layer Security (TLS) 1.2. More information: [Updates coming to the Dataverse connection security](https://blogs.msdn.microsoft.com/crm/2017/09/28/updates-coming-to-dynamics-365-customer-engagement-connection-security/)

<a name="limitations"></a>
### Unified Service Desk limitations with Dataverse

These are the limitations:
- **Unified Interface**: Apps built using Unified Interface are not supported with [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. More information: [Unified Interface framework for new apps](/dynamics365/get-started/whats-new/customer-engagement/new-in-july-2017-update#unified-interface-framework-for-new-apps)
- **Interactive Service Hub**: With the [!INCLUDE [pn-crm-9-0-0-online](../../includes/pn-crm-9-0-0-online.md)] release, Interactive Service Hub has been rebuilt as a Unified Interface app, and is called Customer Service Hub. This implies that [support](../interactive-service-hub-page-hosted-control.md) for the Interactive Service Hub in Unified Service Desk is available only if you are running earlier versions.

- **Embedded intelligence**: Although you can view information from the relationship assistant in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client, you cannot interact with the information in the client. More information: [Embedded intelligence](/dynamics365/customer-engagement/sales-enterprise/embedded-intelligence)
- **LinkedIn Sales Navigator for Microsoft Dynamics 365 Sales**:  This is not supported.
- **Multi-select option sets**: Although multi-select option sets display fine when hosted in Unified Service Desk (using [CRM Page](../crm-page-hosted-control.md) type of hosted control), you cannot change selections in multi-select option sets using the Unified Service Desk APIs.
- **URL addressability in business apps**:  Business apps (app modules) use the appid value in the URLs to refer to resources displayed in an app. For example: “https://<OrgName>.crm.dynamics.com/main.aspx?appid=b0f40cd2-22a6-e711-a94e-000d3a1a7a9b&pagetype=entitylist&etn=bookableresourcebooking.” Unified Service Desk does not support the usage of appid values in URLs to refer to a resource. More information: [Design custom business apps by using the app designer](/dynamics365/customer-engagement/customize/design-custom-business-apps-using-app-designer)

## What's new in [!INCLUDE [pn-unified-service-desk-3-0](../../includes/pn-unified-service-desk-3-0.md)]  

### Error  diagnostics reporting settings moved to Audit & Diagnostics Settings area  
 Previous versions maintained the error diagnostics reporting settings in the Options area of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] solution. With this release, to simplify configuration the error diagnostics reporting settings have been moved to the Audit & Diagnostics Settings area. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Diagnostics](../../unified-service-desk/admin/configure-auditing-diagnostics-unified-service-desk.md#create-an-audit--diagnostics-record-to-use-for-auditing)  

### Support for JAWS screen reader  
 You can now use the JAWS (Job Access With Speech) version 18 for Windows screen reader application for speech output with the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Accessibility in Unified Service Desk](/previous-versions/dynamicscrm-2016/admins-customizers-dynamics-365/mt826622(v=crm.8))  

::: moniker-end

## See also  
 [What’s New in Unified Service Desk for developers](../../unified-service-desk/what-s-new-in-unified-service-desk.md)
 [Overview of Unified Service Desk](../../unified-service-desk/admin/overview-unified-service-desk.md)   
 [Install and Deploy Unified Service Desk](../../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]