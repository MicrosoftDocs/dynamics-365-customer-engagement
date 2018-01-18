---
title: "Performance data collection using keyboard shortcuts | MicrosoftDocs"
description: "Learn about Unified Service Desk performance data collection to collect data about the operational events, errors, and performance in a client application and to create log files using keyboard shortcuts"
ms.custom: ""
ms.date: 01/25/2018
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
ms.assetid: E838A9E7-4ED6-44DF-B2E9-0A3E3A82EA4B
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# Performance data collection
[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] performance data collection enables you to collect data about operational events, errors, and performance in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application. Performance data collection creates log files to help you identify and troubleshoot performance issues or errors. If you encounter technical issues with [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], customer support may ask you send the log file to help troubleshoot the issue.

When you enable performance data collection, log files are maintained with a unique performance session ID (GUID) on the client computer. Example of performance session ID (GUID): **cv0ab1gg-1df3-7bd9-b5dt-1221d65r93w8**.
[comment]: <> (In the above paragraph, the first sentence was very long. I broke into two sentence, please make sure it makes sense.)
The path where the log files are maintained on the client computer:

```%APPDATA%\Roaming\Microsoft\Microsoft Dynamics 365 Unified Service Desk\<version>\USDPerformanceData_<TimeStamp>_<YYYY-MM-DD>```

> [!Note]
> Each time you start or stop collecting performance data, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] creates a new file with a performance session ID, which it maintains on the client computer.

<a name="BKMK_Configure_performance_data_collection_keyboard_shortcut"></a>
## Configure a performance data collection keyboard shortcut

An agent working on a client computer can start and stop collecting the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] performance data using keyboard shortcuts. By default, the keyboard shortcut to start performance data collection is **Ctrl+Alt+Q** and to stop performance data collection is **Ctrl+Alt+P**.

To change the default keyboard shortcut, a System Administrator needs to configure new keyboard shortcuts to start and stop collection of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] performance data.

To configure a new performance data collection keyboard shortcut:

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].

2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]
 
3. Open the Audit & Diagnostics Setting record in the **Audit & Diagnostics Settings** section.
    > [!Note]
    > If there is no existing record, create a new Audit & Diagnostics Setting record. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Create an Audit & Diagnostics record to use for diagnostics](../admin/configure-auditing-diagnostics-unified-service-desk.md).

4. Expand the **Diagnostics Settings** area to see **Performance Data Collection**.

5. Type the keyboard shortcut in the format _key1+key2+key3_ for the **On-Demand Begin Shortcut** field.
[comment]: <> (Did we need to add more information? I removed "Use." because it didn't have any instructions following it.)
6. Type the keyboard shortcut in the format _key1+key2+key3_ for the **On-Demand End Shortcut** field.

7. Click **Save & Close**.

<a name="BKMK_start_performance_data_collection_using_keyboard_shortcut"></a>
## Start performance data collection using a keyboard shortcut

1. Press **Ctrl+Alt+Q** or the configured keyboard shortcut to start collecting performance data. 
Unified Service Desk displays a window asking - **Do you want to start collecting performance data?**.
[comment]: <> (The sentence about the Unified Service Desk window is not an instruction so is not part of the numbered list. It is the result of step 1. OR, you can format it as a note.)
2. Click **Yes** to start collecting the performance data.

> [!Note]
> If you press **Ctrl+Alt+Q** after you start collecting performance data for a session, Unified Service Desk displays a window with a message - **Performance data collection has already started. PerfSessionId - XXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX**.

<a name="BKMK_stop_performance_data_collection_using_keyboard_shortcut"></a>
## Stop performance data collection using keyboard shortcut

1.	Press **Ctrl+Alt+P** or the configured keyboard shortcut to stop the collection of performance data.

2.	[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] displays a window with a message - **Do you want to stop collecting performance data? PerfSessionId - XXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX**.

3.	Click **Yes** to stop collecting the performance data.

> [!Note]
> If you press **Ctrl+Alt+P** after you stop collecting performance data for a session, Unified Service Desk displays a window **Performance data collection has already stopped**.

If you experience performance issues when starting [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], you can manually modify the application configuration file (UnifiedServiceDesk.exe.config) to generate log files and collect performance data.

To modify the application configuration file, change the value from **Off** to **Verbose** in the XML node. 

```<add name="Microsoft.Uii.Common.Performance" value="Verbose"/>```

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Diagnostics Verbosity Level](../admin/configure-auditing-diagnostics-unified-service-desk.md)

## See also

[Configure auditing and diagnostics in Unified Service Desk](../admin/configure-auditing-diagnostics-unified-service-desk.md)

[Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md)
