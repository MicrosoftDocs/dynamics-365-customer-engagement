---
title: "Apply SLAs | MicrosoftDocs"
description: "Learn how to apply service-level agreements in Dynamics 365 Customer Service."
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
ms.collection: get-started
---

# Apply SLAs

You can apply service-level agreements (SLAs) to a case or an SLA-enabled entity record in one of the following ways:

- By updating the SLA information automatically through a workflow, Power Automate flow, or custom plug-in written for the entity.
- Through the entitlement associated with the case entity record. (This isn't applicable for other SLA-enabled entities.)
- Manually applying SLAs to records.
- By setting a particular SLA as the default SLA.

The SLA is reapplied whenever there's an update on an entity record and the updated fields are part of the **Applicable When** conditions of the SLA items.

When the SLA is reapplied, all the items of that SLA are evaluated based on the updated record fields. The failure or warning actions of the matching SLA Item are initiated if the time has exceeded. This happens even if the failure or warning actions were already initiated before the record was updated.

In Unified Interface, by default, when the SLA moves to a terminal status (non-compliant or succeeded), the **Applicable When** and **Success Criteria** won't be evaluated again on the SLA. If you want the SLA to be reevaluated, you can enable the reevaluation setting in the service configuration settings. More information: [Enable SLA recalculation](enable-sla-recalculation.md)

When UCI-SLA is reevaluated, it creates a new SLAKPIInstance and cancels the previous instance. This is new feature in UCI-SLA and does not happen for legacy SLA.

During maintenance activities or when you're importing records and you don't want the SLAs to be applied, you can disable SLAs for your organization. A system administrator can disable SLAs from the **System Settings** dialog box. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - Service tab](/power-platform/admin/system-settings-dialog-box-service-tab) 

> [!NOTE]
>
> Only one SLA can be applied to a record. When an entity record is updated by using a different SLA, the previously applied SLA is canceled.  

## Apply SLAs automatically

You can automatically apply SLAs to records based on your business logic by using workflows, Power Automate flows, or custom plug-ins. For example, if your customers are spread across different countries or regions, you can have multiple SLAs with different business hours and holiday schedules. You can set up business logic to apply SLAs on case records based on the customer's country or region, to make sure that the SLA time calculation is done correctly.  

To create workflows so that SLAs will be automatically applied, talk to your customer service managers, administrator, or customizer. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Overview of using workflow processes](../customerengagement/on-premises/customize/workflow-processes.md)

You can also use the Power Automate flow portal to update the SLA. Currently the flow expects a GUID of the SLA record. More information: [Create your first flow](/power-automate/getting-started#create-your-first-flow)

If you choose to write a custom plug-in for the SLA-enabled entity, you can update the SLA ID in the pre-update plugin of the entity. For example, for case, the code in plug-in would look like:

``incident["slaid"] = new EntityReference("sla", new Guid("baa25488-6d99-es11-99da-225056836fb7"))`` .

## Apply SLAs through entitlements

You can create entitlements to define support terms. More information: [Associate entitlements to cases](create-entitlement-define-support-terms-customer.md#associate-entitlements-to-cases)

## Apply SLAs manually

To apply SLAs to records manually, select the SLA in the SLA field. This field isn't available by default on entity forms, so you will need to ask your system administrator to add it.

While applying the SLA, the application first looks for automatically applied SLAs, followed by SLAs applied through entitlement. If there aren't any, the application looks for the SLA that's set as the default.

## Set a default SLA

You can apply a default SLA in the Customer Service admin center or Customer Service Hub app by performing the following steps:

1. Go to **Service Level Agreements**.

    ### [Customer Service admin center](#tab/customerserviceadmincenter)

     1. In the site map, select **Service terms** in **Operations**. The **Service terms** page appears.
     2. In the **Service-level agreements (SLAs)** section, select **Manage**.

    ### [Customer Service Hub](#tab/customerservicehub)

      * In the site map, go to **Service Management** and select **Service Level Agreements** in **Service Terms**.

---

2. Select the required SLA and then select the **Set As Default** option from the ribbon.

### Set an SLA as the default for a Case entity

For a Case entity, set an SLA as the default if you want it to apply to all cases that don't have an SLA applied through an entitlement. This is useful when a customer wants an SLA but doesn't have an entitlement. For all other entities that are enabled for SLA, you can set one default SLA.

To set an SLA as the default, see [Set a default SLA](#set-a-default-sla).  

> [!NOTE]
> If you deactivate a default SLA, you must activate it again before resetting it as the default.  

### Apply and track SLA status and details on the case record

The service representative who is working on a case can see the SLA details right on the case form. The following table explains what happens when a standard or enhanced SLA is applied to a case form.


| Case form with a standard SLA applied |  Case form with an enhanced SLA applied |
|-------------------------------------|--------------------------------------|
| Only the failure time is tracked and saved on the case record.<br /><br /> You can ask your system administrator or customizer to add a timer to the case form. The timer shows the time remaining to meet the SLA or the time elapsed since the SLA failed. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add a timer control to the case form to track time against an SLA](add-timer-control-case-form-track-time-against-sla.md) | When an enhanced SLA is applied to a case, a related SLA KPI Instance record is created for each SLA KPI that is tracked for that case. In the **Enhanced SLA Details** section of the case record, you'll see a timer and the SLA KPI Instances for the case with their status, failure times, and warning times.<br /><br /> When a service rep puts a case on hold, the status of the SLA KPI Instance is set to Paused. You can see the time during which a case was on hold and the last time the case was put on hold. These details aren't available on the case form by default, but your system customizer can add these fields for you. The on-hold time is the time during which the case was set to a status that you defined as an On-Hold status in the **System Settings** dialog box. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - Service tab](/power-platform/admin/system-settings-dialog-box-service-tab)<br /><br /> When the service representative resumes a case, the status of the SLA KPI Instance record is updated. The following details are updated in the record if the SLA isn't violated:<br /><br /> -   Failure time<br />-   Warning time<br />-   Total time the case has been on hold<br /><br /> If the service representative puts the case on hold after the warning time, the warning time isn't updated when the case is resumed. |

> [!IMPORTANT]
> To track SLAs for entities other than the Case entity, ask your system administrator or customizer to add an enhanced SLA timer on the entity forms. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add a timer to forms to track time against enhanced SLAs](add-timer-forms-track-time-against-enhanced-sla.md)  

### See also

[Enable entities for service-level agreements](enable-entities-service-level-agreements.md)  
[Troubleshoot issues in SLAs](troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
