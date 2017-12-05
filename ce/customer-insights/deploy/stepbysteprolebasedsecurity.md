---
title: Set up role-based security
description: This section takes you through the steps to use role-based access control in your Customer Insights service instance.
keywords: dynamics 365; customer insights
Applies_to: Dynamics 365 for Customer Insights
author: jimholtz
ms.author: jimholtz
manager: brycho
ms.date: 07/03/2017
ms.topic: get-started-article
ms.service: customer-insights 
ms.assetid: ea56b140-75ba-4db1-b742-6fa3e8a768bd
---
Set up role-based security
================================
[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

This section takes you through the steps to use role-based access control in your [!include[pn-customer-insights-full](../../includes/pn-customer-insights-full.md)] service instance. You configure roles in [!include[pn-customer-insights-short](../../includes/pn-customer-insights-short.md)] through the [Azure portal](https://portal.azure.com), and then you assign the roles to specific individuals or security principals.

[//]: # (In steps 12 and 14, security principal and role seem to be used interchangeably. Is the Not Allowed Profiles configuration going to apply to every person who has been assigned the role, or are you customizing these disallowed profiles for an individual person?)
##Configuring role-based access control

1.  Sign in to the Azure portal by using your Azure account, and navigate to your [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] service instance.

2.  On your [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] service instance blade, select **All Settings**.

    ![Select all settings](../media/servicesettings.png "Select all settings") 

3.  On the **Settings** blade, select **Security**.

4.  On the **Role Assignments** blade, select **Add**.

    ![Add a role assignment](../media/addroleassignment40HL.png "Add a role assignment") 

5.  On the **Add Role Assignment** blade, select **Provide Name**.

6.  Enter a **Role Name**, and then select **Create**.

    ![Enter a role name](../media/enterrolename.png "Enter a role name") 

7.  On the **Add Role Assignment** blade, select **Select a role**.

8.  Choose the **Admin** or **Reader** role.

    ![Choose admin or reader role](../media/pickadminorreader.png "Choose admin or reader role")

9.  On the **Add Role Assignment** blade, select **Add**.

10.  On the **Select Users** blade, you should see the associated users and security groups provisioned in your [!include[pn-azure-active-directory](../../includes/pn-azure-active-directory.md)] tenant. Choose the security principals to whom you’d like to assign the role, select **Select**, and then select **OK**.

     ![Select a user](../media/selectuser.png "Select a user") 

11.  On the **Add Role Assignment** blade, select **Add**.

12.  On the **Select Profiles** blade, choose the profiles, interactions, KPIs, views, or widget types to which a security principal has access. For instance, to grant this role access to the data associated with a specific profile, select **Allowed Profiles**.

     ![Select a profile](../media/selectprofile.png "Select a profile")

13.  On the **Select Profiles** blade, choose the profiles to which you want to grant this role access. To grant access to all profiles, select the wildcard character, “\*”. Select **Select**.

14.  If you grant the security principal access to all (\*) profiles, you can still deny the role access to specific profiles. (Similar behavior applies to interactions, KPIs, views, or widget types). Select **Not Allowed Profiles** to deny the role access to profiles of a specific type.

     ![Select Not Allowed Profiles](../media/notallowedprofile.png "Select Not Allowed Profiles to deny a role access to one or more profiles") 

  >[!NOTE]
  >The **Not Allowed Profiles** option only appears when you’ve chosen to grant a role access to all (\*) profiles. Similar behavior applies to interactions, KPIs, views, and widget types.

15.  On the **Add Permissions** blade, select **OK**.

16.  On the **Add Role Assignment** blade, select **Create**  to provision the new role.
