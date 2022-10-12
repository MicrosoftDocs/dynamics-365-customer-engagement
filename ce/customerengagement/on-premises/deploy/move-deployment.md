---
title: Move the Dynamics 365 Customer Engagement deployment
description: Describes how to move the deployment including the databases and servers. 
author: Mattp123
ms.author: matp
ms.prod: dynamics-365
ms.topic: how-to
ms.date: 10/05/2022
ms.custom: template-how-to
---
# Move the Dynamics 365 Customer Engagement on-premises deployment

There might be occasions when you need to move the Microsoft Dynamics 365 Customer Engagement deployment, such as when replacing an existing server computer. This article describes how to move server components in a Dynamics 365 Customer Engagement on-premises deployment.

## Redeploy in the same domain

Follow this procedure to redeploy Dynamics 365 Server and databases to different Windows Server, SQL Server, and SQL Server Reporting Services servers in the same domain.

1. Back up the OrganizationName_MSCRM database(s). More information: [Back up the Dynamics 365 Customer Engagement (on-premises) system](back-up-the-microsoft-dynamics-365-system.md)
1. Install Microsoft Dynamics 365 Server on the new Windows Server or Windows Server farm that will run one or more Dynamics 365 Server roles. More information: [Microsoft Dynamics 365 Server installation](microsoft-dynamics-365-server-installation.md?view=op-9-0&preserve-view=true)
1. Install additional Dynamics 365 Server roles on Windows Server computers in the domain until all roles are installed. If you installed all roles (Full Server) in the previous step you can skip this step.
1. On a computer running SQL Server Reporting Services that's in the same domain as the Windows Server computers from the previous step, install the Microsoft Dynamics 365 Reporting Extensions. More information: [Install Microsoft Dynamics 365 Customer Engagement (on-premises) Reporting Extensions](install-microsoft-dynamics-365-reporting-extensions.md)

   > [!IMPORTANT]
   >  You can't import an organization until the Microsoft Dynamics 365 Reporting Extensions are installed.
1. Restore the OrganizationName_MSCRM database(s) to the new SQL Server instance that's running in the same domain as the other Dynamics 365 Customer Engagement on-premises deployment servers.
1. Using either Deployment Manager or PowerShell, import the organization(s) into the new deployment of Dynamics 365 Customer Engagement. More information: [Import an organization](import-an-organization.md) and [Import-CrmOrganization](/en-us/powershell/module/microsoft.crm.powershell/import-crmorganization?view=dynamics365ce-ps&preserve-view=true)

## Redeploy to another domain

Follow this procedure to redeploy the Dynamics 365 Server and databases to different Windows Server, SQL Server, and SQL Server Reporting Services servers located in another domain.

1. Back up the OrganizationName_MSCRM database(s). More information: [Back up the Dynamics 365 Customer Engagement (on-premises) system](back-up-the-microsoft-dynamics-365-system.md)
1. Install Microsoft Dynamics 365 Server on the new Windows Server or Windows Server farm *in the new domain* that will run one or more server roles.
1. Install additional Dynamics 365 Server roles on Windows Server computers in the new domain until all roles are installed. If you installed all roles (Full Server) in the previous step you can skip this step.
1. On a computer running SQL Server Reporting Services that's in the same domain as the Windows Server computers from the previous step, install the Microsoft Dynamics 365 Reporting Extensions. More information: [Install Microsoft Dynamics 365 Customer Engagement (on-premises) Reporting Extensions](install-microsoft-dynamics-365-reporting-extensions.md)

   > [!IMPORTANT]
   >  You can't import an organization until the Microsoft Dynamics 365 Reporting Extensions are installed.
1. Restore the OrganizationName_MSCRM database(s) to the new SQL Server instance *in the new domain*.
1. Using either Deployment Manager or PowerShell, import the organization(s) into the new deployment of Dynamics 365 Customer Engagement. More information: [Import an organization](import-an-organization.md) and [Import-CrmOrganization](/en-us/powershell/module/microsoft.crm.powershell/import-crmorganization)

## Next steps

[Post-installation and configuration guidelines for Microsoft Dynamics 365](post-installation-configuration-guidelines-dynamics-365.md)
