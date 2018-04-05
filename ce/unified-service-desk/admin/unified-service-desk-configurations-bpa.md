---
title: "Unified Service Desk configurations | MicrosoftDocs"
description: "Learn about the Unified Service Desk configurations that you make in Dynamics 365 on which the Best practices Analyer performs analysis and displays a report."
ms.custom: ""
ms.date: 04/15/2018
ms.service: "usd"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: "D390F342-BDD0-4921-959D-66D2CF822A59"
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Configurations

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] analyzes the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configurations that you make in Dynamics 365.

## Internal WPF Hosting Type
 
[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for Internal WPF hosting type hosted controls that you configure in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and displays a warning when one or more Internal WPF hosting type hosted controls are configured.

It is recommended you move Hosting Type of all the hosted controls of component type CRM page or Standard web application from Internal WPF to IE process.

### Mitigation

For all the hosted controls of component type CRM page or Standard web application, It is recommended to move Hosting Type from Internal WPF to IE process.

1. Sign in to Dynamics 365.
2. Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Hosted Controls**.
3. Select the applicable hosted controls from the list. </br>You can change only for **CRM Page** and **Standard web application** hosted controls.
4. Select **IE Process** from the **Hosting Type** list.
5. Click **Save**.

## Actions Calls in PageLoadComplete Event

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks and displays a warning when you associate any action calls with PageLoadDocument event.

Action Calls associated with PageLoadComplete event occurs several times per page load when an iFrame or frame is used on the CRM entity forms.

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when PageLoadComplete is replaced with BrowserDocumentComplete or DataReady event if you are using this event for CRM entity forms.

### Mitigation

Replace PageLoadComplete event with BrowserDocumentComplete event or DataReady event If you are using it for CRM entity forms.

> [!Note]
> DataReady event is available for use in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]
3.0 or higher version

## Actions Calls with Events

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks and displays a warning when you associate ten or more action calls with the following events.

|Event|Description|
|-----------|------------|
|DesktopReady|DesktopReady event occurs on startup when all the desktop initialization has completed and the connections to Dynamics 365 have been established.
|SessionNew|SessionNew is an event that occurs when a new session is created.|
|SessionActivated|SessionActivated is an event that occurs when a new session is activated.|
|SessionDeactivated|SessionDeactivated is an event that occurs when a new session is deactivated.|
|SessionClosed|SessionClosed is an event that occurs when a session is closed.|

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when you associate ten or less actions with any event.

### Mitigation

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] recommends optimizing to associate ten or less action calls with DesktopReady, SessionNew, SessionActivated, SessionDeactivated, and SessionClosed Event.

## Number of Navigation Rules

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the number navigation rules that you configure in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and displays a warning when the value more than 50.

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when 50 or less navigation rules are configured.

### Mitigation

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] recommends optimizing the number of navigation rules in the range inclusive 0-50.

## Show Script Errors

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for Show Script Errors (ShowScriptErrors) value and displays a warning when the value is set to true.

When you enable Show Script Errors option, you often see pop-up displaying the errors.

Setting Show Script Errors option to false enables you to work without interruption.

### Mitigation

Set `ShowScriptErrors` to false.

1.  Sign in to Dynamics 365.
2.  Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Options**.
3.  Choose **ShowScriptErrors** option from the list of options.
4.  Specify **false** in the **Value** filed.
5.  Click **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage Options for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/admin/manage-options-unified-service-desk)

## Client Caching

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for Client Caching option and displays a warning when the field is blank.

Client caching enables you to reduce the amount of bandwidth required at the startup of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

### Mitigation

Enable Client Caching.

1.  Sign in to Dynamics 365.
2.  Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Options**.
3.  Click **New** on the command bar to create a new option.
4.  For the new option, type **ClientCacheVersionNumber** in the **Name** box, and an alphanumeric number in the Value box. <br/>The
alphanumeric value is used as the cache key for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. The alphanumeric value can be of any value but unique for each time you change.
5.  Click **Save**.

> [!Note] 
> When agent launches [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client again, client caching is not used. However, it does not delete or refresh the client cache store for the agent. When you remove **DisableCaching** key for the agent, the agent returns to using the previously stored client cache store.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Enable client caching](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/admin/configure-client-caching-unified-service-desk)

## Maximum Number of Sessions (maxNumberOfSessions)

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for maxNumberOfSessions option and displays a warning or an error as per the following table.

|Severity| maxNumberOfSessions |
|---------|---------------------|
| Error   | 0                   |
| Error   | More than 5         |
| Warning | 4 or 5              |

maxNumberOfSesions indicates the maximum number of simultaneous sessions that each user can open using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when maxNumberOfSesions value is more than 0 and less than or equal to 3.

### Mitigation

Set maxNumberOfSesions value less than or equal to 3. 

1.  Sign in to Dynamics 365.
2.  Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Options**.
3.  Choose **maxNumberOfSesions** option from the list of options.
4.  Specify **3** in the **Value** filed.
5.  Click **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage Options for Unified Service Desk](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/admin/manage-options-unified-service-desk)

## Help Improve [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] (HelpImproveUSD)

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for `HelpImproveUSD` UII option and displays a warning when the value is set to false.

Help improve [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] program enables the organization-wide setting that allows user agents to send improvement program information to Microsoft. Activate (set to true) HelpImproveUSD to enable the option.

### Mitigation

Set `HelpImproveUSD` to true.

1.  Sign in to Dynamics 365.
2.  Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Options**.
3.  Click **New** on the command bar to create a new option.
4.  On the New Option page, select **HelpImproveUSD** in the Global Options list.
5.  Specify **true** in the **Value** filed.
6.  Click **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Enable client caching](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/admin/configure-client-caching-unified-service-desk)

## Internet Explorer Pooling (InternetExplorerPooling)

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the InternetExplorerPooling UII option and displays a warning when the value is set to false.

InternetExplorerPooling enhances performance of CRM entity page loading in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].<br> [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when
InternetExplorerPooling option is set to true. You must configure the InternetExplorerPooling option to set it to true.

### Mitigation

Set InternetExplorerPooling to true.

1.  Sign in to Dynamics 365.
2.  Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Options**.
3.  click **New** on the **Active UII Options** page.
4.  Choose **Others** for the **Global Option** field.
5.  Type **InternetExplorerPooling** for the **Name** field.
6.  Set **true** for the **Value** field.
7.  Click **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [**Enable Internet Explorer pooling**](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/admin/performance-enhancement-crm-entity-page-loads)

## Activity Tracking Enabled

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the Activity Tracking Enabled option and displays a warning when the option is disabled.

Activity Tracking Enabled options enables you to track all the events for audit and diagnostic purpose.

### Mitigation

Enable Activity Tracking Enabled option.

1.  Sign in to Dynamics 365.
2.  Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Audit & Diagnostics Settings**.
3.  In the **Audit Settings** section, select **Activity Tracking Enabled** check box.
4.  Click **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [**Auditing**](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/admin/configure-auditing-diagnostics-unified-service-desk)

## Diagnostic Tracking Enabled

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the Diagnostic Tracking Enabled option and displays a warning when the option is disabled.
Diagnostic Tracking Enabled enables you to record operational events and errors in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to log files.

### Mitigation

Enable Diagnostic Tracking Enabled option.

1.  Sign in to Dynamics 365.
2.  Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Audit & Diagnostics Settings**.
3.  In the **Diagnostic Settings** section, select **Diagnostic Tracking Enabled** check box.
4.  Click **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [**Diagnostics**](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/admin/configure-auditing-diagnostics-unified-service-desk)

## Enable Exit Monitoring

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the Enable Exit Monitoring option and displays a warning when the option is disabled.

Enable Exit Monitoring collects diagnostics logs and exit logs in the event of an exception in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.

### Mitigation

Enable Exit Monitoring option.

1.  Sign in to Dynamics 365.
2.  Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Audit & Diagnostics Settings**.
3.  In the **Diagnostic Settings** section, select **Enable Exit Monitoring** check box.
4.  Click **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [**Diagnostics**](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/admin/configure-auditing-diagnostics-unified-service-desk)

## Enable Crash Dump Generation

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the Enable Crash Dump Generation option and displays a warning when the option is disabled.

Enable Crash Dump Generation enables you to collect dump files during fatal exception of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

### Mitigation

Enable the option Enable Crash Dump generation.

1.  Sign in to Dynamics 365.
2.  Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Audit & Diagnostics Settings**.
3.  In the **Diagnostic Settings** section, select **Enable Crash Dump Generation** check box.
4.  Click **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [**Diagnostics**](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/admin/configure-auditing-diagnostics-unified-service-desk)  

## Internet Explorer Webpage Recovery

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the IEWebPageRecovery UII option and displays an error when the option is set to false.

IEWebPageRecovery is an UII option that a system administrator can modify. The option helps recovering an unresponsive Internet Explorer webpage. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when IEWebPageRecovery option is set to true.

### Mitigation

Set `IEWebPageRecovery` option to true.

1.  Sign in to Dynamics 365.
2.  Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Options**.
3.  Choose **IEWebPageRecovery** option from the list of options.
4.  Specify **true** in the **Value** filed.
5.  Click **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage Options for Unified Service Desk](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/admin/manage-options-unified-service-desk)

## Process Termination Threshold

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the ProcessTerminationThreshold UII option and displays an error when the value is set to 0.

ProcessTerminationThreshold Indicates the timeout period for the duration (in milliseconds) that the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] monitoring
process (usdmp.exe) waits before terminating an unresponsive Internet Explorer process, which also causes [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to become unresponsive. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when ProcessTerminationThreshold option is set between the range 0 and 30000.

### Mitigation

Set ProcessTerminationThreshold value between the range 0 and 30000.

1.  Sign in to Dynamics 365.
2.  Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Options**.
3.  Choose **ProcessTerminationThreshold** option from the list of options.
4.  Specify a value between 0 and 30000 in the **Value** filed.
5.  Click **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage Options for Unified Service Desk](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/admin/manage-options-unified-service-desk)