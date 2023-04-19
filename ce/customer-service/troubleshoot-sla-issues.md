---
title: Troubleshoot SLA issues in Customer Service | Microsoft Docs
description: Learn about SLA issues and how to troubleshoot them.
ms.date: 04/18/2023
ms.topic: article
author: Soumyasd27
ms.author: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# Troubleshoot issues with service-level agreements in Customer Service

This article explains the various issues related to SLAs and provides reasons and steps to resolve them.

## Troubleshoot issues with SLA creation

### Primary entity isn't available while creating SLAs

Primary entity isn't listed to create an SLA for the entity.

### Reason

To create SLA for an entity, you must enable the SLA for that entity and create an active KPI for it.

### Resolution

Enable SLA for the entity and create an active KPI. For more information on enabling entities for service-level agreements, go to [Enable entities for service level agreements](enable-entities-service-level-agreements.md#enable-entities-for-service-level-agreements)

## Troubleshoot issues with SLA migration

### Standard SLAs aren't showing up in the migration tool

Migration tool doesn't show standard SLAs for migration.

#### Reason 

Legacy SLAs consist of standard SLAs and enhanced SLAs. The migration tool supports only enhanced SLAs. Standard SLAs have been deprecated and are no longer supported in Unified Interface and therefore aren't supported in the migration tool.

#### Resolution 

Check the SLA type in the legacy web client interface. Use enhanced SLAs for migration.

### Unable to use the SLA migration tool to migrate large number of SLAs

Errors appear during the premigration checkup in the migration tool.

#### Reason 

If the number of SLAs being migrated is more than 1000, SLAs may not pass through the premigration checkup, which processes all legacy SLAs.

#### Resolution 

Skip Premigration checkup by using the following flag: use &flags=FCB.SkipPreMigrationCheckUp=true in the URL, when you select **Miscellaneous** > **ARC and SLA migration** **>  in the Customer Service admin center site map. Perform batch migration.

## Troubleshoot issues with SLA time calculation

### Warning and failure duration times are incorrect for the SLA

Some SLAs don't take into account daylight saving time for warning and failure duration.

#### Reason

If your SLA was created in the web client that is now deprecated, the business schedule calendar doesn't support daylight saving time.

#### Resolution

To use the daylight saving time functionality and many other new features, migrate your SLAs created in the web client to Unified Interface. More information: [Migrate automatic record creation rules and service-level agreements](migrate-automatic-record-creation-and-sla-agreements.md)

### Errors on custom time calculation for SLA

Errors received on configuring custom time calculation for SLA and during its usage.

#### Reason 

Custom time calculation isn't configured correctly.

#### Resolution 

Set up custom time calculation and troubleshoot issues. For information on setting up custom time calculation, go to: [Enable custom time calculation of SLA KPIs](enable-sla-custom-time-calculation.md#enable-custom-time-calculation-of-sla-kpis). For information on troubleshooting issues, go to: [Error codes for custom time calculation](/dynamics365/customer-service/enable-sla-custom-time-calculation#error-codes-for-custom-time-calculation)

## Troubleshoot issues with SLA timer

### SLA KPI instance doesn't reach Nearing Non-compliance or Non-compliant state, and the SLA KPI instance timer continues to run

The flow runs that are created for the SLA KPI Instances timer fail with a license error message.

#### Reason

Unified Interface SLAs use **SLAInstanceMonitoringWarningAndExpiryFlow** and legacy SLAs use legacy workflows to move the **SLA KPI Instances** to a **Nearing non-compliance** or **Non-complaint** state.

The flow always works in the context of the user who activates the first SLA in the organization. The user who activates the first SLA on the organization must have all the required licenses for the flow execution. The flow must only be turned off and on by a user who has the SLA KPI privileges at a global level for **prvReadSLAKPIInstance** and **prvWriteSLAKPIInstance**.

If the user is missing any of the required licenses, then the flow runs that are created for the corresponding SLA KPI instance will fail with a license required error: "The user with SystermUserId = XXXX in OrganizationContext = YYYY is not licensed". Thus, the SLA KPI instance will never reach the **Nearing non-compliance** or **Non-complaint** state and the SLA KPI instance timer will continue to run.

Additionally, the current owner of the flow must have the required permissions with read and write access for **SLAKPIInstance**.

If a user who is the current owner of the flow needs to be removed from the organization, you should first change the owner of the flow to another user. This new user must also have all the required permissions. Once a new owner is added, you can remove the previous owner. This will ensure that the flow runs continue to be executed without issues.

#### Resolution

To change the owner of any flow, perform the following steps:

1. In https://powerautomate.microsoft.com, navigate to **My flows > Cloud flows**.
1. Search for the failed flow with the error.
1. Select **Edit**. A new flyout menu is displayed, where you can set a new owner.
1. In the **Owner** field, remove the current owner and add the new owner. Ensure that the new owner has all required flow licenses.

### Warning message appears on slakpiinstances

The following warning message is displayed on entity records: "The SLA instances may be incorrect because workflow <*workflow ID*> is turned off. Please contact your admin to turn the workflow on."

The workflow ID varies from system to system.

#### Reason

The **SLAInstanceMonitoringWarningAndExpiryFlow** must be enabled.

#### Resolution

If none of the Unified Interface SLAs are activated, then you must activate one of the SLAs to activate the **SLAInstanceMonitoringWarningAndExpiryFlow**. The flow must only be turned off and on by a user who has the SLA KPI privileges at a global level for **prvReadSLAKPIInstance** and **prvWriteSLAKPIInstance**.

However, if all the SLAs are active but the flow is still deactivated, perform the following steps:

1. In https://powerautomate.microsoft.com, navigate to **My flows > Cloud flows**.
2. In **Cloud flows**, select  **SLAInstanceMonitoringWarningAndExpiryFlow**.
3. Select **Turn on**.

### SLA timer doesn't pause when its state is changed from InProgress to OnHold on a holiday

Once triggered, the SLA timer continues to run even when its state is changed from **InProgress** to **OnHold**.

#### Reason

If a holiday is configured, the status of the case is updated to **OnHold** to pause the case SLA. However, the pause functionality associated with the **OnHold** status doesn't appear to function correctly. Therefore, the timer continues to run even on a holiday when it should be paused.

So, it includes the holiday hours, non-working hours, and pause time (only business hours) while projecting the SLA warning or failure time.

#### Resolution

The functionality is intended. Your organization defines business hours while scheduling working days and holidays. SLA warning time and failure time adhere to those settings and are calculated based on the defined hours.

See the following scenarios to understand how the SLA **Warning** and **Failure** time is calculated:

- Create a case during non-working hours. Pause and resume the case before working hours start. Hold time between **Pause** and **Resume** won't be considered.
- Create a case during non-working hours. Pause and resume the case during working hours. Hold time will be considered and **Warning** and **Failure** time will be extended based on hold time.
- Create a case during working hours. Pause the case during working hours. Resume the case during non-working hours. Hold time won't be considered for **Warning** and **Failure** time.
- Create a case during working hours. Pause the case during non-working hours and resume it during working hours. **Warning** time and **Failure** time will be recalculated.

### OnHold Time attribute isn't populated for Case for Unified Interface SLA

The **onholdtime** attribute to track the onHold duration for case at a case entity level doesn't get populated.

#### Reason

In the Legacy SLA, the **onholdtime** attribute tracks the on-hold duration for the case at the case entity level. In the Unified Interface SLA, **Elapsed time** tracks the on-hold duration at the KPI instance level, since one case can have multiple KPIs with different pause conditions, and each SLA KPI instance might have a different calendar associated with it.

#### Resolution

For Unified Interface SLAs, use the elapsedtime attribute to track onHold Duration at SLA KPI instance level.  

## Troubleshoot issues with solution import, export, and upgrade

### Unable to import solution with active SLAs and SLAs are deactivated when a solution is imported

SLA solutions can be imported or exported from **Customizations** **> Solutions**. If an SLA solution is already present and you import an upgraded version of the same solution, then the following errors occur:

- During solution upgrade, if you select **Maintain Customizations**, the import fails.
- During solution upgrade, if you select **Overwrite Customizations**, the import succeeds, but the SLAs are deactivated.

#### Reason 

Solution export isn't intended to export data and only intended to export configurations. So, if the solution is imported with **Maintain Customizations** option and SLAs are already present and active in target org, the import will fail.  

If the customizations.xml file has the SLAs and you select **Overwrite Customizations**, the state of the SLAs will be set to Draft and deactivated.

#### Resolution 

- If you want to explicitly import a solution with SLAs defined, you must deactivate the SLAs and then proceed with the import. The SLAs can then be re-activated.

- If you want to import other customizations in the solution, the SLAs don't need to be re-imported. You can remove them from the customizations.xml file.

### Changes to a SLAItem through an upgrade solution don't appear even after a successful upgrade

Changes like Applicable when, Success, Pause conditions, or adding action flows through an upgrade solution don't appear in the SLA of the target organization. This is the expected behavior, and is applicable to both UCI and legacy SLAs.
 
#### Reason 
When an SLA is activated or an SLAItem is modified manually on the organization (for example, Applicable when conditions, Success, Warning, or Failure actions), the upgrade solution changes aren't reflected. This is because the active layer takes precedence over the upgrade solution.

#### Resolution
We recommend that you make changes to a SLA or a SLAItem only through an upgrade solution. If the issue persists even after importing the patch solution, you can opt for the overwrite customization option while importing the full solution. Overwriting customization removes all the active layer customizations on the SLA, and therefore, all the changes in the upgrade solution are reflected. Overwrite customization might only be visible in Legacy Solution import.

## Troubleshoot issues with entitlements

### Unable to create entitlements because Allocation Type dropdown doesn't show any options

Unable to create entitlement forms from either the Customer Service Hub or the Customer Service admin center app because of lack of data in the entitlement’s entity type mappings with the EntitlementEntityAllocationTypeMappingBase table.

### Scenario 1

#### Reason
The **Allocation Type** field doesn't exist in the entitlement entity with **Case** option.

#### Resolution

Add the **Allocation Type** field by performing the following steps:
1. In either of the apps, go to **Advanced Settings** > **Customizations** > **Customize the System** > **Expand Entitlement Entity** > **Fields** > **Check Allocation Type** field options.
1. Add the **Allocation Type** field.

### Scenario 2

#### Reason

The entitlement's entity allocation type mapping records aren't present in the EntitlementEntityAllocationTypeMappingBase table when the **Entity Type** field from the entitlement entity has more than one option other than case.

#### Resolution

**Entity Type** is a type of option set field in the Entitlement table that has **Case** as the default option. If **Case** is the only option available for **Entity Type**, then the Entitlement table automatically loads **Allocation Type** values for the **Case** option. In a case where more than one option is set for the **Entity Type** field, you'll need to select the **Entity Type** option so that the Entitlement table will load **Allocation Type** values based on that **Entity Type** selection.

Add the entitlement's entity allocation type mapping records to the EntitlementEntityAllocationTypeMappingBase table.

- Use the following query to insert missing mapping records and add a record for allocation type for the **Case** entity type:

    `Insert INTO [dbo].[EntitlementEntityAllocationTypeMappingBase]` 
`(entitlemententityallocationtypemappingid, statecode, statuscode, allocationtype, entitytype, OwnerId) Values('0C537E5C-13E8-410B-A65C-783A113D49FC', 0, 1, 0, 0, 'F5C0B9AD-E076-ED11-81B3-6045BDE41C7D')`

- Include the following information for the mandatory fields:
    - **Entitlemententityallocationtypemappingid**: New GUID. 
    - **Statecode**: Provide state code that explains the status.
    - **Statuscode**: Provide the reason code that explains the status.
    - **Allocationtype**: Provide type of entitlement terms.
    - **Entitytype**: Entity type for which the entitlement applies.
    - **OwnerId**: Owner Id

## Troubleshoot other issues

### SLA KPI instance status shows as canceled

When you update the target record so that **Applicable when** condition is no more applicable, the SLA KPI status moves from one of the existing states of **In progress**, **Succeeded**, **Nearing non compliance**, or **Expired** to the **Canceled** state. The SLA KPI instance is canceled on the second evaluation because the **Applicable when** condition is no longer met. Consider the following scenario in which you create an SLA with the following conditions and set it as the default SLA.

- **Applicable when:** Case status equals active
- **Success condition:** Case status equals resolved

1. Create a case. The case status is set to **Active** by default, the SLA is applied, and the SLA timer starts.

2. Resolve the case. The case status is set to **Resolved**, and the SLA is reevaluated for the **Applicable when** condition. The SLA KPI instance status will be set to **Canceled**.

#### Reason

When you define the **Applicable when** and **Success condition** on the same attribute, such as **case status**, one of the criteria might not be met, and the SLA KPI instance status will be canceled.

> [!NOTE]
> When you define the conditions on the same attribute, a recommendation message is displayed that suggests you to not use the same attribute.

#### Resolution

In such scenarios, it is recommended that you don't define the **Applicable when** and **Success condition** on the same attribute.

### Success, warning, and failure actions are being run multiple times in web client

When updates are made to the target record, the attributes present in the **Applicable when** condition of the SLA item are modified in the applied SLA.

Consider a scenario in which you've created an SLA in the web client with an SLA item that has the following **Applicable when** and **Success condition**, and is set as the default.
> ![Scenario for troubleshooting SLAs.](media/troubleshoot-sla.png "Scenario for troubleshooting SLAs")

1. Create a case with case type set as question. The SLA timer starts.

2. Add **Resolved** to case title. The success condition is met and the following events occur:

   - The SLA KPI instance status is updated to succeeded.
   - A success action, such as send mail, is run, if configured.

3. Update the case type to request.

  - The SLA KPI instance that is in the succeeded status is reevaluated because the **Applicable when** attribute is changed.
  - The SLA KPI instance moves from **Succeeded** to **In progress**.
  - Because the case title contains **Resolved** and the success condition is true, the SLA KPI instance status changes from **In progress** to **Succeeded** again, and runs the success action again.

Based on the SLA KPI instance status, if any actions are configured, those actions will be run multiple times.

#### Reason

When the **Applicable when** attribute is updated, the SLA is reevaluated that results in multiple iterations of the actions.

#### Resolution

This is the expected behavior for SLAs in the web client. It is recommended to define the **Applicable when** condition on only those attributes whose values don't change frequently.

### Deletion of SLAs or SLA Items show error messages in Unified Interface during solution upgrade or manual deletion

The following two error messages are displayed:

Error message 1: "The object you tried to delete is associated with another object and cannot be deleted."

Error message 2: "SLAItem delete operation encountered some errors. The process is part of a managed solution and cannot be individually deleted. Uninstall the parent solution to remove the process. See log for more details."

#### Reason

The first error occurs because in UCI SLA, the relationship between the SLA item and SLA KPI instances is set to "Restrict to Delete". The second error occurs because processes that are part of a managed solution can't be deleted. If you try to manually delete an SLA that is part of a managed solution and has flows configured, the error message appears.

#### Resolution

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

If the above resolution doesn’t work, contact Microsoft Support to request deletion of the SLA or SLA items.

###  SLA KPI instance isn't created on the entity

SLA KPI instance isn't created on the entity on which the SLA is enabled.

#### Reason

SLA KPI instances aren't created because of one of the following reasons:

- SLA isn't applied.

- No SLA Item is applicable.

- SLA KPI Applicable From is empty.

- Dependencies are disabled.

#### Resolution 

- SLA isn't applied: Verify if SLA is being applied correctly on the entity. More information: [Apply SLAs](apply-slas.md#apply-slas)

- No SLA Item is applicable: Verify whether the entity satisfies the Applicable when condition for at least one of the SLA items of the applied SLA.

- SLA KPI Applicable From is empty: Verify whether the **Applicable From** Date Field of KPI is filled for that entity.

- Dependencies are disabled: In the SLA form, activate notifications about any out of the box component, if any.

### Errors occur while updating a case

Errors appear on the SLA form while updating a case.

#### Reason 

If the action flow associated with one or more SLA items are deleted or aren't in **Published** state, errors might occur.

#### Resolution 

- Activate the draft flow from the SLA form. If your SLA is active but the dependent flow is inactive, then you may see notifications on the SLA form. As an administrator, select **Activate** to enable all the dependencies.

- Alternate resolution:

    1. Make the SLA inactive and go to the SLA items where you have configured action flows and select **Configure actions**. The Power Automate portal will appear and show your action flow.
    1. Turn on action flow.
    1. After activating action flows for SLA items, activate SLA again.  

### modifiedon and modifiedby fields on the case entity get updated

**modifiedon** and **modifiedby** fields on the case entity get updated for resolved cases.

#### Reason

**modifiedon** and **modifiedby** fields get updated for all resolved cases because of updates made in the **DeactivatedOn** field introduced in case entity, using the async job **ResolvedIncidentsUpdationOperation**. Next SLA for cases results in updates to **modifiedon** and **modifiedby** fields on the case entity. If you want to disable Next SLA, you must contact Microsoft Support.

#### Resolution

Avoid using the **modifiedon** and **modifiedby** fields for reporting because they get modified when calculating Next SLA on the enhanced case grid. If you want to know when the case was resolved, use the **incidentresolution** entity and avoid using **modifiedon** on the case entity.
 
### See also

[Understand SLA details with Timer control](customer-service-hub-user-guide-case-sla.md#understand-sla-details-with-timer-control)
[Define service-level agreements](define-service-level-agreements.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
