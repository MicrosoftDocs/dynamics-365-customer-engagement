---
title: "Matching strategy for LinkedIn Lead Gen Forms | Microsoft Docs"
description: "Learn how to specify which leads in Dynamics 365 apps get updated by configuring the matching strategy for newly synced LinkedIn leads."
keywords: lead matching, field mapping, linkedin leads, lead record
ms.date: 04/02/2018
ms.service: crm-online
ms.topic: article
applies_to: 
  - Dynamics 365 Sales
  - Dynamics 365 Marketing
ms.assetid: 7ceb9c1e-c044-4d4c-8710-9fe0b79aeb68
author: shubhadaj
ms.author: shujoshi
manager: sakudes
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365LinkedIn
---

# Configure a matching strategy to update leads from [!include[LinkedIn](../includes/pn-linkedin.md)] ads

When a new lead is synced from [!include[LinkedIn](../includes/pn-linkedin.md)], the system can either update an existing lead record if the person is already known, or create a new lead if it’s the first contact with this person. New [!include[LinkedIn](../includes/pn-linkedin.md)] leads appear as **[!include[LinkedIn](../includes/pn-linkedin.md)] Form Submissions** in Dynamics 365 apps. The information in [!include[LinkedIn](../includes/pn-linkedin.md)] form submissions consists of the answers given by [!include[LinkedIn](../includes/pn-linkedin.md)] members when they submitted the forms. To match existing leads in Dynamics 365 Sales with new [!include[LinkedIn](../includes/pn-linkedin.md)] form submission answers, users who have at least the [!include[LinkedIn](../includes/pn-linkedin.md)] Lead Gen Forms Connector Administrator security role can define a [!include[LinkedIn](../includes/pn-linkedin.md)] lead matching strategy in the Dynamics 365 Sales settings. A matching strategy maps the fields of a [!include[LinkedIn](../includes/pn-linkedin.md)] form submission to the record fields for a lead. By default, a matching strategy based on a lead’s email address is activated.

A matching strategy applies to all [!include[LinkedIn](../includes/pn-linkedin.md)] leads in the same Dynamics 365 instance. If a matching strategy contains more than one [field mapping](configure-matching-strategy.md#edit-the-linkedin-field-mapping), all mappings must match before an existing lead record is updated. We recommend maintaining simple matching strategies&mdash;for example, strategies based only on phone number or email address.

> [!NOTE]
> If only a subset of the fields match, by default the system won't create a new lead from the form submission.  
> To create new leads when the matching strategy fails, a system administrator or customizer can edit the **[!include[LinkedIn](../includes/pn-linkedin.md)] LeadGen Integration Configurations** entity and change the value for the **On Match fail** attribute from the default value **Ignore** to **Create new lead**. 
> For quick access to this custom entity, consider [adding it to the site map](https://go.microsoft.com/fwlink/p/?linkid=850397).

You need a **[!include[LinkedIn](../includes/pn-linkedin.md)] Lead Gen Forms Connector Administrator** security role to manage lead matching strategies.  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [TechNet: Create users and assign security roles](https://technet.microsoft.com/library/jj191623.aspx)

![Manage lead matching strategies](media/Manage-lead-matching-strategies.png "Manage lead matching strategies")

1. Create a new matching strategy

2. Delete this matching strategy

3. Add more lead mapping fields

4. List of active lead mapping fields


## Create a [!include[LinkedIn](../includes/pn-linkedin.md)] lead matching strategy

1. Go to **Settings** > **[!include[LinkedIn](../includes/pn-linkedin.md)] Lead Gen** > **Lead Matching Strategies**.

2. To create the matching strategy, select **New** ![New](media/Add-icon.png "New"), enter a **Name**, and then select **Save**.

3. To add a [!include[LinkedIn](../includes/pn-linkedin.md)] field mapping record, select **Add** ![Add](media/Add-icon.png "Add") and enter the name of the [!include[LinkedIn](../includes/pn-linkedin.md)] member field.

4. Select the **[!include[LinkedIn](../includes/pn-linkedin.md)] Field Mapping** record to add it to this matching strategy.

## Activate a different [!include[LinkedIn](../includes/pn-linkedin.md)] lead matching strategy

1. Go to **Settings** > **[!include[LinkedIn](../includes/pn-linkedin.md)] Lead Gen** > **Lead Matching Strategies**.

2. In the list, select the matching strategy that you want to activate.

3. In the **Activate** menu in the matching strategy details, select **Yes**.

If another matching strategy is active, it will become deactivated.

> [!TIP]
> It’s a good practice to maintain a single strategy and update it if needed. However, you can maintain multiple matching strategies, but keep in mind that only one can be activated at a time.

## Edit a [!include[LinkedIn](../includes/pn-linkedin.md)] lead matching strategy

1. Go to **Settings** > **[!include[LinkedIn](../includes/pn-linkedin.md)] Lead Gen** > **Lead Matching Strategies**.

2. In the list, select the matching strategy that you want to edit.

3. To add an additional [!include[LinkedIn](../includes/pn-linkedin.md)] field mapping record, select **Add** ![Add](media/Add-icon.png "Add") and enter the name of the [!include[LinkedIn](../includes/pn-linkedin.md)] member field.

4. To remove a [!include[LinkedIn](../includes/pn-linkedin.md)] field mapping record, select **Delete**![Delete](media/Delete-icon.png "Delete").

## Delete a [!include[LinkedIn](../includes/pn-linkedin.md)] lead matching strategy

1. Go to **Settings** > **[!include[LinkedIn](../includes/pn-linkedin.md)] Lead Gen** > **Lead Matching Strategies**.

2. Select the check box for the lead matching strategy you want to delete.

3. Select **Delete**![Delete](media/Delete-icon.png "Delete"), and then confirm your deletion.

> [!NOTE]
> You can’t delete the activated lead matching strategy.

## Edit the LinkedIn field mapping

By default, Dynamics 365 Sales maps fields from [!include[LinkedIn](../includes/pn-linkedin.md)] leads to corresponding fields of a lead record. As a system administrator or customizer, you can change the field mapping or create new mappings to support fields from custom questions on [!include[LinkedIn](../includes/pn-linkedin.md)] lead gen forms. 

1. Go to **Settings** > **[!include[LinkedIn](../includes/pn-linkedin.md)] Lead Gen** > **Lead Field Mappings**.

2. Select the field mapping that you want to change and select **Edit**.

3. Change the mapping or rename the field mapping and select **Save** to apply your changes.

### See also

[How to sync LinkedIn leads by using Dynamics 365 Connector for LinkedIn Lead Gen Forms](sync-linkedin-leads.md)  
[Analyze leads and lead performance](review-leads.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]