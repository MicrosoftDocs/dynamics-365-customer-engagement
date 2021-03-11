---
title: "New features in Dynamics 365 Customer Engagement (on-premises), version 9"
description: Find how to update or upgrade to Dynamics 365 Customer Engagement (on-premises), update 9.1
ms.date: "03/03/2021"
ms.topic: "topic"
ms.assetid: 676b68d9-2a7b-4924-a5cf-299163e8b5ea
author: mattp123
ms.author: matp
ms.prod: dynamicscrm-2016
---

# Update or upgrade to 9.1

# [Version 9.0 deployments](#tab/v90)

1.  Apply the Dynamics 365 Customer Engagement, version 9.1 update to all computers running Dynamics 365 Server and desktop applications in your deployment.

2.  Choose whether to:

    -   Import each organization into a new Dynamics 365 Customer Engagement (on-premises), version 9.1 server deployment. Each imported organization will be updated to Dynamics 365 Customer Engagement, version 9.1 during the import process.

    -   Update each organization in-place in the updated Dynamics 365 Customer Engagement, version 9.1 (on-premises) server deployment.

# [Version 8.2 deployments](#tab/v82)

1.  Upgrade all computers running Dynamics 365 Server and desktop applications in your deployment to Dynamics 365 Customer Engagement (on-premises), version 9.0.

2.  Apply the version 9.1 update to all computers running Dynamics 365 Server and desktop applications in your deployment.

3.  Next, update or import each organization.

---

For more information, see the following articles:

-   [Dynamics 365 Customer Engagement (on-premises) application updates](deploy/update-microsoft-dynamics-crm#microsoft-dynamics-365-customer-engagement-on-premises-application-updates)

-   [Deployment Manager: Update an organization](deploy/update-an-organization)

-   [PowerShell: Update-CrmOrganization](/powershell/module/microsoft.crm.powershell/update-crmorganization?view=dynamics365ce-ps)

-   [Upgrading Dynamics 365 Server](deploy/upgrading-microsoft-dynamics-365-server)

> [!NOTE]
> By default, when you apply the Dynamics 365 Server, version 9.1 update, all organization databases that are enabled in the deployment will be updated to Dynamics 365 Customer Engagement, version 9.1. Administrators can control which organization databases are upgraded in either of the following ways:
> 
> -   Disable the organizations you don't want upgraded. Notice that all organizations must remain disabled until all the servers in a multi-server deployment are updated. More information: [Deployment Manager: Disable or enable an organization](deploy/disable-or-enable-an-organization) and [PowerShell: Disable-CrmOrganization](/powershell/module/microsoft.crm.powershell/disable-crmorganization?view=dynamics365ce-ps).
> 
> - Configure the AutomaticallyInstallDatabaseUpdates deployment setting to false.
> 
>     `Add-PSSnapin Microsoft.Crm.PowerShell`
>     `set-crmadvancedsetting -configurationentityname Deployment -setting AutomaticallyInstallDatabaseUpdates -value $false`

## Apply the update

1.  Copy or download the appropriate update package to the computer where a Dynamics 365, v9.0 (on-premises) application, such as Dynamics 365 Server, v9.0 (on-premises) or Dynamics 365 Reporting Extensions is running.

2.  To start the update installation, right-click the update package, and then select **Run as administrator**.
