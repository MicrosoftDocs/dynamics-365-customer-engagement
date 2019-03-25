---
title: "Assign security roles, set up LinkedIn field mappings and matching strategy (Dynamics 365 for Marketing) | Microsoft Docs "
description: "Map lead fields and match leads between LinkedIn to Dynamics 365 for Marketing"
keywords: LinkedIn; Lead Gen Forms; lead; connector
ms.date: 02/01/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: e41ac66c-19f6-4671-a6e4-e4363a86b898
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Set up the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen integration and define a lead matching strategy

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

Use the settings pages under the **Settings** > **Advanced settings** > **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** heading to configure the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] feature. A few [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] security roles are also provided to let administrators control access to these features.

[!INCLUDE [cc-linkedin-disclaimer](../includes/cc-linkedin-disclaimer.md)]

## Enable users to work with the connector and assign security roles to users

The LinkedIn Lead Gen connector provides dedicated security roles, which you assign to users so they can work with [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] ads that generate leads in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]:

- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen Forms Administrator.** Users with this role can configure lead matching strategies, [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] field mapping, and solution settings for [!INCLUDE[cc-linkedin-solution](../includes/cc-linkedin-solution.md)].
- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen Forms Salesperson.** These users can authorize [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] user profiles to sync data to [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], and view details about the synced submissions.

A third role, [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen S2S Inbound, is an internal security role used to sync data.

Assign these security roles to users who you want to provide access to the **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** menu item. To learn how to assign a security role to users, see [Create users in Dynamics 365 for Customer Engagement apps (online) and assign security roles](../admin/create-users-assign-online-security-roles.md).

## Configure a matching strategy to update leads from [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen ads

A matching strategy maps the fields of a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] form submission to the fields for a lead record in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. By default, the system matches by email address alone.

A matching strategy applies to all [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] leads in the same [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] organization. If a matching strategy contains more than one field mapping, all mappings must match before an existing lead record is updated. We recommend maintaining simple matching strategies (for example, strategies based only on phone number or email address). If only a subset of the fields match, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] creates a new lead from the form submission by default.

### Create a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] lead matching strategy

1. Go to **Settings** > **Advanced Settings** > **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** &gt; **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Matching Strategy**.

2. To create the matching strategy, select **New**, enter a **Name**, and then select **Save**.

3. To add a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] field mapping record, select **Add**, and then enter the name of the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] member field.

4. To add the **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Field Mapping** record to this matching strategy, select it.

### Activate a different LinkedIn lead matching strategy

1. Go to **Settings** > **Advanced Settings** > **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** &gt; **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Matching Strategy**.

2. In the list, select the matching strategy that you want to activate.

3. In the **Activate** menu in the matching strategy details, select **Yes**.

4. If another matching strategy is active, it will become deactivated.

### Edit a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] lead matching strategy

1. Go to **Settings** > **Advanced Settings** > **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** &gt; **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Matching Strategy**.

2. In the list, select the matching strategy that you want to edit.

3. To add an additional [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] field mapping record, select **Add**, and then enter the name of the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] member field.

4. To remove a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] field mapping record, select **Delete**.

### Delete a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] lead matching strategy

1. Go to **Settings** > **Advanced Settings** > **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** &gt; **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Matching Strategy**.

2. Select the check box for the lead matching strategy you want to delete.
    You can't delete the activated lead matching strategy.

3. Select **Delete**, and then confirm your deletion.

## Configure [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Field Mapping

Field mappings define a name and the related field on the lead entity it maps to.

### Create a new field mapping

1. Go to **Settings** > **Advanced Settings** > **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** &gt; **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Field Mappings**.

2. Select **New**. 

3. Enter a name for the field mapping, and then select the **Lead Field** that you want to map this to.

4. To create the new field mapping, select **Save & Close**.

### Edit an existing field mapping

1. Go to **Settings** > **Advanced Settings** > **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** &gt; **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Field Mappings**.

2. Select the field mapping that you want to edit.

3. Update the **Name** or the **Lead Field** for the field mapping.

4. To update the new field mapping, select **Save & Close**.

### Remove an existing field mapping

1. Go to **Settings** > **Advanced Settings** > **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** &gt; **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Field Mappings**.

2. Select the field mapping that you want to remove.

3. To remove the field mapping, select **Delete** and confirm the deletion.

### See also
[LinkedIn Lead Gen integration](linkedin-lead-gen-integration.md)
