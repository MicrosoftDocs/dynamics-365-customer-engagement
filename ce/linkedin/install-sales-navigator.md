---
title: "Install LinkedIn Sales Navigator for Dynamics 365 | Microsoft Docs"
description: "Install the LinkedIn Sales Navigator for Dynamics 365 capabilites from AppSource"
keywords: "installation, setup, sales navigator, appsource"
ms.date: 03/26/2018
ms.assetid: 4b15aff2-3a7b-3488-260c-21611dee658a
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Install Sales Navigator for Dynamics 365 from AppSource

[comment]: <> (add tokens)

## Prerequisites
This installation is required for you to enable the sync between Dynamics 365 and Sales Navigator, including
write-back from Sales Navigator to Dynamics 365.

- You have a System Administrator security role in Dynamics 365. 
- You need a LinkedIn account. [Join now](https://www.linkedin.com/reg/join).
- You will need to sign your team up for [LinkedIn Sales Navigator Team](https://business.linkedin.com/sales-solutions) or [LinkedIn Sales Navigator Enterprise](https://business.linkedin.com/sales-solutions).    
  We recommend having a Sales Navigator Administrator + Team Member seat to complete the installation, however you may use a Sales Navigator Administrator seat.
- You will need to enable JavaScript in your browser.
- You will need to disable your pop-up blocker for the Dynamics 365 domain.

## Install the solution

1. Go to [AppSource](https://appsource.microsoft.com) and search for "LinkedIn". Select the **LinkedIn Sales Navigator Controls for Dynamics 365 Unified Interface**

2. Review the terms of service and select **Get**.


[comment]: <> (update steps and add screenshots)


> [!TIP]
> If you aren't working with Unified Interface apps, [review the installation steps](https://www.linkedin.com/help/sales-navigator/topics/2052/2071/80081) for [Sales Navigator for Microsoft Dynamics](https://appsource.microsoft.com/en-us/product/dynamics-365/linkedin.0cb76fe0-d453-4edb-a68c-65fb9119493a?src=retail&tab=Overview). This solution provides Sales Navigator widgets for Dynamics CRM 2016 and Dynamics 365.

## Update the solution

After installing the solution, you can visit the [Office 365 admin center](https://portal.office.com/) to see if an update is available. You'll need global admin permissions to start the update process.

1. Go to the [Office 365 admin center](https://portal.office.com/) and sign in with your global admin credentials.

2. Under **Admin centers**, select **Dynamics 365**. 

3. In the **Dynamics 365 Administration Center**, select the **Instances** tab.

4. Under **Solutions**, click **Manage your solutions**.

5. Select **LinkedIn Sales Navigator for Microsoft Dynamics** and click **Upgrade**.

6. Review the **Terms of service** and click **Upgrade**.


## Remove the solution

1. Make sure you have a System Administraor or Customizer security role.

2. Sign in to Dynamics 365. 

3. Go to **Settings** > **Solutions**. 

4. Select the solution and choose **Delete**

More information about installing or removing a solution: [TechNet: Install or remove a preferred solution](https://technet.microsoft.com/library/dn878909.aspx).

### See also

[Overview for LinkedIn Sales Navigator solutions](integrate-sales-navigator.md)     
[Find out how to customize forms to see Sales Navigator controls.](add-sales-navigator-controls-forms.md)    
[Sign in to your LinkedIn account to see Sales Navigator controls on form.](view-sales-navigator-forms.md)