---
title: "Install LinkedIn Sales Navigator for Dynamics 365 | Microsoft Docs"
description: "Install the LinkedIn Sales Navigator for Dynamics 365 capabilities from AppSource"
keywords: "installation, setup, sales navigator, appsource"
ms.date: 03/28/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 Version 9.x"
ms.assetid: 4b15aff2-3a7b-3488-260c-21611dee658a
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Install Sales Navigator for Dynamics 365 from AppSource

## Prerequisites
This installation is required for you to enable the sync between [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] and [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator, including
write-back from Sales Navigator to [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)].

- You have a System Administrator security role in [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)]. 
- You need a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] account. [Join now](https://www.linkedin.com/reg/join).
- You will need to sign your team up for [LinkedIn Sales Navigator Team](https://business.linkedin.com/sales-solutions) or [LinkedIn Sales Navigator Enterprise](https://business.linkedin.com/sales-solutions).    
  We recommend having a Sales Navigator Administrator + Team Member seat to complete the installation, however you may use a Sales Navigator Administrator seat.
- You will need to enable JavaScript in your browser.
- You will need to disable your pop-up blocker for the [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] domain.

## Install the solution

1. Go to [AppSource](https://appsource.microsoft.com) and search for "[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)]". Select the **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Controls for [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] Unified Interface**

2. Review the terms of service and select **Get**.


[comment]: <> (update steps and add screenshots)


> [!TIP]
> If you aren't working with Unified Interface apps, [review the installation steps](https://www.linkedin.com/help/sales-navigator/topics/2052/2071/80081) for [Sales Navigator for Microsoft Dynamics](https://appsource.microsoft.com/en-us/product/dynamics-365/linkedin.0cb76fe0-d453-4edb-a68c-65fb9119493a?src=retail&tab=Overview). This solution provides Sales Navigator widgets for Dynamics CRM 2016 and [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)].

## Update the solution

After installing the solution, you can visit the [Office 365 admin center](https://portal.office.com/) to see if an update is available. You'll need global admin permissions to start the update process.

1. Go to the [Office 365 admin center](https://portal.office.com/) and sign in with your global admin credentials.

2. Under **Admin centers**, select **[!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)]**. 

3. In the **[!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] Administration Center**, select the **Instances** tab.

4. Under **Solutions**, click **Manage your solutions**.

5. Select **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator for [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)]** and click **Upgrade**.

6. Review the **Terms of service** and click **Upgrade**.

## Remove the solution

1. Make sure you have a System Administrator or Customizer security role.

2. Sign in to [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)]. 

3. Go to **Settings** > **Solutions**. 

4. Select the solution and choose **Delete**

More information about installing or removing a solution: [TechNet: Install or remove a preferred solution](https://technet.microsoft.com/library/dn878909.aspx).

### See also

[Overview for LinkedIn Sales Navigator solutions](integrate-sales-navigator.md)     
[Customize forms to show Sales Navigator controls](add-sales-navigator-controls-forms.md)    
[Work with Sales Navigator controls on forms](view-sales-navigator-forms.md)