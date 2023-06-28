---
title: "Move environments between tenants (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to prepare for and request to move an environment from one tenant to another."
ms.date: 09/23/2022
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Tenant to tenant migration for Dynamics 365 Marketing

Migrating a Marketing environment between tenants requires assistance from our technical support team. To request tenant to tenant migration within the same Azure geographic location (geo), [contact technical support](/power-platform/admin/get-help-support) and submit a support request.

> [!NOTE]
> When migrating a Marketing environment between tenants, the support team will advise you about pre-migration and post-migration steps (see below). Familiarize yourself with the [Marketing app status after migration](#marketing-app-status-after-migration) to determine if migration will be a good fit for your environment.

> [!WARNING]
> The Marketing app doesn't currently support migration between different tenant geographic locations (geo to geo).

## Marketing app status after migration

After tenant to tenant migration, the Marketing environment will be in the following state:

- The Marketing app will be upgraded to the latest version that is available at the time of migration.
- All Marketing-related settings and customizations from your source environment will be present on the migrated environment.
- All records that were live on the source environment (such as customer journeys, emails, lead-scoring records, and more) will revert to the draft state on the migrated environment.
- Interaction data from your source environment (such as email clicks or website visits) won't be available to the migrated environment. Most insights data will be initialized. You can freely generate new interaction data on the migrated environment without affecting your source environment.
- Content assets uploaded to your source environment (such as images used in emails and landing pages) won't be available on the migrated environment. If you go live on the migrated environment with an email or page that was previously published on the source environment, the published design will show defunct links.
- Other aspects of the org state not specific to Marketing will align with the [general tenant to tenant migration norms](/power-platform/admin/move-environment-tenant).
- When migrating a Marketing environment between tenants, interaction data (such as email clicks), analytics data (such as journey analytics), and Customer Voice data will *not* be migrated.
- Migrating a Marketing environment between tenants with Customer Insights attached is unsupported at this time.

### See also

[Tenant to tenant migration](/power-platform/admin/move-environment-tenant)<br>
[Manage your Marketing environments](manage-marketing-environments.md)<br> 
[Transfer data between environments](transfer-data.md)<br>
[Transfer customizations between environments](transfer-solution.md)<br>
[Administer Power Apps](/power-platform/admin/admin-guide)<br>
[Environments overview](/power-platform/admin/environments-overview)<br>
[Move configuration data across environments and organizations](/power-platform/admin/manage-configuration-data)<br>
[Import, update, and export solutions](/powerapps/maker/common-data-service/import-update-export-solutions)<br>

[!INCLUDE[footer-include](../includes/footer-banner.md)]
