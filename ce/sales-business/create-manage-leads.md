---
title: "Create and manage leads (Dynamics 365 for Sales, Preview) | Microsoft Docs"
description: "Track your potential sales as leads in Dynamics 365 for Sales, Preview."
keywords: "Lead; manage; potential sale; qualify; convert"
ms.date: 12/15/2017
ms.service: dynamics-365-sales
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.custom:
  - dyn365-sales
ms.assetid: 6a90c7e7-4f42-4420-9969-85171faf31e5
author: shubhadaj
ms.author: shujoshi
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Manage Leads in [!INCLUDE[pn-sales-business-doc-name](../includes/pn-sales-business-doc-name.md)], Preview

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc-applies-to-update-9-0-0.md)]

[!INCLUDE[Pre-release disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

In [!INCLUDE[pn-sales-business-doc-name](../includes/pn-sales-business-doc-name.md)], Preview, leads are potential sales. In other words, a lead is a potential customer who must be qualified or disqualified as a sales opportunity. When a lead is qualified, it can be converted to an opportunity, account, or contact.

You can collect leads from many different sources. For example, you can generate sales leads from marketing campaigns, inquiries from your website or mailing lists.

When you create a lead, there are system-required fields to fill out. But other data, such as e-mail addresses, the source of the lead, and specific product interests, can also help your sales staff in following up with the customers.  

 ## Create a lead

1.  Select the Site map icon ![Icon to open the site map](media/Site-map-icon.png "Icon to open the site map"), and then select **Leads**.

2.  Select **+New**.

3.  In the **Summary** tab, enter your lead’s contact and company details.

4.  In the timeline section, add any notes and activities (for example, phone calls or emails) related to this lead.

5.  In the **Stakeholders** section, select the **More Commands** button ![More Commands button](../sales-business/media/more-button-stakeholders-grid.png "More Commands button"), and then select **+ New Connection** to add a contact as a stakeholder. A *stakeholder* is a key contact at the account who will be involved in decision-making. 

    In the **Lookup Records** dialog box, enter a name or select the Lookup icon to choose from a list of suggestions. When you've  entered the name you want, select **Add**. To create a new contact, select **+ New**. By default, the contact you add is assigned the **Stakeholder** role. Click the role corresponding to the contact to select a different role such as Decision Maker or Technical Buyer. 

6.  In the **Details** tab, enter information about your lead’s industry and preferred contact method.

7.  Select the **Save** button on the bottom right of the screen.

## Qualify and convert a lead to an opportunity

If your lead has potential to become a sale, you can qualify the lead to an opportunity. When you qualify a lead, a new record to represent the lead as an opportunity is created. Any notes on a lead record do not transfer to the opportunity record. The notes remain with the originating lead record.

1.  Go to Leads.

2.  In the list of leads, open the lead you want to qualify and convert.

3.  In the **Qualify** section of the sales process bar, type in all applicable information.

4.  Select **Qualify** at the top of the Lead screen.

   You must also select the currency in which to calculate the opportunity.

5.  Select the **Save** button at the bottom right of the screen.

 To qualify multiple leads at once, go to the list of lead records. Then select the check boxes next to all leads that you want to qualify, and then select **Qualify** at the top of the screen.

## Disqualify a lead

When you decide that a lead will not turn into an opportunity, you can disqualify it and still have an audit trail for your sales process. You can reactivate the record, including any attachments and notes, without having to re-enter all the data if the lead contacts you in the future. Deleting the record also removes any attachments and notes.

To disqualify, select the lead, and on the command bar, select **Disqualify**.


### See Also
[Develop sales from lead to cash in [!INCLUDE[pn-sales-business-doc-name](../includes/pn-sales-business-doc-name.md)], Preview](develop-sales-lead-to-cash.md)  
[Overview of Dynamics 365 for Sales, Preview](overview-dynamics-365-for-sales.md)
