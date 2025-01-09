---
title: Add timer in forms to track time against enhanced SLAs (Dynamics 365 Customer Service)
description: Learn the procedure to add a timer in forms to track time against enhanced SLAs in Dynamics 365 Customer Service.
ms.date: 09/04/2024
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# Add a timer in forms to track time against enhanced SLAs

> [!NOTE]
> - Enhanced SLAs have been deprecated and replaced with Unified Interface SLAs. Learn more in [SLAs in web client are deprecated](../implement/deprecations-customer-service.md#slas-in-web-client-are-deprecated).
> - For more information about adding a timer control to Unified Interface SLA-enabled entities, go to [Add a timer control for SLA-enabled entities](add-timer-control-case-form-track-time-against-sla.md#add-a-timer-control-for-sla-enabled-entities).

A timer helps users gauge the amount of time they have to complete a key performance indicator (KPI) that is typically associated with a service level agreement (SLA). If your organization uses enhanced SLAs, you must use quick view forms to add a timer to track time against such SLAs.  
  
 The timer control initially displays a count-down timer to show the time remaining to complete the KPI.  
  
> [!NOTE]
> - A timer control can be used independent of SLAs, too.  
> - The timer control is designed to visually show the current state or show the remaining or elapsed time relative to the date and time specified in the **Failure Time** field of the SLA KPI instance. It doesn’t calculate or keep track of the time for which the Pause condition is true.  
  
 The timer control can show any of the following, depending on the actions of the user and what you as a system administrator or customizer specify when you set up the timer control:  
  
-   If the user completes the task within the remaining time, the control shows the word **Succeeded**.  
  
-   If the user doesn’t complete the task within the remaining time, the control shows the word **Expired**.  
  
-   As the timer counts down, the color changes to yellow as the time remaining nears non-compliance. If the time remaining expires, the timer shows the word **Expired**. Then the timer color changes to red and the timer starts counting up to show the elapsed time since the task should have completed.  
  
-   If a condition causes the SLA KPI to pause, the control shows the word **Paused**.  
  
-   If a condition causes the SLA KPI to be canceled, the control shows the word **Canceled**. This behavior is optional.  
  
-   If either of the required fields in the **Timer Control** dialog box doesn't a value in the record, the control shows the words **Not Set**.  
  
To add a timer to track time against enhanced SLAs:  
  
1.  Ensure the entity is enabled for SLA.  
  
1.  Create SLA KPI fields for the entity for which you want to create the SLA.  
  
1.  Create quick view forms for each SLA KPI instance field that you created.  
  
1.  Create an SLA.  
  
1.  Add the quick view forms that you created to the primary entity form  
  
## Enable an entity for SLA  

To add a timer for an enhanced SLA to an entity form, that entity must be enabled for SLA. Learn more in [Enable entities for service level agreements](enable-entities-service-level-agreements.md).  
  
## Create SLA KPI fields  
  
1. [!INCLUDE[proc_permissions_system_admin](../../includes/proc-permissions-system-admin.md)]  
  
    #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../../includes/proc-dont-have-correct-permissions.md)]  
  
1. [!INCLUDE[proc_settings_customization](../../includes/proc-settings-customization.md)]  
  
1. Choose **Customize the System**.  
  
1. Under **Components**, expand **Entities**, and then expand the entity you want.  
  
1. Click **Fields**.  
  
1. On the Actions toolbar, click **New**, and then enter a **Display Name** to generate the **Name**.  
  
1. In the **Data Type** drop-down list, select **Lookup**.  
  
1. In the **Target Record Type** drop-down list, select a SLA KPI Instance.  
  
    If you create a lookup field in an entity form, the relationship is automatically generated. A lookup field is created as a relationship field.  
  
1. Click **Save and Close** to close the form editor.  
  
1. Publish your customization.  
  
    -   To publish customizations for just one entity, under **Components**, select **Entities**. Then, on the Actions toolbar, select **Publish**.  
  
    -   To publish all customizations you made to any entities or components, on the Actions toolbar, select **Publish All Customizations**.  
  
## Create quick view forms for the SLA KPI Instance entity

 Quick view forms help you show data of a related entity in the primary entity form. For enhanced SLAs, all the SLA-related states and times are stored in the SLA KPI instance entity. To show this data in the primary entity like a lead or an opportunity form, you must create a quick view form for each SLA KPI field that you created for the primary entity. Add a timer to the quick view form so it shows the count down for the SLA.  
  
#### Create a quick view form  
  
1. [!INCLUDE[proc_settings_customization](../../includes/proc-settings-customization.md)]  
  
1. Choose **Customizations**, then choose **Customize the System**.  
  
1. In the solutions explorer, expand the SLA KPI Instance entity, and then select **Forms**.  
  
1. Select **New** > **Quick View Form** from the tool bar.  
  
1. In the **Form** group, click **Form Properties**, and then specify a form name.  
  
1. Double-click the section, type a meaningful name for the section, and then click **OK**.  
  
1. Select the section, and on the **Insert** tab, click **Timer**.  
  
1. Specify a name and label for the timer, and the data source for the failure time.  
  
    Following is an example of the properties you'd set for a timer for a Case entity.  
  
    ![Timer control properties for Enhanced SLA.](../media/crm-ua-v8-1-timer-control-dialog-box-enhanced-sla.png "Timer control properties for enhanced SLA")  
  
   > [!NOTE]
   >  Typically, for enhanced SLAs, the timer control is set up using the SLA KPI Instance status field values only.  
  
1. When you're finished, select **OK**.  
  
1. Publish the customizations .  
  
## Create an SLA

Create an SLA for the entity you want to track. For example, you may want to track the time taken by sales person to take action on a lead, like qualifying or disqualifying a lead. For this tracking, create an SLA for the lead entity. For more information on creating an SLA, go to [Define service level agreements](define-service-level-agreements.md)  
  
## Add the quick view form to the primary entity form to show the timer

 You can add the quick view forms you created earlier as quick view controls in the primary entity forms.  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../../includes/proc-follow-steps-in-link.md)]  
  
1. [!INCLUDE[proc_settings_customization](../../includes/proc-settings-customization.md)]  
  
1. Select **Customize the System**. In the solution explorer, in the left nav pane, expand **Entities**, expand the entity you want to add the quick view form to, and then select **Forms**.  
  
1. To add the timer to use in the Dynamics 365 Customer Service app, open the form of type **Main**.  
  
    -OR-  
  
    To add the timer to the interactive experience form so users can use it in the interactive service hub, open the form of type **Main – Interactive experience**  
  
1. Add a section to insert the quick view control. On  the **Insert** tab, in the **Section** group, select **Section**, and then select **One Column**.   Double-click the section to specify the section properties. Learn more in [Section properties](../../customerengagement/on-premises/customize/section-properties-legacy.md).  
  
   > [!NOTE]
   >  You can't add an SLA timer to the reference panel section of the Main - Interactive experience form.  
  
1. Select the section that you just added, and on the **Insert** tab, in the **Control** group, select **Quick View Form** .  
  
1. Specify a name and label for the quick view control. In the **Lookup Field** drop-down list, select the lookup field that you created to point to the SLA KPI Instance entity.  
  
1. The Related Entity drop-down list is automatically set to "SLA KPI Instance".  
  
1. In the **Quick View Form** drop-down list, select the quick view form you created in the SLA KPI Instance entity.  
  
1. Select **OK** to close the **Quick View Control Properties** dialog box.  
  
    You must save and publish the Main form before the quick view control changes are visible.  
  
### Related information  
 [Add a timer control to the Case form to track time against an SLA](add-timer-control-case-form-track-time-against-sla.md)   


 


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
