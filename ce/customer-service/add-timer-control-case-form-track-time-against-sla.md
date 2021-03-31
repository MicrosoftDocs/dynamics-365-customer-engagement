---
title: "Timer control for SLA-enabled entities | Microsoft Docs"
description: "Learn how to add timer control in the case form to track time against an SLA in Dynamics 365 Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/05/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Add a timer control for SLA-enabled entities

Add a timer control to an service-level agreement (SLA) enabled entity form to help users gauge the amount of time they have to complete a task as specified in the SLA. The timer control displays count-down timers that show the current status and time remaining for the configured SLA KPIs.

## Add an SLA timer to an SLA-enabled entity

After you've configured the SLA KPIs, SLAs, and SLA items for an entity, you can add the SLA Timer control to display the SLA KPIs that are configured for the entity. You can customize the views to filter the KPIs and display only the relevant KPIs to agents. Some of the KPIs that agents can see include the different stages that KPIs go through.

For information on how the SLA KPIs are displayed at runtime when agents view the case to work on in Customer Service Hub, see [Timer for SLA-enabled entities](customer-service-hub-user-guide-case-sla.md#timer-control-for-sla-enabled-entities).

> [!NOTE]
> The SLA Timer control displays SLA KPIs that are created in Unified Interface only.

Do the following steps to add the SLA timer control for the case entity.

> [!IMPORTANT]
> You can add the SLA timer control only in the classic PowerApps experience.

1. In your Dynamics 365 environment, go to **Customizations**.
2. Select the entity for which you want to add the SLA Timer control, and in the **Forms** view, select the corresponding form. In this example, let us select the Case entity, and the **Case for interactive experience** form.
3. On the page that appears, on the **Insert** tab, insert a section, and then insert a subgrid.
4. Double-click the subgrid, and on the **Set Properties** dialog box, enter the necessary details.
   - In the **Data Source** area, in **Default View**, you can add a view or edit an existing view to determine the SLA KPIs that should be displayed for agents at runtime. For information on views, see [Create and edit views](/powerapps/maker/model-driven-apps/create-edit-views-app-designer).

   > ![Configure SLA Timer in customizations](../customer-service/media/sla-timer-properties.png "Configure SLA Timer in customizations")

5. On the **Controls** tab, enter the following information:
   1. Select **Add Control**, and choose SLA Timer.
   2. In the **SLA Timer** area, enter a value for **Update_Frequency_key** to set the timer refresh interval. For optimal performance, choose an interval that is not too short. The default interval is 30 minutes.

   > ![Set refresh frequency for timer](media/sla-timer-update-frequency.png)

6. Save and publish the solution.

## Add an out-of-the-box timer control to the Case form

 On a case form, the timer control can show any of the following, depending on the actions of the customer service representative (CSR) and what you specify when you set up the timer control:  
  
- If the CSR completes the task within the time remaining, the control shows the word **Succeeded**.  
  
- If the CSR doesn’t complete the task within the time remaining, the control shows the word **Expired**.  
  
- As the timer counts down, the color changes to yellow as the time remaining nears non-compliance. If the time remaining expires, the timer shows the word **Expired**. Then the timer color changes to red and the timer starts counting up to show the elapsed time since the task should have been completed. This behavior is optional.  
  
- If a condition causes the milestone to be canceled, the control shows the word **Canceled**. This behavior is optional.  
  
-   If either of the required fields in the **Timer Control** dialog box do not have a value in the record, the control shows the words **Not Set**.  
  
    ![Timer control state in Customer Service Hub](media/timer-sla-csh.png "Timer control state in Customer Service Hub")

    ![Timer control expired in Customer Service Hub](media/timer-sla-csh-expired.png "Timer control expired in Customer Service Hub")
  
> [!IMPORTANT]
> - The instructions in this topic apply if you're adding a timer to track time for the date/time field of any entity, or for tracking time against standard SLAs on case records. If you are using enhanced SLAs and want to add a timer to your forms, see [Add a timer to forms to track time against enhanced SLAs](../customer-service/add-timer-forms-track-time-against-enhanced-sla.md).  
> - The timer control is designed to visually show the current state or show the remaining or elapsed time relative to the date and time as specified in the **Failure Time** field of the SLA KPI Instance. It doesn’t calculate or keep track of the time for which the Pause condition is true.  
 
> [!NOTE]
> The screens showcase the timer control on a Unified interface based app. On a webclient app, the timer control is displayed as follows: <br><br> ![Timer control in webclient app](media/timer-control-webclient.png)


For more information, see: [Track SLA details with Timer Control](customer-service-hub-user-guide-case-sla.md#track-sla-details-with-timer-control)


### Add an out-of-the-box timer control  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
2. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
3. Select **Customize the System**.  
  
4. In the solution explorer, in the left nav pane, expand **Entities**, expand the **Case** entity, and select **Forms**.
  
    To add the timer to the form so the customer service representatives can use it in the Customer Service Hub, open the case form of type **Main**.  
  
5. Select on the form where you want to place the control. You can add it anywhere except the form header or footer.  
  
6. On the **Insert** tab, in the **Control** group, select **Timer**.  

   ![Timer control button on Insert tab in Customer Service Hub](media/insert-timer-control.png "Timer control button on Insert tab in Customer Service Hub")
  
7. In the **Timer Control** dialog box:  
  
   1. In the **General** section, type a name and label for the control.  
  
   2. Under **Data Source**, next to **Failure Time Field**, select the date-time field that represents the time when a milestone should be completed. For example, select the **First Response By** field.  
  
   3. Next to **Success Condition**, select a field to use to evaluate the success of the milestone, and then select the condition that indicates success. For example, select the **First Response Sent** field, and then select **Yes** to indicate the success criteria of the First Response metric. This setting is required.  
  
   4. Next to **Failure Condition**, select a field to use to evaluate the failure of the milestone, and then select the condition that indicates the failure. For example, in the first drop-down list, select **IsEscalated**. In the second drop-down list, select **Yes**.  
  
   5. Next to **Warning Condition**, enter the condition that will cause the timer control to display a warning when the time is about to expire. For example, in the first list next to **Warning Condition**, select **First Response SLA Status**. In the list to the right, select **Nearing Noncompliance**. This setting is optional.  
  
   6. Next to **Cancel Condition**, select a field to evaluate whether the achievement of the milestone should be canceled. Then choose the option that indicates the milestone is canceled. This setting is optional.  
  
   7. Next to **Pause Condition**, enter the condition that will cause the timer to pause the count down. For example, you want the timer to pause the count down every time the case status is set to “On-hold”. For this, in the first drop-down list, select **Status**. In the second drop-down list, select **On-hold**.  
  
      ![Timer control in Customer Service Hub](media/timer-control-box-csh.png "Timer control in Customer Service Hub")
  
8. Select **OK** to add the control to the form.  
  
   **Notes**  
  
- The timer control refreshes on the **OnChange** form event, and also when the form is loaded.  
  
- You can add a timer control to a form based on any record type (entity), including custom record types.  
  
- You can add multiple timer controls for different key performance indicators (KPIs).  
  
- You can add a timer control to any Main or Main - Interactive experience form of other entities, but timer controls are not displayed in [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)].  
  
### See also  

[Add a timer in forms to track time against enhanced SLAs](add-timer-forms-track-time-against-enhanced-sla.md)

[Track SLA details with Timer Control](customer-service-hub-user-guide-case-sla.md#track-sla-details-with-timer-control)



[!INCLUDE[footer-include](../includes/footer-banner.md)]