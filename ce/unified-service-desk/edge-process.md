---
title: "Edge process hosting method for your controls in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Learn about the edge process hosting methods for your controls in Unified Service Desk."
ms.custom: 
  - dyn365-USD
ms.date: 12/01/2018
ms.service: dynamics-365-customerservice
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: D9E7AED8-1D3A-4E62-BD15-7C5CF153EB4E
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

# Edge Process

The Edge Process browser control hosts your controls in individual Edge process instances and displays them in tabs in the Unified Service Desk client application. It facilitates predictable and secure page rendering by making sure that if your web application works in Edge, it will work in Unified Service Desk. You can select Edge Process as the hosting method for the **CRM Dialog**, **CRM Page**, **KM Control**, **Unified Interface Page**, **Unified Interface KM Control** and **Standard Web Application** type of hosted controls.

The advantages of Edge process are as follows:

- Web pages, including Dynamics 365 pages, renders faster in Edge.
- The Edge is a modern browser with better process and memory management.
- Edge is the default browser for Windows 10 operating system.
- Easy configurations to host the applications in Unified Service Desk.
- Improved reliability and supportability for browser-specific issues

> [!NOTE]
> To use Edge process, you must have the latest Windows 10 operating system (Windows 10 October 2018 release).

## Enable Edge process

You can enable Edge process for individual client desktops and/or for entire organizations.

### Enable Edge for Unified Service Desk on client desktop

1. Go to directory where you have installed Unified Service Desk and double-click to open the UnifiedServiceDesk.exe.config file.
Example path: `C:\Program Files\Microsoft Dynamics CRM USD\USD`
2. Under the `<appSettings>` section add the new key.<br>
`<add key="GlobalBrowserMode" value="Edge"/>`

  > [!div class="mx-imageBorder"]
  > ![Edge process configuration setting key](media/edge-process-app-config-file-setting.PNG "Edge process configuration setting key")

3. Save the file.

### Enable Edge for entire organization

Add a new Global UI option for your organization named GlobalBrowserMode with value as Edge

1. Sing-in to Dynamics 365.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the **Active UII Options** page, select **New**.

4. Choose **Others** for the **Global Option** field.

5. Type **GlobalBrowserMode** for the Name field.

6. Type **Edge** for the **Value** field.

7. Select **Save**.

## Create hosted control with hosting type as Edge

You can select Edge Process as the **Hosting Type** while creating a hosted control.

1. Sign in to Dynamics 365.

2. Go to **Settings** > **Unified Service Desk**.

3. Select **Hosted Controls**. The page displays available hosted controls.

4. To create a new hosted control, select **New**.

5. In the **New Hosted Control** page, specify the details and select **Edge process** from the **Hosting Type** drop-down.

6. Select **Save** to create the hosted control.

## See also  
 [Create or edit a hosted control](../unified-service-desk/create-edit-hosted-control.md)  

 [Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md)   

 [Manage hosted controls, actions, and events](../unified-service-desk/manage-hosted-controls-actions-events.md)