---
title: "Performance data collection using keyboard shortcuts | MicrosoftDocs"
description: "Learn about Unified Service Desk performance data collection to collect data about the operational events, errors, and performance in a client application and to create log files using keyboard shortcuts"
ms.custom: ""
ms.date: 02/06/2018
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
Starting with [!INCLUDE[pn-unified-service-desk-3-2](../../includes/pn-unified-service-desk-3-2.md)] performance data collection enables you to collect data about operational events in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application to log files, which is used to identify and troubleshoot performance issues.

> [!Note]
> If you encounter performance issues with [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], customer support may ask you to collect the performance data and send the log file to help troubleshoot the issue.

When you start collecting performance data, log files are generated with a unique performance session ID (GUID) on the client computer.

The default path where the log files are maintained on the client computer:

```%APPDATA%\Roaming\Microsoft\Microsoft Dynamics 365 Unified Service Desk\<version>\USDPerformanceData_<hhmmssfff>_<yyyy-mm-dd>```

You can change the default path of the log files from the application configuration file. In the XML node of the application configuration file, change the value of the following attributes. 

|Attribute|Default Value|New Value|
|:------|:------|:------|
|**Location**|**LocalUserApplicationDirectory**|**Custom**|
|**CustomLocation**|**-**|**<\New folder path in client computer>**<br> Example: C:\UnifiedServiceDesk\Logs|

Default XML node in the application configuration file:

`<add name="RollingPerfTraceListener" type="Microsoft.Crm.UnifiedServiceDesk.Dynamics.Utilities.Performance.RollingPerfTraceListener, Microsoft.Crm.UnifiedServiceDesk.Dynamics" BaseFileName="USDPerformanceData" Location="LocalUserApplicationDirectory" MaxFileSize ="52428800" MaxFileCount="10"/>`

Example of setting new path in the application configuration file:

`<add name="RollingPerfTraceListener" type="Microsoft.Uii.Common.Performance.RollingPerfTraceListener, Microsoft.Uii.Common" BaseFileName="USDPerformanceData" Location="Custom" CustomLocation="C:\UnifiedServiceDesk\Logs" MaxFileSize ="52428800" MaxFileCount="10"/>`

**MaxFileSize** is the maximum size (in bytes) of one performance log file that [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] maintains at the default or configured path in the client computer. When the size of performance log file is equal to **MaxFileSize** value, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] generates a new file in the default or configured path and continues to collect the performance data.

Example: You configure **MaxFileSize="52000000"**. When the size of performance log file is 52000000 bytes (52 MB), [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] generates a new performance log file in the default or configure path and continues to collect the performance data.

**MaxFileCount** is the count of files that [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] maintains at the default or configured path in client computer. When the count of the performance log file is equal to **MaxFileCount** value, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] deletes the oldest performance log file to generate the new performance log file in the default or configured path.

Example: You configure **MaxFileCount="10"**. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] generates 10 performance log files in the default or configured path. To generate a new performance log file, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] deletes the oldest performance log file and generates the new performance log file. At all times, the count of performance log files cannot exceed the **MaxFileCount**.


> [!Note]
> Each time you start collecting performance data, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] creates a new file with a performance session ID, which it maintains on the client computer.<br><br>

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

6. Type the keyboard shortcut in the format _key1+key2+key3_ for the **On-Demand End Shortcut** field.

7. Click **Save & Close**.

<a name="BKMK_collect_performance_data_using_keyboard_shortcut"></a>
## Collect performance data using a keyboard shortcut


### Start performance data collection using a keyboard shortcut

1. Press **Ctrl+Alt+Q** or the configured keyboard shortcut to start collecting performance data. 
Unified Service Desk displays a window asking - **Do you want to start collecting performance data?**.

   ![Do you want to start collecting performance data](../../unified-service-desk/media/usd-keyboard-shortcut-start-collecting-perf-data.PNG "Do you want to start collecting performance data")

    > [!Note]
    > When you press the keyboard shortcut and if [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] does not display the performance data collection starting window, then ensure the keyboard focus is not on the Internet Explorer Webpage. Press **Alt+0** to bring the keyboard focus outside the Internet Explorer webpage, and then press the keyboard shortcut to start the performance data collection. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md)

2. Click **Yes** to start collecting the performance data.

> [!Note]
> If you press **Ctrl+Alt+Q** after you start collecting performance data for a session, Unified Service Desk displays a window with a message - **Performance data collection has already started. PerfSessionId - XXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX**.
> ![Performance data collection already started](../../unified-service-desk/media/usd-keyboard-shortcut-already-started-collecting-perf-data.PNG "Performance data collection already started")


### Stop performance data collection using keyboard shortcut

1.	Press **Ctrl+Alt+P** or the configured keyboard shortcut to stop the collection of performance data.</br>
[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] displays a window with a message - **Do you want to stop collecting performance data? PerfSessionId - XXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX**.

    ![Do you want to stop collecting performance data](../../unified-service-desk/media/usd-keyboard-shortcut-stop-collecting-perf-data.PNG "Do you want to stop collecting performance data")

2.	Click **Yes** to stop collecting the performance data.

> [!Note]
> If you press **Ctrl+Alt+P** after you stop collecting performance data for a session, Unified Service Desk displays a window **Performance data collection has already stopped**.
> ![Performance data collection already stopped](../../unified-service-desk/media/usd-keyboard-shortcut-already-stopped-collecting-perf-data.PNG "Performance data collection already stopped")

<a name="BKMK_collect__startup_performance_data_using_application_configuration_file"></a>
## Collect startup performance data using application configuration file

If you experience performance issues when starting [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], you can manually modify the application configuration file (UnifiedServiceDesk.exe.config) to start collecting the performance data to log files.

To start collecting the startup performance data, change the value in application configuration file from **Off** to **Verbose** in the XML node.

```<add name="Microsoft.Uii.Common.Performance" value="Verbose"/>```

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Diagnostics Verbosity Level](../admin/configure-auditing-diagnostics-unified-service-desk.md)

## See also

[Configure auditing and diagnostics in Unified Service Desk](../admin/configure-auditing-diagnostics-unified-service-desk.md)

[Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md)