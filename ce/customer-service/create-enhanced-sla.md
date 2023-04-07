---
title: "Create enhanced service-level agreements in Dynamics 365 Customer Service | MicrosoftDocs"
description: "Learn how to create enhanced service-level agreements in Dynamics 365 Customer Service."
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

# Create enhanced SLAs

> [!NOTE]
>
> Enhanced SLAs created in the web client have been deprecated and replaced with Unified Interface SLAs. For more information on deprecation, see [SLAs in web client are deprecated](deprecations-customer-service.md#slas-in-web-client-are-deprecated). We recommend migrating the enhanced SLAs created in the web client to Unified Interface. For more information on migrating SLAs, see [Migrate SLAs](migrate-slas.md#migrate-slas).

1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  

     When you activate an SLA, a corresponding workflow is also created. For every action you perform on the SLA, you must have permissions to perform the same action on workflows. The SLA is applied in the context of the permissions that the owner of the SLA has.  

    **Check your security role**  

   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  

   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  

2. Go to **Settings** > **Service Management**.

3. Go to **Service Level Agreements**.

4. To create a new SLA, select **New**.  

    -Or-  

    To edit an SLA, select the SLA from the list of records, and then select **Edit** on the command bar.  

5. If you're creating an SLA, you'll see the **Create SLA** dialog box. Type a name for the SLA, and then select the entity for which you want to create the SLA.  

6. Enter your information as follows:

   - **Applicable From**: Select the field that specifies the date and time from which the SLA items will be calculated. For example, if you select the **Created On** field, calculations will start from the time the record was created.  

       > [!NOTE]
       >  You can have multiple SLA KPIs within one SLA. The start time for different SLA KPIs within an SLA is set at the SLA level and can't be different across SLA KPIs. The start time is determined by the **Applicable From** field value.  

   - **Business Hours**: Select a customer service schedule record that defines your support organization's business hours. This is useful for SLA time-tracking calculations. If a business hours record (customer service schedule) isn't selected, work hours are considered to be all day, every day. 

   - **SLA Type**: Select **Enhanced**.  

        If you're creating an SLA for an entity other than the Case entity, this field is automatically set to **Enhanced** and can't be changed.  

   - **Allow Pause and Resume**: Select **Allow** if you want the SLA to pause during the time the record is on hold. For each entity that's enabled for SLA, you can select each status that will be considered "on hold" by using the **Service** tab of the **System Settings** dialog box. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - Service tab](/power-platform/admin/system-settings-dialog-box-service-tab)

7. [!INCLUDE[proc_click_or_tap_save](../includes/proc-click-or-tap-save.md)]  

8. In the **SLA Details** section, select **Add** ![Add button.](media/crm-itpro-cust-subgridadd.PNG "Add button").

9. Enter the following information in the SLA Item form:  

   - **Name**: Type a meaningful name.  

   - **SLA KPI**: Select the KPI the SLA item is about. For example, if you're creating a KPI for sending the first response within a specified time, select the **First Response By KPI** option from the dropdown list.  

        For example, select **First Response By KPI** in the **SLA KPI** field, and set **Failure After** to two hours from the time the record was created. If the record was created at 09:00, the **Failure Time** field of the SLA KPI Instance record is set to 11:00, assuming business hours are all day, every day.  

       > [!TIP]
       >  If you're creating an SLA for a Case entity, by default you have two options to choose from in the dropdown list. If you want to track other KPIs for a case or if you're creating the SLA for entities other than the Case entity, ask your system customizer to create new fields (of type Lookup) that refer to the SLA KPI Instance entity.  

   - In the **Applicable When** section, define the conditions under which the KPI will be applied. Conditions can be based on primary entity or related entity fields.  

      For example, the conditions might be as shown in the following image.

     ![Customer (Account) Category equals Corporate; Case Priority equals High.](media/crm-ua-sla-details-applicable-when.png "Customer (Account) category equals Corporate; Case priority equals High")  

   - In the **Success Criteria** section, specify the conditions to define when the KPI will be considered as met. For example, the condition might be as shown in the following image.  

     ![Success criteria for an SLA is Case First Response Sent equals Yes.](media/crm-ua-sla-details-success-criteria.png "Success criteria for an SLA is Case First Response Sent equals Yes")  

     > [!NOTE]
     > - Before you specify the failure and warning actions for an SLA, save the SLA item record.
     > - If the conditions configured in the SLA fields conflict with each other, the SLA is canceled before it meets the success or failure criteria. For example, if the **Case Status** field is set as **Active** in the **Applicable When** section and is set as not equal to **Active** in the **Success Criteria** section, the SLA will be canceled when implemented. 

   - In the **Success Action** section, select **Add Step**, and then specify the actions that you want the application to take when the success criteria is met before the violation time. For example, select **Add Step** > **Change Status**, and then in the first dropdown list, select **Case**, and in the next dropdown list, select **Information Provided**.

   - Under **SLA Item Failure**, in the **Failure After** dropdown list, select when the SLA items will be considered as failed. For example, if you select **1 hour**, the KPI will be considered as failed if the first response isn't completed within one hour of the time the case was created. One hour is calculated based on the value in the DateTime field that you select in the **Applicable From** field of the SLA record.  

   - In the **Failure Actions** section, select **Add Step**, and then specify the actions to be taken if the success criteria aren't met and the record exceeds the specified failure time. For example, to mark a case for escalation when the KPI has failed, select **Add Step** > **Update Record** > **Case** > **Set Properties**. Now in the case record, change the value of the **Is Escalated** field, and then close the case form.  

   - Under **SLA Item Warning**, in the **Warn After** dropdown list, select the time when a warning is to be raised that the KPI is nearing violation.  

   - In the **Warning Actions** section, select **Add Step**, and then specify the actions to be taken when the KPI reaches the warning time. For example, to warn the case owner that the KPI is nearing violation, select **Add Step** > **Send Email** > **Create New Message** > **Set Properties**. In the email record, specify the email details, and then close the email form.  

     > [!NOTE]
     >  The time for failure and warning is calculated after considering the business hours selected in the SLA record. If a business hours record (customer service schedule) isn't selected, work hours are considered to be all day, every day.  

### Samples for creating enhanced SLA KPIs

The following sample SLA KPIs for the Lead entity can help you get familiar with creating SLAs for other entities.

#### Sample 1: Contact the customer

This sample SLA KPI tracks whether the salesperson has contacted the customer within a specific timeline.  

|Applicable when|Success condition|Failure time|Failure action|Warning time|Warning action|  
|---------------------|-----------------------|------------------|--------------------|------------------|--------------------|  
|Rating = Hot|Status = Contacted|1 day|Send an escalation email to the sales manager|16 hours|Send a warning email to the salesperson|  
|Rating = Warm|Status = Contacted|2 days|Send an escalation email to the sales manager|1.5 days|Send a warning email to the salesperson|  
|Default|Status = Contacted|7 days|Send an escalation email to the sales manager|5 days|Send a warning email to the salesperson|  

#### Sample 2: Take action on a lead

This sample SLA KPI tracks whether the salesperson has taken necessary action on the lead within a specific timeline.  

|Applicable when|Success condition|Failure time|Failure action|Warning time|Warning action|  
|---------------------|-----------------------|------------------|--------------------|------------------|--------------------|  
|Rating = Hot|Status = Qualified or Disqualified|2 days|Send an escalation email to the sales manager|1.5 hours|Send a warning email to the salesperson|  
|Rating = Warm|Status = Qualified or Disqualified|5 days|Send an escalation email to the sales manager|4 days|Send a warning email to the salesperson|  
|Default|Status = Qualified or Disqualified|15 days|Send an escalation email to the sales manager|12 days|Send a warning email to the salesperson|  

> [!IMPORTANT]
> - We recommend that you don't create or update SLAs by using [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)]. Use the Customer Service app for this purpose.  
> - Make sure you don't have too many SLA items in an SLA because that might negatively affect the create and update operations on the record on which the SLA is applied or reevaluated. We recommend that you have no more than 15 SLA items in an SLA for performance reasons.
> - The SLA business logic relies on **SLA KPI Instance** record values, so to avoid any conflict, we recommend that you don't create plug-ins or processes to directly update the **SLA KPI Instance** record values.

### See also

[Enable entities for service-level agreements](enable-entities-service-level-agreements.md)  
[Troubleshoot issues in SLAs](troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
