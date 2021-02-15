---
title: "Unified Service Desk configurations | MicrosoftDocs"
description: "Learn about the Unified Service Desk configurations that you make in Microsoft Dataverse on which the Best practices Analyer performs analysis and displays a report."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 04/24/2018
ms.topic: article
ms.service: dynamics-365-customerservice
---

# [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Configurations

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] analyzes the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configurations that you make in Microsoft Dataverse.

## Internal WPF Hosting Type
 
[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for **Internal WPF** hosting type hosted controls that you configure in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and displays a warning when one or more Internal WPF hosting type hosted controls are configured.

We recommend that you move the **Hosting Type** of all the hosted controls of component type **CRM Page** or **Standard Web Application** from **Internal WPF** to **IE Process**.

### Mitigation

For all the hosted controls of component type **CRM Page** or **Standard Web Application**, we recommend that you move the hosting type from **Internal WPF** to **IE Process**.

1. Sign in to the Dynamics 365 instance.
2. Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Hosted Controls**.
3. Select the applicable hosted controls from the list. </br>You can change the hosting type for only CRM Page and Standard Web Application hosted controls.
4. In the **Hosting Type** list, select **IE Process**.
5. Select **Save**.

## Actions Calls in PageLoadComplete Event

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks and displays a warning message when you associate any action calls with the **PageLoadComplete** event.

Action calls that are associated with the **PageLoadComplete** event occur several times per page load when an iFrame or frame is used on the CRM entity forms.

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when **PageLoadComplete** is replaced with a **BrowserDocumentComplete** or **DataReady** event if you're using this event for CRM entity forms.

### Mitigation

Replace the **PageLoadComplete** event with a **BrowserDocumentComplete** event or **DataReady** event if you're using it for CRM entity forms.

> [!Note]
> The **DataReady** event is available for use in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]
> 3.0 or later.

## Actions Calls with Events

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks and displays a warning when you associate 10 or more action calls with the events listed in the following table.

|Event|Description|
|-----------|------------|
|**DesktopReady**|A **DesktopReady** event occurs on startup after all the desktop initialization are complete and the connections to the server are established.
|**SessionNew**|A **SessionNew** event occurs when a new session is created.|
|**SessionActivated**|A **SessionActivated** event occurs when a new session is activated.|
|**SessionDeactivated**|A **SessionDeactivated** event occurs when a new session is deactivated.|
|**SessionClosed**|A **SessionClosed** event occurs when a session is closed.|

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when you associate 10 or fewer actions with any event.

### Mitigation

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] recommends optimizing to associate 10 or fewers action calls with **DesktopReady**, **SessionNew** **SessionActivated**, **SessionDeactivated**, and **SessionClosed** events.

## Number of Navigation Rules

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the number of navigation rules that you configure in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and displays a warning message when the value is more than **50**.

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when 50 or fewer navigation rules are configured.

### Mitigation

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] recommends optimizing the number of navigation rules in the range between 0 and 50.

## Show Script Errors (ShowScriptErrors)

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the **ShowScriptErrors** value and displays a warning message when the value is set to **true**.

When you enable Show Script Errors, you often see pop-up error messages.

To work without interruption, you can set the **ShowScriptErrors** value to **false**.

### Mitigation

Set **ShowScriptErrors** to **false**:

1. Sign in to the Dynamics 365 instance.
2. Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Options**
3. In the list of options, select **ShowScriptErrors**.
4. In the **Value** field, select **false**.
5. Select **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage Options for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]](https://docs.microsoft.com/dynamics365/customer-engagement/unified-service-desk/admin/manage-options-unified-service-desk)

## Client Caching

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the client caching option and displays a warning message when the field is blank.

You can use client caching to reduce the amount of bandwidth required during [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] startup.

### Mitigation

Enable client caching:

1. Sign in to the Dynamics 365 instance.
2. Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Options**
3. To create a new option, select **New** on the command bar.
4. For the new option, select **ClientCacheVersionNumber** in the **Name** box, and then type an alphanumeric number in the **Value** box. <br/>The alphanumeric value is used as the cache key for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. The alphanumeric value can be of any value but unique for each time you change.
5. Select **Save**.

> [!Note]
> When an agent launches the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client again, client caching isn't used. However, it doesn't delete or refresh the client cache store for the agent. When you remove the **DisableCaching** key for the agent, the agent returns to using the previously stored client cache store.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Enable client caching](https://docs.microsoft.com/dynamics365/customer-engagement/unified-service-desk/admin/configure-client-caching-unified-service-desk)

## Maximum Number of Sessions (maxNumberOfSessions)

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the **maxNumberOfSessions** option and displays a warning message or an error message in accordance with the following table.

|Severity| maxNumberOfSessions |
|---------|---------------------|
| Error   | 0                   |
| Error   | More than 5         |
| Warning | 4 or 5              |

**maxNumberOfSessions** indicates the maximum number of simultaneous sessions that each user can open using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when the **maxNumberOfSessions** value is more than **0** and less than or equal to **3**.

### Mitigation

Set the **maxNumberOfSessions** value to less than or equal to **3**: 

1. Sign in to the Dynamics 365 instance.
2. Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Options**
3. In the list of options, select **maxNumberOfSessions**.
4. In the **Value** field, type **3**.
5. Select **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage Options for Unified Service Desk](https://docs.microsoft.com/dynamics365/customer-engagement/unified-service-desk/admin/manage-options-unified-service-desk)

## Help Improve [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] (HelpImproveUSD)

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for `HelpImproveUSD` User Interface Integration (UII) option and displays a warning message when the value is set to **false**.

By using the Help Improve [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] program, organization-wide agents can send improvement program information to Microsoft. To enable the program, activate (set to **true**) the **HelpImproveUSD** option.

### Mitigation

Set `HelpImproveUSD` to **true**:

1. Sign in to the Dynamics 365 instance.
2. Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Options**
3. To create a new option, select **New** on the command bar.
4. On the New Option page, select **HelpImproveUSD** in the **Global Options** list.
5. In the **Value** field, select **true**.
6. Select **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Enable client caching](https://docs.microsoft.com/dynamics365/customer-engagement/unified-service-desk/admin/configure-client-caching-unified-service-desk)

## Internet Explorer Pooling (InternetExplorerPooling)

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the **InternetExplorerPooling** UII option and displays a warning message when the value is set to **false**.

Internet Explorer Pooling enhances performance of CRM entity page loading in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].<br> [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when the
**InternetExplorerPooling** option is set to **true**. You must configure the **InternetExplorerPooling** option to set it to **true**.

### Mitigation

Set the **InternetExplorerPooling** option to **true**:

1. Sign in to the Dynamics 365 instance.
2. Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Options**
3. On the **Active UII Options** page, select **New**.
4. In the **Global Option** field, select **Others**.
5. In the **Name** field, enter **InternetExplorerPooling**.
6. In the **Value** field, select **true**.
7. Select **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [**Enable Internet Explorer pooling**](https://docs.microsoft.com/dynamics365/customer-engagement/unified-service-desk/admin/performance-enhancement-crm-entity-page-loads)

## Activity Tracking Enabled

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the **Activity Tracking Enabled** option and displays a warning message when the option is disabled.

By using Activity Tracking Enabled options, you can track all the events for audit and diagnostic purposes.

### Mitigation

Enable the **Activity Tracking Enabled** option:

1. Sign in to the Dynamics 365 instance.
2. Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Audit & Diagnostics Settings**
3. In the **Audit Settings** section, select the **Activity Tracking Enabled** check box.
4. Select **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [**Auditing**](https://docs.microsoft.com/dynamics365/customer-engagement/unified-service-desk/admin/configure-auditing-diagnostics-unified-service-desk)

## Diagnostic Tracking Enabled

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the **Diagnostic Tracking Enabled** option and displays a warning message when the option is disabled.
By using **Diagnostic Tracking Enabled**, you can record operational events and errors in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] log files.

### Mitigation

Enable the **Diagnostic Tracking Enabled** option:

1. Sign in to the Dynamics 365 instance.
2. Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Audit & Diagnostics Settings**
3. In the **Diagnostic Settings** section, select the **Diagnostic Tracking Enabled** check box.
4. Select **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [**Diagnostics**](https://docs.microsoft.com/dynamics365/customer-engagement/unified-service-desk/admin/configure-auditing-diagnostics-unified-service-desk)

## Enable Exit Monitoring

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the **Enable Exit Monitoring** option and displays a warning message when the option is disabled.

**Enable Exit Monitoring** collects diagnostics logs and exit logs in the event of an exception in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.

### Mitigation

Enable the **Enable Exit Monitoring** option:

1. Sign in to the Dynamics 365 instance.
2. Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Audit & Diagnostics Settings**
3. In the **Diagnostic Settings** section, select the **Enable Exit Monitoring** check box.
4. Select **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [**Diagnostics**](https://docs.microsoft.com/dynamics365/customer-engagement/unified-service-desk/admin/configure-auditing-diagnostics-unified-service-desk)

## Enable Crash Dump Generation

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the **Enable Crash Dump Generation** option and displays a warning message when the option is disabled.

By using Enable Crash Dump Generation, you can collect dump files during a fatal exception of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

### Mitigation

Enable the **Enable Crash Dump Generation** option:

1. Sign in to the Dynamics 365 instance.
2. Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Audit & Diagnostics Settings**
3. In the **Diagnostic Settings** section, select the **Enable Crash Dump Generation** check box.
4. Select **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [**Diagnostics**](https://docs.microsoft.com/dynamics365/customer-engagement/unified-service-desk/admin/configure-auditing-diagnostics-unified-service-desk)  

## Internet Explorer Webpage Recovery (IEWebPageRecovery)

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the **IEWebPageRecovery** UII option and displays an error message when the option is set to **false**.

**IEWebPageRecovery** is an UII option that a system administrator can modify. The option helps recover unresponsive Internet Explorer webpages. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when the **IEWebPageRecovery** option is set to **true**.

### Mitigation

Set the `IEWebPageRecovery` option to **true**.

1. Sign in to the Dynamics 365 instance.
2. Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Options**
3. In the list of options, select **IEWebPageRecovery**.
4. In the **Value** field, select **true**.
5. Specify **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage Options for Unified Service Desk](https://docs.microsoft.com/dynamics365/customer-engagement/unified-service-desk/admin/manage-options-unified-service-desk)

## Process Termination Threshold (ProcessTerminationThreshold)

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the **ProcessTerminationThreshold** UII option and displays an error message when the value is set to **0**.

**ProcessTerminationThreshold** indicates the timeout period for the duration (in milliseconds) that the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] monitoring
process (usdmp.exe) waits before terminating an unresponsive Internet Explorer process, which also causes [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to become unresponsive. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when **ProcessTerminationThreshold** option is set between the range **0** and **30000**.

### Mitigation

Set the **ProcessTerminationThreshold** value between the range **0** and **30000**:

1. Sign in to the Dynamics 365 instance.
2. Go to **Settings** > **[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]** > **Options**
3. In the list of options, select **ProcessTerminationThreshold**.
4. In the **Value** field, type a value between **0** and **30000**.
5. Select **Save**.

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage Options for Unified Service Desk](https://docs.microsoft.com/dynamics365/customer-engagement/unified-service-desk/admin/manage-options-unified-service-desk)

## See also

[Analyze best practices in Unified Service Desk](../admin/analyze-best-practices-unified-service-desk.md)

[Download and install Best Practices Analyzer](../admin/download-install-best-practices-analyzer.md)

[Read Best Practices Analyzer report](../admin/read-best-practices-analyzer-report.md)

[List of rule categories and parameters](../admin/compliance-categories-parameters-bpa.md)

[System configurations](../admin/system-configurations-bpa.md)

[Internet Explorer settings](../admin/internet-explorer-settings-bpa.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]