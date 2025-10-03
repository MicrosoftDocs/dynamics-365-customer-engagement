---
title: Resource Scheduling Health Diagnostics Tool
description: Learn how to use the health diagnostics tool in your Dynamics 365 environment.
ms.date: 09/15/2025
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
---

# Resource Scheduling Health Diagnostics Tool

The Resource Scheduling Health Diagnostics Tool helps admins identify and resolve issues in your Dynamics 365 Field Service, Project Operations, or Customer Service environments. You can use the Resource Scheduling Health Diagnostics Tool to:

- Identify configuration issues in your schedule board.
- Detect metadata issues that might affect the performance of your environment.
- Find unsupported customizations that might cause issues in your environment.
- Get recommendations for resolving issues.

## Access the Resource Scheduling Health Diagnostics Tool

To access the Resource Scheduling Health Diagnostics Tool, follow these steps:

1. Go to the **Resource Scheduling** app and select **Settings**.
1. In the navigation menu, select **Administration** under **Scheduling**.
1. Select **Scheduling Parameters**.
   
   :::image type="content" source="./media/scheduling-param-health-diagnostics-tool.png" alt-text="Screenshot of the Scheduling Settings window with the Administration menu and the Scheduling Parameters option highlighted.":::

1. Select **Health Diagnostics** at the top bar.    

   The health diagnostics tool opens in a new tab.

    :::image type="content" source="./media/health-diagnostics-option.png" alt-text="Screenshot of the Resource Scheduling window with the Health Diagnostics option highlighted.":::

## Diagnostic details

The following table shows diagnostic information, including diagnostic name and type, for warnings or errors that the Health Diagnostics Tool might find in your environment. These diagnostics indicate potential issues that you might need to fix, such as performance degradation.

> [!Note]
> If you don't see any diagnostic details from the following table when you run the Heath Diagnostics Tool, your environment doesn't have issues to resolve.

| Diagnostic displayed in UI | Description of diagnostic |
| --- | --- |
| An essential out-of-box record *&lt;Logical record name and id&gt;* in inactive state is detected. | This diagnostic appears if any of the following conditions are true:<ul><li>If scheduling parameter is inactive</li><li>If default schedule board setting is inactive</li><li>If default booking setup metadata is inactive</li><li>If any of the expected configuration records (based on predefined list) are inactive</li></ul>The Health Diagnostics Tool logs a failure for each record and shows a resolution option. |
| An out-of-box action/workflow in draft state is detected. | This diagnostic appears when a Universal Resource Scheduling workflow is in the draft state. The Health Diagnostics Tool logs a failure for each draft workflow and shows a resolution option. |
| An out-of-box SDK message processing step is disabled. | This diagnostic appears when a Universal Resource Scheduling SDK step is disabled. The Health Diagnostics Tool logs a failure for each disabled SDK step and shows a resolution option. |
| An out-of-box web resource is customized. This may cause unpredictable consequences during the next solution upgrade. | This diagnostic appears when a Universal Resource Scheduling web resource is customized. The Health Diagnostics Tool logs a failure for each customized web resource and shows the resolution option. |
| An unexpected result was encountered during the diagnostics of _&lt;diagnostics module&gt;_. | This diagnostic appears when an unexpected failure occurs during the diagnostic run. |
| Booking Relationship Logical Name should be empty for default BSM record. | This diagnostic appears if any of the following conditions are true:<ul><li>**msdyn_BookingRelationshipLogicalName** on default booking setup metadata isn't null</li><li>**msdyn_RequirementRelationshipLogicalName** on default booking setup metadata isn't null</li><li>**msdyn_EntityLogicalName** on none default booking setup metadata refers to a nonexistent entity</li><li>**msdyn_BookingRelationshipLogicalName** on none default booking setup metadata refers to a nonexistent field on booking entity</li><li>**msdyn_RequirementRelationshipLogicalName** on none default booking setup metadata refers to a nonexistent field on requirement entity</li></ul>The Health Diagnostics Tool logs a failure for each record/field and shows a resolution option. |
| Default booking status record is not specified. | This diagnostic appears if **msdyn_DefaultBookingCommittedStatus** or **msdyn_DefaultBookingCanceledStatus** is null on any booking setup metadata record. The Health Diagnostics Tool logs a failure for each booking setup metadata record and shows a resolution option. |
| Default booking status setting on booking setup metadata is set to a record that does not exist or is inactive. | This diagnostic appears if any of the following conditions are true:<ul><li> If there's any booking setup metadata where **msdyn_DefaultBookingCommittedStatus** has a value but is linked to a status that is either inactive or isn't type committed.</li><li>If there's any booking setup metadata where **msdyn_DefaultBookingCanceledStatus** has a value but is linked to a status that is either inactive or isn't type canceled.</li></ul> The Health Diagnostics Tool logs a failure for each failed booking setup metadata field and shows a resolution option. |
| Default requirement status setting on booking setup metadata is set to a record that does not exist or is inactive. | This diagnostic appears if any of the following conditions are true:<ul><li>If there's any booking setup metadata where **msdyn_DefaultRequirementActiveStatus** has a value but is linked to a status that's either inactive or isn't type **Active**.</li><li>If there's any booking setup metadata where **msdyn_DefaultRequirementCanceledStatus** has a value but is linked to a status that's either inactive or isn't type **Canceled**.</li><li>If there's any booking setup metadata where **msdyn_DefaultRequirementCompletedStatus** has a value but is linked to a status that's either inactive or isn't type **Completed**.</li></ul>The Health Diagnostics Tool logs a failure for each failed booking setup metadata/field and shows a resolution option. |
| Default Schedule Board Settings JSON configuration in Settings field is missing. | This diagnostic appears if **msdyn_Settings** on default schedule board setting is null. Also, shows a resolution option. |
| Default Schedule Board Settings SlotMetadataCollection is null or the contents of SlotMetadataCollection don't match the contents of all booking setup metadata records in the system. | This diagnostic appears if any of the following conditions are true:<ul><li>**SlotMetadataCollection** of **msdyn_Settings** on default schedule board setting has zero items.</li><li>**SlotMetadataCollection** of **msdyn_Settings** on default schedule board setting is missing an item for a booking setup metadata.</li></ul>The Health Diagnostics Tool logs a failure for each schedule board setting/booking setup metadata and shows a resolution option. |
| No booking status record of the core type *&lt;specify the core status type&gt;* exists. | This diagnostic appears if there's no booking status record with committed or canceled status. The Health Diagnostics Tool logs a failure for each missing record and shows a resolution option. |
| No requirement status record of the core type *&lt;specify the core status type&gt;* exists. | This diagnostic appears if there isn't at least one requirement status record for each status option. The Health Diagnostics Tool logs a failure for each option where a record doesn't exist and shows a resolution option. |
| Resource must not have empty required attribute *&lt;attribute name&gt;*. Affected entities: *&lt;entity name&gt;*. +*&lt;count of other affected entities&gt;* more. <br>AND/OR <br>Resource must have empty attribute *&lt;attribute name&gt;*. Affected entities: *&lt;entity name&gt;*. +*&lt;count of other affected entities&gt;* more. | This diagnostic appears when there is a bookable resource record where any of the following conditions are true: <ul><li>**ResourceType = Account**: The **Name** or **AccountId** field is empty, or the **ContactId**, **UserId**, or **msdyn_PoolType** field has a value.</li> <li>**ResourceType = Contact**: The **Name** or **ContactId** field is empty, or the **AccountId**, **UserId**, or **msdyn_PoolType** field has a value.</li><li>**ResourceType = User**: The **Name** or **UserId** field is empty, or the **AccountId**, **ContactId**, or **msdyn_PoolType** field has a value.</li><li>**ResourceType = PoolType**: The **Name** or **msdyn_PoolType** field is empty, or the **AccountId**, **ContactId**, or **UserId** field has a value.</li><li>**ResourceType = Crew, Equipment, or Generic**: The **Name** field is empty, or the **AccountId**, **ContactId**, **UserId**, or **msdyn_PoolType** field has a value.</li><li>**ResourceType = Facility**: The **Name** or **msdyn_organizationalunit** field is empty, the **AccountId**, **ContactId**, **UserId**, or **msdyn_PoolType** field has a value, or the **msdyn_StartLocation** or **msdyn_EndLocation** field isn't equal to **OrganizationalUnitAddress**.</li></ul> |
| The Resource Booking Synchronize Job could not be found. | This diagnostic appears when the ResourceBookingSync system job is disabled. Ignore it if you're using a Universal Resource Scheduling version higher than 3.12.152.16. |
| UFX configuration *&lt;configuration name&gt;* is not specified on a schedule board setting record. | This diagnostic appears if any of the following fields on the default schedule board setting record are null:<ul><li> **msdyn_FilterLayout**</li><li>**msdyn_ResourceCellTemplate**</li><li>**msdyn_RetrieveResourcesQuery**</li></ul>The Health Diagnostics Tool logs a failure for each field and shows a resolution option. |
| UFX configuration *&lt;configuration name&gt;* is not specified on the booking setup metadata record. | This diagnostic appears if any of the following fields are null on the default booking setup metadata:<ul><li> **msdyn_CloneEntityQuery**</li><li> **msdyn_RetrieveConstraintsQuery**</li><li> **msdyn_RetrieveResourcesQuery**</li></ul>The Health Diagnostics Tool logs a failure for each field and shows a resolution option. |
| UFX configuration *&lt;configuration name&gt;* on a schedule board setting is set to a record that does not exist or is inactive. | This diagnostic appears if any of the following fields on each schedule board setting record aren't referring to an active configuration record:<ul><li>**msdyn_FilterLayout**</li><li>**msdyn_ResourceCellTemplate**</li><li>**msdyn_RetrieveResourcesQuery**</li></ul>The Health Diagnostics Tool logs a failure for each record/field. |
| UFX configuration *&lt;configuration name&gt;* on a booking setup metadata record refers to a non-existent or an inactive record. | This diagnostic appears if any of the following fields on each booking setup metadata aren't referring to an active configuration record:<ul><li>**msdyn_CloneEntityQuery**</li><li>**msdyn_RetrieveConstraintsQuery**</li><li>**msdyn_RetrieveResourcesQuery**</li></ul>The Health Diagnostics Tool logs a failure for each record/field and shows a resolution option. |
| Unexpected share type on the default schedule board setting record. | This diagnostic appears if the share type of the default schedule board setting record is null or not system. |

### Additional resources

[Troubleshoot issues with Solution Health Hub](troubleshoot-field-service-solution-health.md)

[!INCLUDE [footer-include](../includes/footer-banner.md)]


