---
title: Add a timer control for SLA-enabled entities
description: Add a timer control to SLA-enabled entity forms to help users track time and complete tasks within specified SLA time frames.
ms.date: 12/13/2024
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
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:02/27/2024
---

# Add a timer control for SLA-enabled entities

Add a timer control to a service-level agreement (SLA) enabled entity form to help users gauge the amount of time they have to complete a task as specified in the SLA. The timer control displays countdown timers that show the current status and time remaining for the configured SLA KPIs.

## Add a SLA timer to a SLA-enabled entity

After you've configured the SLA KPIs, SLAs, and SLA items for an entity, you can add the SLA Timer control to display the SLA KPIs that are configured for the entity. You can customize the views to filter the KPIs and display only the relevant KPIs to customer service representatives (service representatives). Some of the KPIs that service representatives can see include the different stages that KPIs go through.

For information on how the SLA KPIs are displayed at runtime when service representatives view the case to work on in Customer Service Hub, see [Timer for SLA-enabled entities](../use/customer-service-hub-user-guide-case-sla.md#timer-control-for-sla-enabled-entities).

> [!NOTE]
> - The SLA Timer control displays SLA KPIs that are created in Unified Interface only.
> - The SLA Timer control displays  **No Applicable SLA** when there aren't any applicable SLAs.

A sample runtime view of the SLA Timer is as follows.

![Runtime view of the SLA timers.](../media/sla-timer-runtime.png "Runtime view of the SLA timers")

However, SLA KPI Instances won't reach a **Nearing non-compliance** or **Non-complaint** state, if the **SLAWarningAndExpiryMonitoringFlow** isn't enabled and the SLA KPI Instance timer continues to run. The following warning message is displayed on the SLA Timers:
"The SLA instances may be incorrect because workflow <*workflow ID*> is turned off. Please contact your admin to turn the workflow on." The workflow ID varies from system to system as it corresponds to **SLAWarningAndExpiryMonitoringFlow**. For more information on how to enable **SLAWarningAndExpiryMonitoringFlow**, see [ Warning message appears on slakpiinstances](../troubleshoot-sla-issues.md#warning-message-appears-on-slakpiinstances).

For more information on why an SLA KPI Instance doesn't reach **Nearing Non-compliance** or **Non-compliant** state and how you can resolve it, see [SLA KPI Instance doesn't reach Nearing Non-compliance or Non-compliant state, and the SLA KPI Instance timer continues to run](../troubleshoot-sla-issues.md#sla-kpi-instance-doesnt-reach-nearing-non-compliance-or-non-compliant-state-and-the-sla-kpi-instance-timer-continues-to-run).

Do the following steps to add the SLA timer control for the case entity.

> [!IMPORTANT]
> You can add the SLA timer control only in the classic Power Apps experience.

1. In your Power Platform environment, select **Advanced Settings** to go to **Customizations**.
2. Select **Customize the System**, and in the **Solutions** page, expand **Entities** under **Components**.
3. Select the entity for which you want to add the SLA Timer control, and in the **Forms** view, select the corresponding form. In this example, let us select the Case entity, and the **Case for interactive experience** form.
4. On the page that appears, on the **Insert** tab, insert a section, and then insert a subgrid.
5. Double-click the subgrid and in the **Set Properties** dialog, enter the necessary details. On the **Display** tab, **Data Source** section:
   1. For **Records**, select **Only Related Records**.
    
        Selecting **All Record Types** retrieves all the SLA KPI instances present in the organization and might lead to performance issues.
   1. For **Entity**, select **SLA KPI Instances (Regarding)**.
   1. In **Default View**, add a view or edit an existing view to determine the SLA KPIs that need to be displayed for service representatives at runtime. For more information on views, see [Create and edit views](/powerapps/maker/model-driven-apps/create-edit-views-app-designer).

   > ![Configure SLA Timer in customizations.](../media/sla-timer-properties.png "Configure SLA Timer in customizations")

6. On the **Controls** tab, enter the following information:
   1. Select **Add Control**, and then select **SLA Timer**.
   2. In the **SLA Timer** area, enter a value for **Update_Frequency_key** to set the timer refresh interval. For optimal performance, choose an interval that isn't too short. The default interval is 30 minutes.

   > ![Set refresh frequency for timer.](../media/sla-timer-update-frequency.png)

7. Save and publish the solution.

### Enable elapsed time for SLA Timers in expired status

You can configure the negative countdown property for the SLA timer so that the timer continues to display the elapsed time after the SLA expires instead of showing the status. The setting needs to be configured for each SLA Timer instance.

1. After you add the SLA Timer control, set the **Turn on negative countdown** property as **Yes**.

   :::image type="content" source="../media/sla-negative-countdown.png" alt-text="Configure negative countdown in SLA timer.":::

2. Save and publish the solution.

### Customize the SLA timer control display label

After you've added the SLA timer control for a SLA-enabled entity, you can customize the labels of the status to be displayed for the timer control.

1. In the SLA Timer area, select **Edit** for **Customized Labels**.

   :::image type="content" source="../media/sla-timer-customized-label.png" alt-text="SLA timer customized label option":::

1. In the **Configure Property "Customized Label"** dialog, select the **Bind to a static value** option and enter the values for multiple language codes.

    :::image type="content" source="../media/sla-timer_configure_property.png" alt-text="SLA timer configure property dialog":::
   - The language code value must be of the following format:

     `(language code1)=(KPI instance status value):(KPI instance custom label)`<br>For example, 1033=1:Custom Noncompliant

   - You can also enter multiple language codes by separating them with a semicolon:<br>`(language code1)=(KPI instance status value):(KPI instance custom label); (language code2)=(KPI instance status value):(KPI instance custom label)`<br>For example, 1033=1:Custom Noncompliant; 3:Paused
    
   - If you need to create multiple language code sets, you must separate each set by selecting **Enter**. For example: 
    
     1. Enter `(language code1)=(KPI instance status value):(KPI instance custom label); (language code2)=(KPI instance status value):(KPI instance custom label)`

      1. Select **Enter**.

      1. Enter `(language code1)=(KPI instance status value):(KPI instance custom label); (language code2)=(KPI instance status value):(KPI instance custom label)`
   
   - The customizable status codes are:

       - 1: Noncompliant
       - 3: Paused
       - 4: Succeeded
       - 5: Canceled

   - To look up the language code, or to enable or disable a language, go to **Advanced Settings**>**Administration**>**Languages**.
     
3. Select **OK**.

4. Save and publish the solution.

## Add an out-of-the-box timer control to the Case form

 On a case form, the timer control can show any of the following, depending on the actions of the customer service representative and what you specify when you set up the timer control:  
  
- If the customer service representative completes the task within the remaining time, the control shows the word **Succeeded**.  
  
- If the customer service representative doesn’t complete the task within the remaining time, the control shows the word **Expired**.  
  
- As the timer counts down, the color changes to yellow as the time remaining nears non-compliance. If the time remaining expires, the timer shows the word **Expired**. Then the timer color changes to red and the timer starts counting up to show the elapsed time since the task should have been completed. This behavior is optional.  
  
- If a condition causes the milestone to be canceled, the control shows the word **Canceled**. This behavior is optional.  
  
- If either of the required fields in the **Timer Control** dialog doesn't have a value in the record, the control shows the words **Not Set**.  
  
    ![Timer control state in Customer Service Hub.](../media/timer-sla-csh.png "Timer control state in Customer Service Hub")

    ![Timer control expired in Customer Service Hub.](../media/timer-sla-csh-expired.png "Timer control expired in Customer Service Hub")
  
> [!IMPORTANT]
> - The instructions in this article apply if you're adding a timer to track time for the date/time field of any entity, or for tracking time against standard SLAs on case records. If you are using enhanced SLAs and want to add a timer to your forms, go to [Add a timer to forms to track time against enhanced SLAs](add-timer-forms-track-time-against-enhanced-sla.md).  
> - The timer control is designed to visually show the current state or show the remaining or elapsed time relative to the date and time as specified in the **Failure Time** field of the SLA KPI Instance. It doesn’t calculate or keep track of the time for which the Pause condition is true.  
 
> [!NOTE]
> The screens showcase the timer control on a Unified Interface app. On a legacy web client app, the timer control is displayed as follows: <br><br> ![Timer control in webclient app.](../media/timer-control-webclient.png)

More information: [Understand SLA details with Timer control](../use/customer-service-hub-user-guide-case-sla.md#understand-sla-details-with-timer-control)

### Add an out-of-the-box timer control  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../../includes/proc-follow-steps-in-link.md)]  
  
2. [!INCLUDE[proc_settings_customization](../../includes/proc-settings-customization.md)]  
  
3. Select **Customize the System**.  
  
4. In the solution explorer on the left pane, expand **Entities**, expand the **Case** entity, and select **Forms**.
  
    To add the timer to the form so the customer service representatives can use it in Customer Service Hub, open the case form of type **Main**.  
  
5. Select on the form where you want to place the control. You can add it anywhere except the form header or footer.  
  
6. On the **Insert** tab, in the **Control** group, select **Timer**.  

   ![Timer control button on Insert tab in Customer Service Hub.](../media/insert-timer-control.png "Timer control button on Insert tab in Customer Service Hub")
  
7. In the **Timer Control** dialog, do the following:  
  
   1. In the **General** section, type a name and label for the control.  
  
   2. Under **Data Source**, next to **Failure Time Field**, select the date-time field that represents the time when a milestone should be completed. For example, select the **First Response By** field.  
  
   3. Next to **Success Condition**, select a field to use to evaluate the success of the milestone, and then select the condition that indicates success. For example, select the **First Response Sent** field, and then select **Yes** to indicate the success criteria of the First Response metric. This setting is required.  
  
   4. Next to **Failure Condition**, select a field to use to evaluate the failure of the milestone, and then select the condition that indicates the failure. For example, in the first drop-down list, select **IsEscalated**. In the second drop-down list, select **Yes**.  
  
   5. Next to **Warning Condition**, enter the condition that will cause the timer control to display a warning when the time is about to expire. For example, in the first list next to **Warning Condition**, select **First Response SLA Status**. In the list to the right, select **Nearing Noncompliance**. This setting is optional.  
  
   6. Next to **Cancel Condition**, select a field to evaluate whether the achievement of the milestone should be canceled. Then choose the option that indicates the milestone is canceled. This setting is optional.  
  
   7. Next to **Pause Condition**, enter the condition that will cause the timer to pause the count down. For example, you want the timer to pause the count down every time the case status is set to “On-hold”. For this, in the first drop-down list, select **Status**. In the second drop-down list, select **On-hold**.  
  
      ![Timer control in Customer Service Hub.](../media/timer-control-box-csh.png "Timer control in Customer Service Hub")
  
8. Select **OK** to add the control to the form.  
  
   **Notes**  
  
   - The timer control refreshes on the **OnChange** form event, and also when the form is loaded.  
  
   - You can add a timer control to a form based on any record type (entity), including custom record types.  
  
   - You can add multiple timer controls for different key performance indicators (KPIs).  
  
   - You can add a timer control to any Main or Main - Interactive experience form of other entities, but timer controls are not displayed in [!INCLUDE[pn_moca_full](../../includes/pn-moca-full.md)].  
  
### Related information  

[Configure service level agreements](define-service-level-agreements.md)

[Set and enable languages](../../customerengagement/on-premises/admin/enable-languages.md#set-and-enable-languages)

[Add a timer in forms to track time against enhanced SLAs](add-timer-forms-track-time-against-enhanced-sla.md)

[Understand SLA details with Timer control](../use/customer-service-hub-user-guide-case-sla.md#understand-sla-details-with-timer-control)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
