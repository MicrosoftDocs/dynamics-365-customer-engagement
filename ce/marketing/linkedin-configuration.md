---
title: "Assign security roles, set up LinkedIn field mappings and matching strategy (Dynamics 365 for Marketing) | Microsoft Docs "
description: "Map lead fields and match leads between LinkedIn to Dynamics 365 for Marketing"
keywords: "LinkedIn; Lead Gen Forms; lead; connector"
ms.date: 03/27/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: e41ac66c-19f6-4671-a6e4-e4363a86b898
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Set up the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen integration and define a lead matching strategy

Administrators can use the settings pages under the **Settings** > **Advanced settings** > **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** heading to configure the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] feature. A few [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] security roles are also provided to let administrators control access to these features.

## Enable users to work with the connector and assign security roles to users

LinkedIn Lead Gen provides dedicated security roles, which you assign to users so they can work with [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] ads that generate leads in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]:

- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen Forms Administrator.** Users with this role can configure lead matching strategies, [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] field mapping, and solution settings for [!INCLUDE[cc-linkedin-solution](../includes/cc-linkedin-solution.md)].
- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen Forms Salesperson.** These users can authorize [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] user profiles to sync data to [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], and view details about the synced submissions.

A third role, [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen S2S Inbound, is an internal security role used to sync data.

Assign these security roles to users who you want to provide access to the **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** menu item. To learn how to assign a security role to users, see [Create users and assign Dynamics 365 (online) security roles](https://technet.microsoft.com/library/jj191623.aspx#BKMK_AssignSecurity).

## Configure a matching strategy to update leads from [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen ads

When a new lead is synced from [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)], [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] can either update an existing lead record if the person is already known, or create a new lead if it's the first contact with this person. New [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] leads appear as **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Form Submissions** in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. The information in [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] form submissions consists of the answers given by [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] members when they submitted the forms.

To match existing leads in [!INCLUDE[pn-crm-online-shortest](../includes/pn-crm-online-shortest.md)] with new [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] form submission answers, users who have at least the **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen Forms Connector Administrator** security role can define a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] lead matching strategy in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. A matching strategy maps the fields of a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] form submission to the record fields for a lead in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. By default, a matching strategy based on a lead's email address is activated.

A matching strategy applies to all [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] leads in the same [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] organization. If a matching strategy contains more than one field mapping, all mappings must match before an existing lead record is updated. We recommend maintaining simple matching strategies (for example, strategies based only on phone number or email address). If only a subset of the fields match, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] creates a new lead from the form submission by default.

### Create a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] lead matching strategy

1. Go to **Settings** > **Advanced Settings** > **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** &gt; **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Matching Strategy**.

1. To create the matching strategy, select **New**, enter a **Name**, and then select **Save**.

1. To add a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] field mapping record, select **Add**, and then enter the name of the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] member field.

1. To add the **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Field Mapping** record to this matching strategy, select it.

### Activate a different LinkedIn lead matching strategy

1. Go to **Settings** > **Advanced Settings** > **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** &gt; **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Matching Strategy**.

1. In the list, select the matching strategy that you want to activate.

1. In the **Activate** menu in the matching strategy details, select **Yes**.

1. If another matching strategy is active, it will become deactivated.

### Edit a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] lead matching strategy

1. Go to **Settings** > **Advanced Settings** > **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** &gt; **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Matching Strategy**.

1. In the list, select the matching strategy that you want to edit.

1. To add an additional [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] field mapping record, select **Add**, and then enter the name of the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] member field.

1. To remove a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] field mapping record, select **Delete**.

### Delete a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] lead matching strategy

1. Go to **Settings** > **Advanced Settings** > **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** &gt; **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Matching Strategy**.

1. Select the check box for the lead matching strategy you want to delete.
    You can't delete the activated lead matching strategy.

1. Select **Delete**, and then confirm your deletion.

## Configure [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Field Mapping

The [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen integration provides a set of field mappings out of the box. Field mappings define the name and the related field on the lead entity it maps to. As a system administrator or customizer, you can change the field mapping or create new mappings to support fields from custom questions on LinkedIn Lead Gen forms.

### Create a new field mapping

1. Go to **Settings** > **Advanced Settings** > **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** &gt; **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Field Mappings**.

1. Select **New**. 

1. Enter a name for the field mapping, and then select the **Lead Field** that you want to map this to.

1. To create the new field mapping, select **Save & Close**.

### Edit an existing field mapping

1. Go to **Settings** > **Advanced Settings** > **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** &gt; **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Field Mappings**.

1. Select the field mapping that you want to edit.

1. Update the **Name** or the **Lead Field** for the field mapping.

1. To update the new field mapping, select **Save & Close**.

### Remove an existing field mapping

1. Go to **Settings** > **Advanced Settings** > **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen** &gt; **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Field Mappings**.

1. Select the field mapping that you want to remove.

1. To remove the field mapping, select **Delete** and confirm the deletion.

### See also
[LinkedIn Lead Gen integration](linkedin-lead-gen-integration.md)
