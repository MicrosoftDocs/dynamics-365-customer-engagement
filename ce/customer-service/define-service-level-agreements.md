---
title: Define service level agreements (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Know how to define service level agreements in Dynamics 365 for Customer Service
keywords: Service leve agreements; Dynamics 365; Customer Service
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: shellyha
ms.date: 06/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: 75c6bab8-54d8-4410-b210-003953aa4b53
ms.custom: dyn365-customerservice
---

# Define Service Level Agreements (SLAs)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Define the level of service or support that your organization agrees to offer to a customer by using service level agreements (SLAs) in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. Include detailed items to define metrics or key performance indicators (KPIs) to attain the service level. KPIs help you get timely warnings on your team’s issues while providing support.  
  
 You can associate an SLA with an entitlement so that when an entitlement is added to a case, the associated SLA is also applied. You can associate only SLAs that are created for the case entity with entitlements. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create an entitlement to define the support terms for a customer](../customer-service/create-entitlement-define-support-terms-customer.md)  
  
 Alternatively, you can set up a default SLA for the organization.  

## Types of SLAs
[!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] lets you create two types of SLAs: **Standard** and **Enhanced**. Standard SLAs can only be created for the Case entity. With an Enhanced SLA, you can:  
  
-   Create SLAs for entities other than Case.  
  
-   Pause an SLA when the case is on hold, so that the time the case is on hold isn’t considered in SLA calculations.  
  
-   Add success actions to an SLA. For example, you may want to send communications internally or outside your organization when the SLA has succeeded. Success actions are initiated only when the success condition is met on time, not when it is breached.  
  
-   Track SLA statuses and times right on the case form by default. These details are tracked through the SLA KPI Instance record type.  

> [!NOTE]
> It is recommended to use only Enhanced SLA as Standard SLA is deprecated. For more information, see[ Important changes coming in Dynamics 365 Customer Engagement](https://docs.microsoft.com/en-us/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming).
  
## Entities (record types) that support SLA  
You can create enhanced SLAs for entities that are enabled for SLA. A system administrator or customizer can enable SLAs for the following entities:  
  
- Case  
- Account  
- Contact  
- All activity entities: Email, Task, Appointment, Phone Call, Social Activity 
  
 > [!NOTE]
 >  SLA can also be enabled for custom entities and custom activities.  
  
 For more information, see [Enable entities for service level agreements](../customer-service/enable-entities-service-level-agreements.md).  
  
  
## Create an Enhanced SLA  
  
1. [!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  
  
     When you activate an SLA, a corresponding workflow is also created. For every action you perform on the SLA, you must have permissions to perform the same action on workflows. The SLA is applied in context to the permissions that the owner of the SLA has.  
  
    #### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. In the Customer Service Hub sitemap, go to **Service Management** > **Service Level Agreements**.

   - The **All Service Level Agreements** view is displayed. You can switch between multiple views using the drop-down. 
   - Select **Show Chart** in the command bar to see the chart view. <br>
  
3.  To create a new SLA, click the **New** button.  
  
     -OR-  
  
     To edit an SLA, in the list of records, select the SLA, and then on the command bar, select **Edit**.  
  
5.  If you're creating a new SLA, you'll see the **Create SLA** dialog box. Type a **Name** for the SLA, and then select the **Entity** for which you want to create the SLA.  
  
6.  Fill in your information  
  
    - **Applicable From**. Select the field that specifies the date and time from which the SLA items will be calculated. For example, if you select the **Created On** field, the calculations for service level agreements will start from the time the record is created.  
  
        > [!NOTE]
        >  You can have multiple SLA KPIs within one SLA. The start time for different SLA KPIs within an SLA is set at the SLA level and can't be different across SLA KPIs. The start time is determined by the Applicable From field value.  
  
    - **Business Hours**. Select a customer service schedule record that defines your support organization’s business hours. This is useful in the SLA time-tracking calculations. If a business hours record (customer service schedule) isn’t selected, the work hours are considered to be 24 x 7.  
  
    - **SLA Type**. The SLA type is **Enhanced**.  
  
    - **Allow Pause and Resume**. Select **Allow** if you want the SLA to pause during the time the record is on hold. For each entity that's enabled for SLA, you can set the                     statuses that will be considered “on hold” in the **Service** tab of System Settings dialog box. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - Service tab](../admin/system-settings-dialog-box-service-tab.md). You can set this field to **Allow** only when you’re creating an enhanced SLA.  
  
7. [!INCLUDE[proc_click_or_tap_save](../includes/proc-click-or-tap-save.md)]  
  
8.  To add SLA details, in the **SLA Details** section, click the **Add** button ![Add button](../customer-service/media/crm-itpro-cust-subgridadd.PNG "Add button").  
  
9. Fill in your information in the SLA Item form:  
  
    - **Name**. Type a meaningful name.  
  
    - **SLA KPI**. Select the key performance indicator the SLA item is about. For example, if you are creating a KPI for sending the first response within a specified time, select the **First Response By KPI** option from the drop-down list.  
  
         For example, select **First Response By KPI** in the **SLA KPI** field, and set **Failure After** to 2 hours from                      record                     creation. If the                      record                     is created at 09:00, the **Failure Time** field of the SLA KPI Instance record is set to 11:00 assuming the business hours are 24 x 7.  
  
        > [!TIP]
        >  If you're creating an SLA for a Case entity, by default, there are two options available in the drop-down list. If you want to track other KPIs      for Case or if you're creating the SLA for entities other than Case, ask your system customizer to create new fields (of type lookup) that refer to the SLA KPI Instance entity.  
  
    -   In the **Applicable When** section, define the conditions under which the KPI will be applicable. The condition can be based on primary entity                     or related entity fields.  
  
         For example, the conditions could be as follows.  
  
        ![When a KPI will be applied in Dynamics 365](../customer-service/media/crm-ua-sla-details-applicable-when.png "When a KPI will be applied in Dynamics 365")  
  
    -   In the **Success Criteria** section, specify the conditions to define when the KPI will be considered as met. For example, the conditions could be as follows.  
  
        ![Success criteria for an SLA](../customer-service/media/crm-ua-sla-details-success-criteria.png "Success criteria for an SLA")  
  
        > [!NOTE]
        >  Before you specify the SLA failure and warning details, save the SLA item record.  
  
    -   In the **Success Action** section, click **Add Step**, and then specify the actions that you want [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to take when the success criteria is met before the violation time. For example, click **Add Step** > **Change Status**. Then, in the first drop-down list, select **Case**, and in the next drop-down list, select **Information Provided**. This option is available only if you’re creating enhanced SLAs.  
  
    -   Under **SLA Item Failure**, in the **Failure After** drop-down list, select when the SLA items will be considered as failed. For example, if you select **1 hour**, the KPI will be considered as failed if the first response is not done within 1 hour of case creation. 1 hour is calculated based on the value in date/time field that you select in the **Applicable From** field of the SLA record.  
  
    -   In the **Failure Actions** section, click **Add Step**, and then specify the actions that will be taken when the success criteria are not met and the                      record                     has exceeded the specified failure time. For example, to mark                      a                     case for escalation when the KPI has failed, click **Add Step** > **Update Record**. Then select **Case** and click **Set Properties**. Now in the case record, change the value of the **Is Escalated** field, and then close the case form.  
  
    -   Under **SLA Item Warning**, in the **Warn After** drop-down list, select when a warning is to be raised for the KPI nearing violation.  
  
    -   In the **Warning Actions** section, click **Add Step**, and then specify the actions to be taken when the KPI reaches the warning time. For example, to warn the case owner about the KPI nearing violation, click **Add Step** > **Send Email**. Then select **Create New Message** and click **Set Properties**. In the email record, specify the email details, and then close the email form.  
  
        > [!NOTE]
        >  The time for failure and warning is calculated after considering the business hours selected in the SLA record. If a business hours record (customer service schedule) isn’t selected, the work hours are considered to be 24 x 7.  
  
 To help you get started with creating SLAs for other entities, here are a couple of sample SLA KPIs for the lead entity.  
  
 SLA KPI 1: Contact the customer (tracks if the salesperson has contacted the customer within the specific timeline)  
  
|Applicable when|Success condition|Failure time|Failure action|Warning time|Warning action|  
|---------------------|-----------------------|------------------|--------------------|------------------|--------------------|  
|Rating = Hot|Status = Contacted|1 day|Send an escalation email to the sales manager|16 hours|Send a warning email to the salesperson|  
|Rating = Warm|Status = Contacted|2 days|Send an escalation email to the sales manager|1.5 days|Send a warning email to the salesperson|  
|Default|Status = Contacted|7 days|Send an escalation email to the sales manager|5 days|Send a warning email to the salesperson|  
  
 SLA KPI 2: Action on lead (tracks if the salesperson has taken necessary action on the lead within specific timeline)  
  
|Applicable when|Success condition|Failure time|Failure action|Warning time|Warning action|  
|---------------------|-----------------------|------------------|--------------------|------------------|--------------------|  
|Rating = Hot|Status = Qualified or Disqualified|2 days|Send an escalation email to the sales manager|1.5 hours|Send a warning email to the salesperson|  
|Rating = Warm|Status = Qualified or Disqualified|5 days|Send an escalation email to the sales manager|4 days|Send a warning email to the salesperson|  
|Default|Status = Qualified or Disqualified|15 days|Send an escalation email to the sales manager|12 days|Send a warning email to the salesperson|  
  
> [!IMPORTANT]
> - We do not recommend creating or updating SLAs by using [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)]. Use the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web application for this purpose.  
> - Make sure that you don't have too many SLA Items in an SLA, because that can directly impact the create and update operations on the record on which the SLA is applied or re-evaluated. We recommend  you not have more than 15 SLA items in an SLA record for performance reasons. 
> - The SLA business logic relies on SLA KPI Instance record values, so it is not recommended to create plugins or processes to directly update the SLA KPI Instance record values to avoid any conflict. 
  
<a name="bkmk_SetAsDefault"></a>   
## Set the SLA as default  
 For case entity, make an SLA a default one if you want it to apply to all the cases that don’t have an SLA applied through an entitlement. This is useful when a customer wants a service level agreement without an entitlement.  
  
 For all other entities, select a default SLA. You can have one default SLA for each entity that is enabled for SLA.  
  
 To set an SLA as the default, select an active SLA from the list, and then click **Set as Default** on the command bar.  
  
> [!NOTE]
>  If you deactivate a default SLA, you must activate it again before resetting it as the default.  
  
<a name="bkmk_DisableSLA"></a>   
## Disable the SLA  
 During maintenance activities or when you’re importing records and you don’t want the SLAs to apply, you can disable SLAs for the organization. A system administrator can disable SLAs from the System Settings. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - Service tab](../admin/system-settings-dialog-box-service-tab.md)  
  
<a name="bkmk_SLAApplication"></a>   
## How is the SLA applied?  
 When a record is created, the SLA is applied (default or through entitlement for the Case entity) and the related record field values are updated. When the record is modified and any of the record field values change, that is, when the fields that are added in the **Applicable When** conditions of the SLA change, the SLA is applied again. For example, if the priority of the case changes from Normal to High, and according to the SLA the first response should happen soon, the SLA is reapplied to make sure the KPIs are tracked based on the updated values.  
  
 When the SLA is applied again, all the SLA items are evaluated based on the updated record fields and the failure or warning actions are initiated if the time has been exceeded. This happens even if the failure or warning actions were already initiated before the record was updated.  
  
> [!NOTE]
>  You can only have one SLA running on one record. When an entity record is updated with a different SLA, the previously applied SLA is canceled.  
  
<a name="bkmk_SLAonDemand"></a>   

## Apply SLA on demand  
 With the enhancements made to SLAs, you can now apply SLAs to records manually. You can also automatically apply SLAs to records based on your business logic (using workflows or custom plug-ins).  
  
 For example, if your customers are spread across geographies, you can have multiple SLAs with different business hours and holiday schedules for different geographies. You can set up business logic to apply SLAs on case records based on the customer's region to make sure that the SLA time calculation happens based on the correct geography.  
  
 To create workflows so SLAs are automatically applied, talk to your customer service managers, administrator, or customizer. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit workflow processes](../customize/workflow-processes.md).
  
 To apply SLAs on-demand manually, choose the SLA in the SLA field. This field is not available by default on entity forms. Ask your system administrator to add the field on the entity form.  
  
## Track SLA status and details on the case record  
The customer service rep working on a case can see the SLA details right on the case form.  

To know how to track SLA status and details on the case record, see [Case form with Enhanced SLA applied](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/customer-service/customer-service-hub-user-guide-case-sla#case-form-with-enhanced-sla-applied).
  
### See also  
[Create an entitlement to define the support terms for a customer](../customer-service/create-entitlement-define-support-terms-customer.md)   
