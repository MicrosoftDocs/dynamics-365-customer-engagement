---
title: "What's new in Unified Service Desk for Dynamics 365 Customer Engagement for administrators | MicrosoftDocs"
description: "Learn about new Unified Service Desk features for Dynamics 365 Customer Engagement" 
ms.custom: ""
ms.date: 04/24/2018
ms.reviewer: ""
ms.service: "usd"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 57f18bf9-1e28-481b-9d78-f2adaf281e16
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# New feature information for administrators
This topic contains information about changes in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] for system administrators available in this version.  

<a name="NewIn330"></a>
## What's new in [!INCLUDE[pn-unified-service-desk-3-3](../../includes/pn-unified-service-desk-3-3.md)]

### Analyze best practices in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]

Best practices are the guidelines about System Configurations, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], Internet Explorer settings, and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configurations in Dynamics 365 Customer Engagement. Consider these guidelines as our recommended way to use [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and serve your customers.

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] analyzes the compliance of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] with best practice rules in certain categories. The [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] displays the results of analysis in the form of a report with severity levels, description of the parameter, and mitigation for the non-compliant / problematic areas.

The categories against which [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] analyzes the compliance of best practice rules are as follows:

- [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Configurations
- System configurations
- Internet Explorer settings

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] is available for the following [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] versions.

|[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] version|Availability|
|------------|-----------|
|[!INCLUDE[pn-unified-service-desk-3-3](../../includes/pn-unified-service-desk-3-3.md)]|Available in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Web client demo package. |
|[!INCLUDE[pn-unified-service-desk-3-2](../../includes/pn-unified-service-desk-3-2.md)]<br>[!INCLUDE[pn-unified-service-desk-3-1](../../includes/pn-unified-service-desk-3-1.md)]<br>[!INCLUDE[pn-unified-service-desk-3-0](../../includes/pn-unified-service-desk-3-0.md)]<br>[!INCLUDE[pn-unified-service-desk-2-2](../../includes/pn-unified-service-desk-2-2.md)]<br>|Available as a separate zip file for download, which you must copy and paste in your **PkgConfigs** folder and extract the package. Then execute the **Package Deployer** and configure the [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] hosted control and necessary actions.|

After the analysis, [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] displays a report that recommends mitigation steps in case of a warning or an error and help you determine your next steps. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when you handle the warning and error as recommended—this helps you to serve your customers without interruption.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Analyze best practices in Unified Service Desk](../admin/analyze-best-practices-unified-service-desk.md)

### Improve [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]

From this release, by default, the Help Improve [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] feature is enabled.

Improvement program data lets [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] send  application-specific information like product usage, health, and performance data to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)]. We use the information that we collect from the program to analyze and improve the service and product experience for our customers.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Help improve Unified Service Desk](../admin/help-improve-unified-service-desk.md)

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

- **Telemetry data.** [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application collects telemetry data that is maintained in [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)] [!include[pn-dynamics-crm](../../includes/pn-dynamics-crm.md)]. In these cases, the natural or legal person, public authority, agency, or other body which, alone or jointly with others, becomes the controller, and the processor is [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)], which processes the data on behalf of the controller.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Comply with General Data Protection Regulation (GDPR)](../admin/comply-gdpr.md) and [Unified Service Desk data compliance under GDPR](../admin/comply-unified-service-desk-data-gdpr.md)

<a name="NewIn320"></a>
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

<a name="NewIn310"></a>  
## What's new in [!INCLUDE[pn-unified-service-desk-3-1](../../includes/pn-unified-service-desk-3-1.md)]

 Administrators will be able  to leverage the following enhancements and new capabilities in this release. 

### Support for the latest

[!INCLUDE [pn-unified-service-desk-3-1](../../includes/pn-unified-service-desk-3-1.md)] is compatible with the [!INCLUDE [pn-crm-9-0-0-online](../../includes/pn-crm-9-0-0-online.md)].

However, certain features in [!INCLUDE [pn-crm-9-0-0-online](../../includes/pn-crm-9-0-0-online.md)] are not fully supported in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. More information: [Unified Service Desk limitations with Dynamics 365 (online), version 9.0](#limitations)

### Security enhancements: User session and access management

When agents host one or more [!INCLUDE [pn-dynamics-365](../../includes/pn-dynamics-365.md)] pages inside the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client using a hosted control of hosting type [IE Process](../select-a-hosting-method-for-your-controls.md#ie-process), an inactivity or session timeout warning may appear. These warnings are based on the configured inactivity and session timeouts in [!INCLUDE [pn-dyn-365-online](../../includes/pn-crm-online.md)] and agents are signed out after the expiry period. This behavior is similar with that of the [!INCLUDE [pn-dyn-365-online](../../includes/pn-crm-online.md)] web client and after the expiry period agents must sign in to the application again to resume working. System administrators can change the default warning and session timeout values from the System Settings page in [!INCLUDE [pn-dyn-365-online](../../includes/pn-crm-online.md)]. More information: [Security enhancements: User session and access management](../../admin/user-session-management.md)

The inactivity timeout setting does not apply to hosted controls of hosting type [Internal WPF](../select-a-hosting-method-for-your-controls.md#internal-wpf) and the agent will not be signed out due to inactivity. However, the session timeout is still applicable and there will be no warning displayed before automatic sign out occurs due to session expiry. We recommend that you use hosted controls of type IE Process if session timeout is desired. 

> [!NOTE]
> We recommend you keep the session timeout default of 24 hours to avoid frequent agent sign outs when hosted controls of type Internal WPF are used. 

### Security enhancements: TLS requirements

Unified Service Desk clients connecting to the [!INCLUDE [pn-crm-9-0-0-online](../../includes/pn-crm-9-0-0-online.md)] instances will require Transport Layer Security (TLS) 1.2. More information: [Updates coming to Dynamics 365 Customer Engagement connection security](https://blogs.msdn.microsoft.com/crm/2017/09/28/updates-coming-to-dynamics-365-customer-engagement-connection-security/)

<a name="limitations"></a>
### Unified Service Desk limitations with Dynamics 365 (online), version 9.0

These are the limitations:
- **Unified Interface**: Apps built using Unified Interface are not supported with [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. More information: [Unified Interface framework for new apps](/dynamics365/get-started/whats-new/customer-engagement/new-in-july-2017-update#unified-interface-framework-for-new-apps)
- **Interactive Service Hub**: With the [!INCLUDE [pn-crm-9-0-0-online](../../includes/pn-crm-9-0-0-online.md)] release, Interactive Service Hub has been rebuilt as a Unified Interface app, and is called Customer Service Hub. This implies that [support](../interactive-service-hub-page-hosted-control.md) for the Interactive Service Hub in Unified Service Desk is available only if you are running Dynamics 365, version 8.2 or an earlier supported version of Microsoft Dynamics CRM.
- **Embedded intelligence**: Although you can view information from the relationship assistant in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client, you cannot interact with the information in the client. More information: [Embedded intelligence](../../sales-enterprise/embedded-intelligence.md)
- **LinkedIn Sales Navigator for Microsoft Dynamics 365 for Sales**:  This is not supported.
- **Multi-select option sets**: Although multi-select option sets display fine when hosted in Unified Service Desk (using [CRM Page](../crm-page-hosted-control.md) type of hosted control), you cannot change selections in multi-select option sets using the Unified Service Desk APIs.
-  **URL addressability in business apps**:  Business apps (app modules) use the appid value in the URLs to refer to resources displayed in an app. For example: “https://<OrgName>.crm.dynamics.com/main.aspx?appid=b0f40cd2-22a6-e711-a94e-000d3a1a7a9b&pagetype=entitylist&etn=bookableresourcebooking.” Unified Service Desk does not support the usage of appid values in URLs to refer to a resource. More information: [Design custom business apps by using the app designer](../../customize/design-custom-business-apps-using-app-designer.md)

  
<a name="NewIn222"></a>   
## What's new in [!INCLUDE [pn-unified-service-desk-3-0](../../includes/pn-unified-service-desk-3-0.md)]  
 Administrators will be able  to leverage the following enhancements and new capabilities in this release.  
  
### Error  diagnostics reporting settings moved to Audit & Diagnostics Settings area  
 Previous versions maintained the error diagnostics reporting settings in the Options area of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] solution. With this release, to simplify configuration the error diagnostics reporting settings have been moved to the Audit & Diagnostics Settings area. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Diagnostics](../../unified-service-desk/admin/configure-auditing-diagnostics-unified-service-desk.md#BKMK_Diagnostics)  
  
### Support for JAWS screen reader  
 You can now use the JAWS (Job Access With Speech) version 18 for Windows screen reader application for speech output with the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Accessibility in Unified Service Desk](https://go.microsoft.com/fwlink/?linkid=826563)  
  
## See also  
 [What’s New in Unified Service Desk for developers](../../unified-service-desk/what-s-new-in-unified-service-desk.md)
 [Overview of Unified Service Desk](../../unified-service-desk/admin/overview-unified-service-desk.md)   
 [Install and Deploy Unified Service Desk](../../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md)