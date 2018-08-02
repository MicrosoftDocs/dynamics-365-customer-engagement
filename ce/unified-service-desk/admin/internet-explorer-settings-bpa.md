---
title: "Internet Explorer settings (Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about the Internet Explorer settings that best practices outlines and against which Best Practices Analyzer performs analysis."
ms.custom: ""
ms.date: 05/07/2018
ms.service: "usd"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 104DE14D-F43E-4414-AC83-5C1157E79831
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] settings

In the context of [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] and the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application, certain parameters of [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] settings are important for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to work seamlessly.

## Tab Process Growth (TabProcGrowth)

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the **TabProcGrowth** registry key and displays an error message when the value isn't set to **16**.

Tab Process Growth is the rate at which [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] creates new tab processes. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when the value is **16**.

### Mitigation

Set **TabProcGrowth** value to **16**:

1. Open **C:/** > **[!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)]** > **regedit**.
2. Go to **Computer**\\**HKEY\_CURRENT\_USER**\\**Software**\\**Microsoft**\\**Internet Explorer**\\**Main**.
3. Right-click **TabProcGrowth**, and then select **Modify**.
    > [!Note]
    > If the registry key isn't present, create it:<br>
        1. Right-click the blank area, and then select **New** > **DWORD (32-bit) Value**. You can see new file.<br>
        2. Type **TabProcGrowth** as the file name, and then select **Modify**.

4. In the **Value data** field, type **16**.
5. Select **OK**.

## Tab Shutdown Delay (TabShutdownDelay)

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the **TabShutdownDelay** registry key and displays an error message when the key is enabled (value set to **0**).

Tab Shutdown Delay causes the [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] processes to terminate on demand. If the value isn't set to zero, Tab Shutdown Delay is enabled. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when Tab Shutdown Delay is disabled (value set to **0**).

### Mitigation

Set **TabShutdownDelay** value to **0**:

1.  Open **C:/** > **[!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)]** > **regedit**.
2.  Go to `Computer\HKEY\CURRENT\USER\Software\Microsoft\Internet Explorer\Main`.
3.  Right-click **TabShutdownDelay**, and then select **Modify**.
    > [!NOTE]
    > If the registry key isn't present, create it:<br>
        1.  Right-click the blank area, and then select **New** > **DWORD (32-bit) Value**. You can see new file.<br>
        2.  Type **TabShutdownDelay** as the file name, and then select **Modify**.

4. In the **Value data** field, type **0**.
5. In the **Base** group box, select **Decimal**.
6. Select **OK**.

## Enable Enhanced Protected Mode

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for Enable Enhanced Protected Mode by checking for the **Isolation** registry key and displays an error message when the key is enabled (value set to **PMEM**).

Enable Enhanced Protected Mode is a security feature. When this feature is enabled, add-ons such as toolbars and extensions are loaded only if they're compatible with Enhanced Protected Mode.

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when Enable Enhanced Protected Mode is disabled (value set to **PMIL**).

### Mitigation

Disable **Enable Enhanced Protected Mode**.

You can disable the option using the Registry Editor or Internet options.

To disable **Enable Enhanced Protected Mode** using the Registry Editor:

1.  Open **C:/** > **[!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)]** > **regedit**.
2.  Go to `Computer\HKEY\CURRENT\USER\Software\Microsoft\Internet Explorer\Main`.
3.  Right-click **Isolation**, and then select **Modify**.
    > [!Note]
    > If the registry key isn't present, create it:<br>
        1.  Right-click the blank area, and then select **New** > **String Value**. You can a see new file.<br>
        2.  Type **Isolation** as the file name, and then select **Modify**.

4.  In the **Value data** field, type **PMIL**. 
5.  Select **OK**.

To disable the option using Internet options:

1.  Open **[!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)]**.
2.  Select **Tools** > **Internet Options** > **Advanced** tab.
3.  In the **Security** section, clear the **Enable Enhanced Protected Mode** check box.
4.  Select **Apply**, and then select **OK**.

## Enable Automatic Crash Recovery

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for Enable Automatic Crash Recovery by checking for the **AutoRecover** registry key and displays an error message when the key is enabled (value set to 0).

Enable Automatic Crash Recovery is a feature that allows you to restore your previous browsing session in the event of crash.

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when Enable Automatic Crash Recovery is disabled (value is set to **2**).

### Mitigation

Disable the **Enable Automatic Crash Recovery** option.

You can disable the option using the Registry Editor or Internet options.

To disable the option using the Registry Editor:

1. Open **C:/** > **[!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)]** > **regedit**.
2. Go to `Computer\HKEY\CURRENT\USER\Software\Microsoft\Internet Explorer\Recovery`.
3.  Right-click **AutoRecover**, and then select **Modify**.
    > [!Note]
    > If the registry key isn't present, create it:<br>
        1.  Right-click the blank area, and then select **New** > **String Value**. You can a see new file.<br>
        2.  Type **Isolation** as the file name, and then select **Modify**.

4.  In the **Value data** field, type **2**.
5.  Select **OK**.

To disable the option using Internet options:

1. Open [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)].
2. Select **Tools** > **Internet Options** > **Advanced** tab.
3. In the **Browsing** section, clear the **Enable automatic crash recovery** check box.
4. Select **Apply**, and then select **OK**.

## Enable Protected Mode

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for Enable Protected Mode by checking for the **2500** registry key and displays an error message when the key is disabled (value set to **3**).

Enable Protected Mode is a security feature where [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] provides multiple layers of defense from untrustworthy access to the [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] process. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when Enable Protected Mode is enabled (value is set to **0**).

### Mitigation

Enable the **Enable Protected Mode** option.

You can enable the option using the Registry Editor or Internet options.

To enable the option using the Registry Editor:

1.  Open **C:/** > **[!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)]** > **regedit**.
2.  Go to `Computer\HKEY\CURRENT\USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\\\<numerically named key folder>`. <br>
Numerically named folders are as follows:<br>
    - 1 (Intranet zone)
    - 2 (Trusted Sites zone)
    - 3 (Internet zone)
    - 4 (Restricted Sites zone)
3.  Right-click the **2500** file, and then select **Modify**.
    > [!Note] 
    > If the registry key isn't present, create it:<br>
        1. Right-click the blank area, and then select **New** > **DWORD (32-bit) Value**. You can a see new file. <br>
        2. Type **2500** as the file name, and then select **Modify**.

6.  In the **Value data** field, type **0**..
7.  Select **OK**.

To enable the option using Internet options:

1. Open **[!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)]**.
2. Select **Tools** > **Internet Options** > **Security** tab.
3. Select a zone to change the security settings. <br>Following are the zones:<br>
    -   Internet
    -   Local intranet
    -   Trusted sites
    -   Restricted sites
4.  Select the **Enable Protected Mode** check box for the all the zones.
5.  Select **Apply**, and then select **OK**.

## Cleanup HTCs

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the **Cleanup HTCs** registry key and displays an error message when the key is disabled (value set to **No**).

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when the **Cleanup HTCs** option is set to **Yes**.

### Mitigation

Set the **Cleanup HTCs** option to **Yes**:

1.  Go to **C:/** > **[!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)]** > **regedit**
2.  Double-click to open **regedit**.
3.  Go to `Computer\HKEY\CURRENT\USER\Software\Microsoft\Internet Explorer`.
4.  Right-click **Cleanup HTCs**, and then select **Modify**.
5.  In the **Value data** field, select **Yes**.
6.  Select **OK**.

## [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] version

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] version and recommends using the latest version of [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)].

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best with the latest version of [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] 11. If you are running [!include[pn-windows-8-1](../../includes/pn-windows-8-1.md)] or [!include[pn-windows-10](../../includes/pn-windows-10.md)], you already have [!include[pn-ie-11](../../includes/pn-ie-11.md)].

### Mitigation

Use the latest version of [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)].

If you're running [!include[pn-windows-7](../../includes/pn-windows-7.md)] or earlier, download [!include[pn-ie-11](../../includes/pn-ie-11.md)].

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Internet Explorer Downloads](https://support.microsoft.com/en-us/help/17621/internet-explorer-downloads)

## See also

[Analyze best practices in Unified Service Desk](../admin/analyze-best-practices-unified-service-desk.md)

[Download and install Best Practices Analyzer](../admin/download-install-best-practices-analyzer.md)

[Read Best Practices Analyzer report](../admin/read-best-practices-analyzer-report.md)

[Best practice rule categories and parameters](../admin/compliance-categories-parameters-bpa.md)

[System configurations](../admin/system-configurations-bpa.md)

[Unified Service Desk configurations](../admin/unified-service-desk-configurations-bpa.md)