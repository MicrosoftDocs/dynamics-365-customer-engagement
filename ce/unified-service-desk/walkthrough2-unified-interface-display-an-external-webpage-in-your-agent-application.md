---
title: "Walkthrough 2: Display external URLs and webpages for Unified Interface apps | MicrosoftDocs"
description: "Use this walkthrough to understand the prerequisites and procedures for displaying external URLs and webpages in your agent application. "
ms.date: 06/27/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
search.audienceType: 
  - customizer
  - developer
ms.custom: evergreen
---


# Walkthrough 2: Display external URLs and webpages in your agent application



This walkthrough demonstrates how to display a webpage or external URL in your agent application. In this walkthrough, you’ll learn how to display the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] Guide, which is available online at https://go.microsoft.com/fwlink/?LinkID=856273, in the client application.

## Prerequisites  

- You must have completed [Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md). The configurations that you completed in the first walkthrough are required in this walkthrough.  

- This walkthrough assumes that you will be using the same user credential that you used at the end of Walkthrough 1 to sign in to the agent application. If a different user will be testing the application, you must assign the user to **Contoso Configuration**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md)  

- You must be familiar with the following concepts in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]:  

  - These two types of hosted controls: Standard Web Application and Toolbar Container. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md)  

  - How to configure [Action calls](../unified-service-desk/action-calls.md)  

  - Filter access using [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] configuration. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](../unified-service-desk/admin/manage-access-using-unified-service-desk-configuration.md)  

<a name="Top"></a>   
## In This Walkthrough  
 [Step 1: Create a hosted control to display the webpage](../unified-service-desk/walkthrough2-unified-interface-display-an-external-webpage-in-your-agent-application.md#Step1)  

 [Step 2: Create a toolbar container type of hosted control](../unified-service-desk/walkthrough2-unified-interface-display-an-external-webpage-in-your-agent-application.md#Step2)  

 [Step 3: Add a toolbar and attach it to the toolbar container](../unified-service-desk/walkthrough2-unified-interface-display-an-external-webpage-in-your-agent-application.md#Step3)  

 [Step 4: Add a toolbar button and action calls to display the webpage](../unified-service-desk/walkthrough2-unified-interface-display-an-external-webpage-in-your-agent-application.md#Step4)  

 [Step 5: Add the controls to the configuration](../unified-service-desk/walkthrough2-unified-interface-display-an-external-webpage-in-your-agent-application.md#Step5)  

 [Step 6: Test the application](../unified-service-desk/walkthrough2-unified-interface-display-an-external-webpage-in-your-agent-application.md#Step6)  

 [Conclusion](../unified-service-desk/walkthrough2-unified-interface-display-an-external-webpage-in-your-agent-application.md#Conclusion)  

<a name="Step1"></a>   
## Step 1: Create a hosted control to display the webpage  
 In this step, you’ll create a hosted control of Standard Web Application type to display the webpage.  

1. Sign in to Unified Service Desk Administrator.  

2. Select **Hosted Controls** under **Basic Settings**.  

3. Select **+ New**.  

4. On the **New Hosted Control** page, specify the following values:  

   |Field|Value|  
   |-----------|-----------|  
   |Name|Contoso Help|  
   |Display Name|Contoso Help|  
   |Unified Service Desk Component Type|Standard Web Application|  
   |Allow Multiple Pages|No|  
   |Hosting Type|Chrome Process|
   |Application is Global|Checked|
   |Display Group|MainPanel|

5. Select **Save**.  

<a name="Step2"></a>   
## Step 2: Create a toolbar container type of hosted control  
 Toolbar Container hosted controls are used to hold and display the toolbars in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. In this section, you’ll create a **Toolbar Container** type of hosted control that appears in the toolbar region of the client application.  

1. Sign in to Unified Service Desk Administrator.  

2. Select **Hosted Controls** under **Basic Settings**.  

3. Select **+ New**.   

4. On the **New Hosted Control** page, specify the following values:  

   |Field|Value|  
   |-----------|-----------|  
   |Name|Contoso About Toolbar Container|  
   |Unified Service Desk Component Type|Toolbar Container|  
   |Display Group|AboutPanel|

5. Select **Save**.  

<a name="Step3"></a>   
## Step 3: Add a toolbar and attach it to the toolbar container  
 In this step, you’ll create a toolbar, and attach the toolbar to the toolbar container hosted control created in step 2. This is done to display the toolbar in your agent application.  

1. Sign in to Unified Service Desk Administrator.  

2. Select **Toolbars** under **Basic Settings**.   

3. Select **+ New**.  

4. On the **New Toolbar** page, type **Contoso About Toolbar** in the **Name** box, and then select **Save**.  

5. Attach the toolbar to the toolbar container hosted control created in step 2. Select the **Related** tab, and then select **Hosted Controls**.

6. Select **Add Existing Hosted Control**. The **Lookup Records** pane is displayed.

7. Type `Contoso About Toolbar Container` in the search bar. Select the record from the list, and then select **Add**. 

8. Select **Save**.  

<a name="Step4"></a>   
## Step 4: Add a toolbar button and action calls to display the webpage  
 In this step, add a button on the toolbar and attach an action call to the button so that when the button is clicked, the specified webpage is displayed in the hosted control that you created in step 1.  

1. After you save the toolbar in step 3, select the **General** tab. 

2. In the **Buttons** area, select **+ New Toolbar Button**.  

3. On the **New Toolbar Button** page, specify the following values.  

   |Field|Value|  
   |-----------|-----------|  
   |Name|Contoso Show Help|  
   |Button Text|Show Help|

4. Select **Save** to save the record. After you save, the **Actions** area is enabled.  

5. Add two action calls to specify the URL of the webpage to navigate to for the hosted control that you created in step 1. Additionally, create another action call to on the **Contoso Global Manager** hosted control to display the hosted control created in step 1 in the agent application. In the **Actions** area, select **Add Existing Action Call**. The **Lookup Records** pane is displayed.

6. Select the search icon in the search box in the **Actions** area, and then select **+ New Action Call**.

7. On the **New Action Call** page, specify the following values:  


   |     Field      |                        Value                        |
   |----------------|-----------------------------------------------------|
   |      Name      |          Contoso Action Call: Display Help          |
   |     Order      |                          1                          |
   | Hosted Control |                    Contoso Help                     |
   |     Action     |                      Navigate                       |
   |      Data      | url=https://learn.microsoft.com/dynamics365/unified-service-desk/unified-service-desk?view=dynamics-usd-4.1 | 

8. Select **Save**. 

9. Select the back button on the browser to go back to the **Contoso Show Help** button. 

10. Select **Add Existing Action Call** in the **Actions** area. The **Lookup Records** pane is displayed.

11. Type the name of the action you created earlier in the search box. Select the record from the list, and then select **Add**.

12. Repeat Steps 5 and 6 to create another action call with the following details:

    |Field|Value|  
    |-----------|-----------|  
    |Name|Contoso Action Call: Display Help Hosted Control|  
    |Order|2|  
    |Hosted Control|Contoso Global Manager|  
    |Action|ShowTab|  
    |Data|Contoso Help|

14. Repeat Steps 8 t 11.

15. Select **Save**. The new action call gets added to the **Contoso Show Help** button. You can see both action calls added to the toolbar button.  

    ![Action calls added to the toolbar button.](../unified-service-desk/media/crm-itpro-usd-wt02-07.png "Action calls added to the toolbar button")  

<a name="Step5"></a>   
## Step 5: Add the controls to the configuration  
 In this step, add the action calls, hosted controls, and toolbar that you created in this walkthrough to **Contoso Configuration** to display these controls to the user who is assigned to the configuration. **Contoso Configuration** was created in [Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md).  

 Add the following to **Contoso Configuration**.  

|Control name|Control type|  
|------------------|------------------|  
|Contoso Action Call: Display Help|Action Call|  
|Contoso Action Call: Display Help Hosted Control|Action Call|  
|Contoso Help|Hosted Control|  
|Contoso About Toolbar Container|Hosted Control|  
|Contoso About Toolbar|Toolbar|  

 To add a control to the configuration:  

1. Sign in to Unified Service Desk Administrator.  

2. Select **Configuration** under **Advanced Settings**.  

3. Select **Contoso Configuration** to open the definition.  

4. Select the **Hosted Controls, Events and Action Calls** tab.  

5. Select the ellipsis (...) in the **Action Calls** section, and then select **Add Existing Action Call**. The **Lookup Records** pane is displayed.

6. Type **Contoso Action Call** in the search box. Both action calls are displayed in the search results. Select the record from the list, and then select **Add**.

7. Select the ellipsis (...) in the **Hosted Controls** section, and then select **Add Existing Hosted Control**. The **Lookup Records** pane is displayed.

8. Type **Contoso** in the search box. Both the hosted controls are displayed in the search results. Select the record from the list, and then select **Add**.

9. Select the **Related** tab, and then select **Toolbars**.

10. Select **Add Existing Toolbar**. The **Lookup Records** pane is displayed.

11. Type **Contoso About Toolbar** in the search box. Select the record from the list, and then select **Add**.

12. Select **Save**.  

<a name="Step6"></a>
## Step 6: Test the application

 Start the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application, and sign in to the Dynamics 365 instance where you configured [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] using the same user credentials that you assigned to the **Contoso Configuration** in [Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md). For information about connecting to Dataverse instance using the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application, see [Connect to a model-driven app instance using the Unified Service Desk client](../unified-service-desk/admin/connect-dynamics-365-instance-using-unified-service-desk-client.md) 

 Your agent application will now have a **Show Help** button at the top-right corner:  

 ![Show Help button in Unified Service Desk.](../unified-service-desk/media/crm-itpro-usd-wt02-08.png "Show Help button in Unified Service Desk")  

 Clicking **Show Help** displays the specified web URL within the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] application.  

 ![Help displayed in the client application.](../unified-service-desk/media/crm-itpro-usd-wt02-09.png "Help displayed in the client application")  

<a name="Conclusion"></a>   
## Conclusion  
 In this walkthrough, you learned how to display a webpage in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application. You also learned how to filter access to [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] controls using configuration.  

### See also
 [Support for Unified Interface Apps in Unified Service Desk](../unified-service-desk/admin/Support-unified-interfaces-apps-usd.md)

 [Unified Interface Page (Hosted Control)](../unified-service-desk/unified-interface-page-hosted-control.md)

 [Unified Service Desk and Unified Interface Configuration Walkthroughs](../unified-service-desk/unified-service-desk-unified-interface-configuration-walkthroughs.md)

 [Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md)

 [Walkthrough 3: Display Unified Interface apps records in your agent application](../unified-service-desk/walkthrough3-unified-interface-display-microsoft-dynamics-365-records-in-your-agent-application.md)

 [Walkthrough 4: Display a Unified Interface apps record in a session in your agent application](../unified-service-desk/walkthrough4-unified-interface-display-dynamics-365-record-session-agent-application.md)

 [Walkthrough 5: Display enhanced session information by displaying session name and overview data](../unified-service-desk/walkthrough5-unified-interface-display-enhanced-session-information-displaying-session-name-overview-data.md)

 [Walkthrough 6: Configure the Debugger hosted control in your agent application](../unified-service-desk/walkthrough6-unified-interface-configure-debugger-hosted-control-agent-application.md)

 [Walkthrough 7: Configure agent scripting in your agent application](../unified-service-desk/walkthrough7-unified-interface-configure-agent-scripting-agent-application.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
