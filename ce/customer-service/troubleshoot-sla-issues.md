---
title: Troubleshoot SLA issues in Customer Service | Microsoft Docs
description: Know about the SLA issues and how to troubleshoot them.
ms.date: 11/23/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Troubleshoot issues in service-level agreements in Customer Service

## Troubleshoot issues faced in creating SLAs

### Warning and failure duration times are incorrect for the SLA

Why do I see that some service-level agreements (SLAs) don't take into account daylight saving time for warning and failure duration?

#### Reason

If your SLA was created in the web client that is now deprecated, the business schedule calendar does not support daylight saving time.

#### Resolution

To use the daylight saving time functionality and many other new features, migrate your SLAs created in the web client to Unified Interface. More information: [Migrate automatic record creation rules and service-level agreements](migrate-automatic-record-creation-and-sla-agreements.md)

## SLA timer does not pause when its state is changed from InProgress to OnHold on a holiday

Once triggered, the SLA timer continues to run even when its state is changed from **InProgress** to **OnHold**.

### Reason

If a holiday is configured, the status of the case is updated to **OnHold** to pause the case SLA. However, the pause functionality associated with the **OnHold** status doesn't appear to function correctly. Therefore, the timer continues to run even on a holiday when it should be paused.

So, it includes the holiday hours, non-working hours, and pause time (only business hours) while projecting the SLA warning or failure time.

### Resolution

The functionality is intended. Your organization defines business hours while scheduling working days and holidays. SLA warning time and failure time adhere to those settings and are calculated based on the defined hours.

See the following scenarios to understand how the SLA **Warning** and **Failure** time is calculated:

- Create a case during non-working hours. Pause and resume the case before working hours start. Hold time between **Pause** and **Resume** will not be considered.
- Create a case during non-working hours. Pause and resume the case during working hours. Hold time will be considered and **Warning** and **Failure** time will be extended based on hold time.
- Create a case during working hours. Pause the case during working hours. Resume the case during non-working hours. Hold time will not be considered for **Warning** and **Failure** time.
- Create a case during working hours. Pause the case during non-working hours and resume it during working hours. **Warning** time and **Failure** time will be recalculated.

## SLA KPI instance status shows as canceled

When you update the target record such that **Applicable when** condition is no more applicable, the SLA KPI status moves from one of the existing states of **In progress**, **Succeeded**, **Nearing non compliance**, or **Expired** to the **Canceled** state. The SLA KPI instance is canceled on the second evaluation because the **Applicable when** condition is no longer met. Consider the following scenario in which you create an SLA with the following conditions and set it as the default SLA.

- **Applicable when:** Case status equals active
- **Success condition:** Case status equals resolved

1. Create a case. The case status is set to **Active** by default, the SLA is applied, and the SLA timer starts.

2. Resolve the case. The case status is set to **Resolved**, and the SLA is reevaluated for the **Applicable when** condition. The SLA KPI instance status will be set to **Canceled**.

### Reason

When you define the **Applicable when** and **Success condition** on the same attribute, such as **case status**, one of the criteria might not be met, and the SLA KPI instance status will be canceled.

> [!NOTE]
> When you define the conditions on the same attribute, a recommendation message is displayed that suggests you to not use the same attribute.

### Resolution

In such scenarios, we recommend that you don't define the **Applicable when** and **Success condition** on the same attribute.

## Success, warning, and failure actions are being run multiple times in web client

When updates are made to the target record, the attributes present in the **Applicable when** condition of the SLA item are modified in the applied SLA.

Consider a scenario in which you've created an SLA in the web client with an SLA item that has the following **Applicable when** and **Success condition**, and is set as the default.
> ![Scenario for troubleshooting SLAs.](media/troubleshoot-sla.png "Scenario for troubleshooting SLAs")

1. Create a case with case type set as question. The SLA timer starts.

2. Add **Resolved** to case title. The success condition is met and the following events occur:

   - SLA KPI instance status is updated to succeeded.
   - A success action, such as send mail, is run, if configured.

3. Update the case type to request.

  - The SLA KPI instance that is in the succeeded status is reevaluated because the **Applicable when** attribute is changed.
  - The SLA KPI instance moves from **Succeeded** to **In progress**.
  - Because the case title contains **Resolved** and the success condition is true, the SLA KPI instance status changes from **In progress** to **Succeeded** again, and runs the success action again.

Based on the SLA KPI instance status, if any actions are configured, those actions will be run multiple times.

### Reason

When the **Applicable when** attribute is updated, the SLA is reevaluated that results in multiple iterations of the actions.

### Resolution

This is the expected behavior for SLAs in the web client. It is recommended to define the **Applicable when** condition on only those attributes whose values don't change frequently.

## SLA KPI instance doesn't reach Nearing Non-compliance or Non-compliant state, and the SLA KPI instance timer continues to run

The flow runs that are created for the SLA KPI Instances timer fail with a license error message.

### Reason

The **SLAInstanceMonitoringWarningAndExpiryFlow** is required to move the **SLA KPI Instances** to a **Nearing non-compliance** or **Non-complaint** state. The flow always works in the context of the user who activates the first SLA in the organization. The user who activates the first SLA on the organization must have all the required licenses for the flow execution. The flow must only be turned off and on by a user who has the SLA KPI privileges at a global level for **prvReadSLAKPIInstance** and **prvWriteSLAKPIInstance**.

If the user is missing any of the required licenses, then the flow runs that are created for the corresponding SLA KPI instance will fail with a license required error: "The user with SystermUserId = XXXX in OrganizationContext = YYYY is not licensed". Thus, the SLA KPI instance will never reach the **Nearing non-compliance** or **Non-complaint** state and the SLA KPI instance timer will continue to run.

Additionally, the current owner of the flow must have the required permissions with read and write access for **SLAKPIInstance**.

If a user who is the current owner of the flow needs to be removed from the organization, you should first change the owner of the flow to another user. This new user must also have all the required permissions. Once a new owner is added, you can remove the previous owner. This will ensure that the flow runs continue to be executed without issues.

### Resolution

To change the owner of any flow, perform the following steps:

1. In https://powerautomate.microsoft.com, navigate to **My flows > Cloud flows**.
1. Search for the failed flow with the error.
1. Select **Edit**. A new flyout menu is displayed, where you can set a new owner.
1. In the **Owner** field, remove the current owner and add the new owner. Ensure that the new owner has all required flow licenses.

##  Warning message appears on slakpiinstances

The following warning message is displayed on entity records: "The SLA instances may be incorrect because workflow <*workflow ID*> is turned off. Please contact your admin to turn the workflow on."

The workflow ID varies from system to system.

### Reason

The **SLAInstanceMonitoringWarningAndExpiryFlow** must be enabled.

### Resolution

If none of the Unified Interface SLAs are activated, then you must activate one of the SLAs to activate the **SLAInstanceMonitoringWarningAndExpiryFlow**. The flow must only be turned off and on by a user who has the SLA KPI privileges at a global level for **prvReadSLAKPIInstance** and **prvWriteSLAKPIInstance**.

However, if all the SLAs are active but the flow is still deactivated, perform the following steps:

1. In https://powerautomate.microsoft.com, navigate to **My flows > Cloud flows**.
2. In **Cloud flows**, select  **SLAInstanceMonitoringWarningAndExpiryFlow**.
3. Select **Turn on**.

## Deletion of SLAs or SLA Items show error messages in UCI during solution upgrade or manual deletion

The following two error messages are displayed:

Error message 1: "The object you tried to delete is associated with another object and cannot be deleted."

Error message 2: "SLAItem delete operation encountered some errors. The process is part of a managed solution and cannot be individually deleted. Uninstall the parent solution to remove the process; see log for more detail."

### Reason

The first error occurs because in UCI SLA, the relationship between the SLA item and SLA KPI instances is set to "Restrict to Delete". The second error occurs because processes that are part of managed solution can't be deleted. So, when you try to delete an SLA manually, which is part of a managed solution and has flows configured, the error message appears.

### Resolution

Resolution 1:

Instead of deleting the SLA, deactivate the SLA in your organization. If it's a part of a managed solution, then perform the following steps:

1. Deactivate the SLA in the source instance and add it to the solution.
1. Deactivate the same SLA in the target instance, and then apply the solution upgrade.

Resolution 2:

You can first manually delete all the SLA-related entity records and SLA KPI instances, and then remove the SLA. Perform the following steps:

1. In your organization, go to **Advanced Find**, search **SLA KPI Instances**, and then select the **SLAItem.**
1. Select **Result**. The SLA KPI instances will be listed.
1. Select the required SLA KPI instances, and then select **Delete SLAKPIInstances**. This will also nullify the SLA KPI instances on the related records.

Even after deleting the reference records, if the error message, "SLAItem delete operation encountered some errors. The process is part of a managed solution and cannot be individually deleted. Uninstall the parent solution to remove the process; see log for more detail." appears, then apply the solution upgrade with SLA deleted from the upgrade solution.

Resolution 3:

If the above resolution doesn’t work, contact support to request deletion of the SLA or SLA items.

## Primary entity isn't available while creating SLA

### Reason
To create SLA on any entity, SLA needs to be enabled for that entity and there should be active KPI for that entity.

### Resolution

Enable SLA for entity and create KPI. Then you would be able to create SLA on that entity.

More information:  

https://learn.microsoft.com/en-us/dynamics365/customer-service/enable-entities-service-level-agreements 

https://learn.microsoft.com/en-us/dynamics365/customer-service/define-service-level-agreements?tabs=customerserviceadmincenter

## Legacy SLAs aren't showing up in the migration tool

### Reason 

In SLA Migration we support only enhanced SLAs.

### Resolution 

Check the SLA type in legacy interface: if its Standard or Enhanced SLA. Please use only enhanced SLAs. SLA Migration tool doesn't show standard SLA as its not supported and deprecated long back.  

For more information: https://learn.microsoft.com/en-us/dynamics365/customer-service/migrate-tool-faqs#can-i-migrate-deprecated-standard-sla-rules 

## Unable to use the SLA migration tool for Migrating large SLA volume 

## Reason 

In SLA Migration we first perform Premigration checkup which process all Legacy SLAs in system. If SLA volume is too large i.e. 1000+; it might get stuck 

## Resolution 

Please skip Premigration checkup with below step: 

use &flags=FCB.SkipPreMigrationCheckUp=true in the URL when you click on ARC/SLA migration in the CSAC  and then perform batch migration. By selecting a few SLAs for every migration.

More information: https://learn.microsoft.com/en-us/dynamics365/customer-service/migrate-tool-faqs#known-issues



### See also

[Track SLA details with Timer Control](customer-service-hub-user-guide-case-sla.md#track-sla-details-with-timer-control)  
[Define service-level agreements](define-service-level-agreements.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
