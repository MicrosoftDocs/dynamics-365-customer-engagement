---
title: "Walkthrough 6: Configure the Debugger hosted control in your agent application | MicrosoftDocs"
ms.custom: ""
ms.date: 05/07/2018
ms.reviewer: ""
ms.service: "usd"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: B87B63D0-7BE3-4B43-806A-29429D9DE75A
author: "kabala123"
ms.author: "kabala"
manager: "sakudes"
---
# Walkthrough 6: Configure the Debugger hosted control in your agent application
[!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] provides a **Debugger** type of hosted control, which provides you key information about your [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] configuration that helps you to successfully build an agent application and troubleshoot issues in your configuration. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Debug issues in Unified Service Desk](../unified-service-desk/debug-issues-unified-service-desk.md )  
  
 This walkthrough demonstrates how to configure a Debugger hosted control for your agent application.  
  
## Prerequisites  
  
-   You must have completed [Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md) and [Walkthrough 3: Display Microsoft Dynamics 365 Unified Interface app records in your agent application](../unified-service-desk/walkthrough3-unified-interface-display-microsoft-dynamics-365-records-in-your-agent-application.md). The configurations that you completed in those walkthroughs are required in this walkthrough.  
  
-   This walkthrough assumes that you’ll be using the same user credential that you used in walkthrough 1 to sign in to the agent application at the end of the walkthrough to test the application. If a different user will be testing the application, you must assign the user to **Contoso Configuration**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md)  
  
-   You must know about the following in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]:  
  
    -   Debugger hosted control. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Debugger (Hosted Control)](../unified-service-desk/debugger-hosted-control.md)  
  
    -   Action call and how to configure it. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Action calls](../unified-service-desk/action-calls.md)  
  
    -   Filter access using [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] configuration. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](admin/manage-access-using-unified-service-desk-configuration.md)  
  
<a name="Top"></a>   
## In This Walkthrough  
 [Step 1: Create a Debugger type of hosted control](../unified-service-desk/walkthrough6-unified-interface-configure-debugger-hosted-control-agent-application.md#Step1)  
  
 [Step 2: Add toolbar button and action call to display the Debugger hosted control](../unified-service-desk/walkthrough6-unified-interface-configure-debugger-hosted-control-agent-application.md#Step2)  
  
 [Step 3: Add the controls to the configuration](../unified-service-desk/walkthrough6-unified-interface-configure-debugger-hosted-control-agent-application.md#Step3)  
  
 [Step 4: Test the application](../unified-service-desk/walkthrough6-unified-interface-configure-debugger-hosted-control-agent-application.md#Step4)  
  
 [Conclusion](../unified-service-desk/walkthrough6-unified-interface-configure-debugger-hosted-control-agent-application.md#conclusion)  
  
<a name="Step1"></a>   
## Step 1: Create a Debugger type of hosted control  
  
1.  Sign in to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
2. [!INCLUDE[proc_settings_usd](../includes/proc-settings-usd.md)]  
  
3.  Click **Hosted Controls**.  
  
4.  Click **New**.  
  
5.  On the **New Hosted Control** page, specify the following values:  
  
    |Field|Value|  
    |-----------|-----------|  
    |Name|Contoso Debugger|  
    |Sort Order|3|  
    |Display Name|Contoso Debugger|  
    |USD Component Type|Debugger|  
    |Display Group|MainPanel|  
  
 ![Create a Debugger hosted control](../unified-service-desk/media/usd-create-debugger-hosted-control-unified-interface.png "Create a Debugger hosted control")  
  
6.  Click **Save**.  
  
<a name="Step2"></a>   
## Step 2: Add toolbar button and action call to display the Debugger hosted control  
 Add a toolbar button to **Contoso Main Toolbar** (created in [Walkthrough 3: Display Microsoft Dynamics 365 Unified Interface app records in your agent application](../unified-service-desk/walkthrough3-unified-interface-display-microsoft-dynamics-365-records-in-your-agent-application.md)), and then add an action call for the button to display the **Contoso Debugger** hosted control that you created in step 1.  
  
1.  Sign in to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
2. [!INCLUDE[proc_settings_usd](../includes/proc-settings-usd.md)]  
  
3.  Click **Toolbars**.  
  
4.  Click **Contoso Main Toolbar**.  
  
5.  In the **Buttons** area, click **+** to add a toolbar button.  
  
6.  On the **New Toolbar Button** page, specify the following values.  
  
    |Field|Value|  
    |-----------|-----------|  
    |Name|Contoso Debugger Button|  
    |Button Text|DEBUGGER|  
    |Order|3 <br> **Note:** The **Order** field defines the position of buttons in the toolbar. Buttons are arranged from left to right or top to bottom in an ascending order.|  
  
7.  Click **Save**.  
  
8.  In the **Actions** area, click **+** to create an action call for the button  
  
9. In the search box, press **ENTER** or click the search icon, and then click **New** in the lower-right corner of the search results pane to create an action call.  
  
10. On the **New Action Call** page, specify the following values.  
  
    |Field|Value|  
    |-----------|-----------|  
    |Name|Contoso Action Call: Show Debugger|  
    |Order|1|  
    |Hosted Control|Contoso Global Manager|  
    |Action|CallDoAction|  
    |Data|action=default<br/>application=Contoso Debugger|  
  
 ![Create action call in Unified Service Desk](../unified-service-desk/media/usd-session-tab-name-format-action-call-unified-interface.png "Create action call in Unified Service Desk")  
  
11. Click **Save**.  
  
<a name="Step3"></a>   
## Step 3: Add the controls to the configuration  
 Add the action call and hosted control that you created in this walkthrough to **Contoso Configuration** to display these controls to the user who is assigned to the configuration. **Contoso Configuration** was created in [Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md).  
  
 Add the following to **Contoso Configuration**.  
  
|Control name|Control type|  
|------------------|------------------|  
|Contoso Action Call: Show Debugger|Action Call|  
|Contoso Debugger|Hosted Control|  
  
 To add a control to the configuration:  
  
1.  Sign in to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
2. [!INCLUDE[proc_settings_usd](../includes/proc-settings-usd.md)]  
  
3.  Click **Configuration**.  
  
4.  Click **Contoso Configuration** to open the definition.  
  
5.  On the nav bar, click the down arrow next to **Contoso Configuration**, and select **Action Calls**.  
  
6.  On the next page, click **Add Existing Action Call**, type “`Contoso Action Call: Show Debugger`” in the search bar, and then press ENTER or click the search icon.  
  
7.  In the search results, click the action call name to add it.  
  
8.  Similarly, add the hosted control by clicking the down arrow next to **Contoso Configuration**, and clicking **Hosted Controls**. 
  
9. Click **Save**.  
  
<a name="Step4"></a>   
## Step 4: Test the application  
 Start the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application, and sign in to the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance where you configured [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] using the same user credentials that you assigned to the **Contoso Configuration** in [Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md). For information about connecting to a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance using the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application, see [Connect to a Dynamics 365 instance using the Unified Service Desk client](admin/connect-dynamics-365-instance-using-unified-service-desk-client.md).  
  
 Your agent application will now have a **DEBUGGER** button in the toolbar area. Clicking this button displays the Debugger control.  
  
 ![Debugger in your agent application](../unified-service-desk/media/usd-debugger-agent-application.png "Debugger in your agent application")  
  
<a name="conclusion"></a>  
## Conclusion 
 In this walkthrough, you saw how to configure the Debugger hosted control in your agent application. You also learned how to filter access to [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] controls using configuration.  
  
### See also

 [Support for Unified Interface Apps in Unified Service Desk](../unified-service-desk/Support-unified-interfaces-apps-usd.md)

 [Preview feature: Unified Interface Page (Hosted Control)](../unified-service-desk/unified-interface-page-hosted-control.md)

 [Preview feature: Unified Service Desk and Unified Interface Configuration Walkthroughs](../unified-service-desk/unified-service-desk-unified-interface-configuration-walkthroughs.md) 

 [Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md)

 [Walkthrough 2: Display an external webpage in your agent application](../unified-service-desk/walkthrough2-unified-interface-display-an-external-webpage-in-your-agent-application.md)

 [Walkthrough 3: Display Microsoft Dynamics 365 Unified Interface app records in your agent application](../unified-service-desk/walkthrough3-unified-interface-display-microsoft-dynamics-365-records-in-your-agent-application.md)

 [Walkthrough 4: Display a Microsoft Dynamics 365 Unified Interface app record in a session in your agent application](../unified-service-desk/walkthrough4-unified-interface-display-dynamics-365-record-session-agent-application.md)

 [Walkthrough 5: Display enhanced session information by displaying session name and overview data](../unified-service-desk/walkthrough5-unified-interface-display-enhanced-session-information-displaying-session-name-overview-data.md)
 
 [Walkthrough 7: Configure agent scripting in your agent application](../unified-service-desk/walkthrough7-unified-interface-configure-agent-scripting-agent-application.md)