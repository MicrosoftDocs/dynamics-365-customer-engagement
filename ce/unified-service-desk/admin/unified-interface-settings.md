---
title: "Unified Interface Settings (Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "Learn about the Unified Interface Settings page in the Unified Service Desk Administrator app."
keywords: 
ms.date: 04/10/2019
ms.service: 
  - usd
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement (on-premises) apps
  - Dynamics CRM 2013
  - Dynamics CRM 2015
  - Dynamics CRM 2016
ms.assetid: 88B92EC9-81ED-4EB0-8269-2DC0624B6DBA
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
monikerRange: ">=dynamics-usd-4"
---

::: moniker range="dynamics-usd-4"
# Preview feature: Set default Unified Interface App using Unified Interface Settings
::: moniker-end

::: moniker range="dynamics-usd-4.1"
# Set default Unified Interface App using Unified Interface Settings
::: moniker-end

Unified Interface Settings is a new configuration element introduced under **Advanced Settings** in the Unified Service Desk Administrator app. Unified Interface Settings enables you as an administrator to configure the default Unified Interface App for your agents and transform the Unified Service Desk sign-in experience.  

![Unified Interface Settings](../media/usd-crm-unified-interface-settings.PNG "Unified Interface Settings")

In addition, you can now configure the settings like a theme, Unified Interface App, and assign users (agents) to the Unified Interface Settings record. After creating a Unified Interface Settings record, you can assign this record to a configuration, so that when the users (agents) sign in to Unified Service Desk client, the system authenticates the users (agents) straight away without showing the application selection window.

> [!NOTE]
> The Unified Interface Settings configuration option is supported only on Dynamics 365 for Customer Engagement apps (Unified Interface apps) and not supported on Dynamics 365 for Customer Engagement apps Web Client.


## How to create Unified Interface Settings record

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] apps

2. Go to **Settings** > **My Apps** > **Unified Service Desk Administrator** app.

3. Select **Site Map**.</br>
![Select Site Map to go to Unified Interface Settings](../media/usd-crm-site-map-unified-interface-setting.PNG "Select Site Map to go to Unified Interface Settings")
 
4. Choose **Unified Interface Settings** under **Advanced Settings**.

5. In the **Active Unified Interface Settings** page, choose **+ New** to create a new record.

6. In the **New Unified Interface Settings** page, specify the following:

    | Field  | Value  |
    |:----------|:----------|
    | Name         | Specify a name of the record.</br> For example, **Sample Setting**. |
    | Theme        | Select a theme for the App.<br>There are two themes.<br>- Air</br>- Unified Blue |
    | Unified Interface App | Select a Unified Interface App for the record. </br> For example, **Customer Service Hub**.|
    | Owner | Add the user profile for the record by choosing the search icon. |
    
  ![New Unified Interface Settings record](../media/usd-crm-unified-new-record-interface-settings.PNG "New Unified Interface Settings record")

7. Select **Save & Close**.

## Add the Unified Interface Settings record to a Configuration

you can add the Unified Interface Settings record to a configuration in two ways:

- Assign a configuration the Unified Interface Settings page.
- Assign a Unified Interface Setting record to a configuration.

### Assign a configuration from the Unified Interface Settings page

1. Go to the Unified Interface Setting record for which you want to attach the configuration.

2. Choose **Related** > **Configuration**.<br>
![Add configuration to the unified interface setting record](../media/usd-crm-unified-interface-add-configuration.PNG "Add configuration to the unified interface setting records")

3. In the **Configuration** tab, select **Add Existing Configuration**.<br>
  > [!Note]
  > You can select **Add New Configuration** to create and then add the configuration to the Unified Interface Settings record. In this walkthrough, we are attaching an already created configuration,**Test Configuration**, to the Unified Interface Settings record.
  
4. In the **Lookup Records** pane, specify the name of the configuration, and choose search icon.<br> The configuration appears, choose the configuration and then choose **Add**.<br>
![Add configuration to the unified interface setting record](../media/usd-crm-add-configuration-unified-interface-record.PNG "Add configuration to the unified interface setting records")

The configuration is added successfully and appears in the **Configuration** tab.

### Assign a Unified Interface Settings record in the Configuration page

1. Go to **Site Map** > **Configuration**.

2. Select **+ New** to create a configuration record.

3. In the **New Configuration** page, specify the required details for the fields. 

4. In the **Unified Interface Settings** field, type the name of the existing Unified Interface record you want to assign, and choose the search icon.<br> Select the record when it appears..<br>
![Add unified interface setting record to the configuration](../media/usd-crm-add-unified-interface-record-configuration.PNG "Add unified interface setting record to the configuration")<br>
    >[!Note]
    > In the above step, we added an existing Unified Interface Settings record to the configuration. To create a new Unified Interface Settings record, see [How to create Unified Interface Setting record](#how-to-create-unified-interface-settings-record).

5. Select **Save & Close**.

## Login experience to Unified Service Desk 

Here are the scenarios you need to consider for signing in to Unified Service Desk.

### Scenario 1: Users (agents) assigned to Configuration with a Unified Interface Settings record

Add users (agents) to a **Configuration** and add a record to the **Unified Interface Settings** field in the **Configuration**. When the user (agent) added to the configuration signs in to Unified Service Desk, the system authenticates the user (agent) and displays the landing page of the Unified Interface App. 

### Scenario 2: Users (agents) assigned to Configuration without a Unified Interface Settings record

Add users (agents) to a **Configuration**, and the **Unified Interface Settings** field is empty in the **Configuration**. In this scenario consider three cases:

 - If there is a default **Configuration** with a **Unified Interface Settings** record assigned, then the system authenticates the user (agent) and displays the landing page of Unified Interface App.

 - If there is a default **Configuration** with no **Unified Interface Settings** record, then during login, the system displays the application selection window for the user (agent) to select Unified Interface App.

 - If there is no default **Configuration**, then during login, the system displays the application selection window for the user (agent) to select Unified Interface App.

### Scenario 3: Users (agents) assigned to Configuration, and Unified Interface Settings record is not created

Add users (agents) to a **Configuration**, and no Unified Interface Settings records are created. As a result, there are no records to select for the **Unified Interface Settings** field in the **Configuration**. In this scenario, when the user (agent) assigned to a particular configuration signs in to Unified Service Desk, the application selection window is displayed and the user (agent) has to select the Unified Interface App.


## See also
 [Unified Interface Page (Hosted Control)](../../unified-service-desk/unified-interface-page-hosted-control.md)

 [Unified Service Desk and Unified Interface Configuration Walkthroughs](../../unified-service-desk/unified-service-desk-unified-interface-configuration-walkthroughs.md)

 [Walkthrough 1: Build a simple agent application for Unified Interface Apps](../../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md) 

 [Walkthrough 2: Display an external webpage in your agent application](../../unified-service-desk/walkthrough2-unified-interface-display-an-external-webpage-in-your-agent-application.md)  

 [Walkthrough 3: Display Microsoft Dynamics 365 for Customer Engagement apps (Unified Interface apps) records in your agent application](../../unified-service-desk/walkthrough3-unified-interface-display-microsoft-dynamics-365-records-in-your-agent-application.md)  

 [Walkthrough 4: Display a Microsoft Dynamics 365 for Customer Engagement apps (Unified Interface apps) record in a session in your agent application](../../unified-service-desk/walkthrough4-unified-interface-display-dynamics-365-record-session-agent-application.md)   

 [Walkthrough 5: Display enhanced session information by displaying session name and overview data](../../unified-service-desk/walkthrough5-unified-interface-display-enhanced-session-information-displaying-session-name-overview-data.md)  

 [Walkthrough 6: Configure the Debugger hosted control in your agent application](../../unified-service-desk/walkthrough6-unified-interface-configure-debugger-hosted-control-agent-application.md)
 
 [Walkthrough 7: Configure agent scripting in your agent application](../../unified-service-desk/walkthrough7-unified-interface-configure-agent-scripting-agent-application.md)
