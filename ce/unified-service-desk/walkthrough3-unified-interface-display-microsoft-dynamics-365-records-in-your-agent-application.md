---
title: "Walkthrough 3  Display records in your agent application | MicrosoftDocs"
description: "Demonstrates how to display Unified Interface apps records in Unified Service Desk."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 06/25/2020
ms.topic: article
ms.service: dynamics-365-customerservice
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---

# Walkthrough 3: Display model-driven apps (Unified Interface apps) records in your agent application

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

This walkthrough demonstrates how to display model-driven app records in your agent application. In this walkthrough, you’ll display all the account and contact records in the model-driven apps. You’ll also create a search button with drop-down menu items for displaying accounts and contacts in the agent application.  

## Prerequisites  

- You must have completed [Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md). The configurations that you completed in walkthrough 1 are required in this walkthrough.  

- This walkthrough assumes that you will be using the same user credential that you used in walkthrough 1 to sign in to the agent application at the end of the walkthrough to test the application. If a different user will be testing the application, you must assign the user to **Contoso Configuration**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md)  

- You must know about the following in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]:  

  - The following two types of hosted controls: Unified Interface Page and Toolbar Container. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md)  

  - Action call and how to configure it. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Action calls](../unified-service-desk/action-calls.md)  

  - Filter access using [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] configuration. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](../unified-service-desk/admin/manage-access-using-unified-service-desk-configuration.md)  

<a name="Top"></a>   
## In This Walkthrough  
 [Step 1: Create Unified Interface Page type of hosted controls to display account and contact records](../unified-service-desk/walkthrough3-unified-interface-display-microsoft-dynamics-365-records-in-your-agent-application.md#Step1)  

 [Step 2: Create a toolbar container type of hosted control](../unified-service-desk/walkthrough3-unified-interface-display-microsoft-dynamics-365-records-in-your-agent-application.md#Step2)  

 [Step 3: Add a toolbar and attach it to the toolbar container](../unified-service-desk/walkthrough3-unified-interface-display-microsoft-dynamics-365-records-in-your-agent-application.md#Step3)  

 [Step 4: Add toolbar buttons and action calls to display records](../unified-service-desk/walkthrough3-unified-interface-display-microsoft-dynamics-365-records-in-your-agent-application.md#Step4)  

 [Step 5: Add the controls to the configuration](../unified-service-desk/walkthrough3-unified-interface-display-microsoft-dynamics-365-records-in-your-agent-application.md#Step5)  

 [Step 6: Test the application](../unified-service-desk/walkthrough3-unified-interface-display-microsoft-dynamics-365-records-in-your-agent-application.md#Step6)  

 [Conclusion](../unified-service-desk/walkthrough3-unified-interface-display-microsoft-dynamics-365-records-in-your-agent-application.md#Conclusion)

<a name="Step1"></a>   
## Step 1: Create Unified Interface Page type of hosted controls to display account and contact records  
 In this step, you’ll create two hosted controls of **Unified Interface Page** type to display the account and contact records respectively.  

1. Sign in to Unified Service Desk Administrator.  

2. Select **Hosted Controls** under **Basic Settings**.  

3. Select **+ New**.  

4. On the **New Hosted Control** page, specify the following values:  

   |Field|Value|  
   |-----------|-----------|  
   |Name|Contoso Accounts Search|  
   |Display Name|Contoso: Accounts|  
   |Unified Service Desk Component Type|Unified Interface Page|  
   |Allow Multiple Pages|No|
   |Pre-Fetch Data|Checked|
   |Application is Global|Checked|  
   |Display Group|MainPanel|  

5. Select **Save**.  

6. Select **+ New** to create another hosted control for displaying contact records.  

7. On the **New Hosted Control** page, specify the following values:  

   |Field|Value|  
   |-----------|-----------|  
   |Name|Contoso Contacts Search|  
   |Display Name|Contoso: Contacts|  
   |Unified Service Desk Component Type|Unified Interface Page|  
   |Allow Multiple Pages|No|
   |Pre-Fetch Data|Checked|
   |Application is Global|Checked|  
   |Display Group|MainPanel| 

8. Select **Save**.  

<a name="Step2"></a>   
## Step 2: Create a toolbar container type of hosted control  
 Toolbar Container type of hosted controls are used to hold and display the toolbars in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. In this section, you’ll create a **Toolbar Container** hosted control that will appear at the top of the client application.  

1. Sign in to Unified Service Desk Administrator.  

2. Select **Hosted Controls** under **Basic Settings**.   

3. Select **+ New**.  

4. On the **New Hosted Control** page, specify the following values  

   |Field|Value|  
   |-----------|-----------|  
   |Name|Contoso Main Toolbar Container|  
   |Unified Service Desk Component Type|Toolbar Container|  
   |Display Group|ToolbarPanel|  

5. Select **Save**.  

<a name="Step3"></a>   
## Step 3: Add a toolbar and attach it to the toolbar container  
 In this step, you’ll create a toolbar, and attach the toolbar to the toolbar container hosted control created in step 2. This is done to display the toolbar in your agent application.  

1. Sign in to Unified Service Desk Administrator.  

2. Select **Toolbars** under **Basic Settings**.  

3. Select **+ New**.  

4. On the **New Toolbar** page, type **Contoso Main Toolbar** in the **Name** box, and then select **Save**.  

5. Attach the toolbar to the toolbar container hosted control created in step 2. Select the **Related** tab, and then select **Hosted Controls**.

6. Select **Add Existing Hosted Control**. The **Lookup Records** pane is displayed.

7. Type **Contoso Main Toolbar Container** in the search box. Select the record from the list, and then select **Add**.  

8. Select **Save**.  

<a name="Step4"></a>   
## Step 4: Add toolbar buttons and action calls to display records from Unified Interface Apps

 In this step, you’ll add buttons on the toolbar and attach action calls to the buttons so that when the button is selected, appropriate records are displayed in the hosted controls that were created in step 1. You’ll configure the search button so that selecting the button displays the account and contact submenu items, and selecting a button displays the respective records.  

1. After you save the toolbar in step 3, Select the **General** tab.

2. In the **Buttons** area, select **+ New Toolbar Button**.  

3. On the **New Toolbar Button** page, specify the following values:  


   |    Field    |                                          Value                                           |
   |-------------|------------------------------------------------------------------------------------------|
   |    Name     |                                  Contoso Search Button                                   |
   | Button Text |                                          SEARCH                                          |
   |   Tooltip   | Search accounts and contacts |
   |    Order    |                                            1                                             |

4. Select **Save**.

5. Select the **Related** tab and select **Toolbar Buttons**.

   > [!NOTE]
   >  You are now adding child toolbar buttons to an existing toolbar button to create a submenu structure.

6. On the next page, select **+ New Toolbar Button**.

7. On the **New Toolbar Button** page, specify the following values.

   |Field|Value|  
   |-----------|-----------|  
   |Name|Contoso Search Account Button|  
   |Button Text|Account|  
   |Order|1<br /><br /> The **Order** field defines the position of buttons in the toolbar. Buttons are arranged from left to right or top to bottom in an ascending order.| 

8. Select **Save**.  

9. You’ll now add two action calls: first to display the account records in the hosted control created in step 1 and the second one on the Contoso Global Manager hosted control to display the account hosted control. 

    In the **Actions** area, select **Add Existing Action Call**. The **Lookup Records** pane is displayed.  

10. Select the search icon and then select **+ New Action Call**.

11. On the **New Action Call** page, specify the following values:  

    |Field|Value|  
    |-----------|-----------|  
    |Name|Contoso Action Call: Search Account|  
    |Order|1|  
    |Hosted Control|Contoso Accounts Search|  
    |Action|Find|  
    |Data|account|

12. Select **Save**. The new action call gets added to the **Contoso Search Account Button** button.

13. Select the back button on the browser to go back to the **Contoso Search Account Button** page.

14. You’ll add another action call to the button to set the focus on the hosted control that displays the account records in the client application. 

    Repeat Steps 9 to 11 and specify the following values.  

    |Field|Value|  
    |-----------|-----------|  
    |Name|Contoso Action Call: Display Account Search|  
    |Order|2|  
    |Hosted Control|Contoso Global Manager|  
    |Action|ShowTab|  
    |Data|Contoso Accounts Search|  

15. Select **Save**. 

16. Repeat Step 13, and then select **Add Existing Action Call**. The **Lookup Records** pane is displayed.

17. Type **Contoso Action Call** in the search box. Select the action that you created in the Step 11 and 14, and then select **Add**.

    The new action call gets added to the **Contoso Search Account Button** button.  

18. Navigate to **Contoso Search Button** toolbar button to add a child button for searching and displaying contacts. Select the **Toolbar Buttons** tab.  

19. Select **Add New Toolbar Button**.  

20. On the **New Toolbar Button** page, specify the following values:  

    |Field|Value|  
    |-----------|-----------|  
    |Name|Contoso Search Contact Button|  
    |Button Text|Contact|  
    |Order|2<br /><br /> The **Order** field defines the position of buttons in the toolbar. Buttons are arranged from left to right or top to bottom in an ascending order.|

21. Select **Save**.  

22. You’ll now add two action calls: first to display the contact records in the hosted control that were created in step 1 and the second one on the Contoso Global Manager hosted control to display the contacts hosted control.  

     In the **Actions** area, select **Add Existing Action Call**. The **Lookup Records** pane is displayed.   

23. Select the search icon and then select **+ New Action Call**.

24. On the **New Action Call** page, specify the following values:  

    |Field|Value|  
    |-----------|-----------|  
    |Name|Contoso Action Call: Search Contact|  
    |Order|1|  
    |Hosted Control|Contoso Contacts Search|  
    |Action|Find|  
    |Data|contact|

25. Select **Save**.

26. Select the back button on the browser to go back to the **Contoso Search Button**.

27. You’ll add another action call to the button to set the focus on the hosted control that displays the contact records in the client application. 

    Repeat Steps 22 to 23, and specify the following values.  

    |Field|Value|  
    |-----------|-----------|  
    |Name|Contoso Action Call: Display Contact Search|  
    |Order|2|  
    |Hosted Control|Contoso Global Manager|  
    |Action|ShowTab|  
    |Data|Contoso Contacts Search|

28. Select **Save**. 

29. Select the back button on the browser to go back to the **Contoso Search Button**.

30. Select **Add Existing Action Call**. The **Lookup Records** pane is displayed.

31. The action calls that you created are displayed. Select the action calls, and then select **Add**. 

    The new action call gets added to the **Contoso Search Contact Button** toolbar button.

31. Select **Save**.

<a name="Step5"></a>   
## Step 5: Add the controls to the configuration  
 In this step, you’ll add the action calls, hosted controls, and toolbar that were created in this walkthrough to **Contoso Configuration** to display these controls to the user who is assigned to the configuration. **Contoso Configuration** was created in [Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md).  

 Add the following to **Contoso Configuration**.  

|Control name|Control type|  
|------------------|------------------|  
|Contoso Action Call: Search Account|Action Call|  
|Contoso Action Call: Display Account Search|Action Call|  
|Contoso Action Call: Search Contact|Action Call|  
|Contoso Action Call: Display Contact Search|Action Call|  
|Contoso Accounts Search|Hosted Control|  
|Contoso Contacts Search|Hosted Control|  
|Contoso Main Toolbar Container|Hosted Control|  
|Contoso Main Toolbar|Toolbar|  

 To add a control to the configuration:  

1. Sign in to Unified Service Desk Administrator. 

2. Select **Configuration** under **Advanced Settings**.  

3. Select **Contoso Configuration** to open the definition.  

4. Select the **Hosted Controls, Events and Action Calls** tab.  

5. Select the ellipsis (...) in the **Action Calls** section, and then select **Add Existing Action Call**. The **Lookup Records** pane is displayed.

6. Type the name of the action call mentioned in the above table in the search box. The action calls are displayed in the search results. Select the record from the list, and then select **Add**.  

7. Select the ellipsis (...) in the **Hosted Controls** section, and then select **Add Existing Hosted Control**. The **Lookup Records** pane is displayed.  

8. Type the name of the hosted control mentioned in the above table in the search box. The hosted controls are displayed in the search results. Select the record from the list, and then select **Add**.

9. Select the **Toolbars, Window Navigation Rules and Entity Searches** tab.

10. Select the ellipsis (...) in the **Toolbars** section, and then select **Add Existing Toolbar**. The **Lookup Records** pane is displayed.

11. Type **Contoso Main Toolbar** in the search box. Select the record from the list, and then select **Add**.

12. Select **Save**.  

<a name="Step6"></a>   
## Step 6: Test the application  
 Start the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application, and sign in to the Dynamics 365 instance where you configured [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] using the same user credentials that you assigned to the **Contoso Configuration** in [Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md). For information about connecting to Dataverse instance using the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application, see [Connect to a model-driven instance using the Unified Service Desk client](../unified-service-desk/admin/connect-dynamics-365-instance-using-unified-service-desk-client.md).  

 Your agent application will now have a **SEARCH** button in the toolbar area with two child buttons (**Account** and **Contact**) that are displayed on selecting the down arrow.  

 ![Display account and contact records](../unified-service-desk/media/crm-itpro-usd-wt03-12.png "Display account and contact records")  

 Select **Account** or **Contact** under the **SEARCH** button to display the respective records from your instance in separate tabs in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application.  

 ![Contact records displayed](../unified-service-desk/media/crm-itpro-usd-wt03-13-unified-interface.png "Contact records displayed")  

<a name="Conclusion"></a>   
## Conclusion  
 In this walkthrough, you learned how to display model-driven app records in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application. You also learned how to filter access to [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] controls using configuration.

### See also

 [Support for Unified Interface Apps in Unified Service Desk](../unified-service-desk/admin/Support-unified-interfaces-apps-usd.md)

 [Unified Interface Page (Hosted Control)](../unified-service-desk/unified-interface-page-hosted-control.md)

 [Unified Service Desk and Unified Interface Configuration Walkthroughs](../unified-service-desk/unified-service-desk-unified-interface-configuration-walkthroughs.md)

 [Walkthrough 1: Build a simple agent application for Unified Interface Apps](../unified-service-desk/walkthrough1-unified-interface-build-a-simple-agent-application.md)   

 [Walkthrough 2: Display an external webpage in your agent application](../unified-service-desk/walkthrough2-unified-interface-display-an-external-webpage-in-your-agent-application.md)
 
 [Walkthrough 4: Display a Unified Interface apps record in a session in your agent application](../unified-service-desk/walkthrough4-unified-interface-display-dynamics-365-record-session-agent-application.md)   

 [Walkthrough 5: Display enhanced session information by displaying session name and overview data](../unified-service-desk/walkthrough5-unified-interface-display-enhanced-session-information-displaying-session-name-overview-data.md) 

 [Walkthrough 6: Configure the Debugger hosted control in your agent application](../unified-service-desk/walkthrough6-unified-interface-configure-debugger-hosted-control-agent-application.md)

 [Walkthrough 7: Configure agent scripting in your agent application](../unified-service-desk/walkthrough7-unified-interface-configure-agent-scripting-agent-application.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]