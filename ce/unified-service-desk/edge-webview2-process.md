---
title: "Use the Edge WebView2 Process hosting method for your controls in Unified Service Desk  | MicrosoftDocs"
description: "Know about the Edge WebView2 Process hosting method for your controls in Unified Service Desk."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 03/15/2021
ms.topic: "article"
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD

---

# Use Edge WebView2 Process to host web applications

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

The Edge WebView2 Process browser control hosts your controls in isolated Edge WebView2 Process instances and displays them in tabs in the Unified Service Desk client application. Edge WebView2 Process is based on *CefSharp*, an open source framework that uses the Chromium core that powers many modern browsers.  More information: [CefSharp](https://cefsharp.github.io/)

> [!IMPORTANT]
> - Unified Service Desk version 4.1.1.1429 supports Chromium version 84.

The advantages of using the Edge WevView2 Process hosting method are as follows:

![Advantages of Edge WebView2 Process](media/advantages-edge-webview2-process.png "Advantages of Edge WebView2 Process")

- Webpages, including model-driven app pages, render faster in Microsoft Edge.
- Microsoft Edge is a modern browser with better process and memory management.
- Microsoft Edge is the default browser for the Windows 10 operating system.
- It provides easy configurations to host the applications in Unified Service Desk.
- It provides improved reliability and supportability for browser-specific issues.

> [!NOTE]
> To use **Edge WebView2 Process**, you must have the latest Windows 10 operating system (Windows 10 October 2018 release).

## Edge WebView2 Process settings

You can set the **Edge WebView2 Process** on the hosted controls (existing hosted controls and new hosted controls) to host applications. This allows you to choose the hosted controls that uses **Edge WebView2 Process** based on your requirements. More information: [Create a hosted control with hosting type as Edge WebView2](edge-webview2-process.md#create-a-hosted-control-with-hosting-type-as-edge-webview2)

If you want to set the **Edge WebView2 Process** to host the applications for an entire organization, then use the **GlobalBrowserMode** Global UII option and specify the value as **Edge WebView2**. More information: [Enable Edge WebView2 for Unified Service Desk on client desktop](edge-webview2-process.md#enable-edge-webview2-for-unified-service-desk-on-client-desktop)

If you want to set the **Edge WebView2 Process** only for some agents in your organization, then in the **UnifiedServiceDesk.exe.config** file, add the **GlobalBrowserMode** key with the value as **Edge WebView2**. More information: [Enable Edge WebView2 for an entire organization](edge-webview2-process.md#enable-edge-webview2-for-an-entire-organization)

### Order of precedence

- Setting the **GlobalBrowserMode** Global UII option value as **Edge WebView2**, takes precedence over the individual hosted control settings. <br><br>For example, some hosted controls have hosting type as **IE Process** and/or **Internal WPF**. At the organization level, you set **GlobalBrowserMode** Global UII option value as **Edge WebView2**. In this scenario, the Global UII option takes precedence and configuration uses the **Edge WebView2 Process** to host the applications. 

- Setting the **GlobalBrowser** mode key to **Edge WebView2** in the **UnifiedServiceDesk.exe.config** file for a particular client desktop, takes precedence over the individual hosted control settings.<br><br>For example, some hosted controls have hosting type as **IE Process** and/or **Internal WPF**. For a few agents, in their client desktops, you have set **GlobalBrowser** mode key to **Edge WebView2** in the **UnifiedServiceDesk.exe.config** file. The value set in the **UnifiedServiceDesk.exe.config** file take precedence and configuration uses the **Edge WebView2 Process** to host the applications.

Setting the **GlobalBrowser** mode key to **Edge WebView2** in the **UnifiedServiceDesk.exe.config** file for a particular client desktop, takes the precedence over other settings.

## Enable Edge WebView2 Process

Enable the **Edge WebView2 Process** by doing one of the following ways:

- Create an individual hosted control with hosting type as Edge WebView2
- Enable for individual client desktops
- Enable for entire an organization

> [!NOTE]
> Enable the **Edge WebView2 Process** either for individual client desktops or for entire organization.

### Create a hosted control with hosting type as Edge WebView2

When you are creating a new hosted control, you can select **Edge WebView2 Process** as the **Hosting Type**.

1. Sign in to Dynamics 365.

2. Go to **Settings** > **Unified Service Desk**.

3. Select **Hosted Controls**. The page displays available hosted controls.

4. To create a new hosted control, select **New**.

5. On the **New Hosted Control** page, specify the details and select **Edge WebView2 process** from the **Hosting Type** drop-down.<br>
![Edge Process hosted control](media/edge-process-hosted-control.PNG "Edge Process hosted control")

6. Select **Save** to create the hosted control.