---
title: "Deploy and operate Dynamics 365 Customer Engagement (on-premises) | Microsoft Docs"
description: This document set explains how to deploy and operate Dynamics 365 Customer Engagement (on-premises)
ms.date: 06/07/2021
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: fdcb7532-2a86-462e-aaa1-c59cbbc85d33
caps.latest.revision: 149
author: Mattp123
ms.author: matp
---
# Deploy and operate Dynamics 365 Customer Engagement (on-premises), version 9.x

::: moniker range="op-9-1"
Dynamics 365 Customer Engagement (on-premises), version 9.1 is available as an update to version 9 customers.

- If you already have version 9 or 8.2 deployed, start here: [Update Customer Engagement (on-premises)](/dynamics365/customerengagement/on-premises/deploy/update-to-v91?view=op-9-1&preserve-view=true)

- If you are installing Customer Engagement (on-premises) for the first time, select **9.0** from the **Version** list above the left navigation to view the deployment instruction for version 9.

::: moniker-end

::: moniker range="op-9-0"

This guide provides a set of comprehensive deployment and operation topics that can help you plan, deploy, and maintain Dynamics 365 Customer Engagement (on-premises), version 9.

**Upgrade information:** If you’re an existing customer interested in upgrading your deployment for earlier version (8.x), start with the [Plan your upgrade to Dynamics 365 Server](plan-your-upgrade-to-microsoft-dynamics-365-server.md) topic.  
  
 **Administration and customization information:**  If you're an administrator or customizer, see the [Administrator Guide for Dynamics 365 Customer Engagement (on-premises)](../admin/overview.md).  
  
 **Reporting and analytics information:** If you're a report writer or other analytics professional, see the [Reporting and Analytics Guide for Dynamics 365 Customer Engagement (on-premises)](../analytics/reporting-analytics-with-dynamics-365.md).  

**Operate the deployment using PowerShell:** Use these topics to find help for the [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlets for Dynamics 365 Customer Engagement (on-premises). More information: [Microsoft Dynamics 365 Customer Engagement (on-premises) PowerShell Reference](/powershell/dynamics365/customer-engagement/overview?view=dynamics365ce-ps&preserve-view=true)
    
 This documentation set includes the following areas:  
  
-   [Dynamics 365 Customer Engagement (on-premises) planning guidance](planning-your-deployment-of-microsoft-dynamics-365.md). Use these topics to help plan your Dynamics 365 Customer Engagement (on-premises) deployment.  
  
-   [Dynamics 365 Customer Engagement (on-premises) installation guidance](installing-on-premises-dynamics-365.md). Use these topics to help install and configure your deployment.  

-   [Operating Dynamics 365 Customer Engagement (on-premises)](operating-microsoft-dynamics-365.md). Use this information to help keep your deployment running efficiently.

> [!NOTE]
> For the deployment and administration information of the previous version (8.x), see [Deploy and operate Dynamics 365 Customer Engagement (on-premises), version 8.x](/previous-versions/dynamicscrm-2016/deployment-administrators-guide/hh699811(v=crm.8)).

::: moniker-end  

## Deployment and operation known issues

### A deployment administrator can't perform deployment administration tasks

After a user is added as a deployment administrator, the member of the Deployment Administrators group might be unable to perform a deployment administrative task, such as importing an organization database. More information: [Known issue where a deployment administrator has insufficient permission](deployment-administrators.md#known-issue-where-a-deployment-administrator-has-insufficient-permission)
