---
title: View and understand the org charts
description: View and understand the org charts to gain insights into your customers' organizational structure and identify key decision-makers.  
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection:  
ms.date: 04/22/2023
ms.custom: bap-template 
---

# View and understand the org charts (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The org chart is accessible from accounts and contacts. Select **Open org chart** from the command bar to open the org chart for the account or a contact. If an organizational chart exists for the selected record, it’s displayed. If not, you can create one. More information: [Create or edit an org chart](manage-org-charts.md#create-or-edit-an-org-chart).  

The following image is an example of an org chart: 

:::image type="content" source="media/org-chart-example.png" alt-text="Screenshot showing an example of org chart" lightbox="media/org-chart-example.png"::: 

The contact card in the org chart provides high-level information about the individual in the org such as, the relationship health, label, and contact details. The following image is an example of a contact card in org chart:

:::image type="content" source="media/org-chart-contact-card.png" alt-text="Screenshot showing contact card in org chart" lightbox="media/org-chart-contact-card.png":::

The following information describes the different elements of the contact card:
- The label in the contact card helps you to visualize and understand contact is approachable or not. To know how to add or edit label, see [Add label to a contact](manage-org-charts.md#add-label-to-a-contact).  
    Also, a contact can be marked as primary in the org chart. More information: [Set a contact as primary](manage-org-charts.md#set-a-contact-as-primary)

- The relationship of a contact is denoted by the display icon in the contact card. The display icon is a circle with a color around it.   
    When you hover over the display icon, the relationship health state along with its trend is displayed. Also, you can open the contact details pane to see the relationship health. More information: [View contact details](#view-contact-details)

    >[!NOTE]
    >- To understand how the relationship health is calculated, see [Compute the relationship health and health trend](relationship-analytics-kpi-calculations.md#step-4-compute-the-relationship-health-and-health-trend).
    >- To view this relationship health, your administrator must configure relationship analytics. More information: [Configure relationship analytics and health](configure-relationship-analytics.md).

## View contact details 

Contact details provide detailed information about the individual such as, Email, Job Title, Manager, Direct Reports, and Relationship health. When LinkedIn Sales Navigator is enabled in your organization, you see LinkedIn controls such as Sales Navigator and InMail. 

Also, you can add notes about the contact, which helps as a reference to you and your team when required.    

To open the contact details pane, double-click the contact card.

:::image type="content" source="media/org-chart-contact-details-pane.png" alt-text="Screenshot showing contact details pane of a contact" lightbox="media/org-chart-contact-details-pane.png"::: 

### LinkedIn controls

If you have a Sales Navigator seat, LinkedIn profiles are always just a few clicks away and can be used to ensure contact details remain up to date. 

Select **Sales Navigator** to sign in to the service. You’ll then be presented with the embedded LinkedIn Sales Navigator widget, where you can match the contact and see their LinkedIn profile.

Select **InMail** to send mails to the contact.

### Contact changes organization in LinkedIn

When a contact leaves the organization and updates their LinkedIn profile, the org chart displays a message to verify the details of the contact.

1. On the message, select **Verify details**.

1. On the **Verify Contact Details** pane, review the details and update the contact information as required.
    -	If the contact has moved to a new organization, updated account information in the **Update Company info in your contacts** section and select **Update Contact**.
    -	If the contact is still with the current org, select **Ignore Update**.

Also, a **red** border is displayed around the card, indicating that the contact’s organization is changed and needs your review.

### Add notes

You can add notes to keep and share important information or tasks related to the contact. The added notes are available in the contact details pane for you and your team to refer and use the information when required. 

To add a note:

1.	In the Seller note section, select **Create a note**.
2.	In the note editor, enter the title and description for the note.
3.	Select **Save**.

The note is added to the contact with information about the author and the time it was created. Also, the note is available on the contact’s timeline.


[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Organization charts](organization-charts.md)  
[Manage org charts](manage-org-charts.md)  

