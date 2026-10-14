---
title: Migrate Field Service to a new environment
description: Learn which Field Service components to reconfigure and validate after you move or copy a Power Platform environment to a new environment or tenant.
ms.date: 09/24/2026
ms.topic: how-to
ms.author: jacoh
ms.reviewer: puneetsingh
author: jasonccohen
ms.custom: 
    - bap-template
    - ai-gen-docs-bap
    - ai-seo-date: 08/07/2026
ai-usage: ai-assisted
---

# Migrate Field Service to a new environment

When you move, copy, or restore the Power Platform environment that hosts Dynamics 365 Field Service, what transfers depends on the selected platform operation. A tenant-to-tenant move, restore, or **Everything** copy includes solutions and Dataverse data. A **Customizations and schemas only** copy doesn't include application data. After any migration, validate Field Service components that depend on environment-specific connections, Azure resources, or configuration.

Use this article together with the platform migration guidance. It summarizes Field Service validation and links to platform procedures for dependencies such as Power Apps, Power Automate, and Azure Synapse Link for Dataverse. For a first-time installation in a new environment, go to [Install Dynamics 365 Field Service](install-field-service.md).
## Prerequisites

- You have the administrative permissions required for the selected platform operation. For example, an environment copy requires the **Environment Admin** or Dataverse **System Administrator** role. A tenant-to-tenant move requires Power Platform or Dynamics 365 service-administrator privileges. Use the Dataverse **System Administrator** role to validate and configure the destination environment.
- You completed the platform-level move by using the appropriate Power Platform process:
  - To move an environment to a different tenant, go to [Tenant-to-tenant migrations](/power-platform/admin/move-environment-tenant).
  - To copy or restore an environment within a tenant, go to [Copy an environment](/power-platform/admin/copy-environment) and [Backup and restore environments](/power-platform/admin/backup-restore-environments).
- You reviewed your overall [environment strategy](/dynamics365/guidance/implementation-guide/environment-strategy-overview) and [application lifecycle management (ALM) checklist](/dynamics365/guidance/implementation-guide/application-lifecycle-management-checklist) before you migrate.

## What carries over and what you reconfigure

A tenant-to-tenant move, restore, or **Everything** copy includes solutions and Dataverse data, including configuration and transactional records. A **Customizations and schemas only** copy includes users, customizations, and schemas, but not application data. Components outside solutions, such as connections and some flows, might also require manual attention after a copy.

For operations that include Dataverse data, the following items normally carry over:

- Field Service solutions and customizations
- Configuration data, such as settings, incident types, price lists, and tax codes
- Transactional data, such as work orders, bookings, and assets
- Security role definitions

Validate the following items in the destination environment:

- Connection references, connections, and required cloud flows
- Resource Scheduling Optimization add-on installation and optimization configuration, if used
- Maps, geocoding, and location settings
- Mobile offline profiles, app associations, filters, and assignments
- Dual-write, Internet of Things (IoT), Azure Synapse Link, and mailbox connections, if used
- User mapping, security groups, and record ownership for tenant-to-tenant moves

For a **Customizations and schemas only** copy or a new destination environment, transfer the required Field Service configuration data separately. Learn more about transferring configuration data in [Move Field Service configuration data](#move-field-service-configuration-data).

## Move Field Service configuration data

If your destination is a new environment rather than a full copy or move, use the [Configuration Migration tool](/power-platform/admin/manage-configuration-data) to transfer Field Service configuration and reference data between environments. This tool supports customer engagement apps, including Field Service. Examples of configuration data include Field Service Settings, incident types, priorities, work order types, tax codes, price lists, and service task types.

When you use the tool, keep these points in mind:

- The tool moves configuration and reference data, not end-user transactional data such as accounts, contacts, or work orders.
- If Field Service business logic could affect the imported records, select **Disable plug-ins** in the export schema. Include this option only when it's needed for the data set, and validate the affected business logic after the import finishes.
- The tool doesn't migrate the Calendar table or image columns, so work hours, calendars, and inspection images need a separate approach.
- Import into a preproduction environment first, and back up the destination environment before you migrate.

## Reconfigure Field Service after migration

After the migration finishes, reconfigure or validate the following Field Service components in the destination environment.

### Connection references and cloud flows

Field Service uses Power Automate cloud flows for features such as work order recap, booking alerts, and inspections. Connection references are environment-specific and can use connections that their owners share with you. After migration:

1. In [**Power Apps**](https://make.powerapps.com), select **Solutions** and open the **Default Solution** to inventory the connection references in the destination environment.
1. Review the Field Service managed and add-on solutions for additional connection references.
1. Associate each required connection reference with a valid destination-environment connection.
1. Identify the cloud flows disabled by the selected copy or import operation and turn on only the flows required in the destination environment. Before you enable a flow, confirm that you have the required license, privileges, and permission to use its connections.

For a tenant-to-tenant move, complete the platform's [post-migration process for Power Automate](/power-platform/admin/move-environment-tenant#post-migration-process-for-power-automate). It includes mapping connection references, enabling child flows before parent flows, and updating trigger URLs. If you migrate a custom connector, review the [custom connector solution limitations](/connectors/custom-connectors/customconnectorssolutions#known-limitations) before you import dependent connection references and flows.

Learn more about connection references in [Use a connection reference in a solution](/power-apps/maker/data-platform/create-connection-reference) and about solution lifecycle management in [Application lifecycle management (ALM) basics](/power-platform/alm/basics-alm).

### Power Apps and custom pages

For a tenant-to-tenant move, follow the platform's Power Apps preparation and post-migration steps. Solution-aware canvas apps, custom pages, and component libraries stop working after the move unless you export and remove them from the source environment first, and then import them into the destination environment.

Learn more in [Prepare Power Apps for a tenant-to-tenant migration](/power-platform/admin/move-environment-tenant#prepare-power-apps) and [Complete the post-migration process for Power Apps](/power-platform/admin/move-environment-tenant#post-migration-process-for-power-apps).

### Maps, geocoding, and location settings

After migration, validate the following location settings:

- In the **Resource Scheduling** app, go to **Settings** > **Administration** > **Scheduling Parameters** and confirm that **Connect to Maps** has the intended value.
- In **Field Service Settings**, confirm that **Auto Geo Code Addresses** has the intended value.
- Test address resolution. Regeocode affected records only if their location data doesn't resolve correctly.

Learn more about these settings in [Set up maps, geocoding, and routing](field-service-maps-address-locations.md).

### Resource Scheduling Optimization add-on

If you use the Resource Scheduling Optimization (RSO) add-on, validate it in the destination
environment.

Steps 2 through 5 apply only to an operation that includes Dataverse data: a tenant-to-tenant move, a restore, or an **Everything** copy. A **Customizations and schemas only** copy brings the add-on but not the optimization scopes, schedules, objectives, and goals. Create those in the destination environment or transfer them as configuration data, then complete steps 2 through 5.

1. Confirm the Resource Scheduling Optimization add-on is present. In the
   [Power Platform admin center](https://admin.powerplatform.microsoft.com/), select
   **Manage** > **Environments**, select your environment, and then select **Dynamics 365 apps**. The copied add-on normally shows as **Installed**. If it isn't listed, select **Install app**, and then select **Resource Scheduling Optimization**.

   > [!IMPORTANT]
   > **Installed** doesn't mean the add-on is ready to run. Copied schedules can still fail.
   > Complete the remaining steps before relying on it.

1. Confirm the expected optimization scopes, schedules, objectives, and goals are present and correctly configured.
1. Re-publish each optimization schedule that's already in a **Published** state. Copied schedules keep their published status but don't run in the destination environment until they're published there.

   > [!NOTE]
   > Leave unpublished schedules as they are. Publishing one starts an optimization that the source
   > environment wasn't running.

1. Confirm each re-published schedule shows a next run time. If its recurrence date range has ended, there is no next occurrence; the field can be empty or show a past time. Extend the date range if the schedule should run again.
1. Run a test optimization and confirm it produces bookings.

Resource Scheduling Optimization runs as a Microsoft-managed service. There are no
environment-specific Azure resources or keys for you to repair after a migration.

Learn more in [Deploy the Resource Scheduling Optimization add-on](rso-deployment.md).

> [!NOTE]
> The add-on license allows for unlimited use of schedule optimization, whether on a regular
> cadence or ad hoc basis. The license includes one active instance of Resource Scheduling
> Optimization per tenant.
>
> For purchasing guidance, including additional licenses for the copied environment, see
> [Get Resource Scheduling Optimization](rso-get-install.md).

### Mobile offline profiles

The Field Service mobile app uses offline profiles to sync data to frontline workers' devices. If you use mobile offline, validate the configuration before asking frontline workers to use the destination environment:

1. Confirm the mobile offline profile and its entity filters exist in the destination environment.
1. Confirm that the profile is published, associated with the Field Service Mobile app, and assigned to the appropriate users or teams.
1. If you change the profile or its assignments, publish the profile.
1. Ask a test user to sign in to the destination environment and complete a full sync.

Learn more in [Set up the mobile offline profile](mobile/set-up-offline-profile.md). If the app connects to the wrong environment, go to [Troubleshoot common issues in the Field Service mobile app](/troubleshoot/dynamics-365/field-service/mobile-app/mobile-app-common-issues).

### Integrations

Validate the integrations used by the destination environment:

- **Dynamics 365 finance and operations apps (dual-write):** Integrations with finance and operations apps, such as Dynamics 365 Finance and Dynamics 365 Supply Chain Management, use dual-write. For a copy or restore, follow the official unlink, environment-cleanup, and relink procedure before you reenable the required table maps. A Dataverse organization linked to a finance and operations apps environment can't be migrated to a different tenant, and cross-tenant links aren't supported. Plan a different approach if you need to move a linked environment. Learn more about copy and restore scenarios in [Unlink and relink dual-write environments](/dynamics365/fin-ops-core/dev-itpro/data-entities/dual-write/relink-environments) and about the tenant-move restriction in [Tenant-to-tenant migrations](/power-platform/admin/move-environment-tenant).
- **Project Operations:** Field Service and Project Operations are Dataverse apps, so their integration moves with the environment. After migration, validate the integration's recurring Power Automate flow and its connection. If the deployment also connects to finance and operations apps, such as Dynamics 365 Finance or Dynamics 365 Supply Chain Management, the dual-write rules in the previous bullet apply, including the tenant-move restriction. Learn more in [Field Service integration with Project Operations](/dynamics365/field-service/project-operations-integration).
- **Connected Field Service (IoT):** Validate the IoT provider and default-provider selection, endpoint and SAS configuration, Dataverse application programming interface (API) connection authorization, and relevant Azure deployment jobs. Reconnect or redeploy components only when validation identifies a missing or invalid dependency. Learn more about these dependencies in [Connected Field Service overview](connected-field-service.md).
- **Azure Synapse Link for Dataverse:** A tenant-to-tenant move deletes Azure Synapse Link profiles and stops data synchronization. A copy or restore doesn't include the profiles. Review how [environment lifecycle events affect Azure Synapse Link](/power-apps/maker/data-platform/azure-synapse-link-olc), and then [transport and verify the link configuration](/power-apps/maker/data-platform/azure-synapse-link-solution).
- **Business Central:** The Business Central integration connects through a Dataverse connection and the synchronization engine, not dual-write. After a copy or tenant move, reconfigure the connection on the **Dynamics 365 Connection Setup** page in Business Central, select **Redeploy Integration Solution** to reset permissions, and run a full synchronization. After a tenant move, confirm that user email addresses match the destination Dataverse tenant so that resource mappings resolve. Learn more in [Integrate Business Central with Field Service](/dynamics365/business-central/admin-integrate-field-service).
- **Microsoft Outlook integration:** After an environment copy, mailbox synchronization can remain intentionally disabled. Enable it only if the destination is the environment that should synchronize with Exchange. Before enabling it, validate the server profile, approve the mailbox, and select **Test & Enable Mailbox**. Learn more about the one-environment synchronization limitation in [Integrate Field Service bookings with Outlook calendars](outlook-integration.md).

### Users and security roles

For a tenant-to-tenant move, prepare and validate users as part of the platform migration process:

1. Before the move, create the required users in the destination tenant, assign their licenses, and ensure they're active and authorized.
1. Create, upload, and validate the case-sensitive `usermapping.csv` file required by the tenant-migration process. Application users aren't supported in the mapping file, so create them in the destination tenant.
1. Update the destination environment's security-group membership because security groups aren't migrated.
1. After the move, confirm that mapped users are enabled and have the required Field Service security roles and column-level security profiles.
1. Validate record ownership and Bookable Resource associations. Reassign only records or resources associated with an unmapped or incorrect user.

Learn more about user preparation and mapping in [Tenant-to-tenant migrations](/power-platform/admin/move-environment-tenant) and about Field Service access in [Set up users, licenses, and security roles](users-licenses-permissions.md).

## Post-migration validation checklist

Before you route users to the destination environment, confirm the following items:

| Area | What to verify |
|---|---|
| Field Service apps | The **Field Service** and **Field Service Mobile** apps open and load without errors. |
| Power Apps and custom pages | Required canvas apps, custom pages, and component libraries are available and work correctly. |
| Connections and cloud flows | Every Field Service connection reference resolves to a valid connection, and required cloud flows are turned on. |
| Work orders | You can create, schedule, and save a work order end to end. |
| Schedule board | The schedule board loads and shows bookable resources. |
| Maps and geocoding | Addresses geocode and resolve correctly. |
| RSO add-on (if used) | Previously published optimization schedules are re-published and, where their date range is still current, show a next run time. A test optimization runs successfully. |
| Mobile offline (if used) | The mobile app signs in to the correct environment and completes a full sync. |
| Integrations (if used) | Dual-write, Project Operations, Business Central, IoT, Azure Synapse Link, and Outlook integrations work as intended. |
| Users and security | Users have the correct Field Service security roles and can access their records. |

## Troubleshoot migration issues

- If Field Service doesn't appear or install correctly, go to [Can't install Dynamics 365 Field Service application](/troubleshoot/dynamics-365/field-service/administration/cant-install-field-service).
- For more Field Service troubleshooting articles, go to [Field Service troubleshooting](/troubleshoot/dynamics-365/field-service/welcome-field-service).

## Related information

- [Install Dynamics 365 Field Service](install-field-service.md)
- [Manage the lifecycle of your Dynamics 365 environments](/dynamics365/guidance/migrate/overview)
- [Tenant-to-tenant migrations](/power-platform/admin/move-environment-tenant)
- [Move configuration data with the Configuration Migration tool](/power-platform/admin/manage-configuration-data)
- [Plan your environment strategy for Dynamics 365](/dynamics365/guidance/implementation-guide/environment-strategy-overview)
- [Best practices for ALM in Dynamics 365 applications](/dynamics365/guidance/implementation-guide/application-lifecycle-management-product#customer-engagement-apps)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
