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
# Internet Explorer Settings

In the context of Best Practices Analyzer and Unified Service Desk Client application, certain parameters of Internet Explorer settings are important for Unified Service Desk to work seamlessly.

### Tab Process Growth (TabProcGrowth)

Best Practices Analyzer checks for the TabProcGrowth key in the Regedit and displays an error when the value is not set to 16.

Tab Process Growth (TabProcGrowth) is the rate at which Internet Explorer creates new tab processes. Unified Service Desk works best when the value is 16.

#### Mitigation

Set TabProcGrowth (Tab Process Growth) value to 16.

 

1. Open C:/ > **Windows** > **regedit**.

2. Go to **Computer**\\**HKEY\_CURRENT\_USER**\\**Software**\\**Microsoft**\\**Internet Explorer**\\**Main.**

3. Right-click on **TabProcGrowth** and select **Modify** option.

> [!Note]
> If the key is not present, create the key.

1. Right-click on the blank area and select **New** &gt; **DWORD
    > (32-bit) Value**. You can see new file.

2.  Type **TabProcGrowth** as file name, and **Modify**.

<!-- -->

1.  Specify **16** in the **Value data** field.

2.  Click **OK**.

### Tab Shutdown Delay (TabShutdownDelay)

Best Practices Analyzer checks for the TabShutdownDelay key in the
Regedit and displays an error when the key is enabled (value set to
zero).

TabShutdownDelay is a key which causes Internet Explorer processes to
terminate on demand. Setting the value other than zero means the
TabShutdownDelay is enabled. Unified Service Desk works best when
TabShutdownDelay is disabled (value is set to zero).

#### Mitigation

Set TabShutdownDelay (Tab Shutdown Delay) value to zero.

 

1.  Open **C:/** &gt; **Windows** &gt; **regedit**.

2.  Go to
    > **Computer**\\**HKEY\_CURRENT\_USER**\\**Software**\\**Microsoft**\\**Internet
    > Explorer**\\**Main.**

3.  Right-click on **TabShutdownDelay** and select **Modify** option.

> Note: If the key is not present, create the key.

1.  Right-click on the blank area and select **New** &gt; **DWORD
    > (32-bit) Value**. You can see new file.

2.  Type **TabShutdownDelay** as file name, and **Modify**.

<!-- -->

1.  Specify **0** in the **Value data** field.

2.  Choose **Decimal** in the **Base** group box.

3.  Click **OK**.

### Enable Enhanced Protected Mode

Best Practices Analyzer checks for the Enable Enhanced Protected Mode
key in the Regedit and displays an error when the key is disabled (value
set to PMIL).

Enable Enhanced Protected Mode is a security feature. When this feature
is enabled, add-ons such as toolbars, and extensions are loaded only if
they are compatible with Enhanced Protected Mode.

 

Unified Service Desk works best when Enable Enhanced Protected Mode
option is disabled (value is set to PMIL).

#### Mitigation

Disable "Enable Enhanced Protected Mode" option.

You can disable the option in the following ways:

 

Disable through Registry (Regedit)

1.  Open **C:/** &gt; **Windows** &gt; **regedit**.

2.  Go to
    > **Computer**\\**HKEY\_CURRENT\_USER**\\**Software**\\**Microsoft**\\**Internet
    > Explorer**\\**Main**

3.  Right-click **Isolation** and select **Modify** option.

> Note: If the key is not present, create the key.

1.  Right-click on the blank area and select **New** &gt; **String
    > Value**. You can a see new file.

2.  Type **Isolation** as file name, and **Modify**.

<!-- -->

1.  Specify **PMEM** in the **Value data** field.

2.  Click **OK**.

Enable through Internet Options

1.  Open **Internet Explorer**.

2.  Click **Tools** &gt; **Internet Options** &gt; **Advanced** tab.

3.  Clear the **Enable Enhanced Protected** Mode check box under
    > **Security** section.

4.  Click **Apply** and then click **OK**.

### Enable Automatic Crash Recovery

Best Practices Analyzer checks for the Enable Automatic Crash Recovery
key in the Regedit and displays an error when the key is enabled (value
set to 0).

Enable automatic crash recovery is a feature that allows you to restore
your previous browsing session in the event of crash.

Unified Service Desk works best when Enable automatic crash recovery
option is disabled (value is set to 2).

#### Mitigation

Disable "Enable automatic crash recovery" option.

You can disable the option in the following ways:

Disable through Registry (Regedit)

1.  Open **C:/** &gt; **Windows** &gt; **regedit**.

2.  Go to **Computer\\HKEY\_CURRENT\_USER\\Software\\Microsoft\\Internet
    > Explorer\\Recovery.**

3.  Right-click on **AutoRecover** and select **Modify** option.

> Note: If the key is not present, create the key.

1.  Right-click on the blank area and select **New** &gt; **String
    > Value**. You can a see new file.

2.  Type **Isolation** as file name, and **Modify**.

<!-- -->

1.  Specify **2** in the **Value data** field.

2.  Click **OK**.

Disable through Internet Options

1.  Open **Internet Explorer**.

2.  Click **Tools** &gt; **Internet Options** &gt; **Advanced** tab.

3.  Clear the **Enable automatic crash recovery** Mode check box under
    > **Security** section.

4.  Click **Apply** and then click **OK**.

### Enable Protected Mode

Best Practices Analyzer checks for the Enable Protected Mode key in the
Regedit and displays an error when the key is disabled (value set to 3).

Enable Protected Mode option is a security feature where Internet
Explorer provides multiple layers of defense from untrustworthy access
to the Internet Explorer process. Unified Service Desk works best when
Enable Protected Mode option is enabled (value is set to zero).

#### Mitigation

Enable "Enable Protected Mode" option.

You can enable the option in the following ways:

 

Enable through Registry (Regedit)

1.  Open **C:/** &gt; **Windows** &gt; **regedit**.

2.  Go to
    > **Computer\\HKEY\_CURRENT\_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet
    > Settings\\Zones\\&lt;numerically named key folder&gt;.**

> Numerically named folders are as follows:

-   1 (Intranet zone)

-   2 (Trusted Sites zone)

-   3 (Internet zone)

-   4 (Restricted Sites zone)

1.  Right-click on **2500** file and select **Modify** option.

> Note: If the key is not present, create the key.

1.  Right-click on the blank area and select **New** &gt; **DWORD
    > (32-bit) Value**. You can a see new file.

2.  Type **2500** as file name, and **Modify**.

<!-- -->

1.  Specify **0** in the **Value data** field.

2.  Click **OK**.

Enable through Internet Options

1.  Open **Internet Explorer**.

2.  Click **Tools** &gt; **Internet Options** &gt; **Security** tab.

3.  Select a zone to change the security settings.

> Following are the zones:

-   Internet

-   Local intranet

-   Trusted sites

-   Restricted sites

1.  Select the **Enable Protected Mode** check box for the all the
    > zones.

2.  Click **Apply** and then click **OK**.

### Cleanup HTCs

Best Practices Analyzer checks for the Cleanup HTCs key in the Regedit
and displays an error when the key is disabled (value set to No).

Unified Service Desk works best when Cleanup HTCs option is set to Yes.

#### Mitigation

Set Cleanup HTCs option to Yes.

 

Set cleanup HTCs through Registry (Regedit)

1.  Go to **C:/** &gt; **Windows** &gt; **regedit**

2.  Double-click to open **regedit**

3.  Go to **Computer\\HKEY\_CURRENT\_USER\\Software\\Microsoft\\Internet
    > Explorer.**

4.  Right-click on **Cleanup HTCs** and select **Modify** option.

5.  Specify **Yes** in the **Value data** field.

6.  Click **OK**.

### Internet Explorer version

Best Practices Analyzer checks for the Internet Explorer version and
recommends using latest version of Internet Explorer.

Unified Service Desk works best with latest version of Internet Explorer
11. If you are running Windows 8.1 or Windows 10, you already have
Internet Explorer 11.

#### Mitigation

Use the latest version of Internet Explorer.

 

If you are running Windows 7 or lower version, visit the Internet
Explorer Downloads to download Internet Explorer 11.

More information: [Internet Explorer
Downloads](https://support.microsoft.com/en-us/help/17621/internet-explorer-downloads)

