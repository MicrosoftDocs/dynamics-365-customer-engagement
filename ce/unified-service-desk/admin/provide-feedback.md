---
title: "Provide feedback about Unified Service Desk | MicrosoftDocs"
description: "Learn about providing feedback about Unified Service Desk."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 04/24/2018
ms.topic: article
ms.service: dynamics-365-customerservice
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
---
# Provide feedback about [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

Have a comment or suggestion about [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]? We need your feedback to help us deliver a reliable product. Good or bad, the quickest route to get your comments to our team is right from within [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. 

With [!INCLUDE[pn-unified-service-desk-3-3](../../includes/pn-unified-service-desk-3-3.md)], you can see **Provide Feedback** option as a smiley on the toolbar.

## Walkthrough: Configure provide feedback window in your agent application

The walkthrough demonstrates how to set up provide feedback window in your agent application. In this walkthrough, you will learn to create **Provide Feedback** button on the **About Toolbar** toolbar container and associate an Action Call to the button.

### Prerequisites

You must know about the following in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]:

 - The Toolbar Container type of hosted control. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Hosted control types and action/event reference](../../unified-service-desk/hosted-control-types-action-event-reference.md)  

 - Action call and how to configure it. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Action calls](../../unified-service-desk/action-calls.md)

<a name="Top"></a>   
## In This Walkthrough

 [Step 1: Create a toolbar container type of hosted control](#Step1)

 [Step 2: Add a toolbar and attach it to the toolbar container](#Step2)

 [Step 3: Add toolbar button and action call to display the feedback window](#Step3)

 [Step 4: Add the controls to the configuration ](#Step4)

 [Step 5: Test the provide feedback option in the application](#Step5)

 [Conclusion](#Conclusion)

<a name="Step1"></a>   
## Step 1: Create a toolbar container type of hosted control  

 Toolbar Container type of hosted control are used to hold and display the toolbars in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. In this section, you’ll create a **Toolbar Container** hosted control that will appear at the top of the client application.  

1. Sign in to the Dynamics 365 instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Hosted Controls** under **Basic Settings** in the site map.

5. Select **+ New** in the **Active Hosted Controls** page.  

6. Specify the following values on the **New Hosted Control** page. 

   |       Field        |          Value          |
   |--------------------|-------------------------|
   |        Name        | About Toolbar Container |
   | USD Component Type |    Toolbar Container    |
   |   Display Group    |       AboutPanel        |

7. Select **Save**.

<a name="Step2"></a>   
## Step 2: Add a toolbar and attach it to the toolbar container  
 In this step, you’ll create a toolbar, and attach the toolbar to the toolbar container hosted control created in step 1. This is done to display the toolbar in your agent application.  

1. Sign in to the Dynamics 365 instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Toolbars** under **Basic Settings** in the site map.

5. Select **+ New** on the **Active Toolbars** page.

6. Enter **About Toolbar** in the **Name** box on the **New Toolbar** page.

7. Select **Save**.

8. Attach the toolbar to the toolbar container hosted control created in step 1. Select the **Related** tab and select **Hosted Controls**.

9. Select **Add Existing Hosted Control**. The **Lookup Records** pane appears.

10. Enter **About Toolbar Container** in the search bar, select the record from the list and then select **Add**.

11. Select **Save**.

<a name="Step3"></a>   
## Step 3: Add toolbar button and action call to display the feedback window

 In this step, you’ll add button on the toolbar and attach action call to the button so that when the button is selected, **Provide Feedback** window is displayed in the hosted control that you created in step 1. After you save the toolbar in step 2, the **Buttons** area becomes available. 

1. Select the **Related** tab and select **Buttons** 

2. Select **+ Add New Toolbar Button**.

3. Specify the following values on the **New Toolbar Button** page.  

    |Field|Value|  
    |-----------|-----------|  
    |Name|Provide Feedback|
    |Image|msdyusd_Feedback_16|
    |Tooltip|Provide Feedback|  
    |Order|102|

4. Select **Save**. Now, you need to add the action call to display the **Provide Feedback** in the hosted control created in step 1.

5. Select the **Add an Existing Action Call** in the **Provide Feedback** button page. The **Lookup Records** pane appears.

6. Type of the name of the record in the search box. If the record is not present, you can create by selecting **+ New**.

7. Specify the following values on the **New Action Call** page.

    |Field|Value|  
    |-----------|-----------|  
    |Name|Show FeedBack Window|  
    |Order|1|  
    |Hosted Control|CRM Global Manager|  
    |Action|ShowFeedback|

8. Select **Save**. The new action call gets added to the **Provide Feedback** button.

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

1. Sign in to the Dynamics 365 instance.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Configuration** under **Advanced Settings** in the site map.

5. Select **Contoso Configuration** to from the list.  

6. Select the **Hosted Controls, Events and Action Calls** tab.  

7. Select the ellipsis (More Commands option) in the **Action Calls** section and then select **Add Existing Action Call**. The **Lookup Records** pane appears.

8. Type **Show FeedBack Window** in the search bar. The action call listed earlier is displayed in the search results. Now, select the action from the list, and then select **Add**. After you add, select **Save** to save the configuration.

9. Next you must add the hosted control. Select the **Hosted Controls, Events and Action Calls** tab.

10. Select the ellipsis (More Commands option) in the **Hosted Controls** section and then select **Add Existing Hosted Control**. The **Lookup Records** pane appears.

11. Type **About Toolbar Container** in the search bar. The hosted control listed earlier is displayed in the search results. Now, select the hosted control from the list, and then select **Add**. After you add, select **Save** to save the configuration.

12. Next you must add the toolbar. Select the **Toolbars, Window Navigation Rules and Entity Searches** tab.

13. Select the ellipsis (More Commands option) in the **Toolbars** section and then select **Add Existing Toolbar**. The **Lookup Records** pane appears.

14. Type **Provide Feedback** in the search bar. The toolbar listed earlier is displayed in the search results. Now, select the toolbar from the list, and then select **Add**. After you add, select **Save** to save the configuration.


<a name="Step5"></a> 
## Step 5: Test the provide feedback option in the application

Start the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application, and sign in to the Dynamics 365 instance where you configured [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] using the same user credentials that you assigned to the **Contoso Configuration**. For information about connecting to the Dataverse instance using the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application, see [Connect to a instance using the Unified Service Desk client](../../unified-service-desk/admin/connect-dynamics-365-instance-using-unified-service-desk-client.md).

Your agent application will now have a **Smiley** button in the toolbar area.

1. On the toolbar, select the **Provide Feedback** smiley. <br/>The **Feedback** window appears.<br>
2. Select a smiley from the list:
   - Good
   - Normal
   - Bad
3. Type your feedback or suggestion in the text box. 
4. Select **Submit** to send your feedback to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)].<br>

   ![Provide feedback smiley and window](../media/provide-feedback-smiley-window.PNG "Provide feedback smiley and window")


<a name="Conclusion"></a> 
## Conclusion

 In this walkthrough, you learned how to set up provide feedback button in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application.  

> [!Note]
> It is recommended that you do not submit any feedback containing personal or other data that is subject to legal or regulatory compliance requirements.
> 
> [!Note]
> Setting the **HelpImproveUsd** global option to **False**, disables the data collection and [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] dose not send information to [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)]. If the data collection is disabled, then agent or system administrator cannot provide feedback due to insufficient permissions.<br>
> ![Insufficient Permissions](../media/insufficient-permissions-provide-feedback-window.PNG "Insufficient Permissions")

## See also

[Help improve Unified Service Desk](../admin/help-improve-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]