---
title: "Support for Unified Interface apps in Unified Service Desk (Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: Learn about downloading and installing the Best Practices Analyzer.
ms.custom: ""
ms.date: 05/07/2018
ms.service: usd
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 7ECEC924-5089-4D9C-88B3-50D1BD7B03A9
author: kabala123
ms.author: kabala
manager: sakudes
---

# Support for Unified Interface Apps in Unified Service Desk

With the release [!INCLUDE[pn-unified-service-desk-3-3](../includes/pn-unified-service-desk-3-3.md)], [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] supports the Apps built using Unified Interface framework.

## What is Unified Interface?

With the release of Dynamics 365 (online), version 9.0, we have introduced a new user experience - Unified Interface - which uses responsive web design principles to provide an optimal viewing and interaction experience for any screen size, device, or orientation.

The new Unified Interface brings all the rich experiences to any client that you are using. Whether you are on a browser, tablet, or phone, you will be able to consume similar experiences. More Information: [About Unified Interface](../admin/about-unified-interface.md)

## What is Unified Interface supportability in Unified Service Desk?

[!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] supports the apps built using Unified Interface framework. That is, you can host a Unified Interface Page to load a URL or page from Dynamics 365 apps, which is built based on the Unified Interface framework.

The experience of the supportability is that the Unified Interface Page hosted control type exposes number of predefined UII actions and events that are unique to handling of Dynamics 365 windows built using Unified Interface framework including list manipulation actions, and a find action for displaying a quick search or advanced search page.

## Deploy the Unified Interface sample application

[!INCLUDE[pn_unified_service_desk_for_crm](../includes/pn-unified-service-desk-for-crm.md)] comes with  sample applications that you can use as the base for starting with your configuration of your agent application.  
  
 The Unified Interface sample application is bundled as a package that you need to deploy on a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] instance before you can start working. The deployment of the Unified Interface sample application package is performed using [!INCLUDE[pn_package_deployer_long](../includes/pn-package-deployer-long.md)]. After the deployment, the entities and custom code specific to [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] become available in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance.

To deploy the Unified Interface sample application package, refer [Deploy a sample Unified Service Desk package using Package Deployer](admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md)

## Configure application selection window in Unified Service Desk

A application selection is introduced to ensure that you can select Web or Unified Interface app as per your business requirement.

The application selection window appears when you login to [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. To enable the application selection window, you must update a **SelectAppModule** key under the **\<appSettings>** section of the **UnifiedServiceDesk.exe.config** (application configuration) file and set it to **true**.

### Add the application selection window key

1. Go to `C:\Program Files\Microsoft Dynamics CRM USD\USD`.
2. Select **UnifiedServiceDesk.exe.config** file.
3. Under the **\<appSettings>** section, type the key.<br>
`<add key="SelectAppModule" value="true"/>`
4. Save the file.

### Login to Unified Service Desk client application

After you update the **SelectAppModule** key in the **UnifiedServiceDesk.exe.config** file, you need to login to [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] to select an web or Unified Interface app.

![Select App Module](media/select-app-module-new.PNG "Select App Module")

## See also
 [Preview feature: Unified Interface Page (Hosted Control)](../unified-service-desk/unified-interface-page-hosted-control.md)
 [Preview feature: Unified Service Desk and Unified Interface Configuration Walkthroughs](../unified-service-desk/unified-service-desk-unified-interface-configuration-walkthroughs.md)
 [Preview feature: Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md) 
 [Preview feature: Walkthrough 2: Display an external webpage in your agent application](../unified-service-desk/walkthrough2-unified-interface-display-an-external-webpage-in-your-agent-application.md)   
 [Preview feature: Walkthrough 3: Display Microsoft Dynamics 365 Unified Interface app records in your agent application](../unified-service-desk/walkthrough3-unified-interface-display-microsoft-dynamics-365-records-in-your-agent-application.md)   
 [Preview feature: Walkthrough 4: Display a Microsoft Dynamics 365 Unified Interface app record in a session in your agent application](../unified-service-desk/walkthrough4-unified-interface-display-dynamics-365-record-session-agent-application.md)   
 [Preview feature: Preview feature: Preview feature: Walkthrough 5: Display enhanced session information by displaying session name and overview data](../unified-service-desk/walkthrough5-unified-interface-display-enhanced-session-information-displaying-session-name-overview-data.md)   
 [Walkthrough 6: Configure the Debugger hosted control in your agent application](../unified-service-desk/walkthrough6-unified-interface-configure-debugger-hosted-control-agent-application.md)
 [Walkthrough 7: Configure agent scripting in your agent application](../unified-service-desk/walkthrough7-unified-interface-configure-agent-scripting-agent-application.md)