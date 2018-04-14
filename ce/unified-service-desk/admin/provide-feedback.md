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

With [!INCLUDE[pn-unified-service-desk-3-3](../../includes/pn-unified-service-desk-3-3.md)], you can see **Provide Feedback** option as a smiley on the toolbar.

## Walkthrough: Configure provide feedback window in your agent application

The walkthrough demonstrates how to set up provide feedback window in your agent application. In this walkthrough, you will learn to create **Provide Feedback** button on the **About Toolbar** toolbar container and associate an Action Call to the button.

### Prerequisites

You must know about the following in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:<br>  
    - The Toolbar Container type of hosted control. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types and action/event reference](../../unified-service-desk/hosted-control-types-action-event-reference.md)  
  
    - Action call and how to configure it. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Action calls](../../unified-service-desk/action-calls.md)

<a name="Top"></a>   
## In This Walkthrough

 [Step 1: Create a toolbar container type of hosted control](#Step1)
  
 [Step 2: Add a toolbar and attach it to the toolbar container](#Step2)

 [Step 3: Step 3: Add toolbar button and action call to display the feedback window](#Step3)

 [Step 4: Add the controls to the configuration ](#Step4)

 [Step 5: Test the provide feedback option in the application](#Step5)
  
 [Conclusion](#Conclusion)

<a name="Step1"></a>   
## Step 1: Create a toolbar container type of hosted control  
 
 Toolbar Container type of hosted control are used to hold and display the toolbars in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. In this section, you’ll create a **Toolbar Container** hosted control that will appear at the top of the client application.  
  
1.  Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]  
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
  
1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]
  
3. Click **Toolbars**.  
  
4. Click **New**.
  
5. On the **New Toolbar** page, type **About Toolbar** in the **Name** box, and then click **Save**.  
  
6. Attach the toolbar to the toolbar container hosted control created in step 1. On the nav bar, click the down arrow next to **About Toolbar**, and click **Hosted Controls**.  
  
7. On the next page, click **Add Existing Hosted Control**, type `About Toolbar Container` in the search bar, and then press **ENTER** or click the search icon.
  
8. From the search result, click **About Toolbar Container** to add.  
  
9. Click **Save**.

<a name="Step3"></a>   
## Step 3: Add toolbar button and action call to display the feedback window

 In this step, you’ll add button on the toolbar and attach action call to the button so that when the button is clicked, **Provide Feedback** window is displayed in the hosted control that were created in step 1.
  
1. After you save the toolbar in step 2, the **Buttons** area becomes available. In the **Buttons** area, click **+** on the right corner to add a button.  
  
2. On the **New Toolbar Button** page, specify the following values:  
  
    |Field|Value|  
    |-----------|-----------|  
    |Name|Provide Feedback|
    |Image|msdyusd_Feedback_16|
    |Tooltip|Provide Feedback|  
    |Order|102|

3. Click **Save**.

4. You need add the action call to display the **Provide Feedback** in the hosted control created in step 1.

    In the **Actions** area, click **+** on the right corner to add an action call.  
  
5. In the search box in the **Actions** area, press **ENTER** or click the search icon.  
  
6. In the search results box, click **New** in the lower right corner to create an action call for this toolbar button.
  
7. On the **New Action Call** page, specify the following values:
  
    |Field|Value|  
    |-----------|-----------|  
    |Name|Show FeedBack Window|  
    |Order|1|  
    |Hosted Control|CRM Global Manager|  
    |Action|ShowFeedback|
  
8. Click **Save**. The new action call gets added to the **Provide Feedback** button.

<a name="Step4"></a>   
## Step 4: Add the controls to the configuration  
 In this step, you’ll add the action call, hosted control, and toolbar that were created in this walkthrough to **Contoso Configuration** to display these controls to the user who is assigned to the configuration. If you have not created **Contoso Configuration**. Visit, [Walkthrough 1: Build a simple agent application](../../unified-service-desk/walkthrough-1-build-a-simple-agent-application.md).
  
 Add the following to **Contoso Configuration**.

|Control name|Control type|  
|------------------|------------------|  
|Show FeedBack Window|Action Call| 
|About Toolbar Container|Hosted Control| 
|Provide Feedback|Toolbar|
  
 To add a control to the configuration:  
  
1.  Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]  
  
3.  Click **Configuration**.  
  
4.  Click **Contoso Configuration** to open the definition.  
  
5.  On the nav bar, click the down arrow next to **Contoso Configuration**, and select **Action Calls**.  
  
6.  On the next page, click **Add Existing Action Call**, type `Show FeedBack Window` in the search bar, and then press **ENTER** or click the search icon.  
  
7.  The action call listed earlier are displayed in the search results. Add these action call.  
  
8.  Similarly, add the hosted control and the toolbar by clicking the down arrow next to **Contoso Configuration**, and clicking **Hosted Controls** and **Toolbars** respectively.  
  
9. Click **Save**.


<a name="Step5"></a> 
## Step 5: Test the provide feedback option in the application

Start the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application, and sign in to the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance where you configured [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] using the same user credentials that you assigned to the **Contoso Configuration**. For information about connecting to a [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance using the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application, see [Connect to a Dynamics 365 instance using the Unified Service Desk client](../../unified-service-desk/admin/connect-dynamics-365-instance-using-unified-service-desk-client.md).

Your agent application will now have a **Smiley** button in the toolbar area.

2. On the toolbar, select the **Provide Feedback** smiley. <br/>The **Feedback** window appears.
3. Select a smiley from the list:
  - Good
  - Normal
  - Bad
4.	Type your feedback or suggestion in the text box. 
5.	Select **Submit** to send your feedback to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)].<br>

    ![Provide feedback window](../media/provide-feedback-window.PNG "Provide feedback window")


<a name="Conclusion"></a> 
## Conclusion

 In this walkthrough, you learned how to set up provide feedback button in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application.  

> [!Note]
> It is recommended that you do not submit any feedback containing personal or other data that is subject to legal or regulatory compliance requirements.

> [!Note]
> Setting the **HelpImproveUsd** global option to **False**, disables the data collection and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] dose not send information to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)]. If the data collection is disabled, then agent or system administrator cannot provide feedback due to insufficient permissions.<br>
![Insufficient Permissions](../media/insufficient-permissions-provide-feedback-window.PNG "Insufficient Permissions")

## See also

[Help improve Unified Service Desk](../admin/help-improve-unified-service-desk.md)