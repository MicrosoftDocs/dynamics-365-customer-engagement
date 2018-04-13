---
title: "Provide feedback about Unified Service Desk (Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about providing feedback about Unified Service Desk."
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
ms.assetid: 23F085E7-C2E2-44C0-80C1-9E65CCA209E9
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# Provide feedback about [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]

Have a comment or suggestion about [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]? We need your feedback to help us deliver a reliable product. Good or bad, the quickest route to get your comments to our team is right from within [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. 

With [!INCLUDE[pn-unified-service-desk-3-3](../../includes/pn-unified-service-desk-3-3.md)], you can see **Provide Feedback** option as a smiley on the tool bar.

## Walkthrough: Configure provide feedback window in your agent application

The walkthrough demonstrates how to set up provide feedback window in your agent application. In this walkthrough, you will learn to create **Provide Feedback** button on the **About Tool Bar** toolbar container and associate an Action Call to the button.

### Prerequisites

You must know about the following in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]:  
  
    -   The Toolbar Container type of hosted control. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md)  
  
    -   Action call and how to configure it. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Action calls](../unified-service-desk/action-calls.md)

<a name="Step1"></a>   
## Step 1: Create a toolbar container type of hosted control  
 
 Toolbar Container type of hosted controls are used to hold and display the toolbars in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. In this section, you’ll create a **Toolbar Container** hosted control that will appear at the top of the client application.  
  
1.  Sign in to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
2. [!INCLUDE[proc_settings_usd](../includes/proc-settings-usd.md)]  
3.  Click **Hosted Controls**.  
  
4.  Click **New**.  
  
5.  On the **New Hosted Control** page, specify the following values  
  
    |Field|Value|  
    |-----------|-----------|
    |Name|About Toolbar Container|
    |USD Component Type|Toolbar Container|
    |Display Group|AboutPanel|
  
6.  Click **Save**.  

<a name="Step2"></a>   
## Step 2: Add a toolbar and attach it to the toolbar container  
 In this step, you’ll create a toolbar, and attach the toolbar to the toolbar container hosted control created in step 2. This is done to display the toolbar in your agent application.  
  
1. Sign in to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
2. [!INCLUDE[proc_settings_usd](../includes/proc-settings-usd.md)]
  
3. Click **Toolbars**.  
  
4. Click **New**.
  
5. On the **New Toolbar** page, type **About Toolbar** in the **Name** box, and then click **Save**.  
  
6. Attach the toolbar to the toolbar container hosted control created in step 1. On the nav bar, click the down arrow next to **About Toolbar**, and click **Hosted Controls**.  
  
7. On the next page, click **Add Existing Hosted Control**, type `About Toolbar Container` in the search bar, and then press **ENTER** or click the search icon.
  
8. From the search result, click **About Toolbar Container** to add.  
  
9. Click **Save**.


## How do I give feedback?

1. On the toolbar, select the **Provide Feedback** smiley. <br/>The **Feedback** window appears.
2. Select a smiley from the list:
  - Good
  - Normal
  - Bad
3.	Type your feedback or suggestion in the text box. 
4.	Select **Submit** to send your feedback to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)].<br>

    ![Provide feedback window](../media/provide-feedback-window.PNG "Provide feedback window")

> [!Note]
> It is recommended that you do not submit any feedback containing personal or other data that is subject to legal or regulatory compliance requirements.<br>
> Setting the **HelpImproveUsd** global option to **False**, disables the data collection and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] dose not send information to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)]. If the data collection is disabled, then agent or system administrator cannot provide feedback due to insufficient permissions.<br>
![Insufficient Permissions](../media/insufficient-permissions-provide-feedback-window.PNG "Insufficient Permissions")


## See also

[Help improve Unified Service Desk](../admin/help-improve-unified-service-desk.md)