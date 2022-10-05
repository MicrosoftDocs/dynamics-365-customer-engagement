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

There might be occasions when you need to move the Dynamics 365 Customer Engagement deployent, such as when replacing an existing server computer. This article describes how to move server components in a Dynamics 365 Customer Engagement on-premises deployment.

## Move the Microsoft Dynamics 365 CE databases to another SQL Server and SQL Server Reporting Services server in the same domain

1. Back up the OrganizationName_MSCRM database(s). More information: [Back up the Dynamics 365 Customer Engagement (on-premises) system](back-up-the-microsoft-dynamics-365-system.md)
1. Install Microsoft Dynamics 365 Server on the new Windows Server or Windows Server farm that will run one or more Dynamics 365 CE Server roles. More information: [Microsoft Dynamics 365 Server installation](microsoft-dynamics-365-server-installation.md?view=op-9-0)
1. On a computer running SQL Server Reporting Services that's in the same domain as the Windows Server computers from the previous step, install the Microsoft Dynamics 365 Reporting Extensions. More information: [Install Microsoft Dynamics 365 Customer Engagement (on-premises) Reporting Extensions](install-microsoft-dynamics-365-reporting-extensions.md)

   > [!IMPORTANT]
   >  You can't import an organization until the Microsoft Dynamics 365 Reporting Extensions are installed.
1. Restore the OrganizationName_MSCRM database(s) to the new SQL Server instance that's running in the same domain as the other Dynamics 365 Customer Engagement on-premises deployment servers.
1. Using either Deployment Manager or PowerShell, import the organization(s) into the new deployment of Microsoft Dynamics 365 CE. More information: [Import an organization](import-an-organization.md) and [Import-CrmOrganization](/en-us/powershell/module/microsoft.crm.powershell/import-crmorganization?view=dynamics365ce-ps)

## Redeploy the Microsoft Dynamics 365 CE deployment that includes the Microsoft Dynamics 365 CE Server to another domain

1. Back up the OrganizationName_MSCRM database(s). More information: [Back up the Dynamics 365 Customer Engagement (on-premises) system](back-up-the-microsoft-dynamics-365-system.md)
1. Install Microsoft Dynamics 365 Server on the new Windows server or Windows server farm *in the new domain* that will run that will run one or more server roles.
1. On a computer running SQL Server Reporting Services that's in the same domain as the Windows Server computers from the previous step, install the Microsoft Dynamics 365 Reporting Extensions. More information: [Install Microsoft Dynamics 365 Customer Engagement (on-premises) Reporting Extensions](install-microsoft-dynamics-365-reporting-extensions.md)

   > [!IMPORTANT]
   >  You can't import an organization until the Microsoft Dynamics 365 Reporting Extensions are installed.
1. Restore the OrganizationName_MSCRM database(s) to the new SQL Server instance *on the new domain*.
1. Using either Deployment Manager or PowerShell, import the organization(s) into the new deployment of Microsoft Dynamics 365 CE. More information: [Import an organization](import-an-organization.md) and [Import-CrmOrganization](/en-us/powershell/module/microsoft.crm.powershell/import-crmorganization?view=dynamics365ce-ps)

## Next steps

[Post-installation and configuration guidelines for Microsoft Dynamics 365](post-installation-configuration-guidelines-dynamics-365.md)
