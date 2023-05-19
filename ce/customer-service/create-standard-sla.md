---
title: "Create standard service-level agreements in Dynamics 365 Customer Service | MicrosoftDocs"
description: "Learn how to create standard service-level agreements in Dynamics 365 Customer Service."
ms.date: 06/16/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
  - intro-internal
---

# Create standard SLAs

> [!NOTE]
>
> Standard SLAs created in the web client have been deprecated and replaced with Unified Interface SLAs. For more information on deprecation, see [SLAs in web client are deprecated](deprecations-customer-service.md#slas-in-web-client-are-deprecated). We recommend migrating the standard SLAs created in the web client to Unified Interface. For more information on migrating SLAs, see [Migrate SLAs](migrate-slas.md#migrate-slas).

1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  

     When you activate an SLA, a corresponding workflow is also created. For every action you perform on the SLA, you must have permissions to perform the same action on workflows. The SLA is applied in the context of the permissions that the owner of the SLA has.  

    **Check your security role**  

   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  

   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  

2. Go to **Settings** > **Service Management**.

3. Go to **Service Level Agreements**.  

4. To create a new SLA, select **New** on the command bar.  

    -Or-  

    To edit an SLA, select the SLA in the list of records, and then select **Edit** on the command bar.  

5. If you're creating a new SLA, you'll see the **Create SLA** dialog box. Type a name for the SLA, and then in the **Entity** dropdown list, select **Case**.  

    You do this because you can create a standard SLA only for the Case entity.  

6. Enter your information as follows:

   - **Applicable From**. Select the case field that specifies the date and time from which the SLA items will be calculated. For example, if you select the **Created On** field, calculations will start from the time the case was created.  

       > [!NOTE]
       >  You can have multiple SLA KPIs within one SLA. The start time for different SLA KPIs within an SLA is set at the SLA level and can't be different across SLA KPIs. The start time is determined by the **Applicable From** field value.  

   - **Business Hours**. Select a customer service schedule record that defines your support organization's business hours. This is useful in the SLA time-tracking calculations. If a business hours record (customer service schedule) isn't selected, work hours are considered to be all day, every day.  

   - **SLA Type**. Select **Standard**.  

        You can select **Standard** only when the **Entity** field is set to **Case**.  

   - **Allow Pause and Resume**. Select **Do Not Allow**. Because standard SLAs don't support pausing and resuming of SLAs, you can set this field to **Allow** only when you're creating an enhanced SLA.  

7. [!INCLUDE[proc_click_or_tap_save](../includes/proc-click-or-tap-save.md)]  

8. To add SLA details, in the **SLA Details** section, select the **Add** button ![Add button.](media/crm-itpro-cust-subgridadd.PNG "Add button").  

    You add SLA details to define the KPIs or metrics for the SLA. You can define any KPI your organization needs. For example, a KPI might be that all cases for standard customers must be resolved within five days from when the case was created.  

    Define success criteria and the failure and warning actions that need to be taken when an SLA metric isn't met for a customer case.  

    SLA KPIs are performance indicators that you'd like to track. For example, First Response or Resolve By. SLA items refer to SLA KPIs based on specific conditions. You can add multiple SLA items and arrange them in the order that works for you. For any given KPI, only the first SLA item that matches the conditions in the **Applicable When** section is applied.  

   > [!NOTE]
   >  In Customer Service, SLA and SLA KPIs (SLA details) use the process (workflow) functionality. Although SLA KPIs use workflows, not all of the actions available in workflows are available for defining failure and warning actions. The available actions are currently limited to **Send Email**, **Create Record**, **Update Record**, **Assign Record**, and **Change Status**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit workflow processes](../customerengagement/on-premises/customize/workflow-processes.md)  

9. Enter the following information in the **New SLA Item** form:  

   - **Name**: Type a meaningful name.  

   - **Related Case Field**: Select a field of DateTime type of the case record that this SLA item refers to. For example, if you're creating a KPI for sending the first response within a specified time, select the **First Response By** option from the dropdown list. If necessary, ask your system customizer to create new fields of type DateTime.  

        When a case record is created or updated, this field is set to the date and time when the failure time will be reached for the respective SLA item. For example, select **First Response By** in **Related Case Field**, and set **Failure After** to two hours from the time the case was created. If the case was created at 09:00, the **First Response By** field in the case record will be set to 11:00, assuming the business hours are all day, every day.  

       > [!TIP]
       >  By default, there are four options available in the dropdown list. If you want to track other KPIs, ask your system customizer to create case fields of type DateTime.  

   - In the **Applicable When** section, define the conditions under which the KPI will be applied. The condition can be based on case or related entity fields.  

      For example, the conditions might be as shown in the following image.

      ![Customer (Account) Category equals Corporate; Case Priority equals High.](media/crm-ua-sla-details-applicable-when.png "Customer (Account) category equals Corporate; Case priority equals High")

     > [!NOTE]
     >  If there are multiple clauses, and you don't use AND or OR grouping, by default the clauses will use the AND grouping.  

   - In the **Success Criteria** section, specify the conditions to define when the KPI will be considered as met. For example, the condition might be as shown in the following image.

       ![Success criteria for an SLA is Case First Response Sent equals Yes.](media/crm-ua-sla-details-success-criteria.png "Success criteria for an SLA is 'Case First Response Sent equals Yes'")  
  
     > [!NOTE]
     >  Before you specify the failure and warning actions for the SLA, save the SLA item record.  </br> </br> If the conditions configured in the SLA fields conflict with each other, the SLA is canceled before it meets the success or failure criteria. For example, if the **Case Status** field is set as **Active** in the **Applicable When** section and is set as **not equal to Active** in the **Success Criteria** section, the SLA will be canceled when implemented.

   - Under **SLA Item Failure**, in the **Failure After** dropdown list, select when the SLA items will be considered as failed. For example, if you select **1 hour**, the KPI will be considered as failed if the first response isn't completed within one hour of the time the case was created. One hour is calculated based on the value in the date-time field that you select in the **Applicable From** field of the SLA record.  

   - In the **Failure Actions** section, select **Add Step**, and then specify the actions to be taken if the success criteria aren't met and the case exceeds the specified failure time. For example, to mark a case for escalation when the KPI has failed, select **Add Step** > **Update Record** > **Case** > **Set Properties**. In the case record, change the value of the **Is Escalated** field, and then close the case form.  

   - Under **SLA Item Warning**, in the **Warn After** dropdown list, select the time when a warning is to be raised that the KPI is nearing violation.  

   - In the **Warning Actions** section, select **Add Step**, and then specify the actions to be taken when the KPI reaches the time when a warning is to be raised. For example, to warn the case owner that the KPI is nearing violation, select **Add Step** > **Send Email** > **Create New Message** > **Set Properties**. In the email record, type the email details, and then close the email form.  

     > [!NOTE]
     >  The time for failure and warning is calculated after considering the business hours selected in the SLA record. If a business hours record (customer service schedule) isn't selected, the work hours are considered to be all day, every day.

     > [!IMPORTANT]
     >  Make sure that you don't have too many SLA items in an SLA because it might negatively affect the create and update operations on the record on which the SLA is applied or reevaluated. For performance reasons, we recommend that you don't have more than 15 SLA items in an SLA record.  

10. [!INCLUDE[proc_click_or_tap_save_and_close](../includes/proc-click-or-tap-save-and-close.md)]  

    > [!IMPORTANT]
    > - Failure and warning actions run asynchronously and might not be triggered exactly at the failure or warning time.
    > - If failure or warning times are set to less than one hour, the processing of failure or warning actions might be delayed.
    > - Make sure you author SLAs in a way that best suits your company's needs. For example, in the SLA **Applicable When** conditions, we recommend that you don't use case fields that are updated too frequently because any change to the field value might lead to the SLA item being canceled.

### See also

[Enable entities for service-level agreements](enable-entities-service-level-agreements.md)  
[Troubleshoot issues in SLAs](troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
