---
title: LinkedIn Sales Navigator FAQs for Dynamics 365
description: Find answers to some of the most frequently asked questions related to LinkedIn Sales Navigator integration with Dynamics 365.
ms.date: 10/14/2024
ms.topic: article
author: udaykirang
ms.author: udag
---

# Frequently asked questions about LinkedIn Sales Navigator integration with Dynamics 365

## Is the LinkedIn Sales Navigator solution available for Dynamics 365 Sales Professional?  

**Answer:**  
Yes, the LinkedIn Sales Navigator solution is available for Dynamics 365 Sales Professional. Administrator must [integrate the solution](integrate-sales-navigator.md) with your sales professional app and [add the controls to forms](add-sales-navigator-controls-forms.md).  

<a name="sync-load-photos-linkedin"> </a>
## Why am I unable to sync or load photos of my contacts from LinkedIn to the org chart? 
  
**Answer:**  
Currently, we don't support syncing or loading contact profile pictures from LinkedIn to the org chart. The org chart displays only the pictures that are stored in Dynamics 365 for contact records.  

<a name="add-remove-fields-contact-details"> </a>
## Why am I unable to remove or add fields to a contact through the Contact Details side pane after selecting nodes in the org chart?  

**Answer:**  
Removing or adding fields from the **Contact Details** pane isn't supported.

<a name="import-leads-accounts-crm-sync"> </a>
## Can I import leads or accounts into Dynamics 365 Sales through CRM Sync?  

**Answer:**  
No, you can't import leads or accounts from Sales Navigator to Dynamics 365 Sales through CRM Sync. However, writeback of InMails, Messages, and Smart Links from Sales Navigator to Dynamics 365 Sales is supported. More information: [Enable Sales Navigator CRM Sync & Activity Writeback for Microsoft Dynamics 365 Sales](https://business.linkedin.com/sales-solutions/sales-navigator-customer-hub/resources/ms-dynamics-sync-activity-writeback)  

<a name="upgrade-solution-2-to-3-version"> </a>
## Why hasn't my LinkedIn Sales Navigator solution been upgraded from version 2.x to 3.x?
  
**Answer:**  
Because there's no change to functionality in version 3.x, we aren't upgrading. This has no effect on your current solution (version 2.x).  

<a name="unable-sync-d365-org-under-admin-tab-linkedin"> </a>
## Why am I unable to sync a Dynamics 365 organization with LinkedIn Sales Navigator on the Admin tab? I get an error message saying that the start of the sync has failed. 

:::image type="content" source="media/faq-unable-sync-d365-lsn-error.png" alt-text="Screenshot of unable to sync a Dynamics 365 organization with LinkedIn Sales Navigator error message.":::

**Answer:**  
The error is from the LinkedIn Sales Navigator application. Contact [LinkedIn Sales Navigator](https://www.linkedin.com/help/sales-navigator/answer/a107028) support to resolve the issue.  

<a name="unable-log-in-to-linkedin-control"> </a>
## Why am I unable to sign in to LinkedIn with Safari?

**Answer:**  
Dynamics 365 doesn't own the sign in of users from the LinkedIn Sales Navigator solution. Contact the [LinkedIn Sales Navigator](https://www.linkedin.com/help/sales-navigator/answer/a107028) support to resolve the issue.  

<a name="incorrect-owner-name-displayed"> </a>
## Why is an incorrect name displayed as the owner of the record instead of my name when I create contact in LinkedIn Sales Navigator?
  
**Answer:**  
Dynamics 365 doesn't own the process of contact creation in LinkedIn Sales Navigator. Contact [LinkedIn Sales Navigator](https://www.linkedin.com/help/sales-navigator/answer/a107028) support to resolve the issue.  

<a name="unable-enable-crm-sync-for-seat"> </a>
## Why can't I enable CRM sync for a seat in LinkedIn Sales Navigator?
  
**Answer:**  
The issue might occur due to the mismatch of the user's email in Dynamics 365 and LinkedIn Sales Navigator. To resolve the issue, follow the steps described in [How Do I Enable CRM Sync if a User's Email is Mismatched?](https://www.linkedin.com/help/sales-navigator/answer/a162746).  
If the issue persists, contact [LinkedIn Sales Navigator](https://www.linkedin.com/help/sales-navigator/answer/a107028) support.

<a name="unable-writeback-inmails"> </a>
## Why am I unable to write back inMails and messages from LinkedIn Sales Navigator to Dynamics 365? The Copy message to CRM option is unavailable.  

:::image type="content" source="media/faq-unable-writeback-inmails-messages-error.png" alt-text="Screenshot of copy message to CRM option unavailable.":::

**Answer:**  
The issue has occurred due to the insufficient permissions in your user account to write back to Dynamics 365 from LinkedIn Sales Navigator. Contact [LinkedIn Sales Navigator](https://www.linkedin.com/help/sales-navigator/answer/a107028) support to resolve the issue.

<a name="onprem-crm-sync-capability-enabled"> </a>
## Does Dynamics 365 on-premises version 9.0 with LinkedIn Sales Navigator have the CRM sync capability enabled?  

**Answer:**  
The on-premises Microsoft Dynamics 2016 and above versions don't support CRM sync or related functionalities. More information: [Prerequisites for CRM sync and write back](https://business.linkedin.com/sales-solutions/sales-navigator-customer-hub/resources/ms-dynamics-sync-activity-writeback#prerequisites)

<a name="smart-links-activity-labelled-pointdrive"> </a>
## Why is a Smart Links activity labeled as PointDrive?  

**Answer:**  
In the Dynamics 365 LinkedIn 3.x solution, only the PointDrive label is changed to Smart Links: the functionality remains the same. If you're using LinkedIn solution version 2.x, we recommend that your system administrator or customizer change the label manually by following these steps:

1. Sign in to your Dynamics 365 app.    
1. Go to **Advanced Settings** > **Customizations** > **Customize the System**.  
1. From the **Entities** site map, select the **PointDrive Presentation Viewed** entity.  

    :::image type="content" source="media/faq-pointdrive-presentation-viewed-entity.png" alt-text="Screenshot of PointDrive Presentation Viewed entity view.":::  

1. For **Display Name** and **Plural Name**, enter **Smart Links Content Viewed**.  

    :::image type="content" source="media/faq-change-name-smart-links-content-viewed.png" alt-text="Screenshot of Change Display Name and Plural Name to Smart Links Content Viewed.":::

1. Save and publish the customizations.  
1. Browse to an entity record and verify that the Smart Links label appears on the timeline.  

    :::image type="content" source="media/faq-smart-links-content-viewed-confirmation.png" alt-text="Screenshot of Smart Links Content Viewed confirmation on the timeline.":::

<a name="show-smart-links-activity-on-timeline"> </a>
## How can I show an activity (InMail, Message, or Smart Links) on the timeline?  

**Answer:**  
If you've properly configured CRM sync and activity writeback, the activity will successfully write back from LinkedIn Sales Navigator to Dynamics 365 and appear on the timeline. If the activities don't appear on the timeline, follow these steps:  

1. Sign in to your Dynamics 365 app.  
1. Go to **Advanced Settings** > **Customizations** > **Customize the System**.  
1. From the **Entities** site map, select the entity (Contact or Lead) and then the form for which you want to configure the timeline.  
1. On the entity form, on the **SOCIAL PANE** tab, select **Notes Properties**, and then select **Change Properties**.  

    :::image type="content" source="media/faq-select-notes-properties.png" alt-text="Screenshot of select the Change Properties option for notes properties.":::

1. In the **Activities Tab Properties** window, under **Unified Interface Properties (New)** tab, select the **Activities** tab.  
1. In the **Filter By** section, select the following options:  
   - From the **Show these activities** list, select **Show selected**.
   - From the options, select the **Ctrl** key, and then select the activity.  

    :::image type="content" source="media/faq-select-options-filter-by-section.png" alt-text="Screenshot of select options to show Smart Links activities.":::

1. Select **OK**, and then save and publish the customizations.

## Related information

[Integrate LinkedIn Sales Navigator solutions for Dynamics 365 Sales](integrate-sales-navigator.md)
