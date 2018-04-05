---
title: "Internet Explorer Settings | MicrosoftDocs"
description: "Learn about the internet explorer settings that best practices outlines and against which Best Practices Analyzer performs analysis."
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
ms.assetid: "104DE14D-F43E-4414-AC83-5C1157E79831"
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] Settings

In the context of [!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] Client application, certain parameters of [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] settings are important for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to work seamlessly.

## Tab Process Growth (TabProcGrowth)

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the TabProcGrowth key in the Regedit and displays an error when the value is not set to 16.

Tab Process Growth (TabProcGrowth) is the rate at which [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] creates new tab processes. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when the value is 16.

### Mitigation

Set TabProcGrowth (Tab Process Growth) value to 16.

1. Open **C:/** > **[!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)]** > **regedit**.
2. Go to **Computer**\\**HKEY\_CURRENT\_USER**\\**Software**\\**Microsoft**\\**Internet Explorer**\\**Main.**
3. Right-click on **TabProcGrowth** and select **Modify** option.
    > [!Note]
    > If the key is not present, create the key.<br>
        1. Right-click on the blank area and select **New** > **DWORD (32-bit) Value**. You can see new file.<br>
        2. Type **TabProcGrowth** as file name, and **Modify**.

4. Specify **16** in the **Value data** field.
5. Click **OK**.

## Tab Shutdown Delay (TabShutdownDelay)

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the TabShutdownDelay key in the Regedit and displays an error when the key is enabled (value set to zero).

TabShutdownDelay is a key which causes [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] processes to terminate on demand. Setting the value other than zero means the TabShutdownDelay is enabled. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when TabShutdownDelay is disabled (value is set to zero).

### Mitigation

Set TabShutdownDelay (Tab Shutdown Delay) value to zero.

1.  Open **C:/** > **[!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)]** > **regedit**.
2.  Go to `Computer\HKEY\CURRENT\USER\Software\Microsoft\Internet Explorer\Main`.
3.  Right-click on **TabShutdownDelay** and select **Modify** option.<br>
       > [!NOTE]
       > If the key is not present, create the key.<br>
            1.  Right-click on the blank area and select **New** > **DWORD (32-bit) Value**. You can see new file.<br>
            2.  Type **TabShutdownDelay** as file name, and **Modify**.
4. Specify **0** in the **Value data** field.
5. Choose **Decimal** in the **Base** group box.
6. Click **OK**.

## Enable Enhanced Protected Mode

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the Enable Enhanced Protected Mode key in the Regedit and displays an error when the key is disabled (value set to PMIL).

Enable Enhanced Protected Mode is a security feature. When this feature is enabled, add-ons such as toolbars, and extensions are loaded only if they are compatible with Enhanced Protected Mode.

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when Enable Enhanced Protected Mode option is disabled (value is set to PMIL).

### Mitigation

Disable "Enable Enhanced Protected Mode" option.

You can disable the option in the following ways:

Disable through Registry (Regedit)

1.  Open **C:/** > **[!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)]** > **regedit**.
2.  Go to `Computer\HKEY\CURRENT\USER\Software\Microsoft\Internet Explorer\Main`.
3.  Right-click **Isolation** and select **Modify** option.
    > [!Note]
    > If the key is not present, create the key.<br>
        1.  Right-click on the blank area and select **New** > **String Value**. You can a see new file.<br>
        2.  Type **Isolation** as file name, and **Modify**.
4.  Specify **PMEM** in the **Value data** field.
5.  Click **OK**.

Enable through Internet Options

1.  Open **[!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)]**.
2.  Click **Tools** > **Internet Options** > **Advanced** tab.
3.  Clear the **Enable Enhanced Protected** Mode check box under **Security** section.
4.  Click **Apply** and then click **OK**.

## Enable Automatic Crash Recovery

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the Enable Automatic Crash Recovery key in the Regedit and displays an error when the key is enabled (value set to 0).

Enable automatic crash recovery is a feature that allows you to restore your previous browsing session in the event of crash.

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when Enable automatic crash recovery option is disabled (value is set to 2).

### Mitigation

Disable "Enable automatic crash recovery" option.

You can disable the option in the following ways:

Disable through Registry (Regedit)

1. Open **C:/** > **[!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)]** > **regedit**.
2. Go to `Computer\HKEY\CURRENT\USER\Software\Microsoft\Internet Explorer\Recovery`.
3.  Right-click on **AutoRecover** and select **Modify** option.
    > [!Note]
    > If the key is not present, create the key.<br>
        1.  Right-click on the blank area and select **New** > **String Value**. You can a see new file.<br>
        2.  Type **Isolation** as file name, and **Modify**.
4.  Specify **2** in the **Value data** field.
5.  Click **OK**.

Disable through Internet Options

1. Open **[!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)]**.
2. Click **Tools** > **Internet Options** > **Advanced** tab.
3. Clear the **Enable automatic crash recovery** Mode check box under **Security** section.
4. Click **Apply** and then click **OK**.

## Enable Protected Mode

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the Enable Protected Mode key in the Regedit and displays an error when the key is disabled (value set to 3).

Enable Protected Mode option is a security feature where [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] provides multiple layers of defense from untrustworthy access to the [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] process. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when Enable Protected Mode option is enabled (value is set to zero).

### Mitigation

Enable "Enable Protected Mode" option.

You can enable the option in the following ways:

Enable through Registry (Regedit)

1.  Open **C:/** > **[!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)]** > **regedit**.
2.  Go to `Computer\HKEY\CURRENT\USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\\\<numerically named key folder>`. <br>
Numerically named folders are as follows:<br>
    - 1 (Intranet zone)
    - 2 (Trusted Sites zone)
    - 3 (Internet zone)
    - 4 (Restricted Sites zone)
3.  Right-click on **2500** file and select **Modify** option.
    > [!Note] If the key is not present, create the key.<br>
        1. Right-click on the blank area and select **New** > **DWORD (32-bit) Value**. You can a see new file. <br>
        2. Type **2500** as file name, and **Modify**.
6.  Specify **0** in the **Value data** field.
7.  Click **OK**.

Enable through Internet Options

1. Open **[!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)]**.
2. Click **Tools** > **Internet Options** > **Security** tab.
3. Select a zone to change the security settings. <br>Following are the zones:<br>
    -   Internet
    -   Local intranet
    -   Trusted sites
    -   Restricted sites
4.  Select the **Enable Protected Mode** check box for the all the zones.
5.  Click **Apply** and then click **OK**.

## Cleanup HTCs

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the Cleanup HTCs key in the Regedit and displays an error when the key is disabled (value set to No).

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when Cleanup HTCs option is set to Yes.

### Mitigation

Set Cleanup HTCs option to Yes.

Set cleanup HTCs through Registry (Regedit)

1.  Go to **C:/** > **[!include[pn-ms-windows-short](../../includes/pn-ms-windows-short.md)]** > **regedit**
2.  Double-click to open **regedit**
3.  Go to `Computer\HKEY\CURRENT\USER\Software\Microsoft\Internet Explorer`.
4.  Right-click on **Cleanup HTCs** and select **Modify** option.
5.  Specify **Yes** in the **Value data** field.
6.  Click **OK**.

## [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] version

[!INCLUDE[pn-best-practices-analyzer](../../includes/pn-best-practices-analyzer.md)] checks for the [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] version and recommends using latest version of [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)].

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best with latest version of [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] 11. If you are running [!include[pn-windows-8-1](../../includes/pn-windows-8-1.md)] or [!include[pn-windows-10](../../includes/pn-windows-10.md)], you already have [!include[pn-ie-11](../../includes/pn-ie-11.md)].

### Mitigation

Use the latest version of [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)].

If you are running [!include[pn-windows-7](../../includes/pn-windows-7.md)] or lower version, visit the [!include[pn-internet-explorer](../../includes/pn-internet-explorer.md)] Downloads to download [!include[pn-ie-11](../../includes/pn-ie-11.md)].

[!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Internet Explorer Downloads](https://support.microsoft.com/en-us/help/17621/internet-explorer-downloads)