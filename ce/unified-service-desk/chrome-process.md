---
title: "Chrome Process hosting method for your controls in Unified Service Desk for Dynamics 365 for Customer Engagement apps | MicrosoftDocs"
description: "Learn about the Chrome Process hosting method for your controls in Unified Service Desk."
ms.custom: 
  - dyn365-USD
ms.date: 12/19/2018
ms.service: dynamics-365-customerservice
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: CDB80F22-D45C-492C-92E8-B00A1CF94F31
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
monikerRange: '>= dynamics-usd-4'
---

# Preview: Chrome Process

[!INCLUDE[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The Chrome Process browser control hosts your controls in individual Chrome process instances and displays them in tabs in the Unified Service Desk client application. It facilitates predictable and secure page rendering by making sure that if your web application works in Google Chrome, it will work in Unified Service Desk. You can select **Chrome Process** as the hosting method for the **CRM Dialog**, **CRM Page**, **KM Control**, **Unified Interface Page**, **Unified Interface KM Control** and **Standard Web Application** type of hosted controls.

The advantages of using the Chrome process hosting method are as follows:

- Webpages, including Dynamics 365 pages, render faster in Google Chrome.
- Google Chrome is a modern browser with better process and memory management.
- Google Chrome browser is simple and secure.
- it provides easy configurations to host the applications in Unified Service Desk.
- It provides improved reliability and supportability for browser-specific issues

## Chrome Process settings

You can set the **Chrome Process** on the hosted controls (exisitng hosted controls and new hosted controls) to host applications. This allows you to choose the hosted controls that uses **Chrome Process** based on your requirements.

If you want to set the **Chrome Process** to host the applications for an entire organization, then use the **GlobalBrowserMode** Global UII option and specify the value as **Chrome**.

If you want to set the **Chrome Process** only for some agents in your organization, then in the **UnifiedServiceDesk.exe.config** file, add the **GlobalBrowserMode** key with the value as **Chrome**.

### Order of precedence

- Setting the **GlobalBrowserMode** Global UII option value as **Chrome**, takes precedence over the individual hosted control settings. <br><br>For example, some hosted controls have hosting type as **IE Process** and/or **Internal WPF**. At the organization level, you set **GlobalBrowserMode** Global UII option value as **Chrome**. In this scenario, the Global UII option takes precedence and configuration uses the **Chrome Process** to host the applications. 

- Setting the **GlobalBrowser** mode key to **Chrome** in the **UnifiedServiceDesk.exe.config** file for a particular client desktop, takes precedence over the individual hosted control settings.<br><br>For example, some hosted controls have hosting type as **IE Process** and/or **Internal WPF**. For a few agents, in their client desktops, you have set **GlobalBrowser** mode key to **Chrome** in the **UnifiedServiceDesk.exe.config** file. The value set in the **UnifiedServiceDesk.exe.config** file take precedence and configuration uses the **Chrome Process** to host the applications.

Setting the **GlobalBrowser** mode key to **Chrome** in the **UnifiedServiceDesk.exe.config** file for a particular client desktop, takes the precedence over other settings.

## Enable Chrome Process

Enable the **Chrome Process** by doing one of the following ways:

- Create a individual hosted control with hosting type as Chrome
- Enable for individual client desktops
- Enable for entire an organization

> [!NOTE]
> Enable the **Chrome Process** either for individual client desktops or for entire organization.

### Create a hosted control with hosting type as Chrome

When you are creating a new hosted control, you can select **Chrome Process** as the **Hosting Type**.

1. Sign in to Dynamics 365.

2. Go to **Settings** > **Unified Service Desk**.

3. Select **Hosted Controls**. The page displays available hosted controls.

4. To create a new hosted control, select **New**.

5. On the **New Hosted Control** page, specify the details and select **Chrome process** from the **Hosting Type** drop-down.

6. Select **Save** to create the hosted control.

### Enable Chrome for Unified Service Desk on client desktop

1. Go to directory where you have installed Unified Service Desk and double-click to open the **UnifiedServiceDesk.exe.config** file.
Example path: `C:\Program Files\Microsoft Dynamics CRM USD\USD`

2. Under the `<appSettings>` section add the new key.<br>
`<add key="GlobalBrowserMode" value="Chrome"/>`

3. Save the file.

### Enable Chrome for an entire organization

Add a new Global UII option for your organization named **GlobalBrowserMode**. Specify the value as **Chrome**.

1. Sign in to Dynamics 365.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the **Active UII Options** page, select **New**.

4. Choose **Others** for the **Global Option** field.

5. Type **GlobalBrowserMode** for the **Name** field.

6. Type **Chrome** for the **Value** field.

7. Select **Save**.

## See also

[Create or edit a hosted control](../unified-service-desk/create-edit-hosted-control.md)  

[Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md)   

[Manage hosted controls, actions, and events](../unified-service-desk/manage-hosted-controls-actions-events.md)