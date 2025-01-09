---
title: "Update Dynamics 365 Customer Engagement (on-premises)"
description: Find how to update Dynamics 365 Customer Engagement (on-premises)
ms.topic: conceptual
author: mattp123
ms.author: matp

---
# Apply the Dynamics 365 Customer Engagement (on-premises), version 9.1 update

::: moniker range="op-9-1"
Updating or upgrading to Dynamics 365 Customer Engagement (on-premises), version 9.1 depends on the version of Dynamics 365 Customer Engagement (on-premises) you have.

# [Version 9.0 deployments](#tab/v90)

1. Ensure that all your computers running Dynamics 365 Customer Engagement (on-premises) version 9.0 have the latest cumulative update. More information: [Microsoft Dynamics 365 on-premises Cumulative Updates](https://support.microsoft.com/en-us/topic/microsoft-dynamics-365-on-premises-cumulative-updates-ed51f905-cf4e-3641-dc7c-afe2b868eeb9)

1. Apply the latest Dynamics 365 Customer Engagement (on-premises), version 9.1 cumulative update to all computers running Dynamics 365 Server and desktop applications in your deployment. More information: [Microsoft Dynamics 365 on-premises Cumulative Updates](https://support.microsoft.com/en-us/topic/microsoft-dynamics-365-on-premises-cumulative-updates-ed51f905-cf4e-3641-dc7c-afe2b868eeb9)

    > [!IMPORTANT]
    >
    > - Always apply the most recent update.
    > - Applying an older 9.1 update on a computer with a later 9.0 version will result in failures due to some assemblies not loading correctly.
    > - If your 9.0 deployment is 9.0.47.08 or later version, then you must apply the 9.1.20.11 update or later version.

3. Choose whether to:

    -   Import each organization into a new Dynamics 365 Customer Engagement (on-premises), version 9.1 server deployment. Each imported organization will be updated to Dynamics 365 Customer Engagement (on-premise), version 9.1 during the import process.

    -   Update each organization in-place in the updated Dynamics 365 Customer Engagement (on-premise), version 9.1 (on-premises) server deployment.

# [Version 8.2 deployments](#tab/v82)

1.  Upgrade all computers running Dynamics 365 Server and desktop applications in your deployment to Dynamics 365 Customer Engagement (on-premises), version 9.0.

2.  Apply the latest version 9.1 update to all computers running Dynamics 365 Server and desktop applications in your deployment. More information: [Microsoft Dynamics 365 on-premises Cumulative Updates](https://support.microsoft.com/en-us/topic/microsoft-dynamics-365-on-premises-cumulative-updates-ed51f905-cf4e-3641-dc7c-afe2b868eeb9)

3.  Next, update or import each organization.

---

For more information, go to the following articles:

-   [Dynamics 365 Customer Engagement (on-premises) application updates](update-microsoft-dynamics-crm.md#microsoft-dynamics-365-customer-engagement-on-premises-application-updates)

-   [Deployment Manager: Update an organization](update-an-organization.md)

-   [PowerShell: Update-CrmOrganization](/powershell/module/microsoft.crm.powershell/update-crmorganization?view=dynamics365ce-ps&preserve-view=true)

-   [Upgrading Dynamics 365 Server](upgrading-microsoft-dynamics-365-server.md)

> [!NOTE]
> By default, when you apply the Dynamics 365 Server, version 9.1 update, all organization databases that are enabled in the deployment will be updated to Dynamics 365 Customer Engagement (on-premises), version 9.1. Administrators can control which organization databases are upgraded in either of the following ways:
> 
> -   Disable the organizations you don't want upgraded. Notice that all organizations must remain disabled until all the servers in a multi-server deployment are updated. More information: [Deployment Manager: Disable or enable an organization](disable-or-enable-an-organization.md) and [PowerShell: Disable-CrmOrganization](/powershell/module/microsoft.crm.powershell/disable-crmorganization?view=dynamics365ce-ps&preserve-view=true).
> 
> - Configure the AutomaticallyInstallDatabaseUpdates deployment setting to false.
> 
>     `Add-PSSnapin Microsoft.Crm.PowerShell`
>     `set-crmadvancedsetting -configurationentityname Deployment -setting AutomaticallyInstallDatabaseUpdates -value $false`

## Apply the update

1.  Copy or download the appropriate update package to the computer where a Dynamics 365, v9.0 (on-premises) application, such as Dynamics 365 Server, v9.0 (on-premises) or Dynamics 365 Reporting Extensions is running.

2.  To start the update installation, right-click the update package, and then select **Run as administrator**.

## See also
[New features in Dynamics 365 Customer Engagement (on-premises), version 9.x](../whats-new.md) <br />
[Update Dynamics 365 Customer Engagement (on-premises)](update-microsoft-dynamics-crm.md)

::: moniker-end

::: moniker range="op-9-0"

For information about the available updates for Dynamics 365 Customer Engagement (on-premises), version 9.0, see [Microsoft Dynamics 365 on-premises Cumulative Updates](https://support.microsoft.com/topic/microsoft-dynamics-365-on-premises-cumulative-updates-ed51f905-cf4e-3641-dc7c-afe2b868eeb9).

## See also
[Update Dynamics 365 Customer Engagement (on-premises)](update-microsoft-dynamics-crm.md)
::: moniker-end
